using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace PizzaConfigurator
{
    internal class Program
    {
        private const string ordersPath = @"c:\temp\orders.json";
        private const string favoritePath = @"c:\temp\favorites.json";
        private const string pathString = @"c:\temp";
        private static readonly string exePath = Assembly.GetEntryAssembly()?.Location;

        public static void Main(string[] args)
        {
            Directory.CreateDirectory(pathString);
            var program = new Program();
            program.Start();
        }

        private void Start()
        {
            Console.Clear();
            Console.WriteLine("------------Pizza konfigurátor------------");
            Console.WriteLine("1 = Sestavení nové pizza");
            Console.WriteLine("2 = Seznam oblíbených pizza");
            Console.WriteLine("3 = Výběr ze základních pizza");
            Console.WriteLine("4 = Odejít");
            while (true)
                switch (KeyInput())
                {
                    case 1:
                        //Sestaveni pizza from scratch
                        var pizza = new Pizza();
                        Phase(1, pizza);
                        return;
                    case 2:
                        //Oblibené pizzy
                        ShowFavoritePizza();
                        return;
                    case 3:
                        //Select and edit default pizza
                        ShowDefaultPizza();
                        return;
                    case 4:
                        //End
                        Environment.Exit(0);
                        return;
                    default:
                        continue;
                }
        }

        private void ShowDefaultPizza()
        {
            Console.Clear();
            Console.WriteLine("------------Základní pizzy------------");
            Console.WriteLine("1 = Zpátky");
            var strWorkPath = Path.GetDirectoryName(exePath) + "\\PizzaTypes";
            var directoryInfo = new DirectoryInfo(strWorkPath);
            var defaultPizzas = new List<Pizza>();
            var counter = 2;
            foreach (var file in directoryInfo.GetFiles("*.json"))
            {
                var fileName = file.Name.Remove(file.Name.IndexOf(".", StringComparison.Ordinal), 5);
                fileName = fileName.ToUpper();
                var sr = File.OpenText(file.FullName);
                var pizzaString = sr.ReadToEnd();
                var pizza = JsonConvert.DeserializeObject<Pizza>(pizzaString);
                defaultPizzas.Add(pizza);
                Console.WriteLine(counter + " = Upravit " + fileName + " (" + WriteOnlyTrueValues(pizza) + ")");
                counter++;
            }

            while (true)
                switch (KeyInput())
                {
                    case 1:
                        Main(new string[] { });
                        return;
                    case 2:
                        if (defaultPizzas.Count < 1) continue;

                        Phase(1, defaultPizzas[0]);
                        return;
                    case 3:
                        if (defaultPizzas.Count < 2) continue;

                        Phase(1, defaultPizzas[1]);
                        return;
                    case 4:
                        if (defaultPizzas.Count < 3) continue;

                        Phase(1, defaultPizzas[2]);
                        return;
                    case 5:
                        if (defaultPizzas.Count < 4) continue;

                        Phase(1, defaultPizzas[3]);
                        break;
                    case 6:
                        if (defaultPizzas.Count < 5) continue;

                        Phase(1, defaultPizzas[4]);
                        return;
                    case 7:
                        if (defaultPizzas.Count < 6) continue;

                        Phase(1, defaultPizzas[5]);
                        return;
                    case 8:
                        if (defaultPizzas.Count < 7) continue;

                        Phase(1, defaultPizzas[6]);
                        return;
                    case 9:
                        if (defaultPizzas.Count < 8) continue;

                        Phase(1, defaultPizzas[7]);
                        return;
                    default:
                        continue;
                }
        }

        private static void SavePizzaToOrders(Pizza pizza)
        {
            var jsonPizza = JsonConvert.SerializeObject(pizza);
            SavePizzaToOrdersFile(jsonPizza);
            SaveToFavorite(jsonPizza);
        }

        private static void SavePizzaToOrdersFile(string jsonPizza)
        {
            var text = jsonPizza;
            try
            {
                // Create the file, or overwrite if the file exists.
                if (File.Exists(ordersPath))
                {
                    var lineCount = File.ReadLines(ordersPath).Count();
                    text = string.Join("\n", File.ReadAllLines(ordersPath)) + "\n" + (lineCount + 1) + ": " + text;
                }
                else
                {
                    text = "1: " + text;
                }

                using (var fs = File.Create(ordersPath))
                {
                    var info = new UTF8Encoding(true).GetBytes(text);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

                // Open the stream and read it back.
                using (var sr = File.OpenText(ordersPath))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null) Console.WriteLine(s);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static void SaveToFavorite(string jsonPizza)
        {
            Console.Clear();
            Console.WriteLine("Uložit pizzu do oblíbených?");
            Console.WriteLine("1 = Ano");
            Console.WriteLine("2 = Ne");
            while (true)
            {
                var key = KeyInput();
                if (key == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Název?");
                    var favoritePizzaName = Console.ReadLine();
                    SaveToFavoriteFile(jsonPizza, favoritePizzaName);
                    Main(new string[] { });
                }
                else if (key == 2)
                {
                    Main(new string[] { });
                    break;
                }
            }
        }

        private static void SaveToFavoriteFile(string jsonPizza, string favoritePizzaName)
        {
            var text = jsonPizza;
            var path = @"c:\temp\favorites.json";
            try
            {
                // Create the file, or overwrite if the file exists.
                if (File.Exists(path))
                {
                    var lineCount = File.ReadLines(path).Count();

                    text = string.Join("\n", File.ReadAllLines(path)) + "\n" + (lineCount + 1) + ": " +
                           favoritePizzaName + " " + text;
                }
                else
                {
                    text = "1: " + favoritePizzaName + " " + text;
                }

                using (var fs = File.Create(path))
                {
                    var info = new UTF8Encoding(true).GetBytes(text);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

                // Open the stream and read it back.
                using (var sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null) Console.WriteLine(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ShowFavoritePizza()
        {
            Console.Clear();
            Console.WriteLine("------------Oblébené pizzy------------");
            Console.WriteLine("1 = Zpět");
            if (File.Exists(favoritePath))
            {
                //List<Pizza> favoritePizzas = new List<Pizza>();

                foreach (var line in File.ReadLines(favoritePath))
                {
                    var jsonLine = line.Remove(0, line.IndexOf("{", StringComparison.Ordinal));
                    var name = line.Remove(line.IndexOf("{", StringComparison.Ordinal),
                        line.Length - line.IndexOf("{", StringComparison.Ordinal));
                    var pizza = JsonConvert.DeserializeObject<Pizza>(jsonLine);
                    //favoritePizzas.Add(pizza);
                    Console.WriteLine(name + ": " + WriteOnlyTrueValues(pizza));
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Nemáte žádné oblíbené pizzy");
                Console.WriteLine("1=Zpět");
            }

            while (true)
            {
                var keyInput = KeyInput();
                if (keyInput == 1)
                {
                    Main(new string[] { });
                    return;
                }
            }
        }

        private string WriteOnlyTrueValues(Pizza pizza)
        {
            var text = "";
            var properties = typeof(Pizza).GetProperties();

            foreach (var property in properties)
                try
                {
                    if (bool.Parse(property.GetValue(pizza).ToString()))
                        text = text + property.Name + ", ";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            return text;
        }

        public static void Phase(int phase, Pizza pizza)
        {
            switch (phase)
            {
                case 1:
                    pizza.SelectBase(pizza);
                    break;
                case 2:
                    pizza.SelectCheeseBase(pizza);
                    break;
                case 3:
                    pizza.SelectSyry(pizza);
                    break;
                case 4:
                    pizza.SelectUzeniny(pizza);
                    break;
                case 5:
                    pizza.SelectMaso(pizza);
                    break;
                case 6:
                    pizza.SelectOstatni(pizza);
                    break;
                case 7:
                    SavePizzaToOrders(pizza);
                    break;
            }
        }

        public static int KeyInput()
        {
            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.NumPad1:
                    return 1;
                case ConsoleKey.NumPad2:
                    return 2;
                case ConsoleKey.NumPad3:
                    return 3;
                case ConsoleKey.NumPad4:
                    return 4;
                case ConsoleKey.NumPad5:
                    return 5;
                case ConsoleKey.NumPad6:
                    return 6;
                case ConsoleKey.NumPad7:
                    return 7;
                case ConsoleKey.NumPad8:
                    return 8;
                case ConsoleKey.NumPad9:
                    return 9;

                case ConsoleKey.D1:
                    return 1;
                case ConsoleKey.D2:
                    return 2;
                case ConsoleKey.D3:
                    return 3;
                case ConsoleKey.D4:
                    return 4;
                case ConsoleKey.D5:
                    return 5;
                case ConsoleKey.D6:
                    return 6;
                case ConsoleKey.D7:
                    return 7;
                case ConsoleKey.D8:
                    return 8;
                case ConsoleKey.D9:
                    return 9;
                default:
                    return 0;
            }
        }
    }
}