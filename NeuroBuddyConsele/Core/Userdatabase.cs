namespace NeuroBuddy.Core;

public class Userdatabase
{
    public string Username { get; set; }

    public List<NeuroCategory> Categories { get; set; } = new List<NeuroCategory>();
    public List<NeuroActivity> Activities { get; set; } = new List<NeuroActivity>();

    public NeuroCategory? GetCategoryById(Guid id)
    {
        return Categories.FirstOrDefault(x => x.ID == id, null);
    }

    public NeuroActivity? GetTaskById(Guid id)
    {
        return Activities.FirstOrDefault(x => x.ID == id, null);
    }
}
