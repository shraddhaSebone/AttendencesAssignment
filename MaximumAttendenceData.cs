using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class MaximumAttendenceData
    {
        public string name { get; set; }
        public int totalAttendence { get; set; }
        public MaximumAttendenceData() { }
        public MaximumAttendenceData(string name,int totalAttendence) 
        {
            this.name = name;
            this.totalAttendence = totalAttendence;
        }
    }
}
