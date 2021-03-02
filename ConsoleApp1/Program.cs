using System;
using RegularExpressionLib.Validation;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string testStr = "peter-levinsky@mail.dk";

            bool b = Validator.CheckEmail(testStr);

            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
