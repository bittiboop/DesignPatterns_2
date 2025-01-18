namespace DesignPatterns_2;

class Program
{
    static void Main(string[] args)
    {
        var config = ConfigurationManagerSingleton.Instance;
        Console.WriteLine($"Application Name: {config.ApplicationName}");
        Console.WriteLine($"Version: {config.Version}");
        Console.WriteLine();
        
        IUserProfileBuilder builder = new UserProfileBuilder();
        builder.SetName("Vanya Fifkov");
        builder.SetAge(25);
        builder.SetEmail("john.doe@example.com.ua");
        builder.SetAdress("Kyiv, Ukraine");
        UserProfile profile = builder.Build();
        
        Console.WriteLine("User Profile:");
        Console.WriteLine(profile);
        Console.WriteLine();
        
        UserProfilePrototype prototype = new UserProfilePrototype(profile);
        UserProfile profileClone = prototype.Clone();
        
        Console.WriteLine("Cloned User Profile:");
        Console.WriteLine(profileClone);
    }
}