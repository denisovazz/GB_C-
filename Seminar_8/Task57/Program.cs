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

void Numbers(int [,] matrix)
{
    int count = 0;

    for (int a = 0; a<10; a++)
    {
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

           if (matrix [i,j]==a)
           {
            count++;
           }
           
        }
        
    }
    if (count != 0)
    {
    System.Console.WriteLine($"{a} встречается {count} раз");
    }
         count = 0;
    }
}
int [,] arr = GetRandomMatrix(3,3,0,9);
PrintMatrix(arr);
Numbers(arr);


