using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week_1_Challenge
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void NameAge()
        {
            string firstName = "Amy";
            string lastName = "Martinez";
            int myAge = 42;

            Console.WriteLine(myAge + 7);
            Console.WriteLine(myAge - 7);
            Console.WriteLine(myAge * 7);
            Console.WriteLine(myAge / 7);
            Console.WriteLine(myAge % 7);

        }

        [TestMethod]
        public void MovieArray()
        {
            string[] movie = { "Terminator 2", "Contact", "Avengers", "Black Widow", "Terminator" };
        }

        [TestMethod]
        public void DatesList()
        {
            List<DateTime> DatesList = new List<DateTime>();
            DateTime today = DateTime.Now;
            DatesList.Add(today);
            DatesList.Add(new DateTime(2020, 12, 25));
            DatesList.Add(new DateTime(2020, 3, 12));
            DatesList.Add(new DateTime(2020, 6, 16));

        }

        [TestMethod]
        public void SleepConditionals()
        {
            Console.WriteLine("How many hours of sleep did you get?");
            int hours = 4;

            if (hours >= 10)
            {
                Console.WriteLine("Wow That's a log of sleep.");
            }
            else if (hours > 8 && hours < 10)
            {
                Console.WriteLine("You shoudl be pretty rested.");

            }
            else if(hours > 4 && hours < 8)
            {
                Console.WriteLine("Bummer.");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }

        }

        [TestMethod]
        public void HowHasYourDayBeen()
        {
            string userDay = "Okay"; //--typically use int instead of string, or if string set to lower case

            switch (userDay)
            {
                case "Great":
                    Console.WriteLine("Glad you are having a great day");
                        break;
                case "Good":
                    Console.WriteLine("Good on ya, mate");
                    break;
                case "Okay":
                    Console.WriteLine("Only okay?");
                    break;
                case "bad":
                    Console.WriteLine("Things can only get better from here.");
                    break;
                case ":(":
                    Console.WriteLine("There is always tequila!");
                    break;                              

            }
        }

        [TestMethod]
        public void Supercalifragilisticexpialidocious()
        {
            string name = "Supercalifragilisticexpialidocious";
            foreach(char letter in name)
            {
                if(letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not a i");
                }
                
            }


        }
        
    }

}