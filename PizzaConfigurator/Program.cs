using System;

namespace PizzaConfigurator
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            while (true)
            {
                switch (keyInput())
                {
                    case 1:
                        //Sestaveni pizza
                        Pizza pizza = new Pizza();
                        pizza.Phase(0);
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

        public static void showFavoritePizza()
        {
        }

        public static void saveToFavorite()
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

    internal class Pizza
    {
        public Pizza(bool zaklad = false, bool syrovyZaklad = false)
        {
            this.zaklad = zaklad;
            this.syrovyZaklad = syrovyZaklad;
        }
        
        private Boolean zaklad; //case false tomato, case true smetana
        private Boolean syrovyZaklad;
        
        public bool Zaklad
        {
            get => zaklad;
            set => zaklad = value;
        }

        public bool SyrovyZaklad
        {
            get => syrovyZaklad;
            set => syrovyZaklad = value;
        }
        
        public struct Syry{
            private static Boolean mozzarela, eidam, hermelin, parmazan; //sýry
            public static bool Mozzarela
            {
                get => mozzarela;
                set => mozzarela = value;
            }

            public static bool Eidam
            {
                get => eidam;
                set => eidam = value;
            }

            public static bool Hermelin
            {
                get => hermelin;
                set => hermelin = value;
            }

            public static bool Parmazan
            {
                get => parmazan;
                set => parmazan = value;
            }
            }

        public struct Uzeniny
        {
            private static Boolean sunka, slanina, vysocina, klobaska; //uzeniny

            public static bool Sunka
            {
                get => sunka;
                set => sunka = value;
            }

            public static bool Slanina
            {
                get => slanina;
                set => slanina = value;
            }

            public static bool Vysocina
            {
                get => vysocina;
                set => vysocina = value;
            }

            public static bool Klobaska
            {
                get => klobaska;
                set => klobaska = value;
            }
        }

        public struct Maso
        {
            private static Boolean kureci, veprove; //maso

            public static bool Kureci
            {
                get => kureci;
                set => kureci = value;
            }

            public static bool Veprove
            {
                get => veprove;
                set => veprove = value;
            }
        }

        public struct Ostatni
        {
            private static Boolean kukurice, zampiony, feferonky, ananas, vejce, olivy; //ostatní

            public static bool Kukurice
            {
                get => kukurice;
                set => kukurice = value;
            }

            public static bool Zampiony
            {
                get => zampiony;
                set => zampiony = value;
            }

            public static bool Feferonky
            {
                get => feferonky;
                set => feferonky = value;
            }

            public static bool Ananas
            {
                get => ananas;
                set => ananas = value;
            }

            public static bool Vejce
            {
                get => vejce;
                set => vejce = value;
            }

            public static bool Olivy
            {
                get => olivy;
                set => olivy = value;
            }
        }

        public void Phase(int phase)
        {
            switch (phase)
            {
                case 1:
                    selectZaklad();
                    break;
                case 2:
                    selectSyrovyZaklad();
                    break;
                case 3:
                    selectSyry();
                    break;
                case 4:
                    selectUzeniny();
                    break;
                case 5:
                    selectMaso();
                    break;
                case 6:
                    selectExtra();
                    break;
            }
        }
        public bool selectZaklad()
        {
            Console.WriteLine("Vyberte si základ:");
            Console.WriteLine("1 = Rajčatový základ");
            Console.WriteLine("2 = Smetanový základ");
            Console.WriteLine("3 = Zpět");
            while (true)
            {
                if(Program.keyInput()==1)
                {
                    return zaklad == true;
                }else if (Program.keyInput() == 2)
                {
                    return zaklad == false;
                }
                else if (Program.keyInput() == 3)
                {
                    Program.Start();
                }
                else
                {
                    continue;
                }
            }
        }
        
        public bool selectSyrovyZaklad()
        {
            Console.WriteLine("Sýrový základ:");
            Console.WriteLine("1 = Ano");
            Console.WriteLine("2 = Ne");
            Console.WriteLine("3 = Zpět");
            while (true)
            {
                if(Program.keyInput()==1)
                {
                    return SyrovyZaklad == true;
                }else if (Program.keyInput() == 2)
                {
                    return SyrovyZaklad == false;
                }
                else if (Program.keyInput() == 3)
                {
                    Phase(0);
                }
                else
                {
                    continue;
                }
            }
        }

        public void selectSyry()
        {
            while (true)
            {
                Console.WriteLine("Sýry:");
                Console.WriteLine("1 = Mozzarela " + Syry.Mozzarela);
                Console.WriteLine("2 = Mozzarela " + Syry.Mozzarela);
                Console.WriteLine("3 = Mozzarela " + Syry.Mozzarela);
                Console.WriteLine("4 = Mozzarela " + Syry.Mozzarela);
                Console.WriteLine("5 = Zpět");
                switch (Program.keyInput())
                {
                    case 1:
                        Syry.Mozzarela = !Syry.Mozzarela;
                        continue;
                    case 2:
                        Syry.Hermelin = !Syry.Hermelin;
                        continue;
                    case 3:
                        Syry.Eidam = !Syry.Eidam;
                        continue;
                    case 4:
                        Syry.Parmazan = !Syry.Parmazan;
                        continue;
                    case 5:
                        Phase(1);
                        break;
                    default:
                        continue;
                }
            }
        }

        public void selectUzeniny()
        {
        }

        public void selectMaso()
        {
        }

        public void selectExtra()
        {
        }
    }
}