//Write a C# program to swap two numbers using third variable 
using System;
namespace A
{
    class B
    {
        static void Main(string[] args)
        {
			int a=10,b=20,temp;
                      Console.WriteLine("Before swapping process, a= "+a+" b= "+b); 
			temp=a;
			a=b;
			b=temp;
		       Console.WriteLine("After swapping process, a= "+a+" b= "+b);  
                      Console.ReadLine();
	  }
    }
}	

