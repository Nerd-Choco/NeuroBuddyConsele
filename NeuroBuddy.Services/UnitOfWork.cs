using NeuroBuddy.Common.Entities;
using NeuroBuddy.Common.Interfaces;
using NeuroBuddy.Common.Interfaces.Entities;
using NeuroBuddy.Services.DatabaseConnection;
using NeuroBuddy.Services.Repositories.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NeuroBuddy.Services
{
    class UnitOfWork : IUnitOfWork
    {
        public IActivityRepository Activities { get; }

        public ICategoryRepository Categories { get; }

        string filePath;
        public UnitOfWork(UserInfo user)
        {

            filePath = "Database\\Users\\"+$"{user.Username}" + ".json";

            DTO dto;

            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                dto = JsonSerializer.Deserialize<DTO>(json) ?? new DTO(new List<NeuroActivity>(), new List<NeuroCategory>());
            }
            else
            {
                dto = new DTO(new List<NeuroActivity>(), new List<NeuroCategory>());

                var json = JsonSerializer.Serialize(dto);
                File.WriteAllText(filePath, json);
            }

            Activities = new ActivityRepository(dto.ActivityList);
            Categories = new CategoryRepository(dto.CategoriesList);
        }
        public void SaveChanges()
        {

            var SavedActivities = Activities.GetAll().ToList();
            var SavedCategory = Categories.GetAll().ToList();

            var dto = new DTO(SavedActivities, SavedCategory);
            var json = JsonSerializer.Serialize(dto);

            File.WriteAllText(filePath, json);
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
