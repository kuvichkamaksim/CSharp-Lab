using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public enum Education
    {
        Master,
        Bachelor,
        SecondEducation,
        PhD
    }

    class Student : Person
    {
        private Education education;

        public string group { get; set; }

        public int gradebookNumber { get; set; }

        public List<Examination> passedExams;

        public float averageMark
        {
            get
            {
                int sum = 0;
                int count = 0;
                foreach (Examination exam in passedExams)
                {
                    if (exam.isDifferential)
                    {
                        sum += exam.mark;
                        count++;
                    }
                }
                return sum / count;
            }
        }

        public void AddExams(Examination[] examList)
        {
            foreach (Examination exam in examList)
            {
                this.passedExams.Add(exam);
            }
        }

        public override string ToString()
        {
            return firstName + ", " + secondName + ", " + group;
        }

        public override void PrintFullInfo()
        {
            base.PrintFullInfo();
            Console.WriteLine("Education level: " + this.education);
            Console.WriteLine("Group: " + this.group);
            Console.WriteLine("Gratebook number: " + this.gradebookNumber);
            Console.WriteLine("Examinations:");
            foreach (Examination exam in this.passedExams)
            {
                Console.WriteLine("\t" + exam);
            }
            Console.WriteLine("Average mark: " + this.averageMark);
        }

        public Student() : base()
        {
            this.education = Education.Bachelor;
            this.group = "IP-71";
            this.gradebookNumber = 15;
            this.passedExams = new List<Examination>();
        }

        public Student(string firstName, string secondName, DateTime birthDate, Education education,
            string group, int gradebookNumber) : base(firstName, secondName, birthDate)
        {
            this.education = education;
            this.group = group;
            this.gradebookNumber = gradebookNumber;
            this.passedExams = new List<Examination>();
        }

        public int countNotDifferential()
        {
            int iter = 0;
            foreach (Examination exam in passedExams)
            {
                if (!exam.isDifferential) iter++;
            }
            return iter;
        }

        public void sortByFirstLetter()
        {
            this.passedExams = this.passedExams.OrderBy(x => x.subject[0]).ThenBy(x => x.subject[0]).ToList();
        }
    }
}
