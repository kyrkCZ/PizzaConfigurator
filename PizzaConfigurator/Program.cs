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
            Console.WriteLine("------------Pizza konfigurátor------------");
            Console.WriteLine("1 = Sestavení nové pizza");
            Console.WriteLine("2 = Seznam oblíbených pizza");
            Console.WriteLine("3 = Výběr ze základních pizza");
            Console.WriteLine("4 = Odejít");
        }
        
        public static void SavePizzaToOrders(Pizza pizza)
        {
            string jsonPizza = JsonConvert.SerializeObject(pizza);
            SavePizzaToOrdersFile(jsonPizza);
            SaveToFavorite(jsonPizza);
        }
        public static Task SavePizzaToOrdersFile(string jsonPizza)
        {
            string text = jsonPizza;
            string path = @"c:\temp\orders.json";
            try
            {
                // Create the file, or overwrite if the file exists.
                if (File.Exists(path))
                {
                    var lineCount = File.ReadLines(path).Count();
                    text = String.Join(" ", File.ReadAllLines(path))+"\n" + lineCount + ": " + text;
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
                    text = String.Join(" ", File.ReadAllLines(path))+"\n" + lineCount + ": " + text;
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
            List<Pizza> fPizzas = new List<Pizza>();
            
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