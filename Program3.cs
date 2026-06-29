// Program to Add the total marks of Physics,Chemistry,Mathematics
using System;

public class Program3
{

    public void CalculateMarks(){

    Console.WriteLine("Enter the Marks of Physics :");
    double Physics = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the Marks of Chemistry :");
    double Chemistry = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the Marks of Mathematics:");
    double Mathematics = Convert.ToDouble(Console.ReadLine());

      double TotalMarks = Physics + Chemistry + Mathematics;



        Console.WriteLine($"The Total of Physics , Chemistry and Mathematics is : {TotalMarks}");
    }

}