using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabukovDV.Sprint4.Task7.V8.Lib;

namespace Tyuiu.ShabukovDV.Sprint4.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шабуков Д. В. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Шабуков Д. В. | СМАРТб-23-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр «264795863157». Преобразуйте ее в     *");
            Console.WriteLine("* матрицу 3 на 4 и подсчитайте сумму нечетных чисел                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            dataservice ds = new dataservice();

            int n = 3;
            int m = 4;
            int[,] matrix = new int[n, m];
            string value = "264795863157";

            int index = 0;
            Console.WriteLine("Массив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[index]}" + " ");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, value);
            Console.WriteLine("Сумма нечетных чисел = " + res);

            Console.ReadKey();
        }
    }
}
