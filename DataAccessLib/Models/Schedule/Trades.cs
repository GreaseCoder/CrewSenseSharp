using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataAccessLib.Models.Schedule
{
    public class Trades
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("start")]
        public DateTimeOffset Start { get; set; }

        [JsonPropertyName("end")]
        public DateTimeOffset End { get; set; }

        [JsonPropertyName("requesting_user")]
        public AcceptingUser RequestingUser { get; set; }

        [JsonPropertyName("accepting_user")]
        public AcceptingUser AcceptingUser { get; set; }

        [JsonPropertyName("admin")]
        public AcceptingUser Admin { get; set; }
    }

    public class AcceptingUser
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
