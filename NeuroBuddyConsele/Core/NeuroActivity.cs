using NeuroBuddyConsele.Core;
using System.Diagnostics;

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

    public string Name { get; set; }
    public Guid ID { get;} = Guid.NewGuid();
    public NeuroCategory Category {get;set;}
    public NeuroSchedule? Schedule { get; set; } = new NeuroSchedule();
    public List<ProgressInterval> ProgressTracker { get; init; } = new List<ProgressInterval>();
    public Status ActivityStatus { get; set; } = Status.NotStarted;

    public NeuroActivity(string name, NeuroCategory category, NeuroSchedule? schedule)
    {
        Name = name;
        Category = category;
        Schedule = schedule;
    }
    public NeuroActivity(string name,NeuroCategory category)
    {
        Name = name;
        Category = category;
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

        ProgressTracker.Add(Interval);

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
        var total = ProgressTracker.Aggregate(TimeSpan.Zero, (sum, interval) => sum + interval.Duration);

        if (ActivityStatus == Status.Started || ActivityStatus == Status.InProcess)
        {
            total += (DateTime.Now - startTime);
        }

        return total;
    }
    public override string ToString()
    {
        return $"Activity: {Name} " +
            $"\nCategory: {Category}"+
            $"\nStatus: {ActivityStatus}" +
            $"\nSchedule: {Schedule}" +
            $"\nProgress:\n{string.Join("\n",ProgressTracker)}" +
            $"\nTotal Duration: {GetActualDuration()}";
    }
} 