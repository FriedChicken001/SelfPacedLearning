namespace Self_Paced_Learning
{
    class Program
    {
        public static object Conosle { get; private set; }

        static void Main(string[] args)
        {
            // CHALLENGE: provide the user a problem but create an if/else statement to check the answer

            int answer;

            Console.Write("Please solve the following problem: \nWhat is 5 * 8 / 4 = ");
             answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 4)
            {
                Console.WriteLine("You are so smart!");

                Console.WriteLine("Try this one out! \nWhat is 10 + 10 / 2 = ");
                 answer = Convert.ToInt32(Console.ReadLine()); ;
                if (answer == 10)
                {
                    Console.WriteLine("Wow~! You are killing it! But can you keep it up?");
                    Console.WriteLine("Finally, what is 100 / 2  = ");
                    answer = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Oof. That was rough. You can't try again but you did something.");
                }
            } 
            else
            {
                Console.WriteLine("Stop wasting time and find a calculator");
            }

            Console.ReadKey();
        }
    }
}
