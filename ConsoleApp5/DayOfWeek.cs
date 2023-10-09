namespace ConsoleApp5
{
    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class DayOfWeekUtility
    {
        public static void PrintDayInRussian(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Понедельник");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Вторник");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Среда");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Четверг");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Пятница");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Суббота");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Неизвестный день");
                    break;
            }
        }
    }
}