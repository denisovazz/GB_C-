int [] FillArray(int size)
{
    int [] array = new int[size];
    for (int i = 0; i<array.Length; i++)
    { 
        array[i] = new Random().Next(-10,10);
        System.Console.Write(array[i]+" ");
    }
    return array;
}

int [] PrintArray(int[] array)
{
    
    for (int i = 0; i<array.Length; i++)
    { 
        array[i] = array[i]*-1;
        System.Console.Write(array[i]+" ");
    }
    return array;
}

System.Console.WriteLine("enter array's size");
int size = int.Parse(Console.ReadLine());

int [] myArray = FillArray(size);
System.Console.WriteLine();
PrintArray(myArray);