// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(100,1000);
//         index++;
//     }

// }

// int [] array = new int [5];
// FillArray(array);


// int length = array.Length;
// int count=0;

// for (int i = 0; i < length; i++)
// {
//     if (array[i]%2==0)
//     {
//         count++;
//     }
  
// }
// Console.WriteLine(String.Join(", ", array));
// Console.WriteLine(count);






//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int [] array = new int [10];
// int length = array.Length;
// int sum=0;

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1,101);
//         index++;
//     }

// }

// FillArray(array);
// Console.WriteLine(String.Join(", ", array));

// for (int i = 1; i < length; i=i+2)
// {
       
//     sum+=array[i];
// }

// Console.WriteLine(sum);





//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


int [] array = new int [3];
int length = array.Length;

int max=array[0];
int min=array[0];




void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,101);
        index++;
    }

}

FillArray(array);



// for (int i = 0; i < length; i++)
//     {
//         if (array[i]>max)
//         {
//             int maxval=array[i];
//             max=maxval;
          
//         }
       
//     }

for (int j = 0; j < length; j++)
{
    if (array[j]<min)
    {
        int minval=array[j];
        min=minval;
        
    }
}


// int dif=max-min;


// Console.WriteLine("Maximum "+max);
Console.WriteLine("Минимальное = "+ min);
// Console.WriteLine("Дельта = ", dif);
Console.WriteLine(String.Join(", ", array));
