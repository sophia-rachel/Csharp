//Program to print the acceleration given the velocity and time
//input:
//Enter the Velocity in m/s:20
//Enter the Time in seconds:10
//output:
//The Acceleration is 2 
using System;
class acc_prog
{
    static void Main(string[] args)
    {
        int velocity, time, acceleration;
        Console.WriteLine("Enter the Velocity in m/s : ");
        velocity = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Time in seconds: ");
        time = int.Parse(Console.ReadLine());
        acceleration = velocity / time;
        Console.WriteLine("The Acceleration is {0}", acceleration);
        Console.ReadLine();
    }
}
