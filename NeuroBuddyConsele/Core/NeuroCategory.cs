using System.Threading.Tasks;

namespace NeuroBuddy.Core;

public class NeuroCategory
{

    public Guid ID { get; set; } = Guid.NewGuid();
    public string Name { get; set; }

    public NeuroCategory(string name)
    {
        Name = name;
    }

    public override string ToString()
    { 

        return $"Name: {Name}, ID: {ID}";
    }
}