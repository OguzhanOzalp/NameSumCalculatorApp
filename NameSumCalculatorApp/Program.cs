
using System;
using NameSumCalculator_0;

class Program
{
    static void Main(string[] args)
    {
        // Set console input and output encoding to UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        //Runs the tests
        UnitTest.RunTests();

        Console.Write("Enter a name: ");
        string name = Console.ReadLine();

        int result = NameSumCalculator.CalculateNameSum(name);
        Console.WriteLine($"The sum of the letters in \"{name}\" is: {result}");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

}