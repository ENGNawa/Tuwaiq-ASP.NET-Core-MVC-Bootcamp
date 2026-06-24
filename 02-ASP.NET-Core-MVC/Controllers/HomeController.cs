using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers;

public class HomeController : Controller
{
    static string[] ArrayProduct = { "Mouse", "Keyboard", "Screen", "Laptop" };

    static List<string> ListProduct = new List<string>()
    {
        "Mouse",
        "Keyboard",
        "Screen",
        "Laptop"
    };

    static Dictionary<string, string> DicProduct = new Dictionary<string, string>()
    {
        { "Mouse", "Computer mouse" },
        { "Keyboard", "Computer keyboard" },
        { "Screen", "Computer screen" },
        { "Laptop", "Portable computer" }
    };

    public IActionResult Index()
    {
        return View();
    }

    public string ShowMessage()
    {
        return "Welcome To Tuwaiq";
    }

    public string Square(int num)
    {
        int result = num * num;
        Console.WriteLine($"[Console Output] The square of {num} is: {result}");
        return "Result printed in Terminal";
    }

    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public string GetItem(string name)
    {
        if (ArrayProduct.Contains(name))
        {
            return "found";
        }

        return "not found";
    }

    public string GetListItem(string name)
    {
        if (ListProduct.Contains(name))
        {
            return "found";
        }

        return "not found";
    }

    public string GetDictionaryItem(string name)
    {
        if (DicProduct.ContainsKey(name))
        {
            return DicProduct[name];
        }

        return "not found";
    }

    public IActionResult Products()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}