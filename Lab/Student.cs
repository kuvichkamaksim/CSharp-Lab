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

        public int gratebookNumber { get; set; }

        private List<Examination> passedExams;

        public float averageMark
        {
            get
            {
                int sum = 0;
                foreach (Examination exam in passedExams)
                {
                    sum += exam.mark;
                }
                return sum / passedExams.Count;
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
            Console.WriteLine("Gratebook number: " + this.gratebookNumber);
            Console.WriteLine("Examinations:");
            foreach (Examination exam in this.passedExams)
            {
                Console.WriteLine(exam);
            }
            Console.WriteLine("Average mark: " + this.averageMark);
        }
    }
}
