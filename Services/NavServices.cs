using WasmPortfolio.Models; 
namespace WasmPortfolio.Services;
public class NavServices
    {
        public NavigationModel GetNavigation()
        {
            var navigation = new NavigationModel
            {
                LeftItems = new List<NavItem>
                {
                    new NavItem { Href = "", Title = "Home" },
                    new NavItem { Href = "about", Title = "About" },
                    new NavItem { Href = "work", Title = "My Work" },
                    new NavItem { Href = "https://sqlpey.com", Title = "Blog" },
                    new NavItem { Href = "techs", Title = "What I use" }
                    // Add more left navigation items as needed
                },
                RightItems = new List<NavItem>
                {
                    new NavItem { Href = "/login", Title = "Login" },
                    new NavItem { Href = "/register", Title = "Register" }
                    // Add more right navigation items as needed
                }
            };

            return navigation;
        }
    }

