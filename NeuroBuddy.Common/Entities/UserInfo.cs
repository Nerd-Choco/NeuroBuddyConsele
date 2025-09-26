using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Common.Entities
{
    public class UserInfo: IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; } = String.Empty;

        public UserInfo(int id, string username)
        {
            Id = id;
            Username = username;
        }
        public UserInfo()
        {

        }
       

    }
    
}
