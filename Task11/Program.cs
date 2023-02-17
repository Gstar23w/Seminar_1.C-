// Напишите программу , которая выводит 
// случайное трехзначное число и удаляет 
// вторую цифру этого числа 

//int number = new Random().Next(100, 1000);
//Console.WriteLine($"Случайцное число из отрезка 10 - 99 => {number}");
//int firstDigit = number / 100;
//int lastDigit = number % 10;
//int result = firstDigit * 10 + lastDigit;
//Console.WriteLine(result);

int number = new Random().Next(100, 1000);
Console.WriteLine($"Число в диапазоне 100 - 999 : {number}");
int newNumber = NewNumber(number);
Console.WriteLine($"Новое число , полученное из первой и последней цифры случайного числа - {newNumber}");
int NewNumber(int num)
{
   int firstDigit = num / 100;
   int secondDigit = num % 10;
   int result = firstDigit * 10 + secondDigit;
   return result;
}

