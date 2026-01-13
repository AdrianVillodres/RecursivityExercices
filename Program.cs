namespace RecursivityActivities
{
    public class Program
    {
        public static void Main()
        {
            int[] arrayInt = { 1, 2, 3, 4, 5 };

            PrintForwardArray(arrayInt, 0);
            Console.WriteLine();
            PrintBackwardArray(arrayInt, 0);
        }


        public static void PrintForwardArray(int[] arrayInt, int index)
        {
            if (index >= arrayInt.GetLength(0))
            {
                return;
            }


        }

        public static void PrintBackwardArray(int[] arrayInt, int index)
        {
            // El teu codi aquí
        }




    }
}