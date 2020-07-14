//Write C# program to design a simple calculator using if else if statements
using System;
namespace A
{
    class B
    {
        static void Main(string[] args)
        {  
        int a,b,c;
        Console.WriteLine("Enter the first Value :");
        a= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second Value :");
        b= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the choice for required operation");
        Console.WriteLine("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n");
        c = Convert.ToInt32(Console.ReadLine());
        if(c==1)
        Console.WriteLine("Sum = {0}", a+b);
        else if(c==2)
        Console.WriteLine("Difference = {0}", a-b);
        else if(c==3)
        Console.WriteLine("Product = {0}", a*b);
        else if(c==4)
        Console.WriteLine("Quotient = {0}", a/b);
        else
        Console.WriteLine("Invalid Choice");
        Console.ReadLine();
          }
    }
}	
	


