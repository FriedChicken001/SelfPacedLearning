namespace Self_Paced_Learning
{
    class Program
    {
        public static object Conosle { get; private set; }

        static void Main(string[] args)
        {
            // how to allow the user to determine the number of lines we use

            Console.Write("How many cool numbers do you want: ");

            int count = Convert.ToInt32(Console.ReadLine());

           for (int i = 1;i <= count;i++) // will repeat based on the user input
                //to count down (int i = 10; i > 0; i --)
            {
                double result = Math.Pow(2, i); // this is  a double because its a larger number than a whole 2 digit part. b.c we are raising the power of the number up to a 4 digit number. We could also console.convert into a double as well. 

                // int result = Mat.Pow(2, i); 
                // Console.Convert result double
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
