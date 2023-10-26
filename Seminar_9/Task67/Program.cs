int n = 453;

int Sum(int n)
{
    if (n==0)
    {
        return 0;
    }

    int temp = n % 10;
    int temp1 = n / 10;
    int sum = Sum(temp1) + temp;
    return sum;
}
System.Console.WriteLine(Sum(n));