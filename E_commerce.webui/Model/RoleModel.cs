using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using E_commerce.webui.Identity;
using Microsoft.AspNetCore.Identity;

namespace E_commerce.webui.Model
{
    public class RoleModel
    {
        [Required]
        public string Name { get; set; }
    }
    public class RoleDetails
    {
         public IdentityRole Role {get;set;}
         public IEnumerable<User> Members {get;set;}
         public IEnumerable<User> NonMembers {get;set;}
    }
    public class RoleEditModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }

}