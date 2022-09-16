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
//         matrix[i,j]=new Random().NextDouble()*5;
//         Console.Write(matrix[i,j]+"\t");

        
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

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]=new Random().Next(1,10);
//         Console.Write(matrix[i,j]+"\t");
        
//     }

//     Console.WriteLine();
// }
// Console.WriteLine();




// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     if (rowsearch<i)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (columnsearch<j)
//             {
//                 matrix[rowsearch,columnsearch]=matrix[i,j];
//                 Console.WriteLine(matrix[rowsearch,columnsearch]+"-Искомый элемент");
                
//             }
//             else
//             {
//             Console.WriteLine("Элемент не существует");
                       
//             }
//             break; 
//         }
//     }
// }
    
            
    
    
  


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

for(int m = 0; m < columns; m++)
    {
        Search (matrix);
        Console.Write(String.Join(", ", arif/rows));
    }
   



void Search (int[,] matrix)
{

 for(int m = 0; m < rows; m++)
{
    
    int n=0;
    arif=(arif+matrix[m, n]);
              
}
}


