// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns]; // 0 , 1
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++) // rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns
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


int SumRowElem(int[,] matrix, int i)
{
    int sumRow = matrix[i,0];
    for (int j = 1; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i,j];
        }
  return sumRow;
}

void GetResult (int[,] matrix)
{
    int minSumRow = 0;
    int sumRow = SumRowElem(matrix, 0);
    for (int i = 1; i < matrix.GetLength(0); i++)
        {
            int tempSumRow = SumRowElem(matrix, i);
            if (sumRow > tempSumRow)
            {
                sumRow = tempSumRow;
                minSumRow = i;
            }
        }
Console.WriteLine($"{minSumRow+1} - строкa с наименьшей суммой элементов. Сумма элементов в строке равна {sumRow}.");
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
GetResult(array2d);