namespace SwitchWeekdays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nädalapäev");

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Täna on esmaspäev");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Täna on esmaspäev");
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                case DayOfWeek.Sunday:
                    break;
            }
        }
    }
}
