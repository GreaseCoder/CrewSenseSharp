using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataAccessLib.Models.Schedule
{
    public class TimeOff
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("start")]
        public DateTimeOffset Start { get; set; }

        [JsonPropertyName("end")]
        public DateTimeOffset End { get; set; }

        [JsonPropertyName("user")]
        public Admin User { get; set; }

        [JsonPropertyName("admin")]
        public Admin Admin { get; set; }

        [JsonPropertyName("time_off_type")]
        public TimeOffType TimeOffType { get; set; }
    }

    public class Admin
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class TimeOffType
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("work_code")]
        public string WorkCode { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("text_color")]
        public string TextColor { get; set; }

        [JsonPropertyName("subtypes")]
        public Subtype[] Subtypes { get; set; }
    }

    public partial class Subtype
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }
    }
}
