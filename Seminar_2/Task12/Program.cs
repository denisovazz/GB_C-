System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number%7==0&&number%23==0)
{
    System.Console.WriteLine("Да");
}
else 
{
    System.Console.WriteLine("Нет");
}