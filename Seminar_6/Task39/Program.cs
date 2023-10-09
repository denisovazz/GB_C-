// переворот массива

int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
   int[] array = new int [length];

   for (int i = 0; i < array.Length; i++)
   {
    array[i] = Random.Shared.Next(leftBorder, rightBorder+1);
   }

   return array;
}

void ReversrArray(int[] sourseArray)
{
    for(int i = 0; i < sourseArray.Length/2; i++)
    {
        int temp = sourseArray[i];
        sourseArray[i] = sourseArray[sourseArray.Length-i-1];
        sourseArray[sourseArray.Length-i-1] = temp;
    }
    
}
 const int Length = 6;
 const int LeftBorder = -10;
 const int RightBorder = 10;
 int[] myArray = GetRandomArray(Length, LeftBorder, RightBorder);
 System.Console.WriteLine(string.Join(", ", myArray));
 ReversrArray(myArray);
 System.Console.WriteLine(string.Join(", ", myArray));