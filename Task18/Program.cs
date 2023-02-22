﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

string Prompt(string message)
{
    Console.WriteLine(message);
    string num = (Console.ReadLine());
    return num;
}
string Range(string num)
{
    if (num == "1") return "x > 0, y > 0";
    if (num =="2") return "x < 0, y > 0";
    if (num == "3") return "x < 0, y < 0";
    if (num == "4") return "x > 0, y < 0";
    return "0";
}
string number = Prompt("Введите номер четверти");
string range = Range(number);
string result = range == "0" ?
                      "Не существует данной четверти"
                      : $"Диапазон возможных координат точек в этой четверти {range}";
 Console.WriteLine(result);