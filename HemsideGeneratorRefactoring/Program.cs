using HemsideGeneratorRefactoring;
using System.Runtime.InteropServices;

Course databaser = new Course("daTAbaser");
Course webbutveckling = new Course("WebbuTVeCkling ");
Course cleancode = new Course("clean Code   ");
Course csharp = new Course("   C#");   


SchoolClass classA = new SchoolClass();
classA.ListOfCourses = new List<Course>
{
    csharp,
    databaser,
    webbutveckling,
    cleancode
};

classA.ClassName = "Klass A";

classA.ClassMessage = new [] { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };


HomePageBuilder builder = new HomePageBuilder(classA);

builder.PrintPage();




