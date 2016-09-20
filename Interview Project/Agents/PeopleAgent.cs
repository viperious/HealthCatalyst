using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Interview_Project.Data.Agents;
using Interview_Project.Data.DTO;

namespace Interview_Project.Agents
{
    public class PeopleAgent
    {
        private readonly IPeopleDataAgent _peopleDataAgent;

        public PeopleAgent(IPeopleDataAgent peopleDataAgent)
        {
            _peopleDataAgent = peopleDataAgent;
        }

        public PeopleAgent()
        {
            _peopleDataAgent = new PeopleDataAgent();
        }

        public List<PersonDto> GetPeople(string value)
        {
            return _peopleDataAgent.GetPeople(value);
        }

        public List<PersonDto> GetAllPeople()
        {
            return _peopleDataAgent.GetAllPeople();
        }
    }
}