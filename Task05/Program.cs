Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int index = -number;
while (index <= number)
{
    Console.Write(index + " ");
    index ++;
}
