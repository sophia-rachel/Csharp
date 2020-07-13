//Write a C# program to print size of various data types *
using System;
namespace A
{
    class B
    {
        static void Main(string[] args)
        {
            Console.WriteLine("size of int type: {0}", sizeof(int));
            Console.WriteLine("size of float type: {0}", sizeof(float));
            Console.WriteLine("size of double type: {0}", sizeof(double));
            Console.WriteLine("size of bool type: {0}", sizeof(bool));
            Console.WriteLine("size of char type: {0}", sizeof(char));
            Console.ReadLine();
        }
    }
}
