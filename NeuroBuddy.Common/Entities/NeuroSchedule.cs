
using System.Text.Json.Serialization;
using NeuroBuddy.Common.Entities;
using NeuroBuddy.Common.Enums;

namespace NeuroBuddy.Common
{
    public class NeuroSchedule
    {
        PeriodOfDay period;

        public DateTime PlannedStartTime { get; set; }

        public TimeSpan PlannedDuration { get; set; }

        public Repetitive Repetition { get; set; } = Repetitive.Daily;

        [JsonIgnore]
        public PeriodOfDay Period { get; set; }

        public NeuroSchedule(DateTime plannedStartTime, TimeSpan plannedDuration, Repetitive repetition)
        {
            PlannedStartTime = plannedStartTime;
            PlannedDuration = plannedDuration;
            Repetition = repetition;
        }

        public NeuroSchedule() { }

        public override string ToString()
        {
            return $"\nPlanned Date: {PlannedStartTime}" +
                $"\nDuration: {PlannedDuration}" +
                $"\nTime Line: {period}";
        }
    }
}
