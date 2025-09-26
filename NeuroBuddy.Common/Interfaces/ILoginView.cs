using NeuroBuddy.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
namespace NeuroBuddy.Common.Interfaces
{
  public interface ILoginView
    {
        event Action<UserInfo> SignInButtonClicked;
        event Action <UserInfo>SignUpButtonClicked;
        void ShowMainWindow(); 
       
    }
}
