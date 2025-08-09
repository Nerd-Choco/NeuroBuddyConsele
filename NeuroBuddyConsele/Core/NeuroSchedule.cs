using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NeuroBuddyConsele.Core
{
 
    public enum PeriodOfDay
    {
        Morning,
        Noon,
        Afternoon,
        Evening,
        Night,
        LateNight
    }

    public enum Repetitive
    {
        Daily,
        Weekly,
        Monthly,
        Yearly,
        Onetime
    }

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
