using Microsoft.AspNetCore.Identity;
 
 
namespace AluSetInstance.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? AccountType { get; set; } = default;
        public string? LastName { get; set; } = default!;
        public string? Name { get; set; } = default!;
        public string? Document { get; set; } = default!;
    }
}