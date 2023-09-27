int number = Random.Shared.Next(100,1000);
Console.WriteLine(number);
int Digit3 = number%10;
int Digit1 = number/100;
int Digit2 = Digit1*10;
int result = Digit2+Digit3;

System.Console.WriteLine(result);