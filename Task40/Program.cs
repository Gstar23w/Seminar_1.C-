// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите три числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

bool IsTreangleExists (int num1, int num2, int num3)
{
if (number1 + number2 > number3 && number2 + number3 > number1 && number1 + number3 > number2) return true;
else return false;
}

bool result=IsTreangleExists(number1, number2, number3);
Console.WriteLine(result ? "Да" : "Нет");

