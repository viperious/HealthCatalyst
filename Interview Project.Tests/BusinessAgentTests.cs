using System;
using System.Collections.Generic;
using System.Linq;
using Interview_Project.Agents;
using Interview_Project.Data.Agents;
using Interview_Project.Data.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Interview_Project.Tests
{
    [TestClass]
    public class BusinessAgentTests
    {
        [TestMethod]
        public void GetPeopleTest()
        {
            var mock = new Mock<IPeopleDataAgent>();
            mock.Setup(frk => frk.GetPeople("Brian"))
                .Returns(new List<PersonDto>
                {
                    new PersonDto
                    {
                        FirstName = "Brian",
                        LastName = "Cauley",
                        DateOfBirth = DateTime.Parse("09/07/1977"),
                        ImageUrl =
                            "https://media.licdn.com/mpr/mpr/shrinknp_200_200/AAEAAQAAAAAAAAOgAAAAJDYwMGJhMmU4LTU0NGUtNDhhYy1hMWQ2LTJlZmYwZjNkMWMxMw.jpg",
                        Addresses = new List<AddressDto>
                        {
                            new AddressDto
                            {
                                AddressType = "Billing",
                                Line1 = "PO BOX 3345",
                                City = "Herriman",
                                State = "UT",
                                PostalCode = "84096"
                            },
                            new AddressDto
                            {
                                AddressType = "Shipping",
                                Line1 = "4488 Meadow Bend Drive",
                                City = "Herriman",
                                State = "UT",
                                PostalCode = "84096"
                            }
                        },
                        Interests = new List<InterestDto>
                        {
                            new InterestDto {Name = "Football"},
                            new InterestDto {Name = "Xbox One"},
                            new InterestDto {Name = "C#"}
                        }
                    }
                });

            var agent = new PeopleAgent(mock.Object);
            var people = agent.GetPeople("Brian");

            mock.Verify(m => m.GetPeople("Brian"), Times.AtMostOnce());
            Assert.IsTrue(people.Count == 1, "Expected only one person to be returned.");
            Assert.IsTrue(people.First().FullName.Equals("Brian Cauley", StringComparison.InvariantCultureIgnoreCase),
                "Expected the full name to be 'Brian Cauley'");
        }
    }
}