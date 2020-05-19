using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    public class Person
    {
        private string firstName, lastName;
        private int age;
        private decimal salary;

        private const string AGE = "Age cannot be zero or a negative integer!";
        private const string FIRST_NAME = "First name cannot contain fewer than 3 symbols!";
        private const string LAST_NAME = "Last name cannot contain fewer than 3 symbols!";
        private const string SALARY = "Salary cannot be less than 460 dollar!";


        public Person(string firstName,string lastName, int age, decimal salary) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
            
            Exceptions();
           
        }

        public string GetFirstName() 
        {
            return firstName;
        }
        public string GetLastName()
        {
            return lastName;
        }
        public int GetAge() 
        {
            return age;
        }

        public void Exceptions() 
        {
            if (this.age <= 0) 
            {
                throw new ArgumentException(AGE);
            }

            if (this.firstName.Length < 3)
            {
                throw new ArgumentException(FIRST_NAME);
                
            }

            if (this.lastName.Length < 3)
            {
                throw new ArgumentException(LAST_NAME);
                
            }

            if (this.salary < 460) 
            {
                throw new ArgumentException(SALARY);
               
            }

        }
        



        public void SalaryIncrease(decimal percentage) 
        {
            if (this.age < 30)
            {
                this.salary += this.salary * percentage / 100;
            }
            else {
                this.salary += this.salary * percentage / 200;
            }
       
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} gets {this.salary} dollars";
        }



    }
}
