using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;

            isDeclared = true;

            bool isDeclaredAndInitialized = false;


        }
        [TestMethod]
        public void characters()
        {
            char letter = 'a';
            char number = '7';
            char symbol = '?';
            char space = ' ';
            char specialCharacter = '\t';
        }
        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.5649841f;
            double doubleExample = 1.654981654891d;
            decimal decimalExample = 1.65468468676516168781654987m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        enum PastryType { Cake, Cupcake, Eclaire, Danish, Canoli}

        [TestMethod]
        public void Enum()
        {
            PastryType myPastry = PastryType.Eclaire;
            PastryType anotherPastry = PastryType.Danish;
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            Console.WriteLine(DateTime.Now);
            DateTime birthday = new DateTime(1981, 05, 11);

            TimeSpan age = today - birthday;
            int ageInDays = age.Days;

            Console.WriteLine(ageInDays / 365);
        }
    }
}
