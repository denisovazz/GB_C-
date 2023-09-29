int GetInt(string message)
{
int result;
Console.WriteLine(message);
while (!int.TryParse(Console.ReadLine(), out result))
{
Console.WriteLine("Ошибка ввода. Введите число");
}
return result;
}

int a = GetInt("Введите число");
int count=1;

while(count <= a)
{
    System.Console.WriteLine(count*count);
    count++;
}