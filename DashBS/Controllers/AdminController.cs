using Microsoft.AspNetCore.Mvc;

namespace DashBS.Controllers;
public class AdminController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
