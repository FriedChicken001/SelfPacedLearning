using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace Self_Paced_Learning
{
    class Program
    {

        static void Main(string[] args)
        {
            // CHALLENGE: create a program that a teacher can use to input their students and sort them alphabettically 

            string[] students = new string[4];

            Console.WriteLine("Please provide the studnet's name: ");

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("Thank you for your input! \nHere are your students in alphabetical order: ");
            Array.Sort(students);

            for (int i = 0;i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
              
            
            

            Console.ReadKey();
        }
    }
}
