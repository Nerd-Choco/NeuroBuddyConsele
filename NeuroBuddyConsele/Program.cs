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
            var activity = new NeuroActivity("HIIT", category);

            activity.Schedule.PlannedStartTime = DateTime.Now; 
            activity.Schedule.PlannedDuration = TimeSpan.FromMinutes(30);

            db.Activities.Add(activity);
            activity = new("Food", category);
            db.Activities.Add(activity);
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
            var cat = db.Activities.First();
            
            int userInput = 0;

            Console.WriteLine(cat);
            while (true)
            {
                Console.WriteLine("____________________________________");
                Console.WriteLine("commands\n____________________________________" +
                    "\n1) start" +
                    "\n2) pause" +
                    "\n3) duration");
                Console.WriteLine("____________________________________");

                userInput = Convert.ToInt32(Console.ReadLine()); 

                if(userInput ==1)
                {
                    db.Activities.First().Start();
                    Console.WriteLine(db.Activities.First().ActivityStatus);

                }
                else if(userInput==2)
                {
                    db.Activities.First().Pause();
                    Console.WriteLine(db.Activities.First().ActivityStatus);
                }
                else if(userInput==3 )
                {
                    Console.WriteLine(db.Activities.First().GetActualDuration() + " : " + db.Activities.First().ActivityStatus);
                }
                else break;
            }
            Console.WriteLine("____________________________________");
            Console.WriteLine(db.Activities.First()); 


        }

    }
}

