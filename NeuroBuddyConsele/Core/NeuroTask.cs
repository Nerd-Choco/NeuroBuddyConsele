namespace NeuroBuddy.Core;

public class NeuroTask
{
    public string Name {get; set;}

    NeuroCategory category;
    public NeuroCategory Category
    {
        get
        {
            return category;
        }
        set
        {

            if (value == null)
                throw new Exception("Cannot have a task without a category");

            if (category != null)
            {
                category.RemoveTask(this);
            }

            category = value;
        }
    }



    public NeuroTask(string name, NeuroCategory category)
    {
        Name = name;

        this.category = category;
        if (category!= null)
        category.AddTask(this);

       

    }

}