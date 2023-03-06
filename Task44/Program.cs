// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int[] FibonacciArray(int num)
{
int[] fibArr = new int[num];
fibArr[0] = 0;//можно не писать
if (num > 1) fibArr[1] = 1;
for (int i = 2; i < num; i++)
{
fibArr[i] = fibArr[i - 1] + fibArr[i - 2];
}
return fibArr;
}

void PrintArray(int[] arr)
{

for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr[i]} ");
}

}


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] fibonacciArray = FibonacciArray(number);
PrintArray(fibonacciArray);