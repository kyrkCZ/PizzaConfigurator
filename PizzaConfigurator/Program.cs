using System;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;

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
            Console.WriteLine("Bagr");
            Console.WriteLine("Bagr");
            Console.WriteLine("Bagr");
            Console.WriteLine("Bagr");
            Console.WriteLine("Bagr");
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
                default:
                    break;
            }
        }
        
        public static void SavePizzaToOrders(Pizza pizza)
        {
            
            pizza = null;
            Program.Main(new string[] { });
        }

        public void ShowFavoritePizza()
        {
            
        }

        public void SaveToFavorite()
        {
            
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