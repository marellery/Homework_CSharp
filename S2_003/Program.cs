// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели");
int num =Convert.ToInt32(Console.ReadLine());



    
if (num<1 || num>7)
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    if (num==6 || num==7)
    {
        Console.WriteLine("УРА!!ВЫХОДНОЙ!");
    }
    else
    {
        Console.WriteLine("Это будний день...");
    }
    
}
