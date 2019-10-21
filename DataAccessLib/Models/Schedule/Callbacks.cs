using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataAccessLib.Models.Schedule
{
    public class Callbacks
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("start")]
        public DateTimeOffset Start { get; set; }

        [JsonPropertyName("end")]
        public DateTimeOffset End { get; set; }

        [JsonPropertyName("minimum_staffing")]
        public long MinimumStaffing { get; set; }

        [JsonPropertyName("records")]
        public Record[] Records { get; set; }

        [JsonPropertyName("title")]
        public Title Title { get; set; }
    }

    public class Record
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("user")]
        public Title User { get; set; }

        [JsonPropertyName("start")]
        public DateTimeOffset Start { get; set; }

        [JsonPropertyName("end")]
        public DateTimeOffset End { get; set; }

        [JsonPropertyName("work_site")]
        public object WorkSite { get; set; }
    }

    public class Title
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
