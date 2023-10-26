internal class Program
{
    private static void Main(string[] args)
    {
        int n = 10;
        int m = 4;

        void PrintNatural(int n, int m)
        {
            if (m > n)
            {
                return;
            }
            PrintNatural(n - 1, m);
            System.Console.WriteLine(n);

        }
        PrintNatural(n, m);
    }
}