using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Artihmetic
    {
        [TestMethod]
        public void Operators()
        {
            double a = 22;
            double b = 15;

            //addition
            double sum = a + b;
            Console.WriteLine(sum); //37

            //subtraction
            double difference = a - b;
            Console.WriteLine(difference); //7

            //multiplication
            double product = a * b;
            Console.WriteLine(product); //330

            //division
            double quotient = a / b;
            Console.WriteLine(quotient); // 1

            //remainder (modulus)
            double remainder = a % b;
            Console.WriteLine(remainder); //7


        }
    }
}

