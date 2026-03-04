using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NOA_Library.Models;

namespace NOA_Library.Data
{
    public class ApplicationDbContext : IdentityDbContext<Users>

    {
        public ApplicationDbContext (DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            builder.Entity<IdentityRole>().HasData(admin);
        }
    }
}
