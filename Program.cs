namespace RecursivityActivities
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(CountDigits(1234));
        }


        public static int CountDigits(int n)
        {
            if (n < 10) return 1;

            return CountDigits( n / 10) + 1;
        }

    }
}