namespace WhileGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string number = "";
            //numbri arvamise mäng
            //tuleb kasutada while, kus öeldakse, kas sinu
            //pakutud number oli suurem või väiksem

            Random random = new Random();
            int SecretNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;

            while (guess != SecretNumber);
            {
                Console.WriteLine("Arva number ära 1 kuni 100-ni");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess <= SecretNumber)
                {
                    Console.WriteLine("number on liiga väike");
                }
                else if (guess > SecretNumber)
                {
                    Console.WriteLine("Number on liiga suur");
                }
            }
            Console.WriteLine($"Õige! Arvatud kordade arv: {attempts}");
        }
    }
}
