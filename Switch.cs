namespace CoolBeans
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number (0-6): ");
           int day = Convert.ToInt32(Console.ReadLine());
           string today = getDay(day);
            Console.WriteLine("Today is " + today);

            
        }

        static String getDay(int dayNum)
        {
            String dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Number";
                    break;
            }
            return dayName;
        }


    }
}
