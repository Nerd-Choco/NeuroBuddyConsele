using System.Text.Json.Serialization;

namespace NeuroBuddy.Core;

public class ProgressInterval
{
    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    [JsonIgnore]
    public TimeSpan Duration => EndTime - StartTime;

    public ProgressInterval() { }

    public ProgressInterval(DateTime start, DateTime end)
    {
        StartTime = start;
        EndTime = end;
    }

    public override string ToString()
    {
        return $"Duration: {Duration}";
    }
}