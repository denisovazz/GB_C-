int number = Random.Shared.Next(10,100);
Console.WriteLine(number);
int LastDigit = number%10;
int firstDigit = number/10;
if (firstDigit>LastDigit)
{
    System.Console.WriteLine("Первая цифра больше второй. Наибольшая цифрв - "+firstDigit);               
}
else if (firstDigit<LastDigit)
{
    System.Console.WriteLine("Вторая цифра больше первой. Наибольшая цифра - "+LastDigit);
}
else 
{
    System.Console.WriteLine("Цифры равны.");
}