using NeuroBuddy.Core;
using NeuroBuddy.Interfaces;
using System.Diagnostics.Tracing;

namespace NeuroBuddy.Mocks
{
    public class UserdatabaseManagerMock : IDatabaseManager
    {
        public Userdatabase GetUserdatabase(string username)
        {
            var db = new Userdatabase(username);
            db.Categories.Add(new NeuroCategory("Health"));
            db.Categories.Add(new NeuroCategory("House"));
            db.Categories.Add(new NeuroCategory("Fun"));
            db.Categories.Add(new NeuroCategory("Workout", db.Categories.First()));
            var duration = TimeSpan.FromMinutes(30);
            TimePeriod activityTime = TimePeriod.Evening;
      
            NeuroSchedule activitySchedule = new NeuroScheduleDurationOnly(duration, activityTime);
            string title = "Take a Shower";

            
            
             var category = db.Categories.First();
         
                var Acticity = new NeuroActivity(title, activitySchedule, category, NeuroStatus.Paused);
            db.Activities.Add(Acticity);
             
            db.Tasks.Add(new NeuroTask("Cleaning", db.Categories[1]));
            db.Tasks.Add(new NeuroTask("Attack on Titans", db.Categories[2]));
            db.Tasks.Add(new NeuroTask("30Min Cardio Daily", db.Categories[3]));

            return db;
        }
    }
}
