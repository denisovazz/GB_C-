int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int result = number1%number2;

if (result==0)
{
    System.Console.WriteLine($"{number1}, {number2} - кратно.");
}
else if (result != 0)
{
    System.Console.WriteLine($"{number1}, {number2} - некратно, остаток {result}");
}