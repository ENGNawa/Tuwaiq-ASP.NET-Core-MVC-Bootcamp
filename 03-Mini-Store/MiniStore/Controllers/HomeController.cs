using Microsoft.AspNetCore.Mvc;

namespace mini_store.Controllers;

public class HomeController : Controller
{
    private static dynamic[] _categories =
    {
        new { Id = 0, Name = "إلكترونيات", Icon = "fa-solid fa-bolt-lightning" },
        new { Id = 1, Name = "ملابس", Icon = "fa-solid fa-shirt" },
        new { Id = 2, Name = "كتب", Icon = "fa-solid fa-book-open" }
    };

    private static dynamic[] _products =
    {
        new { Id = 1, CategoryId = 0, Name = "سماعات فاخرة", Price = 299, Description = "سماعات بتصميم أنيق وصوت نقي.", Image = "headphones.png" },
        new { Id = 2, CategoryId = 0, Name = "ساعة ذكية", Price = 450, Description = "ساعة عملية بتصميم زيتي فاخر.", Image = "watch.png" },
        new { Id = 3, CategoryId = 1, Name = "قميص زيتي", Price = 150, Description = "قميص مريح بتصميم بسيط وأنيق.", Image = "clothes.png" },
        new { Id = 4, CategoryId = 2, Name = "كتاب برمجة", Price = 90, Description = "دليل مختصر لتعلم أساسيات البرمجة.", Image = "book.png" }
    };

    public IActionResult Index()
    {
        ViewBag.CategoriesList = _categories;
        return View();
    }

    public IActionResult Products(int id)
    {
        var filtered = _products.Where(p => p.CategoryId == id).ToArray();

        ViewBag.FilteredProducts = filtered;
        ViewBag.CategoryName = _categories[id].Name;

        return View();
    }

    public IActionResult Details(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);

        if (product == null)
        {
            return NotFound();
        }

        ViewBag.Product = product;

        return View();
    }
}