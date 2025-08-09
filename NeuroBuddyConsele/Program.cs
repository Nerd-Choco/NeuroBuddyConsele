using NeuroBuddy.Core;
using NeuroBuddyConsele.Core;
using System.Text.Json;



class Program
{
    static void FormNew(IUserdatabaseProvider provider, string username)
    {
        var database = provider.Load(username);

        foreach (var activity in database.GetAllActivities())
        {
            var activityName = activity.Title;
            var category = database.GetCategoryById(activity.CategoryId);
            Console.WriteLine($"{activityName}: {category.Name}");
        }
    }

    static void Main(string[] args)
    {
        var provider = new JsonProvider();
        FormNew(provider, "ahmed");
    }
}