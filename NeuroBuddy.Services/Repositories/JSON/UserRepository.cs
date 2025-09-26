using NeuroBuddy.Common.Entities;
using NeuroBuddy.Common.Interfaces.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NeuroBuddy.Services.Repositories.JSON
{
    public class UserRepository : GenericRepository<UserInfo>, IUsersRepository
    {

        public UserRepository(List<UserInfo> values) : base(values)
        {

        }
        public override void Add(UserInfo Entity)
        {
            base.Add(Entity);
        }
        public override void Modify(UserInfo Entity)
        {
            base.Modify(Entity);
        }
        public override void Delete(UserInfo Entity)
        {
            base.Delete(Entity);
        }

    }

}
