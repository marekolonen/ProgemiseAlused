using System.Diagnostics.CodeAnalysis;

namespace IfElseColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("teha if ja else konsoolirakendus, kus " + 
                "kontrollitakse stringi abil värvi vastavust");

            Console.WriteLine("Värvide valikuks on: red, blue, green ja white");

            Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta" + 
                "eelpool sisestatud värvi");

            String Color = Console.ReadLine();
            if (Color == "Red")
            {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            else if  (Color == "Blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Sisestasite Blue");
            }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sisestasite Green");
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Sisestasite Cyan");
            }
            Console.WriteLine("Vale värv");
        }
    }
}
