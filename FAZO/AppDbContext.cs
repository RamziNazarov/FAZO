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
        modelBuilder.Entity<EntertainmentService>().HasKey(x=> new {x.EntertainmentId, x.ServiceId});
        
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
                CoverUrl = "img/destination/mafss.jpg",
                Temperature =
                    "Average surface temperature: - 80 ℃ ( -112 ℉ )\n During winter in the polar regions: - 195 ℃ (- 319 ℉ ) \n During summer in some regions: 20 ℃ ( - 4 ℉ )",
                MoonsCount = "Mars has two natural moons, named Phobos and Deimos.",
                DayLength =
                    "A day on Mars (a Martian day) is approximately 24 hours and 37 minutes. A year on Mars lasts about 687 Earth days.",
                AtmospherePressure =
                    "The average atmospheric pressure on Mars is approximately 0.6% of Earth's atmospheric pressure. This is significantly lower than Earth's pressure and makes the Martian atmosphere unsuitable for human breathing without special equipment.",
                SurfaceType =
                    "Mars' surface is diverse, featuring valleys, mountains, craters, dry riverbeds, sand dunes, and polar ice caps. Mars is also known for its reddish color, caused by the presence of iron oxide (rust) in its soil and rocks."
            },
            new()
            {
                Id = 2,
                Name = "Moon",
                CoverUrl = "img/destination/moon.jpg",
                DayLength = "Day: Approximately 27.3 Earth days (rotation period)\nYear: 354 (The moon orbits Earth)",
                Temperature = "Average Surface Temperature: The average surface temperature on the Moon varies widely. In the daytime, it can reach up to about 127 degrees Celsius (260 degrees Fahrenheit). During the lunar night, temperatures can drop drastically, reaching as low as -173 degrees Celsius (-280 degrees Fahrenheit).",
                AtmospherePressure = "The Moon has an extremely thin and nearly negligible atmosphere, often referred to as an exosphere. The atmospheric pressure on the Moon is close to a vacuum, making it inhospitable to support human life.",
                SurfaceType = "The Moon's surface is primarily composed of rocky terrain, mountains, valleys, impact craters, and vast plains known as maria, which were formed by ancient volcanic activity. It lacks a significant atmosphere, water, or vegetation and is covered in fine lunar dust called regolith.",
                MoonsCount = "The Moon is Earth's only natural satellite."
            },
            new()
            {
                Id = 3,
                Name = "Venus",
                CoverUrl = "img/destination/venuss.jpg",
                DayLength = "A day on Venus (a Venusian day) is quite unique and longer than its year. It lasts approximately 116 Earth days.\n A year on Venus is shorter than its day, lasting about 225 Earth days.",
                Temperature = "Venus has a scorching hot surface due to its thick and dense atmosphere. Surface temperatures can reach up to approximately 467 degrees Celsius (872 degrees Fahrenheit), making it the hottest planet in our solar system.",
                AtmospherePressure = "Venus has an incredibly dense atmosphere with an atmospheric pressure that is about 92 times greater than Earth's at sea level. It consists mainly of carbon dioxide and thick clouds of sulfuric acid.",
                SurfaceType = "Venus has a surface that is rocky and covered in numerous volcanoes, impact craters, and vast plains. The planet's surface is obscured from view by visible light due to its thick cloud cover, making it difficult to observe from space.",
                MoonsCount = "Venus has no natural moons."
            },
            new()
            {
                Id = 4,
                Name = "Jupiter",
                CoverUrl = "img/destination/jupiter.jpg",
                DayLength = "A day on Jupiter is relatively short, lasting about 9 hours and 55 minutes.\nA year on Jupiter is much longer, taking approximately 11.9 Earth years to complete one orbit around the Sun.",
                Temperature = " Jupiter does not have a solid surface like Earth, so it does not have a distinct surface temperature. Instead, its temperature increases with depth as you move closer to its core. The outer atmosphere of Jupiter is extremely cold, with temperatures around -145 degrees Celsius (-234 degrees Fahrenheit).",
                AtmospherePressure = " Jupiter's atmosphere is incredibly thick and has a high atmospheric pressure, which increases with depth into the planet. The pressure at Jupiter's core is estimated to be millions of times greater than Earth's atmospheric pressure.",
                SurfaceType = " Jupiter is a gas giant, meaning it lacks a solid surface like terrestrial planets. Its outer layer consists mainly of hydrogen and helium, with traces of other compounds. It has a dynamic and turbulent atmosphere with distinctive cloud bands and the Great Red Spot, a massive storm system that has persisted for centuries.",
                MoonsCount = "Jupiter has an extensive system of moons, with over 80 known natural satellites as of my last update in September 2021. Some of the largest and most well-known moons include Io, Europa, Ganymede, and Callisto."
            },
            new()
            {
                Id = 5,
                Name = "Uranus",
                CoverUrl = "img/destination/uranus.jpg",
                DayLength = "Day: Approximately 17.24 hours\nYear: Approximately 84 Earth years",
                MoonsCount = "Uranus has 27 known moons as of my last knowledge update in September 2021.",
                Temperature = "Surface Temperature: Approximately -224 degrees Celsius (-371 degrees Fahrenheit)",
                AtmospherePressure = "Uranus has a relatively low atmospheric pressure compared to Earth.",
                SurfaceType = "Uranus is a gas giant and does not have a solid surface. It consists primarily of hydrogen and helium with traces of other compounds and does not have a distinct solid surface like terrestrial planets.",
            },
            new()
            {
                Id = 6,
                Name = "Saturn",
                CoverUrl = "img/destination/saturn.jpg",
                DayLength = "Day: Approximately 10 hours and 33 minutes\nYear: Approximately 29.5 Earth years",
                MoonsCount = "Uranus has 27 known moons as of my last knowledge update in September 2021.",
                Temperature = "Saturn has a vast system of moons, with over 80 known natural satellites as of my last knowledge update in September 2021. Some of the most well-known moons include Titan, Enceladus, and Mimas.",
                AtmospherePressure = "Average Surface Temperature: N/A (Saturn is a gas giant with no solid surface)\nColdest Time in the Polar Regions: N/A (Saturn doesn't have seasons as Earth does)\nWarmest Time in Some Regions: N/A (Saturn doesn't have seasons as Earth does)\nAtmospheric Pressure: Saturn has a thick atmosphere primarily composed of hydrogen and helium, but it lacks a solid surface. The atmospheric pressure increases with depth into the planet.",
                SurfaceType = " Saturn is a gas giant and, like Jupiter, lacks a solid surface. Its outer layers consist mainly of hydrogen and helium, with traces of other compounds. Saturn is known for its stunning ring system, which is composed of icy particles and rocky debris. The planet's interior is thought to be a dense core surrounded by metallic hydrogen and a gaseous envelope.",
            }
        };
        
        modelBuilder.Entity<Destination>().HasData(destinations);
        
        var serviceCategories = new List<ServiceCategory>
        {
            new()
            {
                Id = 1,
                Name = "Education",
                Description = "Embark on an educational journey through the cosmos, where you’ll learn about the mysteries of the universe from experienced astronauts and space scientists.",
                Icon = "fa-route",
                CoverUrl = "img/service/Мафтуна образование 2.jpg"
            },
            new()
            {
                Id = 2,
                Name = "Vocation",
                Description = "Experience a vacation like no other, as you float in zero gravity, gaze at the Earth from space, and explore the beauty of the cosmos.",
                Icon = "fa-ticket-alt",
                CoverUrl = "img/service/Отдых мафтуна 1.jpg"
            },
            new()
            {
                Id = 3,
                Name = "Sport",
                Description = "Push your physical limits in a zero-gravity environment with our unique space sports program, offering activities like space soccer, zero-G gymnastics, and asteroid rock climbing.",
                Icon = "fa-hotel",
                CoverUrl = "img/service/Спорт Мафтуна 2.jpg"
            }
        };
        
        modelBuilder.Entity<ServiceCategory>().HasData(serviceCategories);

        var services = new List<Service>
        {
            new()
            {
                Id = 1,
                ServiceCategoryId = 2,
                Name = "*Space Photography Workshops*",
                CoverUrl = "img/service/Space Photography Workshops.jpg",
                Description = "Some description",
                Duration = "(Duration: 1 day):"
            },
            new()
            {
                Id = 2,
                ServiceCategoryId = 2,
                Name = "*Spacewalks*",
                CoverUrl = "img/service/Spacewalks.jpg",
                Description = "Tourists would have the opportunity to leave the spacecraft in a spacesuit and experience the sensation of floating in space.",
                Duration = "(Duration: 1-2 hours):"
            },
            new()
            {
                Id = 3,
                ServiceCategoryId = 2,
                Name = "*Interplanetary Safari*",
                CoverUrl = "img/service/Interplanetary Safari.jpg",
                Description = "This trip would involve visiting different planets or moons and observing their unique environments and wildlife (if any).",
                Duration = "(Duration: 1 week):"
            },
            new()
            {
                Id = 4,
                ServiceCategoryId = 2,
                Name = "*Spacecraft Piloting Lessons*",
                CoverUrl = "img/service/Spacecraft Piloting Lessons.jpg",
                Description = "These lessons would teach tourists the basics of piloting a spacecraft.",
                Duration = "(Duration: 1-2 days):"
            },
            new()
            {
                Id = 5,
                ServiceCategoryId = 2,
                Name = "*Zero Gravity Dance Parties*",
                CoverUrl = "img/service/Zero Gravity Dance Parties.jpg",
                Description = "These parties would offer a unique social experience in a zero-gravity environment, with music and dancing.",
                Duration = "(Duration: A few hours):"
            },
            new()
            {
                Id = 6,
                ServiceCategoryId = 2,
                Name = "*Sunrise Breakfasts*",
                CoverUrl = "img/service/Sunrise Breakfasts.jpg",
                Description = " Tourists could start their day by watching the sunrise over Earth while enjoying a specially prepared breakfast.",
                Duration = " (Duration: A few hours):"
            },
            new()
            {
                Id = 7,
                ServiceCategoryId = 2,
                Name = "*Space-Themed Movie Nights*",
                CoverUrl = "img/service/Space-Themed Movie Nights.jpg",
                Description = "  Tourists could watch popular space-themed movies while actually being in space!",
                Duration = "(Duration: A few hours):"
            },
            new()
            {
                Id = 8,
                ServiceCategoryId = 2,
                Name = "*Stargazing Sessions*",
                CoverUrl = "img/service/Stargazing Sessions.jpg",
                Description = "Guided sessions would help tourists spot constellations, distant galaxies, and maybe even a shooting star!",
                Duration = " (Duration: A few hours):"
            },
            new()
            {
                Id = 9,
                ServiceCategoryId = 2,
                Name = "*Visiting Lunar Bases and Stations*",
                CoverUrl = "img/service/Visiting Lunar Bases and Stations.jpg",
                Description = " Tourists would have the opportunity to visit active lunar bases and stations, learn about their operations, and interact with the astronauts and scientists working there.",
                Duration = "(Duration: 1 week): "
            },
            new()
            {
                Id = 10,
                ServiceCategoryId = 2,
                Name = "*Spacesuits for Planet Surface Walks*",
                CoverUrl = "img/service/Spacesuits for Planet Surface Walks.jpg",
                Description = "  This activity would provide tourists with the unique opportunity to walk on the surface of a planet or moon, using specially designed spacesuits.",
                Duration = "(Duration: 1 day):"
            },
            new()
            {
                Id = 11,
                ServiceCategoryId = 2,
                Name = "*Stellar Glossy Parties in Space*",
                CoverUrl = "img/service/Stellar Glossy Parties in Space.jpg",
                Description = "  These parties would offer a unique social experience in a zero-gravity environment, with breathtaking views of the stars and planets.",
                Duration = "(Duration: A few hours):"
            },
            new()
            {
                Id = 12,
                ServiceCategoryId = 2,
                Name = "*Special Surveys of Astronomical Phenomena*",
                CoverUrl = "img/service/Special Surveys of Astronomical Phenomena.jpg",
                Description = "  These trips would be timed to coincide with significant astronomical events, such as eclipses, meteor show",
                Duration = "(Duration: Depends on the event):"
            },
            new()
            {
                Id = 13,
                ServiceCategoryId = 3,
                Name = "*Space Rallies:*",
                CoverUrl = "img/service/Special Surveys of Astronomical Phenomena.jpg",
                Description = "   Speed races between planets and satellites, where participants compete in spaceships or shuttles.",
                Duration = null,
            },
            new()
            {
                Id = 14,
                ServiceCategoryId = 3,
                Name = "*Lunar Races:*",
                CoverUrl = "img/service/Special Surveys of Astronomical Phenomena.jpg",
                Description = "    Races on the surface of the Moon using lunar vehicles such as lunar rovers or special lunar racing cars.",
                Duration = null,
            },
            new()
            {
                Id = 15,
                ServiceCategoryId = 3,
                Name = "*Martian Rallies:*",
                CoverUrl = "img/service/Special Surveys of Astronomical Phenomena.jpg",
                Description = "    Competitions on the surface of Mars using rovers or autonomous space vehicles.",
                Duration = null,
            },
            new()
            {
                Id = 16,
                ServiceCategoryId = 3,
                Name = "*Asteroid Racing:*",
                CoverUrl = "img/service/Special Surveys of Astronomical Phenomena.jpg",
                Description = "    Competition on the surface of asteroids, where participants can use mobile space platforms.",
                Duration = null,
            },
            new()
            {
                Id = 17,
                ServiceCategoryId = 3,
                Name = "*Ring Moon Races:*",
                CoverUrl = "img/service/Special Surveys of Astronomical Phenomena.jpg",
                Description = "    Races around the moons of planets such as Io around Jupiter using spacecraft.",
                Duration = null,
            },
            new()
            {
                Id = 18,
                ServiceCategoryId = 3,
                Name = "*Interplanetary Shuttle Race:*",
                CoverUrl = "img/service/Special Surveys of Astronomical Phenomena.jpg",
                Description = "    Competition between interplanetary shuttles, where participants must complete a route through several planets.",
                Duration = null,
            },
            new()
            {
                Id = 19,
                ServiceCategoryId = 3,
                Name = "*Racing on space quads:*",
                CoverUrl = "img/service/Special Surveys of Astronomical Phenomena.jpg",
                Description = "    Exploring planetary surfaces on special space quads and racing on them.",
                Duration = null,
            },
            new()
            {
                Id = 20,
                ServiceCategoryId = 3,
                Name = "*Asteroid Belt Race:*",
                CoverUrl = "img/service/Special Surveys of Astronomical Phenomena.jpg",
                Description = "     Competition among asteroids in the asteroid belt between Mars and Jupiter.",
                Duration = null,
            },
            new()
            {
                Id = 21,
                ServiceCategoryId = 3,
                Name = "*Titan Lakes Racing:*",
                CoverUrl = "img/service/Special Surveys of Astronomical Phenomena.jpg",
                Description = "     Exploring the cryogenic lakes on Titan using floats and racing devices.",
                Duration = null,
            },
            new()
            {
                Id = 22,
                ServiceCategoryId = 1,
                Name = " Research Expeditions ",
                CoverUrl = "img/service/Special Surveys of Astronomical Phenomena.jpg",
                Description = "These trips are designed for those interested in conducting scientific research in space. They could include experiments in zero gravity or studies of celestial bodies.",
                Duration = "(Duration: 1-2 weeks)",
            }
        };
        
        modelBuilder.Entity<Service>().HasData(services);
        
        var entertainments = new List<Entertainment>
        {
            new()
            {
                Id = 1,
                DestinationId = 2,
                CoverUrl = "img/entertainment/photo_2023-10-08_16-03-54.jpg",
                Name = "Lunar Surface",
                Description = "Tourists could have the incredible opportunity to set foot on the Moon's surface, walking in the footsteps of Apollo astronauts. They could witness the barren lunar landscape up close, observe the unique rock formations, and experience the Moon's reduced gravity firsthand.",
            },
            new()
            {
                Id = 2,
                DestinationId = 2,
                CoverUrl = "img/entertainment/photo_2023-10-08_14-59-18.jpg",
                Name = "Artemis Base Camp",
                Description = "As part of NASA's Artemis program, a future lunar base could be established. Tourists could visit this base camp and witness the cutting-edge technology and infrastructure being developed for sustainable human presence on the Moon. They could interact with scientists, engineers, and astronauts working on various research projects and witness the inner workings of a lunar base.",
            },
            new()
            {
                Id = 3,
                DestinationId = 2,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-00-07.jpg",
                Name = "Lunar Poles",
                Description = "The Moon's poles hold the potential for valuable resources and interesting scientific discoveries. Tourists could visit these regions and explore the permanently shadowed craters, where water ice might exist. They could learn about NASA's efforts to utilize these resources for sustainability and witness how scientists extract and utilize these precious substances.",
            },
            new()
            {
                Id = 4,
                DestinationId = 2,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-00-44.jpg",
                Name = "Historic Apollo Sites",
                Description = "There are six Apollo landing sites on the Moon. Tourists could visit these historic locations and learn about the incredible achievements of the Apollo missions. They could see the remnants of the lunar modules, footprints left by astronauts, and other artifacts that symbolize humanity's first explorations on another celestial body.",
            },
            new()
            {
                Id = 5,
                DestinationId = 2,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-01-05.jpg",
                Name = "Lunar Cave Systems",
                Description = "The Moon is believed to contain extensive cave systems formed by ancient lava flows. These caves could provide shelter from radiation and extreme temperatures on the lunar surface. Tourists could explore these caves and witness the potential for future human habitats.",
            },
            new()
            {
                Id = 6,
                DestinationId = 2,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-01-31.jpg",
                Name = "Viewing Earth from the Moon",
                Description = "Tourists could witness the breathtaking sight of our blue planet from the Moon's surface. They could experience Earthrises and Earthsets, seeing our planet in a whole new perspective and marveling at its beauty and fragility.",
            },
            new()
            {
                Id = 7,
                DestinationId = 3,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-04-21.jpg",
                Name = "Maxwell Montes",
                Description = "The highest mountain range on Venus, Maxwell Montes, would offer awe-inspiring views and an opportunity for visitors to study the planet's tectonic activity. Tourists might witness vast lava flows and volcanic features, gaining insights into the geologic history of Venus.",
            },
            new()
            {
                Id = 8,
                DestinationId = 3,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-04-54.jpg",
                Name = "Aphrodite Terra",
                Description = "As one of the largest highland regions on Venus, Aphrodite Terra would present tourists with a diverse landscape to explore. They could observe valleys, impact craters, and potentially ancient riverbeds, studying the planet's geological processes in detail.",
            },
            new()
            {
                Id = 9,
                DestinationId = 3,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-05-12.jpg",
                Name = "Lava Flows",
                Description = "Venus is known for its extensive lava flows that have created vast plains across the planet's surface. Visitors might witness these immense volcanic features firsthand, discovering unique formations and studying the composition of Venusian basaltic rock.",
            },
            new()
            {
                Id = 10,
                DestinationId = 3,
                CoverUrl = "img/entertainment/photo_2023-10-08_16-18-14.jpg",
                Name = "Coronae",
                Description = "Venus boasts impressive volcanic structures known as coronae, which are circular rings with central depressions. These formations would intrigue tourists, offering the opportunity to study their origins and the forces shaping the planet's surface.",
            },
            new()
            {
                Id = 11,
                DestinationId = 3,
                CoverUrl = "img/entertainment/photo_2023-10-08_16-20-59.jpg",
                Name = "Atmosphere Exploration",
                Description = "While challenging, exploring Venus' thick atmosphere would be an incredible experience for tourists. Advanced technology could allow them to study the swirling clouds, high-speed winds, and potentially observe the rare phenomenon of lightning in the Venusian atmosphere.",
            },
            new()
            {
                Id = 12,
                DestinationId = 3,
                CoverUrl = "img/entertainment/photo_2023-10-08_16-20-59.jpg",
                Name = "Atmosphere Exploration",
                Description = "While challenging, exploring Venus' thick atmosphere would be an incredible experience for tourists. Advanced technology could allow them to study the swirling clouds, high-speed winds, and potentially observe the rare phenomenon of lightning in the Venusian atmosphere.",
            },
            new()
            {
                Id = 14,
                DestinationId = 1,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-10-51.jpg",
                Name = "Hellas Planitia",
                Description = "This huge impact basin is one of the largest and deepest on Mars. Visitors could investigate its unique geological features, such as the Dune Fields and Noctis Labyrinthus, and gain insights into the planet's geological evolution.",
            },
            new()
            {
                Id = 15,
                DestinationId = 1,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-13-09.jpg",
                Name = "Phobos and Deimos",
                Description = "These two small moons of Mars would be intriguing destinations for further exploration. Studying their surface features and composition could shed light on the origin and evolution of these enigmatic satellites.",
            },
            new()
            {
                Id = 16,
                DestinationId = 1,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-13-46.jpg",
                Name = "Valles Marineris",
                Description = "A system of canyons stretching across Mars, Valles Marineris provides a thrilling opportunity to observe geological formations and learn about the planet's history.",
            },
            new()
            {
                Id = 17,
                DestinationId = 1,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-14-09.jpg",
                Name = "Olympus Mons",
                Description = "The largest volcano in the solar system, Olympus Mons offers a majestic volcanic landscape for exploration and study.",
            },
            new()
            {
                Id = 18,
                DestinationId = 1,
                CoverUrl = "img/entertainment/photo_2023-10-08_16-37-43.jpg",
                Name = "Elysium Mons",
                Description = "As one of the largest volcanic regions on Mars, Elysium Mons would offer an extraordinary chance to study volcanism and the formation of lava flows. The nearby Elysium Planitia, a flat plain, may also provide interesting discoveries.",
            },
            new()
            {
                Id = 19,
                DestinationId = 4,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-16-13.jpg",
                Name = "Jupiter's Great Red Spot",
                Description = "Being able to observe this iconic storm up close would be awe-inspiring. Tourists could study the dynamics of the storm and witness its mesmerizing cloud patterns",
            },
            new()
            {
                Id = 20,
                DestinationId = 4,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-16-33.jpg",
                Name = "Europa",
                Description = "This moon of Jupiter is considered one of the most promising candidates for hosting extraterrestrial life. Tourists might have the opportunity to explore its icy surface and investigate the subsurface ocean, searching for signs of microbial life.",
            },
            new()
            {
                Id = 21,
                DestinationId = 4,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-16-53.jpg",
                Name = "Io",
                Description = "Known for its intense volcanic activity, Io is the most volcanically active body in the solar system. Visitors could witness breathtaking volcanic eruptions and study the unique geological features of this moon.",
            },
            new()
            {
                Id = 22,
                DestinationId = 4,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-17-26.jpg",
                Name = "Ganymede",
                Description = "As the largest moon in the solar system, Ganymede offers diverse landscapes, including cratered terrains, grooved areas, and possibly even oceans beneath its icy crust. Tourists could examine these features and gain insights into the moon's geological history",
            },
            new()
            {
                Id = 23,
                DestinationId = 4,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-17-46.jpg",
                Name = "Jupiter's Rings",
                Description = "Just like Saturn, Jupiter also has a system of rings. Tourists could witness these ethereal structures and study their composition, origin, and dynamics.",
            },
            new()
            {
                Id = 24,
                DestinationId = 4,
                CoverUrl = "img/entertainment/photo_2023-10-08_15-18-05.jpg",
                Name = "Callisto",
                Description = "This heavily cratered moon boasts a varied terrain. Tourists might visit its impact craters, investigate ancient geology, and observe the distinctive dark regions known as \"mare\".",
            },
            new()
            {
                Id = 25,
                DestinationId = 5,
                CoverUrl = "img/entertainment/image_2023-10-08_15-41-03.png",
                Name = "Miranda",
                Description = " As Uranus' innermost large moon, Miranda displays a fascinating variety of terrains. Tourists could witness its strange \"chevron\" pattern of ridges and canyons, explore its icy cliffs, and observe its impact craters.",
            },
            new()
            {
                Id = 26,
                DestinationId = 5,
                CoverUrl = "img/entertainment/image_2023-10-08_15-49-12.png",
                Name = "Ariel",
                Description = "This moon of Uranus is known for its extensive system of valleys, canyons, and scarps. Tourists might have the opportunity to study these geological features, observe its smooth plains, and investigate potential cryovolcanism.",
            },
            new()
            {
                Id = 27,
                DestinationId = 5,
                CoverUrl = "img/entertainment/image_2023-10-08_15-50-54.png",
                Name = "Titania",
                Description = "The largest moon of Uranus, Titania, presents a diverse landscape with craters, rift valleys, and possibly even mountain ranges. Tourists could explore these features, learn about their formation, and study the moon's geology.",
            },
            new()
            {
                Id = 28,
                DestinationId = 5,
                CoverUrl = "img/entertainment/image_2023-10-08_15-52-23.png",
                Name = "Oberon",
                Description = " As the second-largest moon of Uranus, Oberon provides another intriguing destination. Tourists might investigate its impact craters, analyze its ancient surface, and search for evidence of past geological activity.",
            },
            new()
            {
                Id = 29,
                DestinationId = 5,
                CoverUrl = "img/entertainment/image_2023-10-08_16-06-59.png",
                Name = "Uranus' Ring System",
                Description = "Similar to Saturn, Uranus has its own ring system, albeit less prominent. Visitors might have the opportunity to examine these rings, study their composition, and learn about their origin and dynamics.",
            },
            new()
            {
                Id = 30,
                DestinationId = 6,
                CoverUrl = "img/entertainment/Atmosphere Exploration.jpg",
                Name = "Mimas",
                Description = "This moon is distinctive for its prominent Herschel Crater, which gives it a resemblance to the \"Death Star\" from Star Wars. Tourists might explore this intriguing feature and learn about the moon's geological processes.",
            }
        };
        
        modelBuilder.Entity<Entertainment>().HasData(entertainments);

        var entertainmentServices = new List<EntertainmentService>();
        

        foreach (var entertainment in entertainments)
        {
            entertainmentServices.Add(new ()
            {
                ServiceId = 1,
                EntertainmentId = entertainment.Id
            });
            entertainmentServices.Add(new ()
            {
                ServiceId = 5,
                EntertainmentId = entertainment.Id
            });
            entertainmentServices.Add(new ()
            {
                ServiceId = 3,
                EntertainmentId = entertainment.Id
            });
            entertainmentServices.Add(new ()
            {
                ServiceId = 6,
                EntertainmentId = entertainment.Id
            });
            entertainmentServices.Add(new ()
            {
                ServiceId = 8,
                EntertainmentId = entertainment.Id
            });
            entertainmentServices.Add(new ()
            {
                ServiceId = 11,
                EntertainmentId = entertainment.Id
            });
            entertainmentServices.Add(new ()
            {
                ServiceId = 18,
                EntertainmentId = entertainment.Id
            });
        }
        
        modelBuilder.Entity<EntertainmentService>().HasData(entertainmentServices);
    }
}