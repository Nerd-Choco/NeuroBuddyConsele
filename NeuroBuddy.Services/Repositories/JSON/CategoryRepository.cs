using NeuroBuddy.Common.Entities;
using NeuroBuddy.Common.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Services.Repositories.JSON
{
    class CategoryRepository : GenericRepository<NeuroCategory>, ICategoryRepository
    {
        public CategoryRepository(List<NeuroCategory> values) : base(values)
        {
        }
    }
}
