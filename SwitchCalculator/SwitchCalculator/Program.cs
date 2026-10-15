using System.Threading.Channels;

namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number!");
            float FirstNr = float.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta teine number!");
            float SecondNr = float.Parse(Console.ReadLine());

            Console.WriteLine("Kasuta tingmärki: *, /, +, -,");
            string input = Console.ReadLine();
            //nüüd tuleb teha switchi valik, kas *, /, +, -
            //tuleb teha neli case, kus toimub soovinud tehe
            //peab näitama tehte tulemust
            //kasutage floati Parsimisel
            float answer;

            switch(input)
            {
                case "+":
                    Console.WriteLine($"Liitmise tulemus: {FirstNr} + {SecondNr} = {FirstNr + SecondNr}");
                    break;

                case "-":
                    Console.WriteLine($"Lahutamise tulemus: {FirstNr} - {SecondNr} = {FirstNr - SecondNr}");
                    break;

                case "*":
                    Console.WriteLine($"Korrutamise tulemus: {FirstNr} * {SecondNr} = {FirstNr * SecondNr}");
                    break;


                case "/":
                    if (SecondNr == 0)
                    {
                        Console.WriteLine("Nulliga jagamine ei ole lubatud");
                    }
                    else
                    {
                        Console.WriteLine($"Jagamise tulemus: {FirstNr} / {SecondNr} = {FirstNr / SecondNr}");
                    }
                    break;
                   
                default:
                    Console.WriteLine("Valisid vale tingmärgi");
                    break;
            }
        }
    }
}
