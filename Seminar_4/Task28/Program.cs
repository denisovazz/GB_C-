﻿int ReadNumber(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int SumFrom1ToA(int a)
{
    int sum = 1;

    for(int i = 1; i <= a; i++)
    { 
        sum *= i;
    }
    return sum;
}

int number = ReadNumber("Введите число:");
if (number >1)
{
int result = SumFrom1ToA(number);
System.Console.WriteLine(result);}
else {
    System.Console.WriteLine("Ошибка. введите число больше 1.");
}
