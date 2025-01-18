namespace DesignPatterns_2;

public class UserProfile
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Adress { get; set; }
    
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Email: {Email}, Adress: {Adress}";
    }
}

interface IUserProfileBuilder
{
    void SetName(string name);
    void SetAge(int age);
    void SetEmail(string email);
    void SetAdress(string adress);
    UserProfile Build();
}
class UserProfileBuilder : IUserProfileBuilder
{
    private UserProfile _profile = new UserProfile();
    
    public void SetName(string name)
    {
        _profile.Name = name;
    }
    public void SetAge(int age)
    {
        _profile.Age = age;
    }
    public void SetEmail(string email)
    {
        _profile.Email = email;
    }
    public void SetAdress(string adress)
    {
        _profile.Adress = adress;
    }

    public UserProfile Build()
    {
        return _profile;
    }
}