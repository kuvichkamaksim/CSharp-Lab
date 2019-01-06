using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Examination
    {
        public int semesterNumber { get; set; }

        public string subject { get; set; }

        public string examinerFullName { get; set; }

        public byte mark { get; set; }

        public bool isDefferential { get; set; }

        public DateTime examDate { get; set; }

        public Examination()
        {
            this.semesterNumber = 3;
            this.mark = 100;
            this.subject = "OOP";
            this.examinerFullName = "Mykha I.P.";
            this.isDefferential = false;
            this.examDate = new DateTime();
        }
        public Examination(int semesterNumber, string subject, string examinerFullName, byte mark, bool isDefferential, DateTime examDate)
        {
            this.semesterNumber = semesterNumber;
            this.mark = mark;
            this.subject = subject;
            this.examinerFullName = examinerFullName;
            this.isDefferential = isDefferential;
            this.examDate = examDate;
        }

        public override string ToString()
        {
            return subject + ", " + examinerFullName + ", " + mark;
        }
    }
}
