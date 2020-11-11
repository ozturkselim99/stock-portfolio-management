using Microsoft.AspNetCore.Identity;

namespace stock_portfolio_management.Identity
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
