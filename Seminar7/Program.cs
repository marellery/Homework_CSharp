// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.WriteLine("Сколько чисел вы хотите ввести?");
// int repeat = Convert.ToInt32(Console.ReadLine());
// int index=0;

// for (int i = 0; i < repeat; i++)
// {
//     Console.WriteLine("Введите число");
//     int num = Convert.ToInt32(Console.ReadLine());

//     if (num<0)
//     {
//         index++;
//     }
//     else
//     {
//         index=index;
//     }
// }

// Console.WriteLine("Отрицательных чисел: "+index+".");


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем


Console.WriteLine("Введите k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1==k2&&b1!=b2)
{
    Console.WriteLine("Линии параллельны");
}
else
{
    double x=(b2-b1)/(k1-k2);
    double y=k1*x+b1;

Console.WriteLine("Точка перечечения: "+ x + "; "+ y+".");
}
