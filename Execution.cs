using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Execution
    {
        /*@classname:Execution
         *@objective: to orcastation for calling serval methods
        */
        static void Main(string[] args)
        {
            //create a SchoolAssignmentData type list
            List<SchoolAssignmentData> list = new List<SchoolAssignmentData>();
            SchoolAssignmentData schoolAssignmentData1 = new SchoolAssignmentData(101, "Ravi", "English", 24);
            SchoolAssignmentData schoolAssignmentData2 = new SchoolAssignmentData(101, "Ravi", "Maths", 20);
            SchoolAssignmentData schoolAssignmentData3 = new SchoolAssignmentData(101, "Ravi", "Physics", 23);
            SchoolAssignmentData schoolAssignmentData4 = new SchoolAssignmentData(101, "Ravi", "Chemistry", 24);
            SchoolAssignmentData schoolAssignmentData5 = new SchoolAssignmentData(102, "Rakesh", "English", 21);
            SchoolAssignmentData schoolAssignmentData6 = new SchoolAssignmentData(102, "Rakesh", "Maths", 22);
            SchoolAssignmentData schoolAssignmentData7 = new SchoolAssignmentData(102, "Rakesh", "Physics", 20);
            SchoolAssignmentData schoolAssignmentData8 = new SchoolAssignmentData(102, "Rakesh", "Chemistry", 24);
            SchoolAssignmentData schoolAssignmentData9 = new SchoolAssignmentData(103, "Akash", "English", 24);
            SchoolAssignmentData schoolAssignmentData10 = new SchoolAssignmentData(103, "Akash", "Maths", 19);
            SchoolAssignmentData schoolAssignmentData11 = new SchoolAssignmentData(103, "Akash", "Physics", 20);
            SchoolAssignmentData schoolAssignmentData12 = new SchoolAssignmentData(103, "Akash", "Chemistry", 21);
            SchoolAssignmentData schoolAssignmentData13 = new SchoolAssignmentData(104, "Vikaram", "English", 21);
            SchoolAssignmentData schoolAssignmentData14 = new SchoolAssignmentData(104, "Vikaram", "Maths", 22);
            SchoolAssignmentData schoolAssignmentData15 = new SchoolAssignmentData(104, "Vikaram", "Physics", 20);
            SchoolAssignmentData schoolAssignmentData16 = new SchoolAssignmentData(104, "Vikaram", "Chemistry", 24);
            //add all the data into the list
            list.Add(schoolAssignmentData1);
            list.Add(schoolAssignmentData2);
            list.Add(schoolAssignmentData3);
            list.Add(schoolAssignmentData4);
            list.Add(schoolAssignmentData5);
            list.Add(schoolAssignmentData6);
            list.Add(schoolAssignmentData7);
            list.Add(schoolAssignmentData8);
            list.Add(schoolAssignmentData9);
            list.Add(schoolAssignmentData10);
            list.Add(schoolAssignmentData11);
            list.Add(schoolAssignmentData12);
            list.Add(schoolAssignmentData13);
            list.Add(schoolAssignmentData14);
            list.Add(schoolAssignmentData15);
            list.Add(schoolAssignmentData16);
            foreach (SchoolAssignmentData data in list)
            {
                Console.WriteLine($"{data.rollNumber},{data.name},{data.subject},{data.attendence}");
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            //create AssignmentOpersations class object
            AssignmentOpersations assignmentOpersations = new AssignmentOpersations();
            //calling getAvgAttendencePerSubjects method and return the AvgAttendencePerSubject type list
            List<AvgAttendencePerSubject> list1 = assignmentOpersations.getAvgAttendencePerSubjects(list);
            //iterate the list who has return by method
            foreach (AvgAttendencePerSubject data in list1)
            {
                Console.WriteLine($"{data.avgAttendence},{data.subject}");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            //calling getmaximumAttendenceData method and return MaximumAttendenceData object
            MaximumAttendenceData list2 = assignmentOpersations.getmaximumAttendenceData(list);
            Console.WriteLine($"{list2.name},{list2.totalAttendence}");

            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            //calling getHighestAttendenceInEach method and return the HighestAttendenceInEach type list
            List<HighestAttendenceInEach> list3 = assignmentOpersations.getHighestAttendenceInEach(list);
             foreach(HighestAttendenceInEach data in list3)
            {
                Console.WriteLine($"{data.name},{data.subject},{data.highestAttendence}");  
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            //calling getminimumAttendenceData method and return MinimumAttendenceData object
            MinimumAttendenceData list4 = assignmentOpersations.getminimumAttendenceData(list);
            Console.WriteLine($"{list4.name},{list4.totalAttendence}");

            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            //calling getOverallAttendences method and return the OverallAttendence type list
            List<OverallAttendence> list5 = assignmentOpersations.getOverallAttendences(list);
            foreach(OverallAttendence data in list5)
            {
                Console.WriteLine($"{data.rollNumber},{data.name},{data.totalAttendence}");
            }
        }
    }
}
  