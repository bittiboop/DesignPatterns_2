namespace DesignPatterns_2;

public class UserProfilePrototype
{
    public UserProfile Profile { get; private set; }
    
    public UserProfilePrototype(UserProfile profile)
    {
        Profile = profile;
    }
    public UserProfile Clone()
    {
        return new UserProfile()
        {
            Name = Profile.Name,
            Age = Profile.Age,
            Email = Profile.Email,
            Adress = Profile.Adress
        };
    }
}