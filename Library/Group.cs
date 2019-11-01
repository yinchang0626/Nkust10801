using System;
using System.Collections.Generic;

namespace YC.Model
{
    public class Group
    {
        public static string UnitName = "電子系";

        public Group()
        {
            this.Students = new List<Student>();
        }

        public string Name;
        public List<Student> Students;


        public void ShowStudentCount()
        {
            Console.WriteLine(UnitName + Students.Count);
        }
    }
}
