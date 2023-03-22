using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Vehicle__Emporium.Models;

namespace Vehicle__Emporium.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<BoatEngine> BoatEngines { get; set; }
        public DbSet<Boats> Boats { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Motorcycles> Motorcycles { get; set; }
        public DbSet<MotorHomes> MotorHomes { get; set; }
        public DbSet<TravelTrailer> TravelTrailer { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole {
                Id = "7c4a78c7-e1e5-4bb5-8e8c-7100132f1297", Name = "ADMIN", NormalizedName = "ADMIN".ToUpper() });

            var hasher = new PasswordHasher<IdentityUser>();

            builder.Entity<IdentityUser>().HasData(

                new IdentityUser
                {
                    Id = "7c4a78c7-e1e5-4bb5-8e8c-7100132f1214",
                    UserName = "Admin",
                    NormalizedUserName = "Admin",
                    Email = "Admin@test.com",
                    NormalizedEmail = "Admin@test.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "AdminPassword1!")

                }
            ); 

            builder.Entity<IdentityUserRole<String>>().HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "7c4a78c7-e1e5-4bb5-8e8c-7100132f1297",
                        UserId = "7c4a78c7-e1e5-4bb5-8e8c-7100132f1214"
                    }
                );
        }

    }
    
}