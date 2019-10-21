using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataAccessLib.Models.Schedule
{
    public class Assignmemts
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; set; }

        [JsonPropertyName("start")]
        public DateTimeOffset Start { get; set; }

        [JsonPropertyName("end")]
        public DateTimeOffset End { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("qualifiers_needed")]
        public Qualifier[] QualifiersNeeded { get; set; }

        [JsonPropertyName("minimum_staffing")]
        public long MinimumStaffing { get; set; }

        [JsonPropertyName("is_finalized")]
        public bool IsFinalized { get; set; }

        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        [JsonPropertyName("shifts")]
        public Shift[] Shifts { get; set; }
    }

    public class Shift
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("start")]
        public DateTimeOffset Start { get; set; }

        [JsonPropertyName("end")]
        public DateTimeOffset End { get; set; }

        [JsonPropertyName("length")]
        public long Length { get; set; }

        [JsonPropertyName("break_start")]
        public DateTimeOffset BreakStart { get; set; }

        [JsonPropertyName("break_end")]
        public DateTimeOffset BreakEnd { get; set; }

        [JsonPropertyName("break_length")]
        public double BreakLength { get; set; }

        [JsonPropertyName("hold_over")]
        public long HoldOver { get; set; }

        [JsonPropertyName("recurring")]
        public bool Recurring { get; set; }

        [JsonPropertyName("user")]
        public ScheduledBy User { get; set; }

        [JsonPropertyName("scheduled_by")]
        public ScheduledBy ScheduledBy { get; set; }

        [JsonPropertyName("work_type")]
        public WorkType WorkType { get; set; }

        [JsonPropertyName("labels")]
        public Label[] Labels { get; set; }

        [JsonPropertyName("qualifiers")]
        public Qualifier[] Qualifiers { get; set; }

        [JsonPropertyName("groups")]
        public Group[] Groups { get; set; }
    }
}
