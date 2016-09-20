using System;
using System.Collections.Generic;

namespace Interview_Project.Data.DTO
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string ImageUrl { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public int Age => DateTime.Now.Subtract(DateOfBirth).Days/365; // I know this isn't the most accurate way to do it but works for this test project.
        public virtual List<InterestDto> Interests { get; set; }
        public virtual ICollection<AddressDto> Addresses { get; set; }
    }  
}
