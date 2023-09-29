using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_lab15;

namespace ConsoleApp_lab15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер первого массива:");
            int sizeArr1 = int.Parse(Console.ReadLine());
            Arr arr1 = new Arr(sizeArr1);
            Console.WriteLine("Введите элементы первого массива (через Enter)");
            for (int i = 0; i < sizeArr1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Введённый массив: {arr1.ToString()}");
            Console.WriteLine(arr1.ToString());
            Console.WriteLine($"Сумма элементов массива: {arr1.Summ()}");
            Console.WriteLine();

            Console.WriteLine("Первый массив увеличенный на единицу:");
            arr1++;
            Console.WriteLine(arr1.ToString());
            Console.WriteLine($"Сумма элементов массива: {arr1.Summ()}");
            Console.WriteLine();

            Console.WriteLine("Первый массив уменьшенный на единицу:");
            arr1 -= 2;
            Console.WriteLine(arr1.ToString());
            Console.WriteLine($"Сумма элементов массива: {arr1.Summ()}");
            Console.WriteLine();
            arr1++;

            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Arr arr2 = new Arr(sizeArr1);
            Console.WriteLine("Введите элементы второго массива (через Enter)");
            for (int i = 0; i < sizeArr1; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Первый массив:");
            Console.WriteLine(arr1.ToString());
            Console.WriteLine();

            Console.WriteLine("Второй массив:");
            Console.WriteLine(arr2.ToString());
            Console.WriteLine();

            Console.WriteLine("Сумма двух массивов:");
            Console.WriteLine((arr1 + arr2).ToString());
            Console.WriteLine();

            Console.WriteLine("Разность двух массивов:");
            Console.WriteLine((arr2 - arr1).ToString());
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Первый массив:");
            Console.WriteLine(arr1.ToString());
            Console.WriteLine();

            Console.WriteLine("Функция по варианту");
            Console.WriteLine($"Y = {arr1.F()}");

            Console.WriteLine("Нажмите любую клавишу чтобы завершить программу");
            Console.ReadKey();
        }
    }
}