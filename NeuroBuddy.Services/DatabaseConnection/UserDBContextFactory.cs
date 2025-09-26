using NeuroBuddy.Common.Entities;
using NeuroBuddy.Common.Interfaces;
using System.Text.Json;

namespace NeuroBuddy.Services.DatabaseConnection
{
     public class UserDBContextFactory : IUnitOfWorkFactory
    {

        public UserInfo User { get; set; }
        public UserDBContextFactory(UserInfo user)
        {
            User = user;    
        }

        public event Action UOWCreated;

        public IUnitOfWork GetDBContext()
        {
            UOWCreated?.Invoke();
            return new UnitOfWork(User);
        }

    }
}
