namespace Self_Paced_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statements are commands that look to meet out a condition
            // if (condition) is met, within the brackets it will fulfill the command { result }
            // == - is equal to != - is NOT equal to > - great < - less than >= greater or eaqual to <= lesser or equal to 


            Console.WriteLine("Welcome! Tickets are $5. Please insert caseh.");

            int cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 5)
            {
                Console.WriteLine("That's not enough money.");
            }
            else if (cash == 5)
            {
                Console.WriteLine("Here is your ticket!");
            }
            else
            {
                int change = cash - 5;
                Console.WriteLine(" Here is your ticket and here is your " + change + " dollars in change.");
            }

            Console.ReadKey();
        }
    }
}
