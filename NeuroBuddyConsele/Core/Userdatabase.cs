namespace NeuroBuddy.Core;

public class Userdatabase
{
    public string Username { get; set; }

    public List<NeuroCategory> Categories { get; } = new List<NeuroCategory>();
    public List<NeuroTask> Tasks { get; } = new List<NeuroTask>();
    public List<NeuroActivity> Activities { get; }= new List<NeuroActivity>();
    public List<NeuroSchedule> Schedules { get; } = new List<NeuroSchedule>();                 

    public Userdatabase(string username, IEnumerable<NeuroCategory>? categories = null, IEnumerable<NeuroTask>? tasks = null, IEnumerable<NeuroSchedule>? schedules = null, IEnumerable<NeuroActivity>? activities = null)
    {
        Username = username;

      
        if (categories != null)
            Categories.AddRange(categories);

        if (tasks != null)
            Tasks.AddRange(tasks);

        if (schedules != null)
            Schedules.AddRange(schedules);

        if(activities !=null)
    
            Activities.AddRange(activities);
    }
}
