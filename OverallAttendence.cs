using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class OverallAttendence
    {
        /*@classname:OverallAttendence
         */
        public int rollNumber { get; set; }
        public string name { get; set; }
        public int totalAttendence { get; set; }
        public OverallAttendence() { }
        public OverallAttendence(int rollNumber, string name,int totalAttendence)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.totalAttendence = totalAttendence;
        }
    }
}
