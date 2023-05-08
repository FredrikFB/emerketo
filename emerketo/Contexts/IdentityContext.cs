using emerketo.Models.Entities;
using emerketo.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace emerketo.Contexts;

public class IdentityContext : IdentityDbContext<AppUser>
{
    public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
    {
    }

    public DbSet<AddressEntity> AspNetAdresses { get; set; }

    public DbSet<UserAddressEntity> AspNetUserAdresses { get; set; }
}
