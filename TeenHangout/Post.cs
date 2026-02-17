// Defines the namespace for organization
namespace TeenHangout;

// This class represents a post created by a user
public class Post
{
    // Stores the username of the person who created the post
    public string Username { get; set; }

    // Stores the text/content of the post
    public string Content { get; set; }

    // Stores how many likes the post has received
    public int Likes { get; set; }

    // Constructor used to create a new Post object
    public Post(string username, string content, int likes)
    {
        Username = username;
        Content = content;
        Likes = likes;
    }
}