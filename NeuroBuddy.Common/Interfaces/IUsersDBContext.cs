using NeuroBuddy.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Common.Interfaces
{
    public interface IUsersDBContext
    {
        IEnumerable<UserInfo> LoadUsers();
        void SaveUser(List<UserInfo> users);
    }
}
