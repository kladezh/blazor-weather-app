﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace WeatherApp.Models.Dto
{
    public class ForecastDayDto
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("day")]
        public DayDto Day { get; set; }

        [JsonPropertyName("astro")]
        public AstroDto? Astro { get; set; }

        [JsonPropertyName("hour")]
        public HourDto[] Hours { get; set; }
    }

}