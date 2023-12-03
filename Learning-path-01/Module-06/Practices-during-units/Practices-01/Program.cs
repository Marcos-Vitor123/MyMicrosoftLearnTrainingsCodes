using System;

namespace Program
{
   internal class Program
    {
        private static void Main(string[] args)
        {
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            int gradeA = 4;
            int gradeB = 3;
            int gradeC = 3;
            int gradeD = 3;
            int gradeE = 4;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeC;
            int course4Grade = gradeD;
            int course5Grade = gradeE;

            Console.WriteLine($"{course1Name} {course1Grade}");
            Console.WriteLine($"{course2Name} {course2Grade}");
            Console.WriteLine($"{course3Name} {course3Grade}");
            Console.WriteLine($"{course4Name} {course4Grade}");
            Console.WriteLine($"{course5Name} {course5Grade}");

        }
    } 
}
