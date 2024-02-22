namespace Self_Paced_Learning
{
    class Program
    {
        public static object Conosle { get; private set; }

        static void Main(string[] args)
        {
            // how to create a number generater
            Random numberGen = new Random();

            int roll = 0;
            int attempts = 0;

            Console.WriteLine("Press enter to roll the die.");

            while(roll != 6)
            {

                Console.ReadKey(); // this will make it to where we wait for user input before proceeding

                roll = numberGen.Next(1, 7); /// first number is the INCLUSIVE minimum, second number is the EXCLUDED maximum or the limit
                Console.WriteLine("You rolled: " + roll);
                attempts++; /// this means, after each attempt, increase attempt + 1
            }
            // the while loop whill continue until the condition is met, in this case its hitting up to "6" on the die or the number before 7
            Console.WriteLine("It took you " + attempts + " attempts to roll a six");

            Console.ReadKey();
        }
    }
}
