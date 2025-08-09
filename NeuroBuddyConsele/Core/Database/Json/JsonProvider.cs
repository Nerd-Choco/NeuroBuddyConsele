using System.Text.Json;

namespace NeuroBuddy.Core;

public class JsonProvider : IUserdatabaseProvider
{
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