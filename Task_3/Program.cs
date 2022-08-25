// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int numberPar = number % 2;


if (numberPar==0)
{
    Console.WriteLine ("Это четное число");
}

else
{
     Console.WriteLine ("Это НЕ четное число");
}

