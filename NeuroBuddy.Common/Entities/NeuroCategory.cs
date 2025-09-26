using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Common.Entities;

public class NeuroCategory: IEntity
{

     public int Id { get; set; } 

    public string Name { get; set; }

    public NeuroCategory()
    {
    }

    public NeuroCategory(string name)
    {
        Name = name;
    }
    public NeuroCategory(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"Title: {Name}, ID: {Id}";
    }
}
