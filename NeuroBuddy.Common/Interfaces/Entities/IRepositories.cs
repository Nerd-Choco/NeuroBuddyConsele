using NeuroBuddy.Common.Entities;


namespace NeuroBuddy.Common.Interfaces.Entities
{
    public interface IEntityRepository<T>
    {
        void Add(T Entity);
        void Modify(T Entity);
        void Delete(T Entity);
        IEnumerable<T> GetAll(); 
        T Get(int Id);
    }

}
