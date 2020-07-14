//Write a C# program to swap two numbers without using third variable 
using System;
namespace A
{
    class B
    {
        static void Main(string[] args)
        {  
       int  a=10, b=20;            
       Console.WriteLine("Before swapping process, a= "+a+" b= "+b);    
       a=a+b;      
       b=a-b;       
       a=a-b;  
       Console.WriteLine("After swapping process, a= "+a+" b= "+b);  
       Console.ReadLine();
         }
    }
}	


