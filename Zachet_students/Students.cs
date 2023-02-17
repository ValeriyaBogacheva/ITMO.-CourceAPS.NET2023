using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace students
{
    public class Student
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string points { get; set; }
        public int sumPoints { get; set; }

        public Student() { }
        public Student(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;

        }

    }


}