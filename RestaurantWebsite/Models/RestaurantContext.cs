using Microsoft.EntityFrameworkCore;

namespace RestaurantWebsite.Models
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options): base(options){ }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Reservation> Reservations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) // Configure entity classes
                                                                           // Configure the database tables created from the entity classes
        {
            // Apply the configuration classes and seed initial data
            modelBuilder.ApplyConfiguration(new SeedFood());
            modelBuilder.ApplyConfiguration(new SeedReservation());

        }
    }
}
