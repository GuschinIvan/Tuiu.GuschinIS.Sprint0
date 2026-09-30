using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GuschinIS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.GuschinIS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Иван";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEquel
            Assert.AreEqual("Привет, Иван", res);
        }
    }
}
