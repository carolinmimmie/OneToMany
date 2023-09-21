
using static System.Console;

namespace OneToMany;

class Program
{
    public static void Main()
    {
        Title = "OneToMany"; //sätter namnet på tabben
        CursorVisible = false; //stänger av markör

        while (true) //Loop som körs tills vi stänger ner den
        {
            WriteLine("1. Lista produkter");

            var keyPressed = ReadKey(true); //hämtar in värdet

            Clear();


            switch (keyPressed.Key)
            {
                case ConsoleKey.D1: //case för menyval1
                case ConsoleKey.NumPad1:



                    break;

            }
            Clear();

        }
    }
}

