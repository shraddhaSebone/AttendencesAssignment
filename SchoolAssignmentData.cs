using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class SchoolAssignmentData
    {
        public int rollNumber { get; set; }
        public string name { get; set; }
        public string subject { get; set; }
        public int attendence { get; set; }
        public SchoolAssignmentData() { }
        public SchoolAssignmentData(int rollNumber, string name, string subject, int attendence)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.subject = subject;
            this.attendence = attendence;

        }
    }
}
