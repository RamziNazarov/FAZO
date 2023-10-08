using FAZO.Entities;
using Microsoft.EntityFrameworkCore;

namespace FAZO;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Banner> Banners { get; set; }
    public DbSet<ServiceCategory> ServiceCategories { get; set; }
    public DbSet<Entertainment> Entertainments { get; set; }
    public DbSet<Service> Services { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var banners = new List<Banner>
        {
            new()
            {
                Id = 1,
                CoverUrl = "img/planet-earth-background_23-2150564686.jpg",
                Title = "Join Us In The Ultimate Adventure Of Space Exploration",
                Category = "SPACE TOURS & TRAVEL"
            },
            new()
            {
                Id = 2,
                CoverUrl = "img/spaceship-orbits-dark-galaxy-glowing-blue-comet-generated-by-ai.jpg",
                Title = "Join Us In The Ultimate Adventure Of Space Exploration",
                Category = "SPACE TOURS & TRAVEL"
            }
        };
        
        modelBuilder.Entity<Banner>().HasData(banners);
        
        var destinations = new List<Destination>
        {
            new()
            {
                Id = 1,
                Name = "Mars",
                CoverUrl = "img/destination-1.jpg",
                Temperature =
                    "Average surface temperature: - 80 ℃ ( -112 ℉ )\n During winter in the polar regions: - 195 ℃ (- 319 ℉ ) \n During summer in some regions: 20 ℃ ( - 4 ℉ )",
                MoonsCount = "Mars has two natural moons, named Phobos and Deimos.",
                DayLength =
                    "A day on Mars (a Martian day) is approximately 24 hours and 37 minutes. A year on Mars lasts about 687 Earth days.",
                AtmospherePressure =
                    "The average atmospheric pressure on Mars is approximately 0.6% of Earth's atmospheric pressure. This is significantly lower than Earth's pressure and makes the Martian atmosphere unsuitable for human breathing without special equipment.",
                SurfaceType =
                    "Mars' surface is diverse, featuring valleys, mountains, craters, dry riverbeds, sand dunes, and polar ice caps. Mars is also known for its reddish color, caused by the presence of iron oxide (rust) in its soil and rocks."
            }
        };
        
        modelBuilder.Entity<Destination>().HasData(destinations);
        
        var serviceCategories = new List<ServiceCategory>
        {
            new()
            {
                Id = 1,
                Name = "Education",
                Description = "Some description",
                Icon = "fa-route"
            },
            new()
            {
                Id = 2,
                Name = "Vocation",
                Description = "Some description",
                Icon = "fa-ticket-alt"
            },
            new()
            {
                Id = 3,
                Name = "Sport",
                Description = "Some description",
                Icon = "fa-hotel"
            }
        };
        
        modelBuilder.Entity<ServiceCategory>().HasData(serviceCategories);

        var services = new List<Service>
        {
            new()
            {
                Id = 1,
                ServiceCategoryId = 1,
                Name = "Mars Exploration",
                CoverUrl = "img/destination-1.jpg",
                Description = "Some description"
            }
        };
        
        modelBuilder.Entity<Service>().HasData(services);
        
        var entertainment = new List<Entertainment>
        {
            new()
            {
                Id = 1,
                DestinationId = 1,
                CoverUrl = "img/destination-1.jpg",
                Name = "Mount Sharp (Aeolis Mons):",
                ServiceId = 1,
                Description = "This massive mountain rises over 5 kilometers (3 miles) from the floor of Gale Crater. Exploring its slopes would provide a remarkable opportunity to study Mars' geological history layer by layer.",
            }
        };
        
        modelBuilder.Entity<Entertainment>().HasData(entertainment);
        
        
    }
}