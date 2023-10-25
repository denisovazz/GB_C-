int[,] GetRandomMatrix(int rows, int colums, int leftBorder, int rightBorder)
{
    int[,] matrix = new int[rows,colums];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Random.Shared.Next(leftBorder, rightBorder+1);
        }
    }

    return matrix;
}

int[,] Swap(int [,] matrix)
{
    int temp = 0;
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0)-1,j];
        matrix[matrix.GetLength(0)-1,j] = temp;   
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]}\t");
           
        }
         System.Console.WriteLine();
    }

}

int [,] arr = GetRandomMatrix(3,5,0,10);

PrintMatrix(arr);
Swap(arr);
System.Console.WriteLine();
PrintMatrix(arr);

