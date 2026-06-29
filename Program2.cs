// Program to Add Two Integer numbers
using System;

public class Program2
{

    public void GetInput(){

    Console.WriteLine("Enter the first Number :");
    int Num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the Second Number :");
    int Num2 = Convert.ToInt32(Console.ReadLine());

      int Sum = Num1 + Num2;


        Console.WriteLine($"The Sum of {Num1} and {Num2} is : {Sum}");
    }

}