namespace ForLoopTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest kolmnurk e poolik püramiid");
            Console.WriteLine("------------------------------------");
            // \n tähendab uut rida
            Console.WriteLine("\n\n");

            Console.WriteLine("Sisesta ridade arv: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= count; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}