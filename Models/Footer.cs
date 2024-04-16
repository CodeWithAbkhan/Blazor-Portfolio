namespace WasmPortfolio.Models;

public class Link
{
    public string Title { get; set; }= string.Empty;
    public string Href { get; set; } = string.Empty;
    public string Target { get; set; } = string.Empty;
}

public class FooterCategory
{
    public string Title { get; set; } = string.Empty;
    public List<Link> Links { get; set; } 
}

public class Project
{
    public string Name { get; set; }
    public DateTime Started { get; set; }
    public DateTime Ended { get; set; }
    public string Description { get; set; }
    public List<ProImage> Images { get; set; }
    public List<Technology> Technologies { get; set; }
    public string Website { get; set; }
    public string Github { get; set; }
}

public class ProImage
{
    public string Src { get; set; }
    public string Alt { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
}

public class Technology
{
    public string Name { get; set; }
    public string Icon { get; set; }
}

public interface IProjectServices
{
    List<Project> GetProjects();
}
public class Footer
{
    public List<FooterCategory> Categories { get; set; } 
}
public class NavItem
{
    public string Href { get; set; } = string.Empty;
    public string Title { get; set; }= string.Empty;
    public string Target { get; set; } = string.Empty;
}

public class NavigationModel
{
    public List<NavItem> LeftItems { get; set; }
    public List<NavItem> RightItems { get; set; }

    public NavigationModel()
    {
        // Initialize left and right navigation items
        LeftItems = new List<NavItem>();
        RightItems = new List<NavItem>();
    }
    
}
