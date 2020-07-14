//Write a C# program to find out the leap years from 1900 to 1950 
using System;
namespace A
{
    class B
    {
        static void Main(string[] args)
        {  
            int year;
            for (year = 1900; year <= 1950; year++)
            {   
                if(((year % 4==0) && (year % 100 !=0)) || ((year % 4==0) && (year % 100 ==0) && (year%400==0)))
                {
                    Console.Write(year + " ");
                }
            }

            Console.ReadLine();
        }
    }
}

	


