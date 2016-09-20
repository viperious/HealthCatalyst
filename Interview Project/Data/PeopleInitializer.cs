using System;
using System.Collections.Generic;
using Interview_Project.Data.Models;

namespace Interview_Project.Data
{
    public class PeopleInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PeopleContext>
    {
        protected override void Seed(PeopleContext context)
        {
            var people = new List<Person>
            {
                new Person
                {
                    FirstName = "Brian",
                    LastName = "Cauley",
                    DateOfBirth = DateTime.Parse("09/07/1977"),
                    ImageUrl = "https://media.licdn.com/mpr/mpr/shrinknp_200_200/AAEAAQAAAAAAAAOgAAAAJDYwMGJhMmU4LTU0NGUtNDhhYy1hMWQ2LTJlZmYwZjNkMWMxMw.jpg",
                    Addresses =
                    {
                        new Address
                        {
                            AddressType = AddressTypes.Billing,
                            Line1 = "PO BOX 3345",
                            City = "Herriman",
                            State = "UT",
                            PostalCode = "84096"
                        },
                        new Address
                        {
                            AddressType = AddressTypes.Shipping,
                            Line1 = "4488 Meadow Bend Drive",
                            City = "Herriman",
                            State = "UT",
                            PostalCode = "84096"
                        }
                    },
                    Interests =
                    {
                        new Interest {Name = "Football"},
                        new Interest {Name = "Xbox One"},
                        new Interest {Name = "C#"}
                    },
                },
                new Person
                {
                    FirstName = "Brian",
                    LastName = "Jones",
                    DateOfBirth = DateTime.Parse("04/07/1970"),
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/ac/No_image_available.svg",
                    Addresses =
                    {
                       new Address
                        {
                            AddressType = AddressTypes.Shipping,
                            Line1 = "123 USA Drive",
                            City = "Herriman",
                            State = "UT",
                            PostalCode = "84096"
                        }
                    },
                    Interests =
                    {
                        new Interest {Name = "Cooking"},
                        new Interest {Name = "Xbox One"},
                        new Interest {Name = "C#"}
                    },
                },
                new Person {FirstName = "Jill",
                    LastName = "Cauley",
                    DateOfBirth = DateTime.Parse("02/07/1998"),
                    ImageUrl = "http://russia-insider.com/sites/insider/files/hillary-clinton-thumbs-up.jpg",
                    Addresses =
                    {
                       new Address
                        {
                            AddressType = AddressTypes.Billing,
                            Line1 = "123 USA Drive",
                            City = "Ridewater Drive",
                            State = "UT",
                            PostalCode = "84096"
                        }
                    },
                    Interests =
                    {
                        new Interest {Name = "Fishing"},
                        new Interest {Name = "Swimming"},
                        new Interest {Name = "Dancing"}
                    },
                },
                new Person {
                    FirstName = "Will",
                    LastName = "Cauley",
                    DateOfBirth = DateTime.Parse("06/07/1948"),
                    ImageUrl = "http://media3.s-nbcnews.com/j/newscms/2015_50/1312506/151122-donald-trump-smiling-956a_6d624dc0061bbd1233cc33461649ea73.nbcnews-fp-1200-800.jpg",
                    Addresses =
                    {
                       new Address
                        {
                            AddressType = AddressTypes.Billing,
                            Line1 = "Cauley Drive",
                            City = "Ridewater Drive",
                            State = "UT",
                            PostalCode = "84096"
                        }
                    },
                    Interests =
                    {
                        new Interest {Name = "Money"},
                        
                    },
                }
            };

            people.ForEach(p => context.People.Add(p));
            context.SaveChanges();
        }
    }
}