import React, { useState } from 'react';
import Moment from 'react-moment';
const api = {
  base: "https://localhost:5001/api/weatherforecast",
  actual: "/actual",
  historyall: "/history/all"
}



function App() {
  const [query, setQuery] = useState('');
  const [weather, setWeather] = useState([]);
  const [historyAll, setHistoryAll] = useState([]);

  const search = evt => {
    if (evt.key === "Enter"){
      fetch(`${api.base + api.actual}?city=${query}`)
      .then(res => res.json())
      .then(result => {
          setWeather(result);
          setQuery('');
          console.log(result);
      })
      fetch(`${api.base + api.historyall}`)
        .then(res => res.json())
        .then(result => {
          setHistoryAll(result);
          setQuery('');
          console.log(result);
      })
    }
  }

  function handleDeleteHistoryAll() {
    // DELETE request using fetch inside useEffect React hook
    fetch(`${api.base + api.historyall}`, { method: 'DELETE' })
    setHistoryAll([]);
  }

  return (
    <div className="app">
      <main>
        <div className="search-box">
          <input
            type="text"
            className="search-bar"
            placeholder="Type city..."
            onChange={e => setQuery(e.target.value)}
            value={query}
            onKeyPress={search}
          />
        </div>

        {(typeof weather.main != "undefined") ? (
          <div>
            <div className="location-box">
              <div className="location">{weather.name}, {weather.sys.country}</div>
              <div className="date">
                <Moment className="time" format="DD MMMM YYYY H:mm ">
                  {weather.date}
                </Moment></div>
            </div>
            <div className="weather-box">
              <div className="temp">{Math.round(weather.main.temp)}°C</div>
              <div className="weather">{weather.weather[0].main}</div>
            </div>
          </div>
        ) : ('')}

        {(typeof weather.main != "undefined") ? (
          <div className="history-box">
            <h3>History</h3>
            {(typeof historyAll[0] != "undefined") ? (
              <button type="button" className="delete-btn" onClick={() => handleDeleteHistoryAll()}>Clear All</button>
            ) : ('')}
            {(typeof historyAll[0] != "undefined") ? (
              <div>
                <ul className="history-records">
                  {historyAll.map(d => (
                    <li className="history-record" key={d.dbid}>
                      <div className="history-city">{d.name}, {d.sys.country}</div>
                      <div className="history-temp">{Math.round(d.main.temp)}°C</div>
                      <div className="history-sky">{d.weather[0].main}</div>
                      <Moment className="history-time" format="DD MMMM YYYY H:mm ">
                        {d.date}
                      </Moment>
                    </li>
                  ))}
                </ul>
              </div>
            ) : ('')}
          </div>
        ) : ('')}
      </main>
    </div>
  );
}

export default App;


