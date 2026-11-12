namespace ForLoopPyramid
{
    internal class Program
    {
        static void Main(string[] args)
            //on peamine loop, mille sees on kaks loopi,
            //mis loob pyramidi
        {
            Console.WriteLine("Tärnidest püramiid e poolik teemant");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\n\n");
            int i, j, n;

            Console.WriteLine("Sisesta ridade arv: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");

                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                {
                    Console.Write("\n");

                }
            }
        }
    }
}
