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
            Guid gr = Guid.NewGuid();

            builder.Entity<IdentityRole>().HasData(new IdentityRole {
                Id = gr.ToString(), Name = "ADMIN", NormalizedName = "ADMIN".ToUpper() });

            var hasher = new PasswordHasher<IdentityUser>();
            Guid g = Guid.NewGuid();

            builder.Entity<IdentityUser>().HasData(

                new IdentityUser
                {
                    Id = g.ToString(),
                    UserName = "Admin@test.com",
                    NormalizedUserName = "Admin@test.com",
                    Email = "Admin@test.com",
                    NormalizedEmail = "Admin@test.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin1$")

                }
            ); 

            builder.Entity<IdentityUserRole<String>>().HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = gr.ToString(),
                        UserId = g.ToString()
                    }
                );
        }

    }
    
}