using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Person
    {
        public string firstName { get; set; }

        public string secondName { get; set; }

        private DateTime birthDate;

        public int birthYear
        {
            get => birthDate.Year;

            set
            {
                int year = value;
                int month = this.birthDate.Month;
                int day = this.birthDate.Day;

                this.birthDate = new DateTime(year, month, day);
            }
        }

        public Person()
        {
            firstName = "John";
            secondName = "Smith";
            birthDate = new DateTime();
        }

        public Person(string firstName, string secondName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.birthDate = birthDate;
        }

        public virtual void PrintFullInfo()
        {
            Console.WriteLine("First name: " + this.firstName);
            Console.WriteLine("Second name: " + this.secondName);
            Console.WriteLine("Day of birth: " + this.birthDate.ToShortDateString());
        }
    }
}
