namespace IFAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");

            //konsoolis sisestame numbri
            //see number salvestatakse string andmetüüpi
            //toimub kontroll, kas sisestatud väärtus on number
            //kasutada if ja else lauseid

            string Input = Console.ReadLine();

            if(int.TryParse(Input, out int number))
            {
                Console.WriteLine($"Sisestatud number on: {number}");
            }
            else
            {
            Console.WriteLine("Sisestatud väärtus ei ole number.");
            }




































































        }
        }
}
