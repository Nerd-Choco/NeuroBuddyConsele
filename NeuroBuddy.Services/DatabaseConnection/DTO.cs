using NeuroBuddy.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Services.DatabaseConnection
{
    public class DTO
    {
        public List<NeuroActivity> ActivityList { get; set; }=new() ;
        public  List<NeuroCategory> CategoriesList { get; set; }=new() ;

        public DTO(List<NeuroActivity> activityList, List<NeuroCategory> categoriesList)
        {
            ActivityList = activityList;
            CategoriesList = categoriesList;
        }
    }
    
}
