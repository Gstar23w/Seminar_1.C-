// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int numberM = int.Parse(Console.ReadLine());

int SumNumber(int n)
{
if (n == 0) return 0;
else return (n % 10) + SumNumber(n / 10);
}

Console.WriteLine($"{SumNumber(numberM)}");

