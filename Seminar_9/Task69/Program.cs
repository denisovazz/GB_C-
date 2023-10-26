int Pow(int a, int b)
{
    if (b==0)
    {
        return 1;
    }
    else
    {
        return a * Pow(a, b-1);
    }
}

int a = 5;
int b = 3;
System.Console.WriteLine(Pow(a,b));