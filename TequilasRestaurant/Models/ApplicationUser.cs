using Microsoft.AspNetCore.Identity;

namespace TequilasRestaurant.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
    }
}
