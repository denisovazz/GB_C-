int [] arr = GenerateArr(5);
Console.WriteLine(string.Join(" ", arr));
Console.WriteLine(string.Join(", ", NewArr(arr)));


int [] GenerateArr(int size)
{
    Random random = new Random();
    int [] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(1,10);
    }
    return arr;
}
int[] NewArr(int[] arr)
{
    int[] newArr = new int[arr.Length/2+arr.Length%2];
    for(int i=0; i < newArr.Length; i++)
    {
        
        if(i== arr.Length-1-i)
        newArr[i] = arr[i];
        else{newArr[i] = arr[i] * arr[(arr.Length-1) -i];}
    }
    return newArr;
}