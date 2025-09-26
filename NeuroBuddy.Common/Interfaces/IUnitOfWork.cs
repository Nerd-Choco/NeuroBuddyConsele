using NeuroBuddy.Common.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Common.Interfaces
{
    //single userdatabase connection
    public interface IUnitOfWork : IDisposable
    {
        public IActivityRepository Activities { get; }
        public ICategoryRepository Categories { get; }

        void SaveChanges();
    }

}
