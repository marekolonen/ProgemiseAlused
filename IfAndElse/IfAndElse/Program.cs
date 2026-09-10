namespace IfAndElse
{
    //Projekt nimetusega IfAndElse on, mille sees asub
    //class nimega  Program. See klass sisaldab Main meetodit,
    //mis on programmi sisenemispunkt
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi:");

            //muutuja nimega name, kuhu salvestatakse kasutaja
            //sisestatud tekst
            string name = Console.ReadLine();

            //! tähendab "ei ole" ja == tähendab "on võrdne"
            if (name != " ")
            {
                //Kui kasutajasisestab ,idagi, siis muudetakse taustavärv
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Sisestasid enda nime");
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("Sisestasid tühja nime");
                //Kui kasutaja ei sisesta midagi, siis kostub 2 piiksu
                Console.Beep();
                //ja oodatakse 1 sekund enne programmi lõppu
                Thread.Sleep(1000);
                Console.Beep();
            }  
        }
    }
}
