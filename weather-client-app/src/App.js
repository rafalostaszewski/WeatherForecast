import React, { useState } from 'react';
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

  const dateBuilder = (d) => {
    let months = ["January", "February", "March", "April", "May", "June", "Julay", "August", "Seprember", "October", "November", "December"];
    let days = ["Sunday", "Monday", "Tuesday", "Wensday", "Thursday", "Friday", "Saturday"];

    let day = days[d.getDay()];
    let date = d.getDate();
    let month = months[d.getMonth()];
    let year = d.getFullYear();

    return `${day} ${date} ${month} ${year}`
  }

  return (
    <div className="app">
      <main>
        <div className="search-box">
          <input
            type="text"
            className="search-bar"
            placeholder="Search..."
            onChange={e => setQuery(e.target.value)}
            value={query}
            onKeyPress={search}
          />
        </div>

      {(typeof weather.main != "undefined") ? (
        <div>
          <div className="location-box">
            <div className="location">{weather.name}, {weather.sys.country}</div>
            <div className="date">{dateBuilder(new Date())}</div>
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
            <ul className="history-records">
              {historyAll.map(d => (
                <li className="history-record" key={d.dbid}>
                  {d.date}
                  {d.name}
                </li>
              ))}
            </ul>
          </div>
      ) : ('')}
      </main>
    </div>
  );
}

export default App;


