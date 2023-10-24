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


const int Rows = 3;
const int Colums = 4;
const int LeftBorder = -5;
const int RightBorder = 100;

int[,] myMatrix = GetRandomMatrix(Rows, Colums, LeftBorder, RightBorder);
PrintMatrix(myMatrix);