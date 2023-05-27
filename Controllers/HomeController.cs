using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CSharp_ViewModel.Models;

namespace CSharp_ViewModel.Controllers;

public class HomeController : Controller
{
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
}
