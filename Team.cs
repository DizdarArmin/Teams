using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    public class Team
    {
        string name;
        List<Person> people = new List<Person>();

        List<Person> firstTeam = new List<Person>();
        List<Person> reserveTeam = new List<Person>();
        public Team(string name)
        {
            this.name = name;
        }



        public void AddPerson(Person person) 
        {
            people.Add(person);
            if (person.GetAge() < 40)
                {
                    firstTeam.Add(person);
                }
           else
                {
                    reserveTeam.Add(person);
                }
        }

        public List<Person> FirstTeam() 
        {
            return firstTeam;
        }
        public List<Person> ReserveTeam() 
        {
            return reserveTeam;
        }
        public List<Person> People()
        {
            return people;
        }
       

    }
}
