using System.Xml.Serialization;

namespace IfElsseCodeAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //konsool küsib numbrit
            //number tuleb ära parsida

            //if ja else juures toimub kontroll, et 
            //kas on paaris või paaritu nr

            string nr = Console.ReadLine();
            int number = int.Parse(nr);

            //% jagab muutujat number 2 
            //kui 2 asemel panan 3, siis jagab 3-ga
            if (number % 2 == 0)
            {
                Console.WriteLine("See on paarisarv" + number);
                Paarisarv();
                //siia tuleb välja kutsuda meetod,
                //mis ütleb, et see on paarisarv
            }
            else
            {
                Console.WriteLine("See on paaritu number" + number );
                Paarisarv();
                //siia tuleb välja kutsuda meetod,
                //mis ütleb, et see on paarituarv
            }
        }
        static void Paarituarv()
        {
            Console.WriteLine("Antudnumber on paaritu arv");
        }
        static void Paarisarv()
        {
            Console.WriteLine("Antud number on paarisarv");
        }
    }
}
