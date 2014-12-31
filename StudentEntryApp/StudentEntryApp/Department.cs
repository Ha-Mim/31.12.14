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
       private List<Student> students;
       private const int MAX_NO_OF_STUDENTS = 10;

        public Department(string code, string name)
        {
            Name = name;
            Code = code;
            students = new List<Student>();
        }

       public string AddStudent(Student aStudent)
       {
           if (students.Count <MAX_NO_OF_STUDENTS )
           {
               if (HasThisRegNo(aStudent.RegNo))
               {
                   return "Already Exists"; 
               }
               else
               {
                  
                   students.Add(aStudent);
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
           return students.ToArray();
       }

       private bool HasThisRegNo(string regNo)
       {
           foreach (Student student1 in students)
           {
               if (student1.RegNo == regNo)
               {
                   return true;
               }
               
           }
           return false;
       }
    }
}
