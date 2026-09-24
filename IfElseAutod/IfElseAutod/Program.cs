namespace IfElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //kasutada if ja else
            //kirjuta automark
            //valikus on BMW, Audi, Porsche, Fiat ja Skoda
            //Kui valitakse Škoda, siis seal seees on uuesti küsimus, et
            //mis mudelit sooviud valida. Mudeli valikus Kodiaq ja Octavia

            Console.WriteLine("Vali automark");
            String auto = Console.ReadLine();

            if (auto == "BMW")
            {
                Console.WriteLine("Valisite BMW");
            }
            else if (auto == "Audi")
            {
                Console.WriteLine("Valisite Audi");
            }
            else if (auto == "Porsche")
            {
                Console.WriteLine("Valisite Porche");
            }
            else if (auto == "Fiat")
            {
                Console.WriteLine("Valisite Fiat");
            }
            else if (auto == "Škoda")
            {
                Console.WriteLine("Valisite Škoda");
                Console.WriteLine("Sisestasid automudel");






















        }
    }
}
