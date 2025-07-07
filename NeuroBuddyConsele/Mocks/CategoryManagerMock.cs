using NeuroBuddy.Core;
using NeuroBuddy.Interfaces;

namespace NeuroBuddy.Mocks
{
    internal class CategoryManagerMock : ICategoryManager
    {
        List<NeuroCategory> cats;
        public CategoryManagerMock(IEnumerable<NeuroCategory> categories)
        {
            cats = new List<NeuroCategory>();
            cats.AddRange(categories);
        }

        public void Add(NeuroCategory category)
        {
            cats.Add(category);
        }

        public IEnumerable<NeuroCategory> GetAllCategories()
        {
            return cats;
        }

        public void Remove(NeuroCategory category)
        {
            cats.Remove(category);
        }
    }
}
