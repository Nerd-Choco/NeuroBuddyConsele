using NeuroBuddy.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Common.Interfaces
{
    //the factory of the connecting of the database and the code.
  public interface IUnitOfWorkFactory
    {
        event Action UOWCreated;
        UserInfo User { get; set; }
        IUnitOfWork GetDBContext();
    }
}
