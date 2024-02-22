namespace Self_Paced_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;

            Console.Write("Please give your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please provide your height (inches): ");
            height = Convert.ToInt32(Console.ReadLine());

            if (age >= 18) 
            {
                if(height >= 60)
                {
                    Console.WriteLine("You can enter!"); // having a condition within a condition is called Nesting
                }
                else
                {
                    Console.WriteLine("You do not meet the requirements.");
                }

            }
           

            Console.ReadKey();
        }
    }
}
