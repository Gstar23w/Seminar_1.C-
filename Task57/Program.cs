// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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
int[] MatrixToArray(int[,] matrix)
{
    int c = 0;
    int[] array = new int[matrix.Length];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[c] = matrix[i, j];
            c += 1;
            }
    }
return array;
}
void PrintArray(int[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
else Console.Write($"{arr[i]}");
}
Console.Write("]");
}

void SumElemArray(int[] array)
{
    int count = 1;
    int curentNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == curentNumber) count++;
        else Console.WriteLine($"Число {curentNumber} встречается {count} раз");
        curentNumber = array[i];
        count = 1;
    }
   Console.Write($"Число {curentNumber} встречается {count} раз");
}

int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
int[] arr = MatrixToArray(array2d);
PrintMatrix(array2d);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
Array.Sort(arr);
PrintArray(arr);
SumElemArray(arr);