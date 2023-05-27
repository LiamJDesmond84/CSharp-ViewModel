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
}
