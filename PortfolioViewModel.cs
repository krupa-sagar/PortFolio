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
    public string Summary { get; set; } = "";
    public string? AvatarUrl { get; set; }
    public string? ResumeUrl { get; set; }
    public SocialLinks Social { get; set; } = new();
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
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string Message { get; set; } = "";

    // Needed by Index.cshtml and PortfolioDataService
    public string? Phone { get; set; }
    public string? Location { get; set; }
}

public class PortfolioViewModel
{
    public AboutModel About { get; set; } = new();
    public List<ProjectModel> Projects { get; set; } = new();
    public List<SkillCategory> SkillCategories { get; set; } = new();
    public ContactModel Contact { get; set; } = new();
}