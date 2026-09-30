using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.Guschin.Sprint0.Task6.V2.Lib;

namespace Tyuiu.Guschin.Sprint0.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5 };

            //Пример циклической структуры находится в библиотеке классов в методе AdditionArray
            Console.WriteLine("Сумма элементов массивов =" + DataService.AdditionArray(arraynums));

            //Пример циклической структуры находится в библиотеке классов в методе SubtractionArray
            Console.WriteLine("Разность элементов массивов =" + DataService.SubtractionArray(arraynums));

            //Пример циклической структуры находится в библиотеке классов в методе MultiplicationArray
            Console.WriteLine("Произведение элементов массивов =" + DataService.MultiplicationArray(arraynums));

            Console.ReadKey();
        }
    }
}
