
using NeuroBuddy.Common.Interfaces;
using NeuroBuddy.Common.Entities;
using System;
using NeuroBuddy.Common.Interfaces.Entities;
using System.Windows;
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
        }

        private void View_SignUpButtonClicked(UserInfo obj)
        {
            if (LoadedUsers.Any(x => x.Id == obj.Id))
                throw new Exception("User's already exists");

            BindData(obj);
            
        }

        private void View_SignInButtonClicked(UserInfo obj)
        {
            if (!LoadedUsers.Any(x => x.Id == obj.Id))
                throw new Exception("User's doesn't exists");

            BindData(obj);
        }
        private void BindData(UserInfo obj)
        {
            UsersRepo.Add(obj);
            Users.SaveUser(UsersRepo.GetAll().ToList());

            UOWFactory.User = obj;
            UOWFactory.GetDBContext();
        }
    }
}
