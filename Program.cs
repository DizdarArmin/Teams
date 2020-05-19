using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            //var lines = int.Parse(Console.ReadLine());
            TeamManager teamManager = new TeamManager("Lexicon");
            Manipulate manipulate = new Manipulate();

            int lines = 5;

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split();
                input[0] = manipulate.ToUpper(input[0]);
                input[1] = manipulate.ToUpper(input[1]);

                teamManager.Add(input[0],
                                input[1],
                                int.Parse(input[2]),
                                decimal.Parse(input[3]));

            }

            teamManager.IncreaseSalary(50);
            teamManager.DisplayTeams();
            Console.ReadLine();

        }
        public class Manipulate {
            public string ToUpper(string value)
            {
                return char.ToUpper(value[0]) + value.Substring(1);
            }

        }


    }

    
}
