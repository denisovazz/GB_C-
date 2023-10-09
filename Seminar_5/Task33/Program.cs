int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
   int[] array = new int [length];

   for (int i = 0; i < array.Length; i++)
   {
    array[i] = Random.Shared.Next(leftBorder, rightBorder+1);
   }

   return array;
}

bool SortArray(int[] array, int num)
{
   for(int i = 0; i < array.Length; i++)
   {
    if (array[i] == num)
    return true;
   }
   return false;
}

int [] myArray = GetRandomArray(10, -3, 4);
string myArrayString = string.Join(", ", myArray);
Console.WriteLine(myArrayString);
bool result = SortArray(myArray, 3);
System.Console.WriteLine(result);