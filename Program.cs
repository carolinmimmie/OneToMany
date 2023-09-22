
using OneToMany.Data;
using OneToMany.Domain;
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
            WriteLine("1. Registrera projekt");

            var keyPressed = ReadKey(true); //hämtar in värdet

            Clear();


            switch (keyPressed.Key)//Case för varje knapptryck
            {
                case ConsoleKey.D1: //case för menyval1
                case ConsoleKey.NumPad1:

                    RegisterProjektView();



                    break;

            }
            Clear();

        }
    }

    private static void RegisterProjektView()
    {
        Write("Namn: ");

        var name = ReadLine();

        Write("Beskrivning: ");

        var description = ReadLine();

        Write("Deadline (YYYY-MM-DD): ");

        var deadline = DateTime.Parse(ReadLine());//Använder parse för att deadline ska bli en datetime

        var project = new Project
        {
            Name = name,
            Description = description,
            Deadline = deadline
        };

        SaveProject(project);//Metod som sparar information ovan

        Clear();

        WriteLine("Projekt sparat");






    }

    private static void SaveProject(Project project)
    {
        //Här behöver vi dbContex med DbSet + database/tabell
        using var context = new ApplicationDbContext();

        context.Project.Add(project);

        //Kommer generera en INSERT INTO och skicka till databashanteraren (databasen)
        context.SaveChanges();
    }
}

