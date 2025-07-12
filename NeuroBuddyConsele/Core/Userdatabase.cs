namespace NeuroBuddy.Core;

public class Userdatabase
{
    public string Username { get; set; }

    public List<NeuroCategory> Categories { get; set; } = new List<NeuroCategory>();
    public List<NeuroTask> Tasks { get; set; } = new List<NeuroTask>();

    public NeuroCategory? GetCategoryById(Guid id)
    {
        return Categories.FirstOrDefault(x => x.ID == id, null);
    }

    public NeuroTask? GetTaskById(Guid id)
    {
        return Tasks.FirstOrDefault(x => x.ID == id, null);
    }
}
