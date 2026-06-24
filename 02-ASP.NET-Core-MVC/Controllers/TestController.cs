using Microsoft.AspNetCore.Mvc;

namespace MyMvcApp.Controllers;

public class TestController : Controller
{
    public string Index()
    {
        return "This is Test Controller";
    }
}