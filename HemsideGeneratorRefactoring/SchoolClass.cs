using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemsideGeneratorRefactoring
{
    public class SchoolClass : ISchoolClass
    {
        public string? ClassName { get; set; }   

        public string[]? ClassMessage { get; set; }

        public List<Course>? ListOfCourses { get; set; }    

    }
}




