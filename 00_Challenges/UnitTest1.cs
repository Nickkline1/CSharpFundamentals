using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UpdateStudentGraduation()
        {
            Student websiteVisitor = new Student("Nick", "Kline", new DateTime(1980, 01, 01), CourseType.WebDev, BadgeType.Red, false);
        }
    }
}
