using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public enum CourseType
    {
        CyberSecurity, WebDev, SWDev
    }
    public enum BadgeType
    {
        White, Gold, Blue, Red, Graduate
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CourseType CourseType { get; }
        public BadgeType BadgeType { get; }
        public decimal BalanceOwed { get; set; }
        public bool HasGraduated { get; set; }




        public Student()
        {

        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, CourseType classTaking, BadgeType typeOfBadge, bool hasGraduated)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            CourseType = classTaking;
            BadgeType = typeOfBadge;
            HasGraduated = hasGraduated;
        }
    }
}

