namespace NeuroBuddy.Core;

public class NeuroTask
{
    public string Name {get; set;}
    public Guid CategoryId { get; set; }

    public Guid ID { get; set; } = Guid.NewGuid();

    public NeuroTask(string name,NeuroCategory category)
    {
        Name = name;
        CategoryId = category.ID;
        
    }
    public NeuroTask(string name, Guid categoryId, Guid iD)
    {
        Name = name;
        CategoryId = categoryId;
        ID = iD;
    }
    public NeuroTask() { }
}