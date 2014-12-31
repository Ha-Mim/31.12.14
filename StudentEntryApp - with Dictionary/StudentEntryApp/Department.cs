using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryApp
{
   public  class Department
    {
        public string Code { set; get; }
        public string Name { set; get; }
       private Dictionary<string,Student> students;
       private const int MAX_NO_OF_STUDENTS = 10;

        public Department(string code, string name)
        {
            Name = name;
            Code = code;
            students = new Dictionary<string, Student>();
        }

       public string AddStudent(Student aStudent)
       {
           if (students.Count <MAX_NO_OF_STUDENTS )
           {
               if (students.ContainsKey(aStudent.RegNo))
               {
                   return "Already Exists"; 
               }
               else
               {
                  
                   students.Add(aStudent.RegNo,aStudent);
                   return "Student Added";
               }
           }
           else
           {
               return "OverFlow";
           }
       }

       public Student[] GetStudents()
       {
           return students.Values.ToArray();
       }

       
    }
}
