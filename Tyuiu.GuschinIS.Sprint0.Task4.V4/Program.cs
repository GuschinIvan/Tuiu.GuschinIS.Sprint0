using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GuschinIS.Sprint0.Task4.V4.Lib;

namespace Tyuiu.GuschinIS.Sprint0.Task4.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры программы
            //Вызов метода сложения Addition
            Console.WriteLine(DataService.Addition(1, 5));
            //Вызов метода вычитания Subtraction
            Console.WriteLine(DataServise.Subtraction(15, 5));
            //Вызов метода умножения Multiplication
            Console.WriteLine(DataServise.Multiplication(10, 10));
            //Вызов метода деления Division
            Console.WriteLine(DataServise.Division(5, 5));

            Console.ReadKey();
        }
    }
}
