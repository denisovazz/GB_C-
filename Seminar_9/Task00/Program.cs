//при помощи рекурсии вывести факториал числа N

const uint N = 5;

uint Factorial(uint n)
{
    if(n == 0 || n == 1)
    {
        return 1;
    }
    return n * Factorial(n-1);
}

uint result = Factorial(N);
System.Console.WriteLine(result);