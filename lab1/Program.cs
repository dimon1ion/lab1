using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_____Framework
{
    class MyClass
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Объявить одномерный (5 элементов ) массив с именем 
            A и двумерный массив (3 строки, 4 столбца) дробных 
            чисел с именем B. Заполнить одномерный массив А 
            числами, введенными с клавиатуры пользователем, 
            а двумерный массив В случайными числами с помощью циклов. 
            Вывести на экран значения массивов: 
            массива А в одну строку, массива В — в виде матрицы.
            Найти в данных массивах общий максимальный 
            элемент, минимальный элемент, общую сумму всех 
            элементов, общее произведение всех элементов, сумму четных элементов массива А,
            сумму нечетных столбцов массива В.*/

            Random rnd = new Random();
            {
                int[] A = new int[5];
                Console.WriteLine("Введите числа для массива: ");
                A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToArray<int>();
                double[,] B = new double[3, 4];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        B[i, j] = rnd.Next(1, 10);
                    }
                }
                Console.WriteLine("Первый массив:");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(A[i]);
                }
                Console.WriteLine("\nВторой массив:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"{B[i, j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                double max = A[0];
                double min = A[0];
                double sum = 0;
                double sumchetn = 0;
                double sumnechetn = 0;
                double proizv = 1;
                for (int i = 0; i < 5; i++)
                {
                    if (max < A[i])
                    {
                        max = A[i];
                    }
                    else if (min > A[i])
                    {
                        min = A[i];
                    }
                    sum += A[i];
                    proizv *= A[i];
                    if (A[i] % 2 == 0)
                    {
                        sumchetn += A[i];
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (max < B[i, j])
                        {
                            max = B[i, j];
                        }
                        else if (min > B[i, j])
                        {
                            min = B[i, j];
                        }
                        sum += B[i, j];
                        proizv *= B[i, j];
                        if (i % 2 == 0)
                        {
                            sumnechetn += B[i, j];
                        }
                    }
                }
                Console.WriteLine($"Сумма всех = {sum}" +
                    $"\nМинимальное число: {min}" +
                    $"\nМаксимальное число: {max}" +
                    $"\nПроизведение: {proizv}" +
                    $"\nСумма четных элементов: {sumchetn}" +
                    $"\nCумма нечетных столбцов: {sumnechetn}");
                Console.WriteLine('\n');
            }

            /*Даны 2 массива размерности M и N соответственно. 
            Необходимо переписать в третий массив общие элементы первых двух массивов без повторени*/

            {
                int M = 10;
                int N = 5;
                int[] a = new int[M];
                int[] b = new int[N];
                int[] c = new int[M + N];
                for (int i = 0; i < M; i++)
                {
                    a[i] = rnd.Next(1, 10);
                    Console.Write(a[i] + " ");
                }
                Console.WriteLine();
                for (int i = 0; i < N; i++)
                {
                    b[i] = rnd.Next(1, 10);
                    Console.Write(b[i] + " ");
                }
                int res = 1;
                for (int i = 0; i < M + N; i++)
                {
                    if (i < M)
                    {
                        c[i] = a[i];
                    }
                    else
                    {
                        c[i] = b[i - M];
                    }
                    for (int j = 0; j < i; j++)
                    {
                        if (c[i] == c[j])
                        {
                            break;
                        }
                        if (j == i - 1)
                        {
                            res++;
                        }
                    }
                }
                int[] d = new int[res];
                d[0] = c[0];
                Console.Write($"\nРезультат:{d[0]}");
                for (int i = 0, k = 0; i < M + N; i++)
                {
                    for (int j = 0; j < i - k; j++)
                    {
                        if (c[i] == d[j])
                        {
                            k++;
                            break;
                        }
                        if (j == i - 1 - k)
                        {
                            d[i - k] = c[i];
                            Console.Write(d[i - k]);
                        }
                    }
                }
                Console.WriteLine('\n');
            }

            /*Пользователь вводит строку. Проверить, является ли 
            эта строка палиндромом. Палиндромом называется 
            строка, которая одинаково читается слева направо 
            и справа налево.*/

            {
                string write;
                Console.WriteLine("Введите предложение: ");
                write = Console.ReadLine();
                bool palindrom = true;
                if (write.Length % 2 == 0)
                {
                    for (int i = 0; i < write.Length / 2; i++)
                    {
                        if (write[i] == write[write.Length - i - 1])
                        {
                            continue;
                        }
                        palindrom = false;
                        break;
                    }
                }
                else
                {
                    palindrom = false;
                }
                if (palindrom)
                {
                    Console.WriteLine("Является палиндромом");
                }
                else
                {
                    Console.WriteLine("Не является палиндромом");
                }
                Console.WriteLine('\n');
            }

            /*Подсчитать количество слов во введенном предложении.*/

            {
                string write4;
                Console.WriteLine("Введите предложение: ");
                write4 = Console.ReadLine();
                int word = 0;
                for (int i = 0; i < write4.Length; i++)
                {
                    if (i == write4.Length - 1)
                    {
                        word++;
                    }
                    if (write4[i] == ' ')
                    {
                        word++;
                    }
                }
                Console.WriteLine($"Количество слов: {word}");
                Console.WriteLine();
            }

            /*Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
            Определить сумму элементов массива, расположенных 
            между минимальным и максимальным элементами*/

            {
                int[,] arr = new int[5, 5];
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        arr[i, j] = rnd.Next(-100, 100);
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                int[] indexmin = { 0, 0 };
                int[] indexmax = { 0, 0 };
                int minarr = arr[0, 0];
                int maxarr = arr[0, 0];
                int summa = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (maxarr < arr[i, j])
                        {
                            maxarr = arr[i, j];
                            indexmax[0] = i;
                            indexmax[1] = j;
                        }
                        if (minarr > arr[i, j])
                        {
                            minarr = arr[i, j];
                            indexmin[0] = i;
                            indexmin[1] = j;
                        }
                    }
                }
                if (indexmin[0] > indexmax[0])
                {
                    int[] index = { 0, 0 };
                    index[0] = indexmin[0];
                    index[1] = indexmin[1];
                    indexmin[0] = indexmax[0];
                    indexmin[1] = indexmax[1];
                    indexmax[0] = index[0];
                    indexmax[1] = index[1];
                }
                else if (indexmin[0] == indexmax[0])
                {
                    if (indexmin[1] > indexmax[1])
                    {
                        int[] index = { 0, 0 };
                        index[0] = indexmin[0];
                        index[1] = indexmin[1];
                        indexmin[0] = indexmax[0];
                        indexmin[1] = indexmax[1];
                        indexmax[0] = index[0];
                        indexmax[1] = index[1];
                    }
                }
                bool start = false;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == indexmin[0] && j == indexmin[1])
                        {
                            start = true;
                            continue;
                        }
                        if (i == indexmax[0] && j == indexmax[1])
                        {
                            start = false;
                            break;
                        }
                        if (start)
                        {
                            summa += arr[i, j];
                        }
                    }
                }
                Console.WriteLine($"Минимум: {minarr}" +
                    $"\nМаксимум: {maxarr}" +
                    $"\nСумма равна: {summa}");
            }
        }
    }
}
