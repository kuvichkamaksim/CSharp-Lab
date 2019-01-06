using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public interface IMarkName
    {
        string NationalScaleName();
        string EctsScaleName();
    }

    class Examination : IMarkName
    {
        public int semesterNumber { get; set; }

        public string subject { get; set; }

        public string examinerFullName { get; set; }

        public byte mark {get; set; }

        public bool isDifferential { get; set; }

        public DateTime examDate { get; set; }

        public Examination()
        {
            this.semesterNumber = 3;
            this.mark = 100;
            this.subject = "OOP";
            this.examinerFullName = "Mykha I.P.";
            this.isDifferential = false;
            this.examDate = new DateTime();
        }
        public Examination(int semesterNumber, string subject, string examinerFullName, byte mark, bool isDefferential, DateTime examDate)
        {
            this.semesterNumber = semesterNumber;
            this.mark = mark;
            this.subject = subject;
            this.examinerFullName = examinerFullName;
            this.isDifferential = isDefferential;
            this.examDate = examDate;
        }

        public override string ToString()
        {
            return subject + ", " + examinerFullName + ", " + mark;
        }

        public string NationalScaleName()
        {
            return this.mark.ToString();
        }

        public string EctsScaleName()
        {
            if (this.mark <= 100 && this.mark >= 95) return "A";
            if(this.mark < 95 && this.mark >= 85) return "B";
            if (this.mark < 85 && this.mark >= 75) return "C";
            if (this.mark < 75 && this.mark >= 65) return "D";
            if (this.mark < 65 && this.mark >= 60) return "E";
            return "F";
        }
    }
}
