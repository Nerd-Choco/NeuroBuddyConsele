
using NeuroBuddy.Common.Interfaces;
using NeuroBuddy.Common.Entities;
using System;
using NeuroBuddy.Common.Interfaces.Entities;
using NeuroBuddy;
namespace NeuroBuddy.Application.Controllers
{
   public class UsersFactoryController
    {
        ILoginView View;
        IUsersDBContext Users;
        List<UserInfo> LoadedUsers = new();
        IUsersRepository UsersRepo;
        IUnitOfWorkFactory UOWFactory; 
        public UsersFactoryController(ILoginView view, IUsersDBContext users, IUsersRepository usersRepo, IUnitOfWorkFactory UOW)
        {
            View = view;
            Users = users;
            LoadedUsers = users.LoadUsers().ToList();
            UsersRepo = usersRepo;
            UOWFactory = UOW;

            view.SignInButtonClicked += View_SignInButtonClicked;
            view.SignUpButtonClicked += View_SignUpButtonClicked;
            UOWFactory.UOWCreated += UOWFactory_UOWCreated;
        }

        private void UOWFactory_UOWCreated()
        {
            View.ShowMainWindow();
        }

        private void View_SignUpButtonClicked(UserInfo obj)
        {
            if (LoadedUsers.Any(x => x.Username == obj.Username))
                throw new Exception("User's already exists");

            UsersRepo.Add(obj);
            BindData(obj);
            
        }

        private void View_SignInButtonClicked(UserInfo obj)
        {
            if (!LoadedUsers.Any(x => x.Username== obj.Username))
                throw new Exception("User's doesn't exists");

            BindData(obj);
        }
        private void BindData(UserInfo obj)
        {
            Users.SaveUser(UsersRepo.GetAll().ToList());

            UOWFactory.User = obj;
            UOWFactory.GetDBContext();
        }
    }
}
