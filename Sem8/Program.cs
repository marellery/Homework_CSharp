// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.



int rows = new Random().Next(3, 10);
int columns = new Random().Next(3, 10);

int[,] array = new int[rows, columns];

Console.WriteLine("Первоначальный массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + "\t");

    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Упорядоченный массив:");


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1)-1; k++)
        {
            if (array[1,k]<array[1,k+1])
            {
                int temp = array[i,k];
                array[i,k]= array[1,k+1];
                array[1,k+1]=temp;

            }
        }
        Console.Write(array[i, j] + "\t");

    }
    Console.WriteLine();

}

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] array = new int[new Random().Next(3,10),new Random().Next(3,10)];

// Matrix(array);

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }

// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void Matrix (int[,] matrix) {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int[,] matr = new int[matrix.GetLength(0), matrix.GetLength(1)];
//         matr[i, j] = new Random().Next(10);
//         Console.Write($"{matr[i, j]}" + "\t");
//         }
//     Console.WriteLine();
// }
// }


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int rows = new Random().Next(3,10);
// int columns = new Random().Next(3,10);

// int[,] matrixFirst = new int[rows,columns];
// int[,] matrixSecond = new int[rows,columns];


// Console.WriteLine("Первая матрица");
// void Matrix (int[,] matrix) {
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         int[,] matr = new int[rows,columns];
//         matr[i, j] = new Random().Next(10);
//         Console.Write($"{matr[i, j]}" + "\t");
//         }
//     Console.WriteLine();
// }
// }


// Matrix(matrixFirst);
// Console.WriteLine();
// Console.WriteLine("Вторая матрица");
// Matrix(matrixSecond);
// Console.WriteLine();






// Console.WriteLine("Вторая матрица");
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         matrixFirst[i, j] = new Random().Next(10);
//         Console.Write($"{matrixFirst[i, j]}" + "\t");
//         }
//     Console.WriteLine();
// }


// Console.WriteLine();

// Console.WriteLine("Результат умножения");




//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


// int size = 4;
// int[,,] matrix = new int[size, size, size];


// for (int i = 0; i < size; i++)
// {
//     for (int j = 0; j < size; j++)
//     {
//         for (int k = 0; k < size; k++)
//         {
//             matrix[i, j, k] = new Random().Next(10);
//             Console.Write($"{matrix[i, j, k]}" + "("+i + ", " + j + ", " + k + ")" + "\t");
//         }

//     }

//     Console.WriteLine();
// }
// Console.WriteLine();




//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// int size=4;
// int[,] matrix = new int[size, size];
// matrix[0,0]=1;

// for(int i=0; i<size; i++)
// {
//     for (int j = 0; j < size; j++)
//     {
//       matrix[i, j]++;
//       Console.Write($"{matrix[i, j]} "); 

//     }

// Console.WriteLine();
// }
//     Console.WriteLine();




