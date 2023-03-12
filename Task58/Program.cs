// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                matrix[i, j] = rnd.Next(min, max + 1);
            }
    }
return matrix;
}

int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns]; 
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                matrix[i, j] = rnd.Next(min, max + 1);
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
                Console.Write($"{matrix[i, j], 4} ");
            }
     Console.WriteLine();
    }
}

int[,] array2d = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[,] newArray2d = CreateMatrixRndInt2(4, 4, 0, 10);
PrintMatrix(newArray2d);
Console.WriteLine();
int [,] resultMatrix = new int[4, 4];
MultiplyMatrix(array2d, newArray2d, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(resultMatrix);

void MultiplyMatrix(int[,] array2d, int[,] newArray2d, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array2d.GetLength(1); k++)
      {
        sum += array2d[i,k] * newArray2d[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}



