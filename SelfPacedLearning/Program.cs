using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace Self_Paced_Learning
{
    class Program
    {

        static void Main(string[] args)
        {
            MeetAlien();

            

            Console.ReadKey();
        }

        static void MeetAlien()
        {
            Random numbergen = new Random();

            string name = "X-" + numbergen.Next(10, 9999);

            int age = numbergen.Next(10, 500);

            Console.WriteLine("Hi, I'm " + name);
            Console.WriteLine("I'm " + age + " years old.");
            Console.WriteLine("Oh, and I'm an alien.");

        }
    }



}
