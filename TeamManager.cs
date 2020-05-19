using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    public class TeamManager
    {

        Team team;


        public TeamManager(string name) {
            this.team = new Team(name);
        }

        

        public void Add(string firstName, string lastName, int age, decimal salary)
        {
            team.AddPerson(new Person(firstName, lastName, age, salary));
        }

        public void IncreaseSalary(decimal increase)
        {
            Console.WriteLine();
            team.People().ForEach(p => p.SalaryIncrease(increase));
            team.People().ForEach(p => Console.WriteLine(p.ToString()));
        }

        public void DisplayTeams()
        {
            Console.WriteLine();
            Console.WriteLine("First team has " + team.FirstTeam().Count + " players");
            Console.WriteLine("Reserve team has " + team.ReserveTeam().Count + " players");
        }

        public void DisplaySalary()
        {
            team.People().ForEach(p => Console.WriteLine(p.ToString()));
        }


   




    }
}
