using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace YC.Model
{
    public class Group
    {
        public Group()
        {
            //this.Students = new List<Student>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UnitName { get; set; }
        public int Semester { get; set; }
        //public List<Student> Students;

    }
}
