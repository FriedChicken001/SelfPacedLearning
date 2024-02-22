namespace Self_Paced_Learning
{
    class Program
    {
        public static object Conosle { get; private set; }

        static void Main(string[] args)
        {
            string[] movies = { "Lord of the Rings", "Fight Club", "Interstellar", "Gladiator" };

            for (int i = 0; i < movies.Length; i++) //instead of using a numerical number, we can just summon the legnth of the entire array
            {
                int rank = i + 1; // this is tel tell us what rank the movies are "what order they are in the index"

                Console.WriteLine(rank + " " + movies[i]); 
            
            }

            Console.ReadKey();
        }
    }
}
