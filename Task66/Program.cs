// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());

int SumNumbers (int M, int N)
{
    if (M == N) return N;     
    return N += SumNumbers(M, N - 1);
}

Console.WriteLine($"M = {M}; N = {N} -> {SumNumbers(M, N)}");
