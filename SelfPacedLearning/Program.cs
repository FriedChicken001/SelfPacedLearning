using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace Self_Paced_Learning
{
    class Program
    {

        static void Main(string[] args)
        {
            int result = Multiply(3, 8);
            
            Console.Write("The result is: " +  result);

            if (result % 2 == 0)
            {
                
                Console.WriteLine("\n" + result + " is an even number!");

            }
            else
            {
                Console.WriteLine(result + " is an uneven number!");

            }


            Console.ReadKey();
        }

        static int Multiply (int num01, int num02) //within the parenthesis are parameters
        {
            int result = num01 * num02;
            return result;

        }
    }



}
