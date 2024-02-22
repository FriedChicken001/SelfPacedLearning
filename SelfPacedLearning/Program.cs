using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;


namespace Self_Paced_Learning
{
    class Program
    {

        static void Main(string[] args)
        {
            // CHALLENGE: Write a program that counts every word in a sentence.

            Console.WriteLine("Enter a sentence!");

            string userInput = Console.ReadLine();

            int wordCount = CountWords(userInput);

            
            Console.WriteLine("There are " +wordCount + " words in that sentence!");
            



            Console.ReadKey();
        }

        static int CountWords (string userInput) //within the parenthesis are parameters
        {
            int wordCount = userInput.Split(' ').Length;



            return wordCount;

        }
    }



}
