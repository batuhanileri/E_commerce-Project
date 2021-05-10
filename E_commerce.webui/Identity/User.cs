using Microsoft.AspNetCore.Identity;

namespace E_commerce.webui.Identity
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}