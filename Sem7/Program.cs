//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.WriteLine("Введите количество столбцов");

// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество строк");

// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// double[,] matrix = new double [rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]=new Random().NextDouble()*(-10-100);
//         Console.Write(Math.Round(matrix[i,j], 2)+"\t");

        
//     }

//     Console.WriteLine();

// }
// Console.WriteLine();




//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.WriteLine("Введите номер столбца");
// int rowsearch = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер строки");
// int columnsearch = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// int rows = new Random().Next(1,11);
// int columns = new Random().Next(1,11);
// Console.WriteLine("Столбцов: "+rows);
// Console.WriteLine("Строк: "+columns);
// Console.WriteLine();



// int[,] matrix = new int [rows, columns];

// for (int i = 1; i < matrix.GetLength(0); i++)
// {
//     for (int j = 1; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]=new Random().Next(1,10);
//         Console.Write(matrix[i,j]+"\t");
        
//     }

//     Console.WriteLine();
// }
// Console.WriteLine();



//  if (rowsearch>rows || columnsearch> columns)
//             {
//                Console.WriteLine("Элемент не существует");
                               
//             }
//             else
//             {
            
//                   Console.WriteLine(matrix[rowsearch,columnsearch]+"-Искомый элемент");     
//             }
              
            
    
    
  


//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

int rows = new Random().Next(1,10);
int columns = new Random().Next(1,10);
double arif = 0;



int[,] matrix = new int [rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j]=new Random().Next(1,10);
        Console.Write(matrix[i,j]+"\t");
        
    }

    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("----------------------------");


for (int i = 0; i < columns; i++)
{
    double sum=0;
    for (int j = 0; j < rows; j++)
    {
        sum+=matrix[i,j];
    }
    Console.WriteLine($"{Math.Round(sum/columns-1, 2)}");

}




