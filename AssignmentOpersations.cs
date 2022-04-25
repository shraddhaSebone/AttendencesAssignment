using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class AssignmentOpersations
    {/*@classname:AssignmentOpersations
      *@objective:To perform various task
      *Date:21/04/2022
      *Author:Shraddha Choudhary
     */
        public List<AvgAttendencePerSubject> getAvgAttendencePerSubjects(List<SchoolAssignmentData> list)
        {
            /*
             *@method Name:getAvgAttendencePerSubjects
             *@objective : to find average attendence per subject
             *param:List<SchoolAssignmentData> list
             *return:List<AvgAttendencePerSubject>
            */

            //dic creating with key as subject name and object type of AvgAttendencePerSubject
            Dictionary<string, AvgAttendencePerSubject> dict = new Dictionary<string, AvgAttendencePerSubject>();
            //create a list for storing result
           List<AvgAttendencePerSubject> resultlist = new List<AvgAttendencePerSubject>();
            //iterating list
            foreach (SchoolAssignmentData data in list)
            {
                if (dict.ContainsKey(data.subject))
                {
                    //dic has same subject then add attendence of that student and increment in count
                    dict[data.subject].avgAttendence += data.attendence;
                    dict[data.subject].count++;
                }
                else
                {
                    // if dic does not subject then create objcet and add values in AvgAttendencePerSubject
                    dict.Add(data.subject, new AvgAttendencePerSubject());
                    dict[data.subject].avgAttendence = data.attendence;
                    dict[data.subject].subject = data.subject;
                    dict[data.subject].count = 1;
                }
            }
            //iterating a dictinory and divide the avgAttendence by count and adding value in resultlist
            foreach(AvgAttendencePerSubject data in dict.Values)
            {
                dict[data.subject].avgAttendence /= data.count;
                resultlist.Add(data);
            }
            return resultlist;
        }
        public MaximumAttendenceData getmaximumAttendenceData(List<SchoolAssignmentData> list)
        {
            /*
            *@method Name:getmaximumAttendenceData
            *@objective : Find name of students who has maximum attendance across all subject
            *param:List<SchoolAssignmentData> list
            *return:MaximumAttendenceData
           */

            //dic creating with key as student name and object type of MaximumAttendenceData
            Dictionary<string, MaximumAttendenceData> keyValuePairs = new Dictionary<string, MaximumAttendenceData>();
            //iterating list
            foreach (SchoolAssignmentData data in list)
            {
                // dic has same student name then add attendence in totalAttendence
                if (keyValuePairs.ContainsKey(data.name))
                {
                    keyValuePairs[data.name].totalAttendence += data.attendence;
                }
                else
                {
                    // if dic does not student name then create objcet and add values in MaximumAttendenceData
                    keyValuePairs.Add(data.name, new MaximumAttendenceData());
                    keyValuePairs[data.name].name = data.name;
                    keyValuePairs[data.name].totalAttendence = data.attendence;
                }
            }
            //creating object of MaximumAttendenceData class
            MaximumAttendenceData maximumAttendenceData = new MaximumAttendenceData();
            //adding minimum value totalAttendence
            maximumAttendenceData.totalAttendence = int.MinValue;
            //iterating dictinory
            foreach (MaximumAttendenceData data in keyValuePairs.Values)
            {
                //logic for highest Attendence
                if (data.totalAttendence > maximumAttendenceData.totalAttendence)
                {
                    //if existing attendence is greater then of MaximumAttendenceData then assign it in object of maximumAttendenceData
                    maximumAttendenceData.totalAttendence = data.totalAttendence;
                    maximumAttendenceData.name= data.name;
                }
            }
            return maximumAttendenceData;
        }
        public List<HighestAttendenceInEach> getHighestAttendenceInEach(List<SchoolAssignmentData> list)
        {
            /*
           *@method Name: getHighestAttendenceInEach
           *@objective: Find name of students who has highest attendence in each subject
           *param:List<SchoolAssignmentData> list
           *return:List<HighestAttendenceInEach>
          */

            //dic creating with key as subject name and object type of HighestAttendenceInEach
            Dictionary<string, HighestAttendenceInEach> keyValuePairs = new Dictionary<string, HighestAttendenceInEach>();
            //create a list for storing highestAttendence
            List<HighestAttendenceInEach> highestAttendence = new List<HighestAttendenceInEach>();
            //iterating list
            foreach(SchoolAssignmentData data in list)
            {
                // dic has same subject name then add attendence in totalAttendence
                if (keyValuePairs.ContainsKey(data.subject))
                {
                    //existing attendence of dictinory is greateer then attedences 
                    if (keyValuePairs[data.subject].highestAttendence < data.attendence)
                    {
                        keyValuePairs[data.subject].name = data.name;
                        keyValuePairs[data.subject].subject = data.subject;
                        keyValuePairs[data.subject].highestAttendence = data.attendence;
                    }
                }
                else
                {
                    // if dic does not subject name then create objcet and add values in HighestAttendenceInEach
                    keyValuePairs.Add(data.subject, new HighestAttendenceInEach());
                    keyValuePairs[data.subject].name = data.name;
                    keyValuePairs[data.subject].subject = data.subject;
                    keyValuePairs[data.subject].highestAttendence = data.attendence;
                }
            }
            //iterating dictinory
            foreach(HighestAttendenceInEach data in keyValuePairs.Values)
            {
                highestAttendence.Add(data);
            }
            return highestAttendence;
        }
        public MinimumAttendenceData getminimumAttendenceData(List<SchoolAssignmentData> list) 
        {
            /*
            *@method Name:getminimumAttendenceData
            *@objective : Find name of students who has minimum attendance across all subject
            *param:List<SchoolAssignmentData> list
            *return:MinimumAttendenceData
           */

            //dic creating with key as student name and object type of MinimumAttendenceData
            Dictionary<string, MinimumAttendenceData> keyValuePairs = new Dictionary<string, MinimumAttendenceData>();
            //iterating list
            foreach (SchoolAssignmentData data in list)
            {
                // dic has same subject name then add attendence in totalAttendence
                if (keyValuePairs.ContainsKey(data.name))
                {
                    keyValuePairs[data.name].totalAttendence += data.attendence;
                }
                else
                {
                    // if dic does not student name then create objcet and add values in MinimumAttendenceData
                    keyValuePairs.Add(data.name, new MinimumAttendenceData());
                    keyValuePairs[data.name].name = data.name;
                    keyValuePairs[data.name].totalAttendence = data.attendence;
                }
            }
            //creating object of MinimumAttendenceData class
            MinimumAttendenceData minimumAttendenceData = new MinimumAttendenceData();
            //adding minimum value totalAttendence
            minimumAttendenceData.totalAttendence = int.MaxValue;
            //iterating dictinory
            foreach (MinimumAttendenceData data in keyValuePairs.Values)
            {
              //if existing attendence is less than then of MinimumAttendenceData then assign it in object of minimumAttendenceData
              if (data.totalAttendence < minimumAttendenceData.totalAttendence)
              {
                        minimumAttendenceData.totalAttendence = data.totalAttendence;
                        minimumAttendenceData.name = data.name;
              }
            }
            return minimumAttendenceData;
        }
        public List<OverallAttendence> getOverallAttendences(List<SchoolAssignmentData> list)
        {
           /*
           *@method Name:getOverallAttendences
           *@objective : List students name in order of their overall attendance across all subjects
           *param:List<SchoolAssignmentData> list
           *return:List<OverallAttendence>
           */

            //dic creating with key as rollNumber and object type of OverallAttendence
            Dictionary<int, OverallAttendence> keyValuePairs = new Dictionary<int, OverallAttendence>();
            //iterating list
            foreach (SchoolAssignmentData data in list)
            {
                //dic has same rollNumber then add attendence in totalAttenedence
                if (keyValuePairs.ContainsKey(data.rollNumber))
                {
                    keyValuePairs[data.rollNumber].totalAttendence += data.attendence;
                    keyValuePairs[data.rollNumber].rollNumber = data.rollNumber;
                    keyValuePairs[data.rollNumber].name = data.name;
                }
                else
                {
                  // if dic does not rollNumber then create objcet and add values in OverallAttendence
                  keyValuePairs.Add(data.rollNumber, new OverallAttendence());
                  keyValuePairs[data.rollNumber].totalAttendence = data.attendence;
                  keyValuePairs[data.rollNumber].name = data.name;
                }
            }
            //create list for storing list
            List<OverallAttendence> overallAttendence = new List<OverallAttendence>();
            //iterate dictinory
            foreach (OverallAttendence data in keyValuePairs.Values)
            {
                overallAttendence.Add(data);
            }
            //logic of sorting
            int temp;
            for (int i = 0; i < overallAttendence.Count() - 1; i++)
            {
                for (int j = 0; j < overallAttendence.Count() - 1 - i; j++)
                {
                    if (overallAttendence[j].totalAttendence < overallAttendence[j + 1].totalAttendence)
                    {
                        temp = overallAttendence[j].totalAttendence;
                        overallAttendence[j].totalAttendence = overallAttendence[j + 1].totalAttendence;
                        overallAttendence[j + 1].totalAttendence = temp;
                    }
                }
            }
            {
                //var itemMoved = false;
                //do
                //{
                //    itemMoved = false;
                //    for (int i = 0; i < overallAttendence.Count() - 1; i++)
                //    {
                //        if (overallAttendence[i].totalAttendence > overallAttendence[i + 1].totalAttendence)
                //        {
                //            var lowerValue = overallAttendence[i + 1].totalAttendence;
                //            overallAttendence[i + 1].totalAttendence = overallAttendence[i].totalAttendence;
                //            overallAttendence[i].totalAttendence = lowerValue;
                //            itemMoved = true;
                //        }
                //    }
                //} while (itemMoved);
            }
            //overallAttendence.Sort(x,y) => y.totalAttendence.CompareTo(x.totalAttendence));
            return overallAttendence;
        }
    }
}
            
