using System;
using System.IO;

public class Program
{
    public static void Main(string[] args) 
    {
        var number1 = 25;
        var number2 = 2;
        int remainder = number1 % number2;
        Console.WriteLine(remainder);
        number1 = 20;
        remainder = number1 % number2;
        Console.WriteLine(remainder);

        Console.Write("Enter a number: ");
        Console.WriteLine("\n");
        Console.WriteLine("wooo");


        string numInput = Console.ReadLine();
        bool success = int.TryParse(numInput, out int num );
        if (success)
        {
            Console.WriteLine("Times Table!");
            for(int i=1; i<=10;i++)  
            {
                Console.WriteLine($@"{num} x {i} = {num*i}");
            }
        }

        else {
        System.Console.WriteLine("yeah not a good number");
        // var name = Console.ReadLine();
        // Console.WriteLine();
        }
    }
}
