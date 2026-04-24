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
    public string Name { get; set; } = "Krupa Sagar";
    public string Title { get; set; } = "Application Developer";
    public string Bio { get; set; } = "I am a .NET developer with hands-on experience in building desktop applications using WPF and the MVVM pattern. I have worked on developing structured and responsive UI, handling large-scale views, and implementing efficient application logic.Alongside desktop development, I have started exploring web technologies and built an ASP.NET Core MVC application using Razor views. This has helped me understand server-side rendering, routing, and web application architecture.I am open to opportunities in both WPF and .NET web development, and I am focused on strengthening my skills to build scalable and maintainable applications across platforms.";
    public string Location { get; set; } = "Bengaluru, KA";
    public string Email { get; set; } = "sagaras1063@gmail.com";
    public string GitHub { get; set; } = "https://github.com/krupa-sagar";
    public string LinkedIn { get; set; } = "linkedin.com/in/krupa-sagar-0105a21b3";
    public string AvatarInitials { get; set; } = "KS";

    // Needed by GetAbout() and Index.cshtml
    public string Summary
    {
        get => string.IsNullOrWhiteSpace(_summary) ? Bio : _summary;
        set => _summary = value;
    }
    public string? Shortsummary{ get; set; }

    public string? AvatarUrl { get; set; } = "https://ui-avatars.com/api/?name=Alex+Johnson&size=200&background=0d6efd&color=fff";
    public string? ResumeUrl { get; set; } = "/files/resume.pdf";
    public SocialLinks Social { get; set; } = new()
    {
        GitHub = "https://github.com/krupa-sagar",
        LinkedIn = "https://www.linkedin.com/in/krupa-sagar-0105a21b3/?lipi=urn%3Ali%3Apage%3Ad_flagship3_profile_view_base_contact_details%3BaWUNXF4%2FTI6bHSjjw5ELWg%3D%3D",
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
    public string? Phone { get; set; } = "+91 8217660778";
    public string? Location { get; set; } = "Bengaluru, KA";
}

public class PortfolioViewModel
{
    public AboutModel About { get; set; } = new();
    public List<ProjectModel> Projects { get; set; } = new();
    public List<SkillCategory> SkillCategories { get; set; } = new();
    public ContactModel Contact { get; set; } = new();
}
