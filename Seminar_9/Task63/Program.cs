int n = 10;

void  PrintNatural(int n)
{
    if (0==n)
    {
      return;
    } 
    PrintNatural(n-1);
    System.Console.WriteLine(n);
   
}
PrintNatural(n);