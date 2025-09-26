using NeuroBuddy.Common.Entities;
using NeuroBuddy.Common.Interfaces;
using NeuroBuddy.Services.Repositories.JSON;
using NeuroBuddy.Services.DatabaseConnection;
namespace NeuroBuddy.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the testing project");


            var user = new UserInfo(1, "Choco");

            //this loads and saves from/to Json Files.

            IUsersDBContext userList = new JSONUsersFactory();

            // this is user repos (add, creates, delete , modifies) to the List of users.
            var usersInfoRepository = new UserRepository(userList.LoadUsers().ToList());
            
            //for the single user, this creates the unit of work for each user.
            IUnitOfWorkFactory userDataBaseFact = new UserDBContextFactory(user);

            
            var unitOfWork = userDataBaseFact.GetDBContext();

            usersInfoRepository.Add(user);
           
            //this saves the users list to Json file.
            userList.SaveUser(usersInfoRepository.Entities);
            foreach (var item in unitOfWork.Activities.GetAll())
            {
                Console.WriteLine(item);
                Console.WriteLine("==========");
            }
        }
    }
}
