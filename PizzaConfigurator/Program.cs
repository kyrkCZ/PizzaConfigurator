using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PizzaConfigurator
{
    class Program
    {
        private static readonly string exePath = System.Reflection.Assembly.GetEntryAssembly().Location;
        const string ordersPath = @"c:\temp\orders.json";
        const string favoritePath = @"c:\temp\favorites.json";
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("------------Pizza konfigurátor------------");
            Console.WriteLine("1 = Sestavení nové pizza");
            Console.WriteLine("2 = Seznam oblíbených pizza");
            Console.WriteLine("3 = Výběr ze základních pizza");
            Console.WriteLine("4 = Odejít");
            while (true)
            {
                switch (KeyInput())
                {
                    case 1:
                        //Sestaveni pizza from scratch
                        Pizza pizza = new Pizza();
                        Phase(1, pizza);
                        break;
                    case 2:
                        //Oblibené pizzy
                        ShowFavoritePizza();
                        break;
                    case 3:
                        //Select and edit default pizza
                        ShowDefaultPizza();
                        break;
                    case 4:
                        //End
                        System.Environment.Exit(0);
                        break;
                    default:
                        continue;
                }
                continue;
            }
        }

        private void ShowDefaultPizza()
        {
            Console.Clear();
            Console.WriteLine("------------Základní pizzy------------");
            Console.WriteLine("1 = Zpátky");
            string strWorkPath = System.IO.Path.GetDirectoryName(exePath) + "\\PizzaTypes";
            DirectoryInfo directoryInfo = new DirectoryInfo(strWorkPath);
            List<Pizza> defaultPizzas = new List<Pizza>();
            int counter = 2;
            foreach (var file in directoryInfo.GetFiles("*.json"))
            {
                String fileName = file.Name.Remove(file.Name.IndexOf("."), 5);
                fileName = fileName.ToUpper();
                StreamReader sr = File.OpenText(file.FullName);
                string pizzaString = sr.ReadToEnd();
                Pizza pizza = JsonConvert.DeserializeObject<Pizza>(pizzaString);
                defaultPizzas.Add(pizza);
                Console.WriteLine(counter + " = " + fileName + ": " + pizzaString);
                counter++;
            }

            while (true)
            {
                switch (KeyInput())
                {
                    case 1:
                        Main(new string[] { });
                        break;
                    case 2:
                        if (defaultPizzas.Count < 1)
                        {
                            
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                }
            }
            
        }

        private static void SavePizzaToOrders(Pizza pizza)
        {
            string jsonPizza = JsonConvert.SerializeObject(pizza);
            SavePizzaToOrdersFile(jsonPizza);
            SaveToFavorite(jsonPizza);
        }
        public static Task SavePizzaToOrdersFile(string jsonPizza)
        {
            string text = jsonPizza;
            try
            {
                // Create the file, or overwrite if the file exists.
                if (File.Exists(ordersPath))
                {
                    var lineCount = File.ReadLines(ordersPath).Count();
                    text = String.Join(" ", File.ReadAllLines(ordersPath))+"\n" + (lineCount+1) + ": " + text;
                }
                else
                {
                    text = "1: " + text;
                }

                using (FileStream fs = File.Create(ordersPath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(text);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(ordersPath))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return Task.CompletedTask;
        }

        public static void SaveToFavorite(string jsonPizza)
        {
            Console.WriteLine("Uložit pizzu do oblíbených?");
            Console.WriteLine("1 = Ano");
            Console.WriteLine("2 = Ne");
            while (true)
            {
                int key = Program.KeyInput();
                if (key == 1)
                {
                    SaveToFavoriteFile(jsonPizza);
                    break;
                }
                else if (key == 2)
                {
                    Program.Main(new string[] { });
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        public static Task SaveToFavoriteFile(string jsonPizza)
        {
            string text = jsonPizza;
            string path = @"c:\temp\favorites.json";
            try
            {
                // Create the file, or overwrite if the file exists.
                if (File.Exists(path))
                {
                    var lineCount = File.ReadLines(path).Count();
                    text = String.Join(" ", File.ReadAllLines(path))+"\n" + (lineCount+1) + ": " + text;
                }
                else
                {
                    text = "1: " + text;
                }

                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(text);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return Task.CompletedTask;
        }
        
        public void ShowFavoritePizza()
        {
            Console.Clear();
            Console.WriteLine("------------Oblébené pizzy------------");
            Console.WriteLine("1 = Zpět");
            if (File.Exists(favoritePath))
            {
                List<Pizza> favoritePizzas = new List<Pizza>();

                int counter = 0;  
                
                foreach (string line in System.IO.File.ReadLines(favoritePath))
                {
                    string[] lineArray = line.ToCharArray().Select(c => c.ToString()).ToArray();
                    string json = null;
                    for (int i = 3; i < line.Length; i++)
                    {
                        json += lineArray[i];
                    }
                    Pizza pizza = JsonConvert.DeserializeObject<Pizza>(json);
                    favoritePizzas.Add(pizza);
                    counter++;
                    Console.WriteLine(counter + ": " + json);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Nemáte žádné oblíbené pizzy");
            }
            while (true)
            {
                int keyInput = KeyInput();
                if (keyInput == 1)
                {
                    Program.Main(new string[] { });
                }
            }
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
                    Program.SavePizzaToOrders(pizza);
                    break;
                default:
                    break;
            }
        }

        public static int KeyInput()
        {
            ConsoleKey key = Console.ReadKey(true).Key;
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