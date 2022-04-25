using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class HighestAttendenceInEach
    {
        public string name { get; set; }
        public string subject { get; set; }
        public int highestAttendence { get; set; }
        public HighestAttendenceInEach() { }
        public HighestAttendenceInEach(string name,string subject,int highestAttendence)
        {
            this.name = name;
            this.subject = subject;
            this.highestAttendence = highestAttendence;
        }
    }
}
