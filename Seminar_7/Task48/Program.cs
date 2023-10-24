
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


const int Rows = 3;
const int Colums = 4;


int[,] myMatrix = GetMatrix(Rows, Colums);
PrintMatrix(myMatrix);