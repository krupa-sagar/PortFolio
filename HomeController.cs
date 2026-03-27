using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers;

public class HomeController : Controller
{
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

    private PortfolioViewModel BuildPortfolioViewModel() => new()
    {
        About = new AboutModel(),

        Projects = new List<ProjectModel>
        {
            new()
            {
                Title = "E-Commerce Platform",
                Description = "A full-stack e-commerce solution with real-time inventory, payment integration, and admin dashboard built with ASP.NET Core and React.",
                Tags = new() { "ASP.NET Core", "React", "SQL Server", "Stripe" },
                LiveUrl = "#",
                GitHubUrl = "#",
                Icon = "bi-cart3",
                AccentColor = "#4f46e5"
            },
            new()
            {
                Title = "Task Management App",
                Description = "A collaborative project management tool featuring real-time updates via SignalR, drag-and-drop boards, and team analytics.",
                Tags = new() { "Blazor", "SignalR", "EF Core", "PostgreSQL" },
                LiveUrl = "#",
                GitHubUrl = "#",
                Icon = "bi-kanban",
                AccentColor = "#0891b2"
            },
            new()
            {
                Title = "Weather Dashboard",
                Description = "A responsive weather dashboard consuming multiple APIs, featuring interactive charts, location search, and 7-day forecasts.",
                Tags = new() { "MVC", "Chart.js", "REST APIs", "Bootstrap" },
                LiveUrl = "#",
                GitHubUrl = "#",
                Icon = "bi-cloud-sun",
                AccentColor = "#059669"
            },
            new()
            {
                Title = "Inventory System",
                Description = "Enterprise inventory management system with barcode scanning support, automated reorder alerts, and detailed reporting.",
                Tags = new() { "WPF", ".NET 8", "MVVM", "SQLite" },
                GitHubUrl = "#",
                Icon = "bi-box-seam",
                AccentColor = "#d97706"
            },
            new()
            {
                Title = "Blog Engine",
                Description = "A lightweight CMS and blog platform with markdown support, SEO optimization, comment system, and RSS feed generation.",
                Tags = new() { "Razor Pages", "EF Core", "Markdown", "Azure" },
                LiveUrl = "#",
                GitHubUrl = "#",
                Icon = "bi-pencil-square",
                AccentColor = "#dc2626"
            },
            new()
            {
                Title = "API Gateway Service",
                Description = "A microservices API gateway with rate limiting, JWT authentication, request routing, and health monitoring dashboard.",
                Tags = new() { "Minimal API", "Redis", "Docker", "JWT" },
                GitHubUrl = "#",
                Icon = "bi-diagram-3",
                AccentColor = "#7c3aed"
            }
        },

        SkillCategories = new List<SkillCategory>
        {
            new()
            {
                Category = "Backend",
                Icon = "bi-server",
                Skills = new()
                {
                    new() { Name = "C# / .NET", Proficiency = 95 },
                    new() { Name = "ASP.NET Core", Proficiency = 90 },
                    new() { Name = "Entity Framework Core", Proficiency = 85 },
                    new() { Name = "REST API Design", Proficiency = 90 },
                    new() { Name = "SignalR", Proficiency = 75 },
                }
            },
            new()
            {
                Category = "Frontend",
                Icon = "bi-layout-text-window",
                Skills = new()
                {
                    new() { Name = "HTML / CSS", Proficiency = 90 },
                    new() { Name = "JavaScript / TypeScript", Proficiency = 80 },
                    new() { Name = "Blazor", Proficiency = 75 },
                    new() { Name = "React", Proficiency = 70 },
                    new() { Name = "Bootstrap", Proficiency = 88 },
                }
            },
            new()
            {
                Category = "Database",
                Icon = "bi-database",
                Skills = new()
                {
                    new() { Name = "SQL Server", Proficiency = 88 },
                    new() { Name = "PostgreSQL", Proficiency = 80 },
                    new() { Name = "Redis", Proficiency = 70 },
                    new() { Name = "MongoDB", Proficiency = 65 },
                    new() { Name = "SQLite", Proficiency = 85 },
                }
            },
            new()
            {
                Category = "DevOps & Tools",
                Icon = "bi-tools",
                Skills = new()
                {
                    new() { Name = "Git / GitHub", Proficiency = 92 },
                    new() { Name = "Docker", Proficiency = 78 },
                    new() { Name = "Azure", Proficiency = 72 },
                    new() { Name = "CI/CD Pipelines", Proficiency = 75 },
                    new() { Name = "Visual Studio / VS Code", Proficiency = 95 },
                }
            }
        }
    };
}
