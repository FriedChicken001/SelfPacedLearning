namespace Self_Paced_Learning
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] movies = new string[4]; // inside the second string[]. you can input the legnth of the array
            // ^^ this is an empty array that the user inputs the information

            Console.WriteLine("Type in 4 movies");

            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = Console.ReadLine(); // <-- this is storing values in the array
            }
            
            Console.WriteLine("\nHere they are alphabetically: ");

            Array.Sort(movies); // this will sort the array in order alphabettically (or numerically if its a number)

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }

            Console.ReadKey();
        }
    }
}
