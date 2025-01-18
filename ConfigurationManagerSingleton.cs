namespace DesignPatterns_2;

public class ConfigurationManagerSingleton
{
    private static ConfigurationManagerSingleton instance;
    private static readonly object _lock = new object();
    
    public string ApplicationName { get; private set; }
    public string Version { get; private set; }
    
    private ConfigurationManagerSingleton()
    {
        ApplicationName = "User Profile Manager";
        Version = "1.0.0";
    }
    
    public static ConfigurationManagerSingleton Instance
    {
        get
        {
            lock (_lock)
            {
                if (instance == null)
                {
                    instance = new ConfigurationManagerSingleton();
                }
                return instance;
            }
        }
    }
}