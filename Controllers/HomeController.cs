using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CSharp_ViewModel.Models;

namespace CSharp_ViewModel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Names()
    {
        // to a View that has defined a model as @model string[]
        string[] names = new string[]
        {
            "Sally",
            "Billy",
            "Joey",
            "Moose"
        };
        return View(names);
    }

    public IActionResult Numbers()
    {
        // to a View that has defined a model as @model string[]
        int[] nums = new int[]
        {
            3,
            6,
            9,
            12
        };
        return View(nums);
    }

    public IActionResult Users()
    {
        // to a View that has defined a model as @model string[]
        List<User> users = new List<User>();


        User user1 = new User()
        {
            FirstName = "Karl",
            LastName = "Pilkington"
        };

        User user2 = new User()
        {
            FirstName = "Ricky",
            LastName = "Gervais"
        };

        User user3 = new User()
        {
            FirstName = "Stephen",
            LastName = "Merchant"
        };

        users.Add(user1);
        users.Add(user2);
        users.Add(user3);

        return View(users);
    }

    public IActionResult OneGuy()
    {
        // to a View that has defined a model as @model string[]
        User norm = new User()
        {
            FirstName = "Norm",
            LastName = "MacDonald"
        };

        return View(norm);

    }
}
