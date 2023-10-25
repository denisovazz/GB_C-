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

int[] MinEl(int[,] matrix)
{
    int min = matrix[0,0];
    int[] minEl = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
           if (matrix[i,j]< min)
           {
            min = matrix[i,j];
            minEl[0] = i;
            minEl[1] = j;
           }
        }
    }
    return minEl;
}

int[,] NewArr(int[,] matrix)
{
    int rowOff = 0;
    int columnOff = 0;
    int[ ] minEl = MinEl(matrix);
    int [,] newArr = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        if (i == minEl[0])
        {
            rowOff++;
        }

            for(int j = 0; j < newArr.GetLength(1); j++)
           {

             if (j == minEl[1])
               {
                  columnOff++;
               }
           
                newArr[i,j] = matrix[i+rowOff,j+columnOff];
               
             
           }
        
           columnOff = 0;
    }
    return newArr;
}

int[,] myMatrix = GetRandomMatrix(5,5,0,9);
PrintMatrix(myMatrix);
System.Console.WriteLine();
int [,] newArr = NewArr(myMatrix);
PrintMatrix(newArr);