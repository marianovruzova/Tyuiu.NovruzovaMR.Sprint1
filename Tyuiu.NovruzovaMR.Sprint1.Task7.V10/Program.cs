using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NovruzovaMR.Sprint1.Task7.V10.Lib;

namespace Tyuiu.NovruzovaMR.Sprint1.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Новрузова М. Р. | АСОиУБ-23-3";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *");
            Console.WriteLine("* Задание #7                                                         *");
            Console.WriteLine("* Вариант #10                                                           *");
            Console.WriteLine("* Выполнил: Новрузова Мария Руслановна | АСОиУБ-23-3                   *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("*                  ln cos x                                            *");
            Console.WriteLine("* z =  2ctg(3x) - -----------                                          *");
            Console.WriteLine("*                         2                                            *");
            Console.WriteLine("*                  ln( 1+x )                                           *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            int x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("z = " + ds.Calculate(x));

            Console.ReadLine();
        }
    }
}