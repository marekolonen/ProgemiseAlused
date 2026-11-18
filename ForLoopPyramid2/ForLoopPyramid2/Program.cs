namespace ForLoopPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        //on peamine loop, mille sees on kaks loopi,
        //mis loob pyramidi
        {
            Console.WriteLine("Tärnidest püramiid");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\n\n");
            int i, j, n, r;

            Console.WriteLine("Sisesta ridade arv: ");
            r = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.Write("\n");
            }
            {
                for (i = r - 1; i >= 1; i--)
                {
                    for (j = 1; j <= r - i; j++)
                        Console.Write(" ");

                    for (j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");

                    Console.Write("\n");
                }
            }
        }
    }  
}