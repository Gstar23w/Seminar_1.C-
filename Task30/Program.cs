﻿// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


Console.WriteLine("Сколько эллементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = NewArray(num, 0, 1);
Console.WriteLine($"Полученый массив из {num} эллементов");
PrintArray(arr);

int[] NewArray(int num, int min, int max)
{
int[] arr = new int[num];
for (int i = 0; i < num; i++)
{
arr[i] = new Random().Next(min, max+1);
}
return arr;
}
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
}