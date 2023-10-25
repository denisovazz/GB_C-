
 // Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

int[,] GetRandomMatrix(int rows, int columns, int leftBorder, int rightBorder)
{
int[,] matrix = new int[rows, columns];

for(int i = 0; i < matrix.GetLength(0); i++)
{
for(int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i,j] = Random.Shared.Next(leftBorder, rightBorder +1);
}
}
return matrix;
}

int[,] ChangeMatrix(int[,] matrix)
{
int[,] tempMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
for (int i = 0; i < tempMatrix.GetLength(0);i++)
{
for(int j = 0; j < tempMatrix.GetLength(1); j++)
{
tempMatrix[i, j] = matrix[j, i];
}
}
return tempMatrix;
}

void PrintMatrix(int[,] matrix)
{
for(int i = 0; i < matrix.GetLength(0); i++)
{
for(int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j]}\t");
}
Console.WriteLine();
}
}

const int Rows = 3;
const int Columns = 4;
const int LeftBorder = -5;
const int RightBorder = 10;

int[,] myMatrix = GetRandomMatrix(Rows, Columns, LeftBorder, RightBorder);
PrintMatrix(myMatrix);
int[,] myMatrixChange = ChangeMatrix(myMatrix);
PrintMatrix(myMatrixChange);