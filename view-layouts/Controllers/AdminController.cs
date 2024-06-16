using Microsoft.AspNetCore.Mvc;

namespace view_layouts.Controllers;

public class AdminController : Controller
{
    [Route("/admin")]
    public IActionResult Dashboard()
    {
        ViewData["Layout"] = "_AdminLayout";
        ViewData["Title"] = "Dashboard";
        return View();
    }
    [Route("/users")]
    public IActionResult Users()
    {
        ViewData["Layout"] = "_AdminLayout";
        ViewData["Title"] = "Users";
        return View();
    }

    [Route("/settings")]
    public IActionResult Settings()
    {
        ViewData["Layout"] = "_AdminLayout";
        ViewData["Title"] = "Settings";
        return View();
    }
}