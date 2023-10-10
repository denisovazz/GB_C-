int MyNumber = 13;

void PrintBinaryView(int number)
{
    if (number <= 0) return;
    PrintBinaryView(number/2);
    System.Console.Write(number%2);
}

PrintBinaryView(MyNumber);