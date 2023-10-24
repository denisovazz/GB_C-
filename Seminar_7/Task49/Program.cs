
int[,] GetMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows,colums];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i+j;
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

void NewMatrix(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if (i%2!=0 && j%2!=0)
           {
            matrix[i,j] = matrix[i,j] * matrix[i,j];
        }
        }
       
    }
}

const int Rows = 5;
const int Colums = 5;


int[,] myMatrix = GetMatrix(Rows, Colums);
PrintMatrix(myMatrix);
NewMatrix(myMatrix);
System.Console.WriteLine();
PrintMatrix(myMatrix);