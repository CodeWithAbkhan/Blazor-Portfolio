using WasmPortfolio.Models;

namespace WasmPortfolio.Services;

public class ProjectServices : IProjectServices
{
    public List<Project> GetProjects()
    {
        return new List<Project>
        {
            
            new Project
            {
                Name = "My Porfolio Powered by .NET blazor",
                 Started = DateTime.Parse("2024-03-29"),
                Ended =DateTime.Parse("2024-04-16"),
                Description = "My Personal Porfolio build using .NET 8 and ASP.NET Core Blazor WebAssembly",
                Images = new List<ProImage>
                {
                    new ProImage
                    {
                        Src = "images/projects/blazor-dotnet-wasm-portfolio-github-light.png",
                        Alt = " main page ",
                        Width = 1920,
                        Height = 1080
                    }
                },
                Technologies = new List<Technology>
                {
                    new Technology { Name = "NET Core", Icon = "images/icons/net-core.svg" },
                    new Technology { Name = "C#", Icon = "images/icons/cpp.svg" },
                    new Technology { Name = "Blazor .NET 8", Icon = "images/icons/blazor.svg" },
                    new Technology { Name = "Web Assembly", Icon = "images/icons/webassembly.svg" },
                    new Technology { Name = "Github", Icon = "images/icons/github.svg" }
                },
                Website = "https://youtu.be/B2TWGlE8noU",
                Github = "https://github.com/CodeWithAbkhan/Blazor-Portfolio"
            },
            new Project
            {
                Name = "Patients Management System",
                Started = DateTime.Parse("2020-02-12"),
                Ended =DateTime.Parse("2022-01-24"),
                Description = "SM Patients Management System: ASP.NET Core Blazor, .NET 8 powered, deployed on Ubuntu 22.04 VPS via Docker. SQL Server image managed within Docker for efficient data handling. Simplifying patient management for healthcare professionals with a secure, user-friendly interface. Stay tuned for updates!",
                Images = new List<ProImage>
                {
                    new ProImage
                    {
                        Src = "images/projects/sm-patients-management-system-project-build-with-aspnet-core-dot-net-8-full-stack-docker-sql-server-image-deployed-on-vps-ubuntu-using-docker.png",
                        Alt = "main page screenshot",
                        Width = 1920,
                        Height = 1080
                    }
                },
                Technologies = new List<Technology>
                {
                    new Technology { Name = "NET Core", Icon = "images/icons/net-core.svg" },
                    new Technology { Name = "C#", Icon = "images/icons/cpp.svg" },
                    new Technology { Name = "Blazor .NET 8", Icon = "images/icons/blazor.svg" },
                    new Technology { Name = "MS SQL SERVER", Icon = "images/icons/sql-server.svg" },
                    new Technology { Name = "Docker", Icon = "images/icons/docker.svg" },
                    new Technology { Name = "Github", Icon = "images/icons/github.svg" },
                    new Technology { Name = "Linux", Icon = "images/icons/linux.svg" }
                },
                Website = null,
                Github = "https://github.com/CodeWithAbkhan/smpatients"
            },
            new Project
            {
                Name = "Static Server Rendering in .NET 8 blazor",
                 Started = DateTime.Parse("2020-02-12"),
                Ended =DateTime.Parse("2022-01-24"),
                Description = "Personal Markdown MD Blog using .NET 8 and ASP.NET Core.100% performance achieved using Latest Blazor Static Server Rendering Featured, using .NET 8 SDK with InteractiveServer None, Search, Pagination and styling with Bootstrap.!",
                Images = new List<ProImage>
                {
                    new ProImage
                    {
                        Src = "images/projects/Blog-using-latest-Blazor-Static-Server-Rendering-Features-Project.png",
                        Alt = " main page ",
                        Width = 1920,
                        Height = 1080
                    }
                },
                Technologies = new List<Technology>
                {
                    new Technology { Name = "NET Core", Icon = "images/icons/net-core.svg" },
                    new Technology { Name = "C#", Icon = "images/icons/cpp.svg" },
                    new Technology { Name = "Blazor .NET 8", Icon = "images/icons/blazor.svg" },
                    new Technology { Name = "Github", Icon = "images/icons/github.svg" }
                },
                Website = "https://youtu.be/B2TWGlE8noU",
                Github = "https://github.com/CodeWithAbkhan/StaticBlogBlazor"
            }
        };
    }
}