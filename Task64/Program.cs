// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

int NaturalNumbersFromN(int n)
{    
    if (n == 0) return 1;
        if (n - 1 == 0) Console.WriteLine($"{n}\"");
        else Console.Write($"{n}, ");        
    return n - NaturalNumbersFromN(n - 1);
}

Console.Write($"N = {n} -> \"");
NaturalNumbersFromN(n);