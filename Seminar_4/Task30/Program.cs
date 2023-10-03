
int[] FillArray(int size)
{

int [] array = new int[size];


    for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(0,2);
    System.Console.Write(array[i]+" ");
    }
    return array;
}

int [] arr = FillArray(8);