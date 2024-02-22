namespace Self_Paced_Learning
{
    class Program
    {
        public static object Conosle { get; private set; }

        static void Main(string[] args)
        {
           for (int i = 1;i <= 10;i++) // this will count up to 10
                //to count down (int i = 10; i > 0; i --)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
