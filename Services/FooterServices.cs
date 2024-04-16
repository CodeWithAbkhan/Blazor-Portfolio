using WasmPortfolio.Models;
namespace WasmPortfolio.Services;


public class FooterServices
{
    public Footer GetFooter()
    {
        var footer = new Footer
        {
            Categories = new List<FooterCategory>
            {
                new FooterCategory
                {
                    Title = "Important Links",
                    Links = new List<Link>
                    {
                        new Link { Title = "Home", Href = "" },
                        new Link { Title = "My work", Href = "work" },
                        new Link { Title = "Blog", Href = "https://sqlpey.com" },
                        new Link { Title = "What I Use", Href = "techs" }
                    }
                },
                new FooterCategory
                {
                    Title = "Social",
                    Links = new List<Link>
                    {
                        new Link { Title = "Github", Href = "https://github.com/CodeWithAbkhan/", Target = "_blank" }, // Add username dynamically
                        new Link { Title = "Instagram", Href = "https://instagram.com/sqlpey", Target = "_blank" }, // Add username dynamically
                        new Link { Title = "Discord", Href = "", Target = "_blank" } // Add discord invite link dynamically
                    }
                },
                new FooterCategory
                {
                    Title = "Other",
                    Links = new List<Link>
                    {
                        new Link { Title = "What i use", Href = "uses" },
                        new Link { Title = "Contact", Href = "contact" }
                    }
                }
            }
        };

        // You can populate dynamic data for Github, Instagram, and Discord links here
        // For example:
        // footer.Categories[1].Links[0].Href = "https://github.com/" + meta.accounts.github.username;
        // footer.Categories[1].Links[1].Href = "https://instagram.com/" + meta.accounts.instagram.username;
        // footer.Categories[1].Links[2].Href = meta.accounts.discord.invite;

        return footer;
    }
}

