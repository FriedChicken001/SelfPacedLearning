namespace Self_Paced_Learning
{
    class Program
    {
        public static object Conosle { get; private set; }

        static void Main(string[] args)
        {
            // CHALLENGE: Roll 2 die and loop it until you get two of a kind
            Random numberGen = new Random();

            int roll01 = 0;
            int roll02 = 0;
            int attempts = 1;

            Console.WriteLine("Press enter to roll the die.");

            while(true)
            {

                Console.ReadKey(); // this will make it to where we wait for user input before proceeding

                roll01 = numberGen.Next(1, 7); /// first number is the INCLUSIVE minimum, second number is the EXCLUDED maximum or the limit
                Console.WriteLine("Die 1: " + roll01);
                roll02 = numberGen.Next(1, 7);
                Console.WriteLine("Die 2: " + roll02);

                if (roll01 == roll02 || roll02 == roll01)
                {

                    Console.WriteLine(" It took you " + attempts + " attempts to roll a double");

                    break;
                }
                else
                {
                    attempts++;
                }
                /// this means, after each attempt, increase attempt + 1
            }
            // the while loop whill continue until the condition is met, in this case its hitting up to "6" on the die or the number before 7


            Console.ReadKey();
        }
    }
}
