﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(WeatherForecastDbContext))]
    [Migration("20210630104307_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Domain.Clouds", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("WeatherForecastId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("all")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WeatherForecastId")
                        .IsUnique();

                    b.ToTable("Clouds");
                });

            modelBuilder.Entity("Domain.Coord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("WeatherForecastId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("lat")
                        .HasColumnType("REAL");

                    b.Property<double>("lon")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("WeatherForecastId")
                        .IsUnique();

                    b.ToTable("Coord");
                });

            modelBuilder.Entity("Domain.Main", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("WeatherForecastId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("feels_like")
                        .HasColumnType("REAL");

                    b.Property<int>("grnd_level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("humidity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("pressure")
                        .HasColumnType("INTEGER");

                    b.Property<int>("sea_level")
                        .HasColumnType("INTEGER");

                    b.Property<double>("temp")
                        .HasColumnType("REAL");

                    b.Property<double>("temp_max")
                        .HasColumnType("REAL");

                    b.Property<double>("temp_min")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("WeatherForecastId")
                        .IsUnique();

                    b.ToTable("Main");
                });

            modelBuilder.Entity("Domain.Rain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("WeatherForecastId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("h1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("h3")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WeatherForecastId")
                        .IsUnique();

                    b.ToTable("Rain");
                });

            modelBuilder.Entity("Domain.Snow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("WeatherForecastId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("h1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("h3")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WeatherForecastId")
                        .IsUnique();

                    b.ToTable("Snow");
                });

            modelBuilder.Entity("Domain.Sys", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("WeatherForecastId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("country")
                        .HasColumnType("TEXT");

                    b.Property<int>("sunrise")
                        .HasColumnType("INTEGER");

                    b.Property<int>("sunset")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WeatherForecastId")
                        .IsUnique();

                    b.ToTable("Sys");
                });

            modelBuilder.Entity("Domain.Weather", b =>
                {
                    b.Property<int>("Dbid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("WeatherForecastId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("icon")
                        .HasColumnType("TEXT");

                    b.Property<int>("id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("main")
                        .HasColumnType("TEXT");

                    b.HasKey("Dbid");

                    b.HasIndex("WeatherForecastId");

                    b.ToTable("Weather");
                });

            modelBuilder.Entity("Domain.WeatherForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Base")
                        .HasColumnType("TEXT");

                    b.Property<int>("Dt")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Timezone")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Visibility")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecast");
                });

            modelBuilder.Entity("Domain.Wind", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("WeatherForecastId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("deg")
                        .HasColumnType("INTEGER");

                    b.Property<double>("gust")
                        .HasColumnType("REAL");

                    b.Property<double>("speed")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("WeatherForecastId")
                        .IsUnique();

                    b.ToTable("Wind");
                });

            modelBuilder.Entity("Domain.Clouds", b =>
                {
                    b.HasOne("Domain.WeatherForecast", "WeatherForecast")
                        .WithOne("Clouds")
                        .HasForeignKey("Domain.Clouds", "WeatherForecastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WeatherForecast");
                });

            modelBuilder.Entity("Domain.Coord", b =>
                {
                    b.HasOne("Domain.WeatherForecast", "WeatherForecast")
                        .WithOne("Coord")
                        .HasForeignKey("Domain.Coord", "WeatherForecastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WeatherForecast");
                });

            modelBuilder.Entity("Domain.Main", b =>
                {
                    b.HasOne("Domain.WeatherForecast", "WeatherForecast")
                        .WithOne("Main")
                        .HasForeignKey("Domain.Main", "WeatherForecastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WeatherForecast");
                });

            modelBuilder.Entity("Domain.Rain", b =>
                {
                    b.HasOne("Domain.WeatherForecast", "WeatherForecast")
                        .WithOne("Rain")
                        .HasForeignKey("Domain.Rain", "WeatherForecastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WeatherForecast");
                });

            modelBuilder.Entity("Domain.Snow", b =>
                {
                    b.HasOne("Domain.WeatherForecast", "WeatherForecast")
                        .WithOne("Snow")
                        .HasForeignKey("Domain.Snow", "WeatherForecastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WeatherForecast");
                });

            modelBuilder.Entity("Domain.Sys", b =>
                {
                    b.HasOne("Domain.WeatherForecast", "WeatherForecast")
                        .WithOne("Sys")
                        .HasForeignKey("Domain.Sys", "WeatherForecastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WeatherForecast");
                });

            modelBuilder.Entity("Domain.Weather", b =>
                {
                    b.HasOne("Domain.WeatherForecast", "WeatherForecast")
                        .WithMany("Weather")
                        .HasForeignKey("WeatherForecastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WeatherForecast");
                });

            modelBuilder.Entity("Domain.Wind", b =>
                {
                    b.HasOne("Domain.WeatherForecast", "WeatherForecast")
                        .WithOne("Wind")
                        .HasForeignKey("Domain.Wind", "WeatherForecastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WeatherForecast");
                });

            modelBuilder.Entity("Domain.WeatherForecast", b =>
                {
                    b.Navigation("Clouds");

                    b.Navigation("Coord");

                    b.Navigation("Main");

                    b.Navigation("Rain");

                    b.Navigation("Snow");

                    b.Navigation("Sys");

                    b.Navigation("Weather");

                    b.Navigation("Wind");
                });
#pragma warning restore 612, 618
        }
    }
}
