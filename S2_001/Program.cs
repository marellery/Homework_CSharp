//Задача1. Ввести трехзначное число и вывести вторую цифру


Console.WriteLine("Введите трехначное число");
int num =Convert.ToInt32(Console.ReadLine());

int num1 = num/10%10;

if (num<99 || num>999)
{
    Console.WriteLine("Число не из заданного промежутка");
}

else
{
    Console.WriteLine(num1);
}
