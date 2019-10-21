using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataAccessLib.Models.Schedule
{
    public partial class Misc
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; set; }

        [JsonPropertyName("length")]
        public double Length { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("work_type")]
        public string WorkType { get; set; }
    }

    public partial class User
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
