using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace students
{
    public class SampleContext: DbContext
    {
        public SampleContext() : base("StudentDB")
        { }
        public DbSet<Student> _Students { get; set; }

    }
}