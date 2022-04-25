using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class MinimumAttendenceData
    {
        public string name { get; set; }
        public int totalAttendence { get; set; }
        public MinimumAttendenceData() { }
        public MinimumAttendenceData(string name, int totalAttendence)
        {
            this.name = name;
            this.totalAttendence = totalAttendence;
        }
    }
}
