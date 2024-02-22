namespace Self_Paced_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01; // declaring a variable, we are not assigning a value yet
            int num02;

            Console.Write("Input a number: "); // this prompts the user to input on the same line as the question instead of making a new line

            num01 = Convert.ToInt32( Console.ReadLine() ); //this code takes the input and convert it into a number only

            Console.Write("Input a second number: ");

            num02 = Convert.ToInt32( Console.ReadLine() );

            int result = num01 * num02; // takes the inputted numbers from both questions and multiplies them
            Console.WriteLine("And the result is " + result);
       

            Console.ReadKey();
        }
    }
}
