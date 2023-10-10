int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
   int[] array = new int [length];

   for (int i = 0; i < array.Length; i++)
   {
    array[i] = Random.Shared.Next(leftBorder, rightBorder+1);
   }

   return array;
}


const int Length = 6;
const int LeftBorder = -10;
const int RightBorder = 10;
int[] myArray1 = GetRandomArray(Length, LeftBorder, RightBorder);
