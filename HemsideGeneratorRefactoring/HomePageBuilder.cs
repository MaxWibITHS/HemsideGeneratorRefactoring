using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HemsideGeneratorRefactoring
{
    public class HomePageBuilder
    {
        ISchoolClass sc;
        
        public HomePageBuilder(SchoolClass sc)
        {
            this.sc = sc;
        }
    
        public void PrintPage()
        {
            Console.WriteLine("<!DOCTYPE html>\n<html>\n<body>\n<main>\n");
            Console.WriteLine($"<h1> Välkomna {sc.ClassName}! </h1>");
            PrintClassMessage();
            PrintCourses();
            Console.WriteLine("\n</main>\n</body>\n</html>");
        }

        private void PrintClassMessage()
        {
            foreach(string msg in sc.ClassMessage) 
            {
                Console.WriteLine ($"<p><b> Meddelande: </b> {msg} </p>");
            }
            
        }

        private void PrintCourses()
        {
            foreach (Course course in sc.ListOfCourses)
            {
                string trimmedcourses = course.CourseName.Trim();
                Console.WriteLine($"<p>{trimmedcourses[0].ToString().ToUpper() + trimmedcourses.ToString().Substring(1).ToLower()}</p>");
            }

        }
    }
}

