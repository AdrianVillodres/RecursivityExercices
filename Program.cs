namespace RecursivityActivities
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(Swap(1234));
        }


        public static int Swap(int n)
        {
            return SwapAux(n, 0);
        }


        private static int SwapAux(int n, int result)
        {
            //down
            if (n == 0)
            {
                return result;
            }
            int lastDigit = n % 10;

            int substraction = n / 10;
            //down
            return SwapAux(substraction, result * 10 + lastDigit);
            //up
            //up

        }



    }
}