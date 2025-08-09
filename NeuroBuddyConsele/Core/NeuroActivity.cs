using NeuroBuddyConsele.Core;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace NeuroBuddy.Core;

public enum Status
{
    NotStarted,
    Started,
    Paused,
    InProcess,
    Compeleted
}

public class NeuroActivity
{
    private DateTime startTime;

    public string Title { get; set; }

    public Guid ID { get;} = Guid.NewGuid();

    public Guid CategoryId {get; set;}

    public NeuroSchedule? Schedule { get; set; } = new NeuroSchedule();

    public List<ProgressInterval> ProgressIntervals { get; init; } = new List<ProgressInterval>();

    [JsonIgnore]
    public Status ActivityStatus { get; set; } = Status.NotStarted;


    public NeuroActivity(string name, NeuroCategory category, NeuroSchedule? schedule)
    {
        Title = name;
        CategoryId = category.ID;
        Schedule = schedule;
    }

    public NeuroActivity(string name,NeuroCategory category)
    {
        Title = name;
        CategoryId = category.ID;
    }

    public NeuroActivity() { }

    public void Start()
    {
        startTime = DateTime.Now;
        if (ActivityStatus == Status.NotStarted)
        {
            ActivityStatus = Status.Started;
            return;
        }
        ActivityStatus = Status.InProcess;
    }

    public void Pause()
    {
        if (ActivityStatus == Status.NotStarted|| ActivityStatus==Status.Paused)
            return; 

        var Interval = new ProgressInterval();
        Interval.EndTime = DateTime.Now;
        Interval.StartTime = startTime;

        ProgressIntervals.Add(Interval);

        this.ActivityStatus = Status.Paused;
    }

    public void End()
    {
        if (ActivityStatus == Status.Started|| ActivityStatus== Status.InProcess)
        {
            Pause();
            ActivityStatus = Status.Compeleted; 
        }
    }

    public TimeSpan GetActualDuration()
    {
        var total = ProgressIntervals.Aggregate(TimeSpan.Zero, (sum, interval) => sum + interval.Duration);

        if (ActivityStatus == Status.Started || ActivityStatus == Status.InProcess)
        {
            total += (DateTime.Now - startTime);
        }

        return total;
    }
    
    public override string ToString()
    {
        return $"Activity: {Title} " +
            $"\nCategory: {CategoryId}"+
            $"\nStatus: {ActivityStatus}" +
            $"\nSchedule: {Schedule}" +
            $"\nProgress:\n{string.Join("\n",ProgressIntervals)}" +
            $"\nTotal Duration: {GetActualDuration()}";
    }
} 