using System.Reflection;
using System.Runtime.CompilerServices;
using DesignPatterns.VisitorPattern.DemoPractice.HtmlNodes.Operations;

namespace DesignPatterns.SingletonPattern.DemoPractice;

public class ConfigManager
{
    private static Dictionary<int, string> _config = new Dictionary<int, string>();
    private static ConfigManager _instance = new ConfigManager();

    private ConfigManager()
    {
    }

    public static ConfigManager GetInstance()
    {
        return _instance;
    }

    public void SetConfig(int key, string value)
    {
        _config.Add(key, value);
    }

    public Object GetConfig(int key)
    {
        if(_config.ContainsKey(key)) return _config[key];
        throw new ArgumentNullException("key doesnt exist");
    }
}