using System;
using Microsoft.EntityFrameworkCore;

namespace NationalParks.Models
{
    public class NationalParksContext : DbContext
    {
        public NationalParksContext(DbContextOptions<NationalParksContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
{
			builder.Entity<Park>()
				.HasData(
					new Park { ParkId = 1, Name = "Yosemite National Park", State = "California", StateOrNational = "National" },
					new Park { ParkId = 2, Name = "Glacier National Park", State = "Montana", StateOrNational = "National" },
					new Park { ParkId = 3, Name = "Zion National Park", State = "Utah", StateOrNational = "National" },
					new Park { ParkId = 4, Name = "Olympic National Park", State = "Washington", StateOrNational = "National" },
					new Park { ParkId = 5, Name = "Ecola State Park", State = "Oregon", StateOrNational = "State" },
					new Park { ParkId = 6, Name = "Niagara Falls State Park", State = "New York", StateOrNational = "State" },
					new Park { ParkId = 7, Name = "Smith Rock State Park", State = "Oregon", StateOrNational = "State" },
					new Park { ParkId = 8, Name = "Shasta State Historic Park", State = "California", StateOrNational = "State" }
		);
}
    }
}