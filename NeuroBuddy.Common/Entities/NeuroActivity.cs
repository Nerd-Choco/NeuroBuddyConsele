using System.Text.Json.Serialization;
using NeuroBuddy.Common.Enums;

namespace NeuroBuddy.Common.Entities
{
    public class NeuroActivity:IEntity
    {
        private DateTime startTime;

        public string Title { get; set; }

        public int Id { get;  set; }

        public int CategoryId { get; set; }

        public NeuroSchedule? Schedule { get; set; } = new NeuroSchedule();

        public List<ProgressInterval> ProgressIntervals { get; init; } = new List<ProgressInterval>();

        [JsonIgnore]
        public ActivityStatus ActivityStatus { get; set; } = ActivityStatus.NotStarted;


        public NeuroActivity(string name, NeuroCategory category, NeuroSchedule? schedule)
        {
            Title = name;
            CategoryId = category.Id;
            Schedule = schedule;
        }

        public NeuroActivity(string name, NeuroCategory category)
        {
            Title = name;
            CategoryId = category.Id;
        }

        public NeuroActivity() { }

        public void Start()
        {
            startTime = DateTime.Now;
            if (ActivityStatus == ActivityStatus.NotStarted)
            {
                ActivityStatus = ActivityStatus.Started;
                return;
            }
            ActivityStatus = ActivityStatus.InProcess;
        }

        public void Pause()
        {
            if (ActivityStatus == ActivityStatus.NotStarted || ActivityStatus == ActivityStatus.Paused)
                return;

            var Interval = new ProgressInterval();
            Interval.EndTime = DateTime.Now;
            Interval.StartTime = startTime;

            ProgressIntervals.Add(Interval);

            ActivityStatus = ActivityStatus.Paused;
        }

        public void End()
        {
            if (ActivityStatus == ActivityStatus.Started || ActivityStatus == ActivityStatus.InProcess)
            {
                Pause();
                ActivityStatus = ActivityStatus.Completed;
            }
        }

        public TimeSpan GetActualDuration()
        {
            var total = ProgressIntervals.Aggregate(TimeSpan.Zero, (sum, interval) => sum + interval.Duration);

            if (ActivityStatus == ActivityStatus.Started || ActivityStatus == ActivityStatus.InProcess)
            {
                total += DateTime.Now - startTime;
            }

            return total;
        }
        public void SetActivity(NeuroActivity activity)
        {
            this.Title = activity.Title;
            this.startTime = activity.startTime;
            this.ActivityStatus = activity.ActivityStatus;
            this.CategoryId = activity.CategoryId;
            this.Id = activity.Id;
            this.ProgressIntervals.AddRange(activity.ProgressIntervals);
            this.Schedule = activity.Schedule;
        }

        public override string ToString()
        {
            return $"Activity: {Title} " +
                $"\nCategory: {CategoryId}" +
                $"\nStatus: {ActivityStatus}";
              //  $"\nSchedule: {Schedule}" +
             //   $"\nProgress:\n{string.Join("\n", ProgressIntervals)}" +
             //   $"\nTotal Duration: {GetActualDuration()}";
        }
    }
}
