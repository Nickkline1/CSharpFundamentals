using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while (total !=10)
            {
                Console.WriteLine(total);

                total = total + 1; //1, 1+1, 2+1, 3+1, 4+1, 5+1, etc
            }

            int someCount = 0;
            bool keepLooping = true;

            while (keepLooping)
            {
                if (someCount <= 100)
                {
                    Console.WriteLine(someCount);
                    someCount++; //same as someCount = someCount + 1
                }
                else
                {
                    keepLooping = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 28;

            //1 starting point
            //2 condition
            //3 what to do after each loop
            //4 body of the loop (what gets executed

                //1                 //2      //3
            for (int i =0; i <studentCount; i++)
            {
                //4
                Console.WriteLine(i);
            }
            int e = 0;

            //you can write a while loop for anything that you can write a for loop
            while (e < studentCount)
            {
                Console.WriteLine(++e);
                
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "Aaron", "Alexandro", "Andrew", "Ben", "Chris" };

            //1 Collection being worked on
            //2 Name of the current iteration
            //3 Type that is held in the collection
            //4 in Keyword
                       //3     2     4     1
            foreach (string student in students)
            {
                Console.WriteLine(student +  " is a student in this class");
            }

            string myName = "Michael Joseph Pabody";

            foreach (char letter in myName)
            {
                Console.Write(letter);
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello");
                Console.WriteLine(iterator);
                iterator++;
            }
            while (iterator < 5);
        }
    }
}
