using System;

namespace _00_Challenges
{
    public enum CourseTaught
        {
            CyberSecurity, WebDev, SWDev
        }

    public class Instructor
    {
        public Instructor(int employeeNumber)
        {
            EmployeeNumber = employeeNumber;
        }


        public string FirstName { get; set; }
        public string LastName { get; set;}
        public DateTime DateOfBirth { get; set; }
        public int EmployeeNumber { get; }
        public CourseTaught CourseTaught { get; set; }



        public Instructor()
        {

        }
        public Instructor(string firstName, string lastName, DateTime dateOfBirth, CourseTaught typeOfCourse, int employeeNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            CourseTaught = typeOfCourse;
            EmployeeNumber = employeeNumber;
        }
    }
}
