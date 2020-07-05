using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 5
            //5.	Написать программу, которая выводит на экран таблицу квадратов и кубов целых чисел а от 1 до 10.
            // Столбцы таблицы должны иметь обозначения, например, а, а^2, а^3.

            //for (int a = 0; a < 10; a++) 
            //{ 
            //Console.Write($"a^{a}  ");
            //}

            //Console.WriteLine();

            //for (int b = 0; b < 10; b++)
            //{
            //    for (int c = 0; c < 10; c++)
            //    {
            //        Console.Write($"{c}    ");
            //    }
            //    Console.WriteLine($"{b}    ");
            //}

            //Console.ReadKey();
            #endregion

            #region 6
            //6.	Составить программу печати таблицы температур по Цельсию от 0 до 100 градусов 
            //с шагом в один градус и их эквивалентов по шкале Фаренгейта, используя для перевода формулу tF = 9tc/5 + 32.

            //for (int temperature = 0; temperature < 101; temperature++)
            //{

            //    double tFarinhate = 9 * temperature / 5 + 32;
            //    Console.WriteLine($"Градус Цельсія: {temperature} = {tFarinhate} F");

            //}
            //Console.ReadKey();
            #endregion

            #region 13
            //13.	Напечатать таблицу перевода 1, 2, ..., 20 долларов США в гривни по текущему курсу (курс вводится с клавиатуры).

            //Console.Write("Ведіть курс валюти: ");
            //string a = Console.ReadLine();
            //double currency = Double.Parse(a.Replace('.', ','));



            //for (double money = 1; money <= 100; money++)
            //{
            //    double dollars = money * currency;
            //    Console.WriteLine($"UAH {money} - {dollars} $");
            //}
            //Console.ReadKey();
            #endregion

            #region 15
            //15.	Распечатать в «столбик» таблицу умножения на 7.
            //for (int a = 0; a < 10; a++)
            //{
            //    Console.Write($"{a}  ");
            //}
            //Console.WriteLine();
            //for (int b = 0; b < 10; b++)
            //{
            //    Console.Write("*  ");
            //}
            //Console.WriteLine();
            //for (int c = 0; c < 10; c++)
            //{
            //    Console.Write("7  ");
            //}
            //Console.WriteLine();
            //for (int d = 0; d < 10; d++)
            //{
            //    int result = d * 7;
            //    Console.Write($"{result} ");
            //}
            //Console.ReadKey();
            #endregion

            #region 115
            //115.	Ежемесячная стипендия студента составляет А грн., а расходы на проживание превышают стипендию и составляют В грн. в месяц.
            //Рост цен ежемесячно увеличивает расходы на 3 %. 
            //Составьте программу расчета суммы денег, которую необходимо единовременно
            //попросить у родителей, чтобы можно было прожить учебный год (10 месяцев), используя только эти деньги и стипендию.
            //for (double grants = 0; grants < 10; grants++)

            //    {
            //        double myExpenses = 1200 + (1200* 0.03)-(grants+1000);
            //    Console.WriteLine($"Money parents: {myExpenses}");
            //}

            //Console.ReadKey();
            #endregion

            #region 23
            /*
             * 23.	Напечатать таблицу стоимости 50, 100, 150, ..., 1000 г сыра 
             * (стоимость 1 кг сыра вводится с клавиатуры).
            */
            //Console.Write("Ведіть ціну(1 кг): ");
            //string a = Console.ReadLine();
            //double price = Double.Parse(a.Replace(',', '.'));

            //double minPrice = price / 1000;

            //double mass = 0;
            //while (mass <= 1000)
            //{
            //    double allPrice = mass * minPrice;
            //    Console.WriteLine($"{mass} - {allPrice}");
            //    mass++;
            //}
            //Console.ReadKey();
            #endregion

           








        }



    }
}
