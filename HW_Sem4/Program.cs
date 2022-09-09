
//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.WriteLine("Введите Х:");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y:");
// int Y = Convert.ToInt32(Console.ReadLine());

// double num = Math.Pow(X, Y);
// Console.WriteLine(X+ " в степени "+ Y+ " равняется "+ num);








//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число:");
// !!!!!!!!!!!!!!!!!!!!    //string num = Convert.ToString(Console.ReadLine());

// !!!!!!!!!!!!!!!!!!!!!   //int sum = (int) char.GetNumericValue(num[0]);
// Console.WriteLine(sum);
int num = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine(GetSum(num));

int GetSum(int number)
{
    int sum=0;

    while (number>0)
    {
        sum+=number%10;
        number/=10;
    }
    return sum;
}

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Console.WriteLine("Старт");
// Console.WriteLine();

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1,100);
//         index++;
//     }

// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine (col[position]);
//         position++;
//     }
// }

// int [] array = new int [8];

// FillArray(array);
// PrintArray(array);

// Console.WriteLine();

