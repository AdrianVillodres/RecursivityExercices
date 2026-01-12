namespace RecursivityActivities
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(AddDigits(456));
        }


        public static int AddDigits(int n)
        {
            if (n < 10) return n;

            return AddDigits(n % 10) + AddDigits(n / 10);

        }


    }
}