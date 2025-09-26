using NeuroBuddy.Common.Entities;
using NeuroBuddy.Common.Enums;
using NeuroBuddy.Common.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Services.Repositories.JSON
{
    class ActivityRepository : GenericRepository<NeuroActivity>, IActivityRepository
    {
        public ActivityRepository(List<NeuroActivity> values) : base(values)
        {
        }

        public IEnumerable<NeuroActivity> GetByCategoryId(int CategoryId)
        {
            return Entities.Where(x => x.CategoryId == CategoryId); 
        }

        public IEnumerable<NeuroActivity> GetByDay(DateTime Day)
        {
            return Entities.Where(x => x.Schedule?.PlannedStartTime.Date == Day.Date);
        }

        public IEnumerable<NeuroActivity> GetByStatus(ActivityStatus status)
        {
            return Entities.Where(x => x.ActivityStatus == status); 
        }
    }
}
