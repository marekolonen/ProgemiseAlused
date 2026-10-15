namespace IfElseMethodCall
{
    internal class Program
    {
        //Main on meetod, mis läheb alati esimesena tööle
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //kasutada if ja else
            //kui kasutaja soovib, siis saab ta meetodi välja kutsuda
            Console.WriteLine("Kui soovid meetotit välja kutsuda, siis kirjua ja ");
            string method = Console.ReadLine();

            if(method == "ja")
            {
                //kui kirjutan meetodi nime, siis seda nimetatakse
                //meetodi välja kutsumine
                HelloMethod();
            }
            else
            {
                Console.WriteLine("Ei soovinud midagi");
            }
           
        }

        //teha teine meetod siia ja nimeks on sellel HelloMethod

        static void HelloMethod()
        { 
            Console.WriteLine("Hello, Kitty");
        }
    }   
}
