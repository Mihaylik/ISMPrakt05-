using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ISMPrakt05ClassLibrary;


namespace ISMPrakt05ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods method = new Methods();
            long n=0;
            
            Console.Write("Введите число элментов массива:\nN = ");
            try
            {
                n = long.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Error("Число элементов должно быть больше нуля!");
                    Main(args);
                }
            }
            catch
            {
                 Error("Введено неправильное значение!");
                 Main(args);
            }
            int[] arr = method.FillArrayWhithRandVall(n);
            Console.WriteLine("Массив:");
            for (long i=0;i<arr.Length;i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
            DoOperation(arr, method, args);
            Console.ReadKey();
        }
        static void DoOperation(int[] arr, Methods method, string[] args)
        {
            Console.Write("Выберите одну из операций:\n1. Сумма отрицательных элементов массива.\n2. Максимальный среди парных элементов массива.\n3. Произведение элементов массива с парными индексами.\n4. Индекс максимального элемента массива.\n5. Максимальный за модулем элемент массива.\n6. Сумма индексов положительных элемнтов.\n7. Кл-во непарных элементов массива.\n8. Переписать массив.\n№ ");
            int num = SetNumEl();
            switch (num)
            {
                case 1:
                    {
                        long res = method.SumNegEls(arr);
                        Console.Write("Сумма отрицательных элементов массива: " + res+"\n");
                        Thread.Sleep(2000);
                        DoOperation(arr, method, args);
                    }
                    break;
                case 2:
                    {
                        long[] element = method.MaxOfPairEl(arr);
                        if (element[0] == -1) Console.Write("В массиве нету парных элементов!\n");
                        else Console.Write($"Максимальный среди парных элементов массива: arr[{element[0]}] = {element[1]}\n");
                        Thread.Sleep(2000);
                        DoOperation(arr, method, args);
                    }
                    break;
                case 3:
                    {
                        long res = method.DobElWhithPairIndex(arr);
                        Console.Write("Произведение элементов массива с парными индексами: " + res+"\n");
                        Thread.Sleep(2000);
                        DoOperation(arr, method, args);
                    }
                    break;
                case 4:
                    {
                        long res = method.IndexMaxEl(arr);
                        Console.Write("Индекс максимального элемента массива: " + res+"\n");
                        Thread.Sleep(2000);
                        DoOperation(arr, method, args);
                    }
                    break;
                case 5:
                    {
                        long[] element = method.MaxOfAbsEl(arr);
                        Console.Write($"Максимальный за модулем элемент массива: arr[{element[0]}] = {element[1]}\n");
                        Thread.Sleep(2000);
                        DoOperation(arr, method, args);
                    }
                    break;
                case 6:
                    {
                        long res = method.SumIndexPossEl(arr);
                        if (res == -1) Console.Write("Положительных элементов не найдено!\n");
                        else Console.Write("Сумма индексов положительных элемнтов: " + res+"\n");
                        Thread.Sleep(2000);
                        DoOperation(arr, method, args);
                    }
                    break;
                case 7:
                    {
                        long res = method.ColsAnPairEl(arr);
                        if (res == -1) Console.Write("Парных элементов не найдено!\n");
                        else Console.Write("Кл-во непарных элементов массива: " + res+"\n");
                        Thread.Sleep(2000);
                        DoOperation(arr, method, args);
                    }
                    break;
                default:
                    {
                        Thread.Sleep(1000);
                        Main(args);
                    }break;
            }
        }
        static int SetNumEl()
        {
            int num = 0;
            try
            {
                num = int.Parse(Console.ReadLine());
                if (num < 1 || num>8)
                {
                    Console.WriteLine("Введите число от 1 до 8\n№ ");
                    SetNumEl();
                }
            }
            catch
            {
                Console.WriteLine("Введите число от 1 до 8\n№ ");
                SetNumEl();
            }
            return num;
        }
        static void Error(string message)
        {
            Console.WriteLine(message);
            Thread.Sleep(1500);
            Console.Clear();
            
        }
    }
}
