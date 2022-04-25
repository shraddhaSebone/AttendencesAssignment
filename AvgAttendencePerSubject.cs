using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class AvgAttendencePerSubject
    {
        public int avgAttendence { get; set; }
        public string subject { get; set; }
        public int count { get; set; }
        public AvgAttendencePerSubject() { }
        public AvgAttendencePerSubject(int avgAttendence,string subject,int count)
        {
            this.avgAttendence = avgAttendence;
            this.subject = subject;
            this.count = count;
        }
    }
}
