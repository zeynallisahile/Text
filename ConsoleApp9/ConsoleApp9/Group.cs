using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Group
    {
        public string GroupNo { get; set; }
        private Student[]Students=new Student[0];
        public Group()
        {
            GroupNo = GroupNo;
            StudentLimit = StudentLimit;
        }
        public int StudentLimit
        { 
            get=>StudentLimit; 
            set
            {
                if(value>4 && value<10)
                {
                    StudentLimit = value;
                }
            }
        }
        public bool CheckGroupNo(string groupNo)
        {
            bool check=false;
           if (!string.IsNullOrWhiteSpace(groupNo))
            {
             if(char.IsUpper(groupNo[0])&& char.IsUpper(groupNo[1])&& char.IsDigit(groupNo[2])&& char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
               {
                   check = true;
               }
                
            }
           return check;
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public int GetStudent(int? id)
        {
            return Students(id);
        }

        public string GetAllStudents()
        {
            return Student[]
        }
    }
}
