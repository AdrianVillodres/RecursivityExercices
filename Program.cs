namespace RecursivityActivities
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("entro");
            Console.WriteLine(Countdown(5));
            Console.WriteLine("salgo");

            //CountdownClassic(5);
        }


        public static void CountdownClassic(int n)
        {
            for(int i = n; i > 0; i--)
            {
                Console.WriteLine(i);
            }

        }


        public static int CountdownExplicado(int n)
        {
            //bajada


            //base case: n < 0
            if (n < 0) return 0;

            Console.WriteLine("bajda");


            //bajada
            int num = n - CountdownExplicado(n - 1);
            //subida
            Console.WriteLine(n);

            //subida
            return num;
            
        }

        public static int Countdown(int n)
        {
            //base case: n < 0
            if (n == 0) return 0;

            Console.WriteLine(n);
            return Countdown(n - 1); //caso recursivo

        }



    }
}