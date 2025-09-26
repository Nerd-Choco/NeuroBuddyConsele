using NeuroBuddy.Common.Entities;
using NeuroBuddy.Common.Interfaces;
using System.Text.Json;


namespace NeuroBuddy.Services.DatabaseConnection
{
     public class JSONUsersFactory: IUsersDBContext
    {
         private readonly string filePath = "Database\\Users\\RegisteredUsers.json";

       public IEnumerable<UserInfo> LoadUsers()
        {

            if (!File.Exists("Database\\Users\\RegisteredUsers.json"))
                return new List<UserInfo>();


            var usersList = new List<UserInfo>();

            var FileContext = File.ReadAllText("Database\\Users\\RegisteredUsers.json");
            if (string.IsNullOrWhiteSpace(FileContext))
                return new List<UserInfo>();

            return JsonSerializer.Deserialize<List<UserInfo>>(FileContext);
        }

        public void SaveUser(List<UserInfo> users)
        {
            if (!File.Exists(filePath))
                File.Create(filePath);

            var Json = JsonSerializer.Serialize(users);
            File.WriteAllText(filePath, Json);
        }
    }
}
