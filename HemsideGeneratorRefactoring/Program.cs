using HemsideGeneratorRefactoring;
using System.Runtime.InteropServices;

Course databaser = new Course();
Course webbutveckling = new Course();
Course cleancode = new Course();
Course csharp = new Course();   

databaser.CourseName = "daTAbaser";
webbutveckling.CourseName = "WebbuTVeCkling ";
cleancode.CourseName = "clean Code   ";
csharp.CourseName = "   C#";

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




