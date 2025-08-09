namespace NeuroBuddy.Core;

public class JsonUserdatabase : IUserdatabase
{
    public string Username { get; set; }    

    public List<NeuroCategory> Categories { get; init; } = new List<NeuroCategory>();
    
    public List<NeuroActivity> Activities { get; init; } = new List<NeuroActivity>();

    public JsonUserdatabase()
    {

    }

    public JsonUserdatabase(string username, IEnumerable<NeuroCategory> cats, IEnumerable<NeuroActivity> acts)
    {
        Username = username;
        Categories = new List<NeuroCategory>(cats);
        Activities = new List<NeuroActivity>(acts);
    }

    public NeuroCategory? GetCategoryById(Guid id)
    {
        return Categories.FirstOrDefault(x => x.ID == id, null);
    }

    public NeuroActivity? GetActivityById(Guid id)
    {
        return Activities.FirstOrDefault(x => x.ID == id, null);
    }

    public IEnumerable<NeuroCategory> GetAllCategories()
    {
        return Categories;
    }

    public IEnumerable<NeuroActivity> GetAllActivities()
    {
        return Activities;
    }

    public IEnumerable<NeuroActivity> GetAllActivitesOfCateogry(Guid catId)
    {
        var cat = GetCategoryById(catId);
        if (cat is null)
            throw new Exception();

        return Activities.Where(x => x.CategoryId == catId);
    }

    public IEnumerable<NeuroActivity> GetAllActivitesOfDate(DateTime day)
    {
        return Activities.Where(x => x.Schedule is not null && x.Schedule.PlannedStartTime.Day == day.Day);
    }

    public void AddActivity(NeuroActivity activity)
    {
        Activities.Add(activity);
    }

    public void AddCategory(NeuroCategory category)
    {
        Categories.Add(category);
    }
}

