using System.Diagnostics.CodeAnalysis;

namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Eelnevaid teadmisi kasutades kirjuta programm, mis väljastaks:
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //for loopi sees peab olema for loops
            //peab saama sisestada arvu, mitu korda soovib väljundit korrata
            Console.WriteLine("Sissesta korduste arv");
            int arv = Convert.ToInt32(Console.ReadLine());
                
            for (int i = 1; i <=  arv; i++)
            {
                Console.WriteLine("See on rida nr {0}", i);
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("kill - koll ");
                }
                Console.WriteLine("killadi - koll ");
            }
        }
    }
}
