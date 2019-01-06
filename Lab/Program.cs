using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple tests
            DateTime dateOfBirth = new DateTime(1999, 10, 23);
            Student example = new Student("Maksim", "Kuvichka", dateOfBirth, Education.Bachelor, "IP-71", 15);
            Console.WriteLine(example.ToString());

            Examination[] newExams =
            {
                new Examination(3, "Phylosophy", "Kytsyk K.M.", 100, true, new DateTime(2018, 12, 10)),
                new Examination(3, "OOP", "Mukha I.P.", 100, false, new DateTime(2018, 12, 15)),
                new Examination(2, "Physics", "Linchevskiy I.V.", 100, false, new DateTime(2018, 6, 20))
            };
            example.AddExams(newExams);
            Console.WriteLine("\nFull Info:");
            example.PrintFullInfo();

            // personal task 1
            Console.WriteLine("\n");
            Person person1 = new Person("John", "Weak", new DateTime(2018, 5, 13));
            Person person2 = new Person("John", "Weak", new DateTime(2018, 5, 13));
            Person person3 = new Person("Jim", "Lock", new DateTime(2018, 5, 13));
            Console.WriteLine(person1.Equals(person2)); //true
            Console.WriteLine(person1.Equals(person3)); //false

            // personal task 2
            Console.WriteLine("\n");
            Examination exam1 = new Examination(); //mark=100
            Console.WriteLine(exam1.NationalScaleName()); //100
            Console.WriteLine(exam1.EctsScaleName()); //A

            // personal task 3
            Console.WriteLine(example.countNotDifferential()); //2

            // personal task 4
            Console.WriteLine("\n");
            foreach (Examination passedExam in example.passedExams)
            {
                Console.WriteLine(passedExam.ToString());
            }

            example.sortByFirstLetter();

            Console.WriteLine("\n");
            foreach (Examination passedExam in example.passedExams)
            {
                Console.WriteLine(passedExam.ToString());
            }
            

            Console.ReadLine();
        }
    }
}
