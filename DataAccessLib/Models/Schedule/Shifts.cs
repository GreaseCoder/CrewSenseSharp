using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataAccessLib.Models.Schedule
{
    public class Shifts
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

    public class Group
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }
    }

    public class Label
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("label")]
        public string LabelLabel { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("text_color")]
        public string TextColor { get; set; }
    }

    public class Qualifier
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("shortcode")]
        public string Shortcode { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("text_color")]
        public string TextColor { get; set; }
    }

    public class ScheduledBy
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class WorkType
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
        public Group[] Subtypes { get; set; }
    }
}
