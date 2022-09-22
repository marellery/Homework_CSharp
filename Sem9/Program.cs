// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// Console.WriteLine("ВВедите M:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("ВВедите N:");
// int N = Convert.ToInt32(Console.ReadLine());

// string Natural (int N, int M)
// {
//     if (N<M)
//     {
//         return $"{N}"+"  "+Natural(N+1,M);
//     }
//      if (N>M)
//     {
//         return $"{M}"+"  "+Natural(M+1,N);
//     }
//     else return string.Empty;

// }
// Console.WriteLine(Natural (N, M));


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.WriteLine("Введите M:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите N:");
// int N = Convert.ToInt32(Console.ReadLine());
// int sum =0;

// int NaturalSum (int N, int M)
// {
//     if (N<=M) 
//     {
//         for (int i = N; i < M; i++)
//         {
//             sum=sum+N;
//         }
//         return sum;
//     }
//     if (N>=M) 
//     {
//         for (int i = M; i < N; i++)
//         {
//             sum=sum+M;
//         }
//         return sum;
//     }
//     else return sum;
// }
// Console.WriteLine(NaturalSum(M,N));



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.



// int AkkermanFunc(int m, int n)
// 		{
// 			if(m == 0)
// 			{
// 				return n + 1;
// 			}
// 			if(m > 0 && n == 0)
// 			{
// 				return AkkermanFunc(m - 1, 1);
// 			}
// 			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
// 		}
		
// 		Console.WriteLine(AkkermanFunc(2,2));
	