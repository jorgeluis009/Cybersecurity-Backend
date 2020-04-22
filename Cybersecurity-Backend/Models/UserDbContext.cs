using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Cybersecurity_Backend.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() { userId = 1, username = "a", password = "a", name = "a", lastname = "a", email = "a@a.com" },
                new User() { userId = 2, username = "b", password = "b", name = "b", lastname = "b", email = "b@b.com" },
                new User() { userId = 3, username = "c", password = "c", name = "c", lastname = "c", email = "c@c.com" });
        }


    }
}
