using Microsoft.AspNetCore.Mvc;

namespace MyMvcApp.Controllers;

public class TuwaiqController : Controller
{
    public string Index()
    {
        return "Welcome to Tuwaiq Academy!";
    }

    public string Bootcamp(string track)
    {
        return $"You are enrolled in the {track} Bootcamp!";
    }
}