using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherForecast",
                columns: table => new
                {
                    dbid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Base = table.Column<string>(type: "TEXT", nullable: true),
                    Visibility = table.Column<int>(type: "INTEGER", nullable: false),
                    Dt = table.Column<int>(type: "INTEGER", nullable: false),
                    Timezone = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecast", x => x.dbid);
                });

            migrationBuilder.CreateTable(
                name: "Clouds",
                columns: table => new
                {
                    dbid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    all = table.Column<int>(type: "INTEGER", nullable: false),
                    WeatherForecastId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clouds", x => x.dbid);
                    table.ForeignKey(
                        name: "FK_Clouds_WeatherForecast_WeatherForecastId",
                        column: x => x.WeatherForecastId,
                        principalTable: "WeatherForecast",
                        principalColumn: "dbid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coord",
                columns: table => new
                {
                    dbid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    lon = table.Column<double>(type: "REAL", nullable: false),
                    lat = table.Column<double>(type: "REAL", nullable: false),
                    WeatherForecastId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coord", x => x.dbid);
                    table.ForeignKey(
                        name: "FK_Coord_WeatherForecast_WeatherForecastId",
                        column: x => x.WeatherForecastId,
                        principalTable: "WeatherForecast",
                        principalColumn: "dbid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Main",
                columns: table => new
                {
                    dbid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    temp = table.Column<double>(type: "REAL", nullable: false),
                    feels_like = table.Column<double>(type: "REAL", nullable: false),
                    temp_min = table.Column<double>(type: "REAL", nullable: false),
                    temp_max = table.Column<double>(type: "REAL", nullable: false),
                    pressure = table.Column<int>(type: "INTEGER", nullable: false),
                    humidity = table.Column<int>(type: "INTEGER", nullable: false),
                    sea_level = table.Column<int>(type: "INTEGER", nullable: false),
                    grnd_level = table.Column<int>(type: "INTEGER", nullable: false),
                    WeatherForecastId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Main", x => x.dbid);
                    table.ForeignKey(
                        name: "FK_Main_WeatherForecast_WeatherForecastId",
                        column: x => x.WeatherForecastId,
                        principalTable: "WeatherForecast",
                        principalColumn: "dbid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rain",
                columns: table => new
                {
                    dbid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    h1 = table.Column<int>(type: "INTEGER", nullable: false),
                    h3 = table.Column<int>(type: "INTEGER", nullable: false),
                    WeatherForecastId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rain", x => x.dbid);
                    table.ForeignKey(
                        name: "FK_Rain_WeatherForecast_WeatherForecastId",
                        column: x => x.WeatherForecastId,
                        principalTable: "WeatherForecast",
                        principalColumn: "dbid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Snow",
                columns: table => new
                {
                    dbid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    h1 = table.Column<int>(type: "INTEGER", nullable: false),
                    h3 = table.Column<int>(type: "INTEGER", nullable: false),
                    WeatherForecastId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Snow", x => x.dbid);
                    table.ForeignKey(
                        name: "FK_Snow_WeatherForecast_WeatherForecastId",
                        column: x => x.WeatherForecastId,
                        principalTable: "WeatherForecast",
                        principalColumn: "dbid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sys",
                columns: table => new
                {
                    dbid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id = table.Column<int>(type: "INTEGER", nullable: false),
                    country = table.Column<string>(type: "TEXT", nullable: true),
                    sunrise = table.Column<int>(type: "INTEGER", nullable: false),
                    sunset = table.Column<int>(type: "INTEGER", nullable: false),
                    WeatherForecastId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys", x => x.dbid);
                    table.ForeignKey(
                        name: "FK_Sys_WeatherForecast_WeatherForecastId",
                        column: x => x.WeatherForecastId,
                        principalTable: "WeatherForecast",
                        principalColumn: "dbid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    dbid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id = table.Column<int>(type: "INTEGER", nullable: false),
                    main = table.Column<string>(type: "TEXT", nullable: true),
                    description = table.Column<string>(type: "TEXT", nullable: true),
                    icon = table.Column<string>(type: "TEXT", nullable: true),
                    WeatherForecastId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.dbid);
                    table.ForeignKey(
                        name: "FK_Weather_WeatherForecast_WeatherForecastId",
                        column: x => x.WeatherForecastId,
                        principalTable: "WeatherForecast",
                        principalColumn: "dbid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wind",
                columns: table => new
                {
                    dbid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    speed = table.Column<double>(type: "REAL", nullable: false),
                    deg = table.Column<int>(type: "INTEGER", nullable: false),
                    gust = table.Column<double>(type: "REAL", nullable: false),
                    WeatherForecastId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wind", x => x.dbid);
                    table.ForeignKey(
                        name: "FK_Wind_WeatherForecast_WeatherForecastId",
                        column: x => x.WeatherForecastId,
                        principalTable: "WeatherForecast",
                        principalColumn: "dbid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clouds_WeatherForecastId",
                table: "Clouds",
                column: "WeatherForecastId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Coord_WeatherForecastId",
                table: "Coord",
                column: "WeatherForecastId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Main_WeatherForecastId",
                table: "Main",
                column: "WeatherForecastId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rain_WeatherForecastId",
                table: "Rain",
                column: "WeatherForecastId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Snow_WeatherForecastId",
                table: "Snow",
                column: "WeatherForecastId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sys_WeatherForecastId",
                table: "Sys",
                column: "WeatherForecastId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weather_WeatherForecastId",
                table: "Weather",
                column: "WeatherForecastId");

            migrationBuilder.CreateIndex(
                name: "IX_Wind_WeatherForecastId",
                table: "Wind",
                column: "WeatherForecastId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clouds");

            migrationBuilder.DropTable(
                name: "Coord");

            migrationBuilder.DropTable(
                name: "Main");

            migrationBuilder.DropTable(
                name: "Rain");

            migrationBuilder.DropTable(
                name: "Snow");

            migrationBuilder.DropTable(
                name: "Sys");

            migrationBuilder.DropTable(
                name: "Weather");

            migrationBuilder.DropTable(
                name: "Wind");

            migrationBuilder.DropTable(
                name: "WeatherForecast");
        }
    }
}
