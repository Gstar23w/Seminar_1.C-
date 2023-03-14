// Задача 68: Напишите программу вычисления
// функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return AkkermanFunction(m - 1, 1);
    else return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
}

Console.WriteLine($"m = {m}; n = {n} -> A(m,n) = {AkkermanFunction(m, n)}");