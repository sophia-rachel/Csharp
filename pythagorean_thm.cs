//Program to print hypotenuse given two sides using pythagoras theorem
//input:
//Enter the first side value 
//3
//Enter the first side value 
//4
//output:
//The hypotenuse is : 5
using System;
class progpyth
{
    static void Main(string[] args)
    {
        double a, b, c;
        Console.WriteLine("Enter the first side value ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the first side value  ");
        b = double.Parse(Console.ReadLine());
        c = Math.Sqrt(a * a + b * b);
        Console.WriteLine("The hypotenuse is : {0}", c);
        Console.ReadLine();
 
    }
}