using NeuroBuddy.Common.Entities;
using NeuroBuddy.Common.Interfaces;
using NeuroBuddy.Common.Interfaces.Entities;
using NeuroBuddy.Services.DatabaseConnection;
using NeuroBuddy.Services.Repositories.JSON;
using NeuroBuddy.View;
using System.Windows.Forms;
using NeuroBuddy.Application.Controllers;
using static System.Windows.Forms.DataFormats;


namespace NeuroBuddy.View
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            ILoginView view = new AssignUserWindow();
            var User = new UserInfo();
            var RegsiteredUsers = new JSONUsersFactory();
            IUsersRepository UserRepo = new UserRepository(RegsiteredUsers.LoadUsers().ToList());
            var UOF = new UserDBContextFactory(User);


               var loginCTL = new UsersFactoryController(view, RegsiteredUsers, UserRepo, UOF);


            // To customize application configuration such as set high DPI settings or default font,

            System.Windows.Forms.Application.Run((Form)view);
        }
    }
}