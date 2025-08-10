namespace NeuroBuddy.Core;

public interface IUserdatabase
{
    string Username {get; set;}
  
    IEnumerable<NeuroCategory> GetAllCategories();

    IEnumerable<NeuroActivity> GetAllActivities();

    IEnumerable<NeuroActivity> GetAllActivitesOfCateogry(Guid catId);

    IEnumerable<NeuroActivity> GetAllActivitesOfDate(DateTime day);

    NeuroCategory? GetCategoryById(Guid id);

    NeuroActivity? GetActivityById(Guid id);

    void AddActivity(NeuroActivity activity);

    void AddCategory(NeuroCategory category);
}

public interface IUserdatabaseProvider
{
    IUserdatabase Load(string username);

    void Save(IUserdatabase db);
    bool IsRegistered(string username);
    void LoadUsers();
    void SaveUsers(string username);
    IUserdatabase CreateEmpty(string username);

    IUserdatabase CreateClone(IUserdatabase db, string newUsername);
}