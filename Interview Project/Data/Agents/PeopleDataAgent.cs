using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Interview_Project.Data.DTO;
using Interview_Project.Data.Models;

namespace Interview_Project.Data.Agents
{
    public class PeopleDataAgent: IPeopleDataAgent
    {
        /// <summary>
        /// List of all poeple that contail a particular string
        /// </summary>
        /// <param name="value">A string value that is case insensitive</param>
        /// <returns>A list of persons</returns>
        public List<PersonDto> GetPeople(string value)
        {
            value = value.ToLower();

            using (var context = new PeopleContext())
            {
                return Mapper.Map<List<PersonDto>>(context.People.Where(x => x.FirstName.ToLower().Contains(value) || x.LastName.ToLower().Contains(value)).ToList());
            }            
        }

        public List<PersonDto> GetAllPeople()
        {
            using (var context = new PeopleContext())
            {
                return Mapper.Map<List<PersonDto>>(context.People.ToList());
            }
        }
    }
}
