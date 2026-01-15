namespace RecursivityActivities
{
    public class Program
    {
        public static void Main()
        {
            int[] arrayInt = { 1, 2, 3, 4, 5 };

            PrintForwardArray(arrayInt, 0);
            Console.WriteLine();
            PrintBackwardArray(arrayInt, arrayInt.Length - 1);
        }


        public static void PrintForwardArray(int[] arrayInt, int index)
        {
            if (index >= arrayInt.Length)
            {
                return;
            }

            Console.WriteLine(arrayInt[index]);

            PrintForwardArray(arrayInt, index + 1);

        }

        public static void PrintBackwardArray(int[] arrayInt, int index)
        {
            if (index < 0)
            {
                return;
            }

            Console.WriteLine(arrayInt[index]);

            PrintBackwardArray(arrayInt, index - 1);

            
        }
    }
}