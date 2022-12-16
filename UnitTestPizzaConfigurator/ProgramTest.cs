using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using NUnit.Framework;
using PizzaConfigurator;

namespace UnitTestProgram
{
    [TestFixture]
    public class ProgramTest
    {
        private static readonly string ExePath = Assembly.GetEntryAssembly()?.Location;
        
        [Test]
        public void TestCreateDirectory()
        {
            // Arrange
            string expectedPathString = @"c:\temp";

            // Act
            Directory.CreateDirectory(expectedPathString);

            // Assert
            Assert.IsTrue(Directory.Exists(expectedPathString));
        }
        [Test]
        public void TestReadDefaultPizzas()
        {
            // Arrange
            var stack = new Program();
            string strWorkPath = @"C:\Users\kramn\RiderProjects\PizzaConfigurator\PizzaConfigurator\bin\Debug\PizzaTypes";
            var directoryInfo = new DirectoryInfo(strWorkPath);
            var defaultPizzas = new List<Pizza>();

            // Act
            var counter = 2;
            foreach (var file in directoryInfo.GetFiles("*.json"))
            {
                var fileName = file.Name.Remove(file.Name.IndexOf(".", StringComparison.Ordinal), 5);
                fileName = fileName.ToUpper();
                var sr = File.OpenText(file.FullName);
                var pizzaString = sr.ReadToEnd();
                var pizza = JsonConvert.DeserializeObject<Pizza>(pizzaString);
                defaultPizzas.Add(pizza);
                Console.WriteLine(counter + " = Upravit " + fileName + " (" + stack.OnlyTrueValuesPizza(pizza) + ")");
                counter++;
            }
            // Assert
            Assert.IsNotEmpty(defaultPizzas);
        }
        [Test]
        public void OnlyTrueValuesPizza_ReturnsExpectedOutput()
        {
            // Arrange
            var stack = new Program();       
            var pizza = new Pizza
            {
                TomatoZaklad = true,
                SyrovyOkraj = false,
                Mozzarela = true
            };

            // Act
            var result = stack.OnlyTrueValuesPizza(pizza);

            // Assert
            Assert.AreEqual("TomatoZaklad, Mozzarela, ", result);
        }
    }
}