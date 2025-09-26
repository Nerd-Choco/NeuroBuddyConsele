using NeuroBuddy.Common.Entities;
using NeuroBuddy.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Common.Interfaces.Entities
{
    public interface IActivityRepository : IEntityRepository<NeuroActivity>
    {
        IEnumerable<NeuroActivity> GetByCategoryId(int CategoryId);
        IEnumerable<NeuroActivity> GetByDay(DateTime Day);
        IEnumerable<NeuroActivity> GetByStatus(ActivityStatus status);
    }
}
