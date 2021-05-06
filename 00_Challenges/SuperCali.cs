using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_Challenges
{
    [TestClass]
    public class SuperCali
    {
        [TestMethod]
        public void W1D3LoopsAndConditionals()
        {

            string super = "Supercalifragilisticexpialidocious";
            foreach (char letter in super)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine(letter);

                }
            }
        }
    }
}