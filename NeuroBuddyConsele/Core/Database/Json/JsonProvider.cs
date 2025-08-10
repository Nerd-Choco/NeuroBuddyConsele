using System.Text.Json;

namespace NeuroBuddy.Core;

public class JsonProvider : IUserdatabaseProvider
{
    List<string> RegisteredUsers = new List<string>();
    string filePath = "UserList.json";
    public bool IsRegistered(string username)
    {
        LoadUsers();
        if (RegisteredUsers.Contains(username))
            return true;
        return false; 
    }
   public void LoadUsers()
    {
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            RegisteredUsers = JsonSerializer.Deserialize<List<string>>(json) ?? new List<string>();
        }
    }
   public void SaveUsers(string username)
    {
        RegisteredUsers.Add(username);
        var json = JsonSerializer.Serialize(RegisteredUsers);
        File.WriteAllText(filePath, json);
    }
    string GetFilePath(string username)
    {
         return username + ".json";
    }

    public IUserdatabase Load(string username)
    {
        var filePath = GetFilePath(username);

        if (File.Exists(filePath))
        {
            var serialized = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<JsonUserdatabase>(serialized);
        }

        return new JsonUserdatabase();
    }

    public void Save(IUserdatabase db)
    {
        var filePath = GetFilePath(db.Username);

        var jdb = db as JsonUserdatabase;
        if (jdb is null)
            throw new Exception("Should only pass JsonDatabase object");

        var serialized = JsonSerializer.Serialize(jdb);
        File.WriteAllText(filePath, serialized);
        SaveUsers(db.Username);
    }

    public IUserdatabase CreateEmpty(string username)
    {
        return new JsonUserdatabase(username, [], []);
    }

    public IUserdatabase CreateClone(IUserdatabase db, string newUsername)
    {
        var jdb = db as JsonUserdatabase;
        if (jdb is null)
            throw new Exception("Should only pass JsonDatabase object");

        return new JsonUserdatabase(newUsername, jdb.Categories, jdb.Activities);
    }
}