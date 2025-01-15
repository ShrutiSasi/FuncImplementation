using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq.Expressions;
using System;

namespace FuncImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //A method which returns a random integer between 1 to 10000 using Func.This method should return the number.Use Lamba expressions.
            Func<int> RandomNumberGenerator = () =>
            {
                var randNumber = new Random();
                return randNumber.Next(1,10000);
            };

            //A method which could take in a Func<int> and return a string which outputs "The Generates Number is: {number"}
            Func<Func<int>, string> printMessage = (randGenerator) =>
            {
                int number = randGenerator();
                return $"The Generates Number is: {number}";
            };
        }
    }
}
