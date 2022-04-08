using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class Student
    {      
        public int No { get; set; }
        public string FullName { get; set; }

        Dictionary<string, int> Exams = new Dictionary<string, int>();

        public void AddExam(string examName, int point)
        {
            if(!string.IsNullOrWhiteSpace(examName))
            Exams.Add(examName, point);
        }

        public int GetExamResult(string examName, int point)
        {
            if(!string.IsNullOrWhiteSpace(examName))
            {
                return Exams[examName];
            }
            return -1;
        }

        public int GetExamAvg()
        {
            int avarage = 0;
            foreach (var value in Exams.Values)
            {
                avarage+=
            }
            return avarage;

            }
        }
    }

