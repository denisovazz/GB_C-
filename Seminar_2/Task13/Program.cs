System.Console.WriteLine("Введите первое число:");
int number1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1*number1==number2||number2*number2==number1)
{
    System.Console.WriteLine("Да");
}
else 
{
    System.Console.WriteLine("Нет");
}
