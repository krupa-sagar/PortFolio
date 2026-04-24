using Portfolio.Models;

namespace Portfolio.Services
{
    /// <summary>
    /// Provides portfolio content. Replace the hard-coded values with a
    /// database or CMS call as needed.
    /// </summary>
    public class PortfolioDataService
    {
        public PortfolioViewModel GetPortfolioData()
        {
            return new PortfolioViewModel
            {
                About = GetAbout(),
                Projects = GetProjects(),
                SkillCategories = GetSkillCategories(),
                Contact = GetContact()
            };
        }

        // ── About ──────────────────────────────────────────────────────────

        private static AboutModel GetAbout() => new()
        {
            Name = "Krupa Sagar",
            Title = ".NET Developer",
            Summary = "I have 4+ years of experience building desktop applications using WPF and MVVM"+
                            "Focused on building scalable, maintainable applications with clean UI and efficient architecture."+
                            "Currently expanding into ASP.NET Core to build modern web applications.",
            Shortsummary = "Passionate software engineer with 4+ years of experience building " +
                      "scalable web applications using C#, ASP.NET Core, and modern front-end " +
                      "technologies. I love turning complex problems into elegant solutions.",
            AvatarUrl = "https://ui-avatars.com/api/?name=Alex+Johnson&size=200&background=0d6efd&color=fff",
            ResumeUrl = "/files/resume.pdf",
            Social = new SocialLinks
            {
                GitHub   = "https://github.com/krupa-sagar",
                LinkedIn = "https://linkedin.com/in/krupa-sagar-0105a21b3",
                Twitter  = "https://twitter.com/"
            }
        };

        // ── Projects ───────────────────────────────────────────────────────

        private static List<ProjectModel> GetProjects() =>
        [
            new()
            {
                Title       = "E-Commerce Platform",
                Description = "A full-featured online store built with ASP.NET Core, Entity Framework, " +
                              "Stripe payments, and a responsive Bootstrap UI.",
                ImageUrl    = "https://placehold.co/600x340/0d6efd/ffffff?text=E-Commerce",
                Tags        = ["ASP.NET Core", "EF Core", "Stripe", "SQL Server"],
                LiveUrl     = "#",
                GitHubUrl   = "#",
                IsFeatured  = true
            },
            new()
            {
                Title       = "Task Management API",
                Description = "RESTful API built with .NET 8, using Clean Architecture, CQRS with " +
                              "MediatR, JWT authentication, and full Swagger documentation.",
                ImageUrl    = "https://placehold.co/600x340/198754/ffffff?text=Task+API",
                Tags        = [".NET 8", "Clean Architecture", "CQRS", "JWT"],
                LiveUrl     = "#",
                GitHubUrl   = "#",
                IsFeatured  = true
            },
            new()
            {
                Title       = "Real-Time Chat App",
                Description = "Blazor WebAssembly + SignalR chat application with rooms, " +
                              "private messaging, and online presence indicators.",
                ImageUrl    = "https://placehold.co/600x340/dc3545/ffffff?text=Chat+App",
                Tags        = ["Blazor", "SignalR", "Azure"],
                LiveUrl     = "#",
                GitHubUrl   = "#",
                IsFeatured  = false
            },
            new()
            {
                Title       = "DevOps Dashboard",
                Description = "Internal dashboard aggregating CI/CD pipeline metrics, build health, " +
                              "and deployment status from Azure DevOps via REST APIs.",
                ImageUrl    = "https://placehold.co/600x340/6f42c1/ffffff?text=DevOps+Dashboard",
                Tags        = ["Azure DevOps", "Razor Pages", "Chart.js"],
                LiveUrl     = "#",
                GitHubUrl   = "#",
                IsFeatured  = false
            }
        ];

        // ── Skills ─────────────────────────────────────────────────────────

        private static List<SkillCategory> GetSkillCategories() =>
        [
            new()
            {
                Category = "Back-End",
                Icon     = "bi-server",
                Skills   =
                [
                    new() { Name = "C# / .NET",         Proficiency = 95 },
                    new() { Name = "ASP.NET Core MVC",   Proficiency = 92 },
                    new() { Name = "Entity Framework",   Proficiency = 88 },
                    new() { Name = "SQL Server / PostgreSQL", Proficiency = 85 },
                    new() { Name = "REST & GraphQL APIs", Proficiency = 90 }
                ]
            },
            new()
            {
                Category = "Front-End",
                Icon     = "bi-layout-text-window",
                Skills   =
                [
                    new() { Name = "HTML / CSS",    Proficiency = 90 },
                    new() { Name = "JavaScript / TypeScript", Proficiency = 80 },
                    new() { Name = "Bootstrap 5",   Proficiency = 88 },
                    new() { Name = "Blazor",        Proficiency = 75 },
                    new() { Name = "React",         Proficiency = 70 }
                ]
            },
            new()
            {
                Category = "DevOps & Tools",
                Icon     = "bi-gear-wide-connected",
                Skills   =
                [
                    new() { Name = "Docker / Kubernetes", Proficiency = 78 },
                    new() { Name = "Azure & Azure DevOps", Proficiency = 82 },
                    new() { Name = "Git & CI/CD",          Proficiency = 90 },
                    new() { Name = "Unit & Integration Testing", Proficiency = 85 }
                ]
            }
        ];

        // ── Contact ────────────────────────────────────────────────────────

        private static ContactModel GetContact() => new()
        {
            Email    = "sagaras1063@gmail.com",
            Phone    = "+91 8217660778",
            Location = "Bengaluru, KA",
        };
    }
}
