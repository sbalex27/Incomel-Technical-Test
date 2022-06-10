using Microsoft.AspNetCore.Identity;

namespace Incomel_Technical_Test.Models
{
    public class User : IdentityUser
    {
        public IEnumerable<Employee> Employees { get; set; }
    }
}
