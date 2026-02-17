using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TeenHangout.Pages;

// This class controls the data sent to the Index page
public class IndexModel : PageModel
{
    // Array that will hold all users
    public User[] Users { get; set; }

    // Array that will hold all posts
    public Post[] Posts { get; set; }

    // Runs automatically when the page loads (GET request)
    public void OnGet()
    {
        // Create array of sample users
        Users = new User[]
        {
            new User("MusicLover", 15, "Purple"),
            new User("GamerGirl", 16, "Red"),
            new User("BookwormBen", 15, "Yellow")
        };

        // Create array of sample posts
        Posts = new Post[]
        {
            new Post("GamerGirl", "Anyone want to play online later?", 30),
            new Post("BookwormBen", "Reading the best book ever!", 15),
            new Post("MusicLover", "Concert next week! So excited!", 22)
        };
    }
}