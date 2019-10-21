using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataAccessLib.Models.Schedule
{
    public class Schedule
    {
        [JsonPropertyName("start")]
        public string Start { get; set; }

        [JsonPropertyName("end")]
        public string End { get; set; }

        [JsonPropertyName("days")]
        public IList<Day> Days { get; set; }

        [JsonPropertyName("prev")]
        public Prev Prev { get; set; }

        [JsonPropertyName("next")]
        public Next Next { get; set; }
    }

    public class Day
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("assignments")]
        public IList<Assignmemts> Assignments { get; set; }

        [JsonPropertyName("time_off")]
        public IList<TimeOff> TimeOff { get; set; }

        [JsonPropertyName("callbacks")]
        public IList<Callbacks> Callbacks { get; set; }

        [JsonPropertyName("trades")]
        public IList<Trades> Mrades { get; set; }

        [JsonPropertyName("misc")]
        public IList<Misc> Misc { get; set; }
    }

    public class Prev
    {
        [JsonPropertyName("href")]
        public string Href { get; set; }
    }

    public class Next
    {
        [JsonPropertyName("href")]
        public string Href { get; set; }
    }
}
