namespace NeuroBuddy.Core;

public enum TimePeriod
{
    Morning, 
    Noon, 
    Afternoon,
    Evening,
    Night,
    Midnight
}
public abstract class NeuroSchedule
{
    public override abstract string ToString();
    //public NeuroReminder? Reminder {get; set;}
}

public class NeuroScheduleStartEnd : NeuroSchedule
{
    public DateTime Start {get; set;}
    public DateTime End {get; set;}

    

    public TimeSpan Duration => End - Start;
    public NeuroScheduleStartEnd(DateTime start, DateTime end)
    {
        Start = start;
        End = end;
    }
    public override string ToString()
    {
        return $"Start : " + Start.ToString() + " End: " + End.ToString() + "Duration: " + Duration.ToString();

    }
}

public class NeuroScheduleDurationOnly : NeuroSchedule
{
    public TimeSpan Duration {get; set;}
    public TimePeriod Period { get; set; }
    public NeuroScheduleDurationOnly(TimeSpan duration, TimePeriod period)
    {
        Duration = duration;
        Period = period;
    }
    public override string ToString()
    {
        return $"Duration: " + Duration.TotalMinutes.ToString() + "\n Period of the day: "+ Period.ToString();

    }
}