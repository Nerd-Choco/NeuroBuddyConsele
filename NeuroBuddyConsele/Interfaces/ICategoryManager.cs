using NeuroBuddy.Core;

namespace NeuroBuddy.Interfaces
{
    public interface ICategoryManager
    {
        void Add(NeuroCategory category);

        void Remove(NeuroCategory category);

        IEnumerable<NeuroCategory> GetAllCategories();
    }
}
