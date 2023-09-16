using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Starpholio_Definitive.Models;

namespace Starpholio_Definitive.Data
{
    public class ApplicationDbContext : IdentityDbContext/*<IdentityExtendModel>*/
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}