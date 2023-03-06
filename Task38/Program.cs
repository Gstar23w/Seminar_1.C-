// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int[] CreateArrayRndInt (int size, int min, int max)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(min, max + 1);
}
return arr;
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

int GetMaxInArray (int[] arr)
{
    int max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if(max <= arr[i]) 
        max = arr[i];
    }
    
    return (max);
}

int GetMinInArray (int[] arr)
{
    int min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if(min >= arr[i]) 
        min = arr[i];
    }

    return (min);
}

int [] arr = CreateArrayRndInt(5, 0, 20);
PrintArray(arr);
GetMaxInArray(arr);
GetMinInArray(arr);
int sum = GetMaxInArray(arr) - GetMinInArray(arr);
Console.WriteLine($"->{sum}");