using System.Collections.Generic;
using Interview_Project.Data.DTO;

namespace Interview_Project.Data.Agents
{
    public interface IPeopleDataAgent
    {
        List<PersonDto> GetPeople(string value);
        List<PersonDto> GetAllPeople();
    }
}