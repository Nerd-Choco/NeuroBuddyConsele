using NeuroBuddy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Core
{
    // instead of making inheritance, my idea is to create  a bool?
    //is logged? but the this will really change the whole interface every time the bool is clicked 
    //it would be easier for the backend maybe but hard to manipulate in the GUI
    // basically the Logged activity is everything like the scheduled
    // the only difference is that it doesn't have reminders + it can't be set in the future (further from the current time) 
    public enum NeuroStatus
    {
        NotStarted,
        InProcess,
        Paused,
        Completed,
        Incomplete
    } 
    public class NeuroActivity
    {
        NeuroCategory category;
        public  string Title { get; set; }
        public  NeuroSchedule Schedule { get; set; }
        public  NeuroCategory Category { get { return category; }
            set {

                if (value == null)
                    throw new Exception("Cannot have a task without a category");

                if (category != null)
                {
                    category.RemoveActivity(this);
                }

                category = value;
            }
        }
        public NeuroStatus Status { get; set; } = NeuroStatus.NotStarted;

 
     //   public bool EnableFutureSchedule { get;  set; }
    public NeuroActivity() { }
        public NeuroActivity(string title, NeuroSchedule schedule, NeuroCategory category, NeuroStatus status)
        {
            Title = title;
            Schedule = schedule;
            Category = category;
            Status = status;
        }

    }

}

