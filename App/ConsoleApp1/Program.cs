using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Group g1 = new Group();
            //g1.Name = "甲組";

            Group g2 = new Group();
            //g2.Name = "乙組";

            Group g3 = new Group();
            //g3.Name = "丙組";
            g1.Students.Add(new Student());

            g1.ShowStudentCount();
            g2.ShowStudentCount();
            g3.ShowStudentCount();

            Group.UnitName = "電機系";
            g1.ShowStudentCount();
            g2.ShowStudentCount();
            g3.ShowStudentCount();

            Console.ReadKey();
        }
    }


    public class Group 
    {
        public static string UnitName="電子系";

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

    public class Student
    {
        public string Name;
    }
}
