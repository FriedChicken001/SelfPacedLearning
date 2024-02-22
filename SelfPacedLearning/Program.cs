namespace Self_Paced_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            // CHALLENGE: ADD 3 NUMBERS AND FIND THEIR AVERAGE
            double num01; 
            double num02;
            double num03;

            Console.Write("Input a number: "); 
            num01 = Convert.ToDouble( Console.ReadLine() ); 

            Console.Write("Input a second number: ");
            num02 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Input a second number: ");
            num03 = Convert.ToDouble(Console.ReadLine());

            double addition = num01 + num02 + num03;
            double average = addition / 3;
            Console.WriteLine("And the result is " + average);
       

            Console.ReadKey();
        }
    }
}
