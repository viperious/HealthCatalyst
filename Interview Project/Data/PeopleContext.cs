using System.Data.Entity;
using Interview_Project.Data.Models;

namespace Interview_Project.Data
{
    public class PeopleContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}

