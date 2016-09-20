using System;
using System.Collections.Generic;

namespace Interview_Project.Data.Models
{
    public class Person
    {
        public Person()
        {
            Interests = new List<Interest>();
            Addresses = new List<Address>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }

        public virtual DateTime DateOfBirth { get; set; }
        public virtual ICollection<Interest> Interests { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}