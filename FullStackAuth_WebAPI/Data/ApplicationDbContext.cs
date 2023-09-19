using FullStackAuth_WebAPI.Models;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FullStackAuth_WebAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Review> Reviews { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Favorite> Favorites { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
            

    }
    
}
