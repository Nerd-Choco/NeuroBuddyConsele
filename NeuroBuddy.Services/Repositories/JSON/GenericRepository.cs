using NeuroBuddy.Common.Entities;
using NeuroBuddy.Common.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Services.Repositories.JSON
{
    public class GenericRepository<T> : IEntityRepository<T> where T : IEntity
    {
        public List<T> Entities = new();

        public GenericRepository(List<T> values)
        {
            Entities = values;
        }

        public virtual void Add(T Entity)
        {
            if (Entity is null || Entities.Any(x => x.Id == Entity.Id))
                throw new Exception();

            Entities.Add(Entity);
        }

        public virtual void Delete(T Entity)
        {
            Entities.Remove(Entity); 
        }

        public virtual T Get(int Id)
        {
            var requiredValue = Entities.FirstOrDefault(x => x.Id == Id);

            if (requiredValue is null)
                throw new Exception();

            return requiredValue;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return Entities;
        }

        public virtual void Modify(T Entity)
        {
            var index = Entities.FindIndex(x=>x.Id == Entity.Id);

            if (index < 0)
                throw new Exception();

            Entities[index] = Entity; 

        }
    }
}
