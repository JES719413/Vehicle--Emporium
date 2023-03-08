using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
    }
}