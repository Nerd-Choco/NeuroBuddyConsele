using NeuroBuddyConsele.Core;

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
        this.ActivityStatus = Status.Started;
    }
    public void Pause()
    {
        if (ActivityStatus == Status.NotStarted)
            return; 

        var Interval = new ProgressInterval();
        Interval.EndTime = DateTime.Now;
        Interval.StartTime = startTime;

        ProgressTracker.Add(Interval);

        this.ActivityStatus = Status.Paused;
    }
    public TimeSpan GetActualDuration()
    {
        return ProgressTracker.Aggregate(TimeSpan.Zero, (total, x) => total + x.Duration);
    }
    public override string ToString()
    {
        return $"Activity: {Name} " +
            $"\nCategory: {Category}"+
            $"\nStatus: {ActivityStatus}" +
            $"\nSchedule: {Schedule}" +
            $"\nProgress : {ProgressTracker}";
    }
} 