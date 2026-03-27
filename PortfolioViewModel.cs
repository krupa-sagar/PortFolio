using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models;

public class SocialLinks
{
    public string GitHub { get; set; } = "";
    public string LinkedIn { get; set; } = "";
    public string Twitter { get; set; } = "";
    public string Website { get; set; } = "";
}

public class AboutModel
{
    public string Name { get; set; } = "Alex Johnson";
    public string Title { get; set; } = "Full-Stack Developer";
    public string Bio { get; set; } = "Passionate developer with 5+ years of experience crafting elegant solutions to complex problems. I love building products that make a difference.";
    public string Location { get; set; } = "San Francisco, CA";
    public string Email { get; set; } = "alex@example.com";
    public string GitHub { get; set; } = "https://github.com/alexjohnson";
    public string LinkedIn { get; set; } = "https://linkedin.com/in/alexjohnson";
    public string AvatarInitials { get; set; } = "AJ";

    // Needed by GetAbout() and Index.cshtml
    public string Summary
    {
        get => string.IsNullOrWhiteSpace(_summary) ? Bio : _summary;
        set => _summary = value;
    }
    public string? AvatarUrl { get; set; } = "https://ui-avatars.com/api/?name=Alex+Johnson&size=200&background=0d6efd&color=fff";
    public string? ResumeUrl { get; set; } = "/files/resume.pdf";
    public SocialLinks Social { get; set; } = new()
    {
        GitHub = "https://github.com/alexjohnson",
        LinkedIn = "https://linkedin.com/in/alexjohnson",
        Twitter = "https://twitter.com/"
    };

    private string _summary = "";
}

public class ProjectModel
{
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public List<string> Tags { get; set; } = new();
    public string? LiveUrl { get; set; }
    public string? GitHubUrl { get; set; }
    public string Icon { get; set; } = "bi-code-slash";
    public string AccentColor { get; set; } = "#4f46e5";

    // Needed by PortfolioDataService + Index.cshtml
    public string? ImageUrl { get; set; }
    public bool IsFeatured { get; set; } = false;
}

public class SkillCategory
{
    public string Category { get; set; } = "";
    public string Icon { get; set; } = "";
    public List<SkillItem> Skills { get; set; } = new();
}

public class SkillItem
{
    public string Name { get; set; } = "";
    public int Proficiency { get; set; } // 0-100
}

public class ContactModel
{
    [Required]
    public string Name { get; set; } = "";

    [Required]
    [EmailAddress]
    public string Email { get; set; } = "";

    [Required]
    public string Subject { get; set; } = "";

    [Required]
    public string Message { get; set; } = "";

    // Needed by Index.cshtml and PortfolioDataService
    public string? Phone { get; set; } = "+1 (555) 123-4567";
    public string? Location { get; set; } = "San Francisco, CA";
}

public class PortfolioViewModel
{
    public AboutModel About { get; set; } = new();
    public List<ProjectModel> Projects { get; set; } = new();
    public List<SkillCategory> SkillCategories { get; set; } = new();
    public ContactModel Contact { get; set; } = new();
}
