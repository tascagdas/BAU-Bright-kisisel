using Microsoft.AspNetCore.Identity;

namespace MiniShop.Entity.Concrete.Identity
{
    public class Role : IdentityRole
    {
        public string Description { get; set; }
    }
}
