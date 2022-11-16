using System;

namespace PizzaConfigurator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            Pizza pizza = new Pizza();
            Pizza.Maso pizzaMaso = new Pizza.Maso();
            Pizza.Syry pizzaSyry = new Pizza.Syry();
            Pizza.Uzeniny pizzaUzeniny = new Pizza.Uzeniny();
            Pizza.Ostatni pizzaOstatni = new Pizza.Ostatni();
            program.Start();
        }

        public void Start()
        {
            while (true)
            {
                switch (keyInput())
                {
                    case 1:
                        //Sestaveni pizza
                        Console.WriteLine("select 1");
                        Phase(0);
                        break;
                    case 2:
                        //Oblibené pizzy
                        showFavoritePizza();
                        break;
                    case 3:
                        //End
                        System.Environment.Exit(0);
                        break;
                    default:
                        continue;
                }

                continue;
            }
        }

        public void Phase(int phase)
        {
            switch (phase)
            {
                case 1:
                    pizza.selectZaklad();
                    break;
                case 2:
                    selectSyrovyZaklad();
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
            }
        }
        public static void showFavoritePizza()
        {
        }

        public void saveToFavorite()
        {

        }

        public static int keyInput()
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