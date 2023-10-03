int ReadNumber(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int SumNumber(int a)
{
    int count = 0;
    while (a > 0)
    {
        a = a/10;
        count++;
    }
    return count;
}

int number = ReadNumber("Enter number");
int sum = SumNumber(number);
System.Console.WriteLine($"В числе {number} - {sum} чисел");