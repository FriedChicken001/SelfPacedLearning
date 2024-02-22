namespace Self_Paced_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 1"; // changes the tab name
            Console.ForegroundColor = ConsoleColor.DarkMagenta;  // changes the font color
            Console.WindowHeight = 40; // this is 40 lines tall


            Console.WriteLine("Once upon a time, there was a princess. Choose her name.");

            Console.ReadLine(); // this pauses the code until an input is provided by the user. 

            Console.WriteLine(" ... ah, that was her name! Such creativity and beauty she had but then a dragon came upon the tower!! Ahhhhhh ~ \nBut wait a hero appeared! What was their name again?");

            Console.ReadLine();

            Console.WriteLine("...Yes! They did come! They came and attacked the dragon using the strongest weapon in the land. \nWhat was it called again..");

            Console.ReadLine();

            Console.WriteLine("Yes, dear reader! Thank you for your amazing help!");

            Console.ReadKey(); // <--- this is to wait for plaer input so it does not close
        }
    }
}
