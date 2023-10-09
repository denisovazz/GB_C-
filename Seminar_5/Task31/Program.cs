int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
   int[] array = new int [length];

   for (int i = 0; i < array.Length; i++)
   {
    array[i] = Random.Shared.Next(leftBorder, rightBorder+1);
   }

   return array;
}


int SumPozitiveElementsArray(int [] array)
{
   int sum = 0;

   for (int i = 0; i < array.Length; i++)
   {
       if (array[i] > 0)
       {
        sum += array[i];
       }
   }
   return sum;
}

int SumNegativeElementArray(int[] array)
{
   int sum = 0;

   for (int i = 0; i < array.Length; i++)
   {
       if (array[i] < 0)
       {
        sum += array[i];
       }
   }
   return sum;
}

const int Length = 12;
const int LeftBorder = -9;
const int RightBorder = 9;

int [] myArray = GetRandomArray(Length, LeftBorder, RightBorder);
string myArrayString = string.Join(", ", myArray);
Console.WriteLine(myArrayString);
int sumPositive = SumPozitiveElementsArray(myArray);
int sumNegative = SumNegativeElementArray(myArray);

System.Console.WriteLine($"Сумма положительных элементов массива = {sumPositive}, отрицательных {sumNegative}");