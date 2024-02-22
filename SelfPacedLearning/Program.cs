using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace Self_Paced_Learning
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();

            shoppingList.Add("Dreams");
            shoppingList.Add("Miracles");
            shoppingList.Add("Rainbows");
            shoppingList.Add("Pony");

            for (int i = 0; i < shoppingList.Count; i++) // when requesting the length of the list, use .count
                {
                Console.WriteLine(shoppingList[i]);
                }

            shoppingList.Remove("Dreams"); //how to remove in general
            shoppingList.RemoveAt(1);  // removes at a specific point

            Console.WriteLine("------------");

            for (int i = 0; i < shoppingList.Count; i++) // when requesting the length of the list, use .count
            {
                Console.WriteLine(shoppingList[i]);
            }


            Console.ReadKey();
        }
    }
}
