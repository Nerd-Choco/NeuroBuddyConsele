using NeuroBuddy.Core;
using NeuroBuddy.Interfaces;
using NeuroBuddy.Mocks;

namespace NeuroBuddyConsele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine().Trim();
            IDatabaseManager UserData = new UserdatabaseManagerMock();
            Userdatabase Data = UserData.GetUserdatabase(username);

            int Userinput = 0;


            Console.WriteLine($"User name {Data.Username}");
            while (true)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Command: \n1) List categories" +
                    "\n2) List Tasks " +
                    "\n3) List Activities " +
                    "\n4) Add Category " +
                    "\n5) Add Task " +
                    "\n6) Schedule Activity");

                Userinput = Convert.ToInt32(Console.ReadLine());
                switch (Userinput)
                {
                    case 1:
                        ICategoryManager cat = new CategoryManagerMock(Data.Categories);
                        var CatList = cat.GetAllCategories();
                        foreach (var item in CatList)
                        {
                            Console.WriteLine(item.Name);
                            var children = item.Children;
                            if (item.Children != null)
                            {
                                foreach (var item1 in children)
                                {
                                    Console.WriteLine(item1);
                                }
                            }
                        }
                        break;
                    case 2:
                        var tasks = Data.Tasks;
                        foreach (var task in tasks)
                        {
                            Console.WriteLine(task.Name + " : Category : " + task.Category.Name);
                        }
                        break;
                    case 3:
                       var activties=  Data.Activities;
                        foreach (var activity in activties)
                            Console.WriteLine(activity.Title + "\nDate : " + activity.Schedule.ToString() + "\nCategory: " + activity.Category + "\nStatus: " + activity.Status);
                        break;


                }



            }
        }
    }
}
