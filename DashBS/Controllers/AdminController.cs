using Microsoft.AspNetCore.Mvc;

namespace DashBS.Controllers;
public class AdminController : Controller
{
    public IActionResult Index() => View();

    public IActionResult Dashboard() => View();

    public IActionResult Users() => View();

    public IActionResult Settings() => View();

    public IActionResult Details() => View();

    public IActionResult About() => View();

    public IActionResult Contact() => View();

    public IActionResult Error() => View();

    public IActionResult OnGet() => View();

    public IActionResult OnPost() => View();

    public IActionResult OnPut() => View();

    public IActionResult OnDelete() => View();

    public IActionResult OnPre() => View();




}
