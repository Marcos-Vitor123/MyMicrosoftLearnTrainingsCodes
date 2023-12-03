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

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            int totalCreditHours = 0;
            totalCreditHours += course1Credit;
            totalCreditHours += course2Credit;
            totalCreditHours += course3Credit;
            totalCreditHours += course4Credit;
            totalCreditHours += course5Credit;

            int totalGradePoints = 0;
            totalGradePoints += course1Credit * course1Grade;
            totalGradePoints += course2Credit * course2Grade;
            totalGradePoints += course3Credit * course3Grade;
            totalGradePoints += course4Credit * course4Grade;
            totalGradePoints += course5Credit * course5Grade;

            Console.WriteLine($"{totalGradePoints} {totalCreditHours}");

            Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
            Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
            Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
            Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
            Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");
        }
    }
}
