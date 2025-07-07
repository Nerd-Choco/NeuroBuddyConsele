using NeuroBuddy.Core;

namespace NeuroBuddy.Interfaces
{
    public interface IDatabaseManager
    {
        Userdatabase GetUserdatabase(string username);
        
    }
}
