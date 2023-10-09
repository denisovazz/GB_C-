int [] arr = GenerateArr(5);
System.Console.WriteLine(string.Join(" ", arr));
System.Console.WriteLine(FindCount(arr));


int [] GenerateArr(int size)
{
    Random random = new Random();
    int [] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(1,100);
    }
    return arr;
}

int FindCount(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>=10 && arr[i] <=99)
        {
            count++;
        }
    }
    return count;
}