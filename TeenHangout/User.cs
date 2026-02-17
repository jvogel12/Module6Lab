// Defines the namespace for organization
namespace TeenHangout;

// This class represents a user/member of Teen Hangout
public class User
{
    // Property to store the user's username
    public string Username { get; set; }

    // Property to store the user's age
    public int Age { get; set; }

    // Property to store the user's favorite color
    public string FavoriteColor { get; set; }

    // Constructor used to create a new User object
    // It requires username, age, and favorite color when creating a user
    public User(string username, int age, string favoriteColor)
    {
        Username = username;
        Age = age;
        FavoriteColor = favoriteColor;
    }
}