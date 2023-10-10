int num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[num];
Fibb(arr);

void Fibb(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0||i == 1)
        {
            arr[i] = i;
        }
     
        else
        {
        arr[i] = arr[i-1] + arr[i-2];
        }
    }
    
}

System.Console.Write(string.Join(" ", arr));



