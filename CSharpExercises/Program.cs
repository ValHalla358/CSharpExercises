using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpExercises;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CSharpExercises");
            Console.WriteLine();

            //console.writeline(exercises.helloworld());
            //console.readline();
            //Console.WriteLine("CSharpExercises");
            //Console.WriteLine();
            //Assert("HelloWorld() should return \"hello world!\"", Exercises.HelloWorld() == "hello world!");
            Assert("SayHello() should return\"Hello Valerie\"", Exercises.SayHello() == $"Hello Valerie");
            Console.ReadLine();
            Assert("Sum(5,11) should return 16" , Exercises.Sum(5,11) == 16);
            Console.ReadLine();
            Assert("Divide(10,2) should return 5", Exercises.Divide(10,2) == 5);
            Console.ReadLine();
            Assert("CanOpenCheckingAccount(16) should return false", Exercises.CanOpenCheckingAccount(16) == false);
            Console.ReadLine();
            Assert("GetFirstName(Valerie Smith)should return \"Valerie\"", Exercises.GetFirstName("Valerie Smith") == "Valerie");
            Console.ReadLine();
            Assert("ReverseStringHard(hello)should return \"olleh\"", Exercises.ReverseStringHard("hello") == "olleh");
            Console.ReadLine();
            Assert("ReverseStringEasy(hello)should return \"olleh\"", Exercises.ReverseStringEasy("hello") == "olleh");
            Console.ReadLine();
            Assert("PrintTimesTable(9) should print correctly", Exercises.PrintTimesTable(9) == Constants.TimesTableFor9);
            Console.ReadLine();
            Assert("ConvertKelvinToFahrenheit(295) should return 71.33", Exercises.ConvertKelvinToFahrenheit(295) == 71.33);
            Console.ReadLine();
            Assert("GetAverageHard(new int[] {1,2,3,4,5,6,7,8,9}) should return 5", Exercises.GetAverageHard(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }) == 5);
            Console.ReadLine();
            Assert("GetAverageEasy(new int[] {1,2,3,4,5,6,7,8,9}) should return 5", Exercises.GetAverageHard(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }) == 5);
            Console.ReadLine();
            Assert("DrawTriangle(8,5) should draw correctly", Exercises.DrawTriangle(8, 5) == Constants.TriangleFor8and5);
            Console.ReadLine();
            Assert("GetMilesPerHour(200, 2, 30, 45) should return \"80MPH\"", Exercises.GetMilesPerHour(200, 2, 30, 45) == "80MPH");
            Console.ReadLine();
            Assert("IsVowel('a') should return true", Exercises.IsVowel('a') == true);
            Assert("IsVowel('p') should return false", Exercises.IsVowel('p') == false);
            Console.ReadLine();
            Assert("IsConsonant('a') should return false", Exercises.IsConsonant('a') == false);
            Assert("IsConsonant('b') should return true", Exercises.IsConsonant('b') == true);
            Console.ReadLine();
            Assert("CollatzConjecture(27) should return 111", Exercises.CollatzConjecture(27) == 111);
            Assert("GetNext7Days() should return next 7 days", JsonConvert.SerializeObject(Exercises.GetNext7Days(DateTime.Parse("08/22/2016"))) == JsonConvert.SerializeObject(Constants.Next7Days));
            Assert("IsInLeapYear(1924) should return false", Exercises.IsLeapYear(1924) == false);
            Assert("MortgageCalculator(300000, 3.8, 30, 12) should return 1397.87", Exercises.MortgageCalculator(300000, 3.8m, 30, 12) == 1397.87);
            Assert("DuckGoose(100) should print correctly", Exercises.DuckGoose(100) == Constants.DuckGooseResult);








            // Person[] people = new Person[4];

            // people[0] = new Person { Id = 1, FirstName = "Blaine" };
            // people[1] = new Person { Id = 2, FirstName = "Cameron" };
            // people[2] = new Person { Id = 3, FirstName = "Jennifer" };
            // people[3] = new Person { Id = 4, FirstName = "Ryan" };

            // Console.WriteLine("Length of array: {0}", people.Length);

            // int id = 2;

            // Grab the person to delete from the list
            // foreach (var person in people)
            // {
            //if(person.Id == 2)
            //{
            //people.Remove(person);
            //   break;
            // }
            //}



        }
        static void Assert(string exerciseName, bool condition)
        {
            if (condition)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[PASS] - {exerciseName}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[FAIL] - {exerciseName}");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }


    }
    //class Person
    //{
    /* public int Id { get; set; }
     public string FirstName { get; set; }
     public string LastName { get; set; }*/
    //}
}
