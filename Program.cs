// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число N: ");

// int N = Convert.ToInt32(Console.ReadLine());
// /// <summary>
// /// Печать чисел от 1 до N
// /// </summary>
// /// <param name="start"> левая граница (1)</param>
// /// <param name="end"> правая граница (N)</param>
// /// <returns>строчку с числами от 1 до N</returns>
// string GetStringOfNumbers(int start, int end)
// {
//     // Базовый случай - выход 
//     if (start == end) return start.ToString(); 

//     // Рекурсивный случай 
//     return start + ", " + GetStringOfNumbers(start - 1, end);
// }
// Console.WriteLine($" '{GetStringOfNumbers(N, 1)}' "); // start = N, end = 1




// // Домашнее задание из презентации:
// Console.Write("Введите число M: ");

// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");

// int N = Convert.ToInt32(Console.ReadLine());

// string NaturalNumbers(int M, int N)
// {
//     // Базовый случай - выход 
//     if (M == N) return M.ToString(); 

//     // Рекурсивный случай 
//     return M + ", " + NaturalNumbers(M + 1, N);
// }
// Console.WriteLine($" Все натуральные числа от M до N '{NaturalNumbers(M, N)}' "); 








// // // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // // M = 1; N = 15 -> 120
// // // M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SumFromMToN(m, n);

// // вызов функции "сумма чисел от M до N"
// void SumFromMToN(int m, int n)
// {
//     Console.Write(SumMN(m - 1, n));
// }

// // функция сумма чисел от M до N
// int SumMN(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }


Console.Write("Введите число M: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");

int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int M, int N)
{
    // Базовый случай - выход 
    int result = M;
    if (M == N) return N;

    // Рекурсивный случай 
    else
    {
       return M + SumNumbers(M + 1, N);
    }
}



Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {SumNumbers(m,n)}");           