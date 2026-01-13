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
            //the minimun number will be always 1 in the end, so the + 1 in the second return just adds 1 to the previous final number(wich is 1), then continues adding becuase the return accumulates the number
            if (n < 10) return 1;

            return CountDigits( n / 10) + 1;
        }

    }
}
