
using NeuroBuddy.Common.Entities;
using NeuroBuddy.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroBuddy
{
    public partial class MainView : Form
    {

  //      Button currenBtn;
        NeuroActivity activity;
        public MainView()
        {

            InitializeComponent();
            NeuroCategory cat = new(1, "Gym");
            activity = new NeuroActivity("Workout", cat);
            activity.Id = 0;
            activity.Schedule.PlannedDuration = TimeSpan.FromMinutes(5);
        }

        
      
    }
}
