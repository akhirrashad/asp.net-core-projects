using Microsoft.AspNetCore.Mvc;


namespace view_layouts.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        ViewData["Layout"] = "_UserLayout";
        ViewData["Title"] = "Home";
        return View();
    }
    [Route("/about")]
    public IActionResult About()
    {
        ViewData["Layout"] = "_UserLayout";
        ViewData["Title"] = "About";
        return View();
    }

    [Route("/contact")]
    public IActionResult Contact()
    {
        ViewData["Layout"] = "_UserLayout";
        ViewData["Title"] = "Contact";
        return View();
    }
}