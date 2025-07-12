using NeuroBuddy.Core;

using System.Text.Json;
using System.Text.Json.Nodes;

namespace NeuroBuddyConsele
{
    internal class Program
    {
        static void MockDatabase()
        {
            var db = new Userdatabase();
            var category = new NeuroCategory("Health");
            var task = new NeuroTask("Workout", category);
          
            db.Tasks.Add(task);
            task = new("Food", category);
            db.Tasks.Add(task);
            db.Categories.Add(category); 

            db.Username = "choco";
            var text = JsonSerializer.Serialize(db);
            File.WriteAllText("db.json",text);
        }
        static Userdatabase RetrieveDatabase()
        {
            var text = File.ReadAllText("db.json");
            var db = JsonSerializer.Deserialize<Userdatabase>(text);

            return db;
        }
        static void Main(string[] args)
        {
            MockDatabase();
            var db= RetrieveDatabase();
            var cat = db.GetCategoryById(db.Tasks.First().CategoryId);

            Console.WriteLine(cat);
        }

    }
}

