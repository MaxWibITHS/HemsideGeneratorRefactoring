using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemsideGeneratorRefactoring
{
    public class Course
    {
        public Course(string? courseName)
        {
            CourseName = courseName;
        }
    
        internal string? CourseName { get; set; }

    }
}

