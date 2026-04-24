using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Controllers;

public class HomeController : Controller
{
    private readonly PortfolioDataService _portfolioDataService;

    public HomeController(PortfolioDataService portfolioDataService)
    {
        _portfolioDataService = portfolioDataService;
    }

    public IActionResult Index()
    {
        var vm = BuildPortfolioViewModel();
        return View(vm);
    }

    [HttpPost]
    public IActionResult Contact(ContactModel contact)
    {
        if (!ModelState.IsValid)
        {
            var vm = BuildPortfolioViewModel();
            vm.Contact = contact;
            return View("Index", vm);
        }
        TempData["ContactSuccess"] = "Thanks for reaching out! I'll get back to you soon.";
        return RedirectToAction("Index", new { scrollTo = "contact" });
    }

    private PortfolioViewModel BuildPortfolioViewModel() => _portfolioDataService.GetPortfolioData();
}
