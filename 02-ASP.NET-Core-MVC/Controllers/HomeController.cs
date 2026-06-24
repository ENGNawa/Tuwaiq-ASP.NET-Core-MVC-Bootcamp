using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Store(string searchTerm)
    {
        var allProducts = new List<object>
    {
        new { Id = 1, Name = "Laptop", Price = 3500, Image = "laptop.webp" },
        new { Id = 2, Name = "Smart Phone", Price = 2500, Image = "phone.webp" },
        new { Id = 3, Name = "Keyboard", Price = 150, Image = "keyboard.webp" },
        new { Id = 4, Name = "Monitor", Price = 900, Image = "monitor.jpg" }
    };

        var filteredProducts = new List<object>();

        foreach (var item in allProducts)
        {
            dynamic product = item;

            if (string.IsNullOrEmpty(searchTerm) ||
                product.Name.ToLower().Contains(searchTerm.ToLower()))
            {
                filteredProducts.Add(item);
            }
        }

        ViewBag.MyProducts = filteredProducts;
        ViewBag.CurrentSearch = searchTerm;

        return View();
    }
    public IActionResult Courses()
    {
        return View("~/Views/Tuwaiq/Courses.cshtml");
    }
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