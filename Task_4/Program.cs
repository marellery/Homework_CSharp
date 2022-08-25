// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int number1 = number % 2;

if (number1>1&&number1<number)
{
    Console.WriteLine(number1);
    number1++;
}






