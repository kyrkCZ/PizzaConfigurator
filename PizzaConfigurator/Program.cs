using System;

namespace PizzaConfigurator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }

        public void start()
        {
            while (true)
            {
                switch (keyInput())
                {
                    case 1:
                        //Sestaveni pizza
                        Pizza pizza = new Pizza();
                        pizza.selectBase();
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

        public void showFavoritePizza()
        {
            
        }

        public int keyInput()
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

        struct Syry
        {
            private Boolean mozzarela, eidam, hermelin, parmazan;//sýry

            public bool Mozzarela
            {
                get => mozzarela;
                set => mozzarela = value;
            }

            public bool Eidam
            {
                get => eidam;
                set => eidam = value;
            }

            public bool Hermelin
            {
                get => hermelin;
                set => hermelin = value;
            }

            public bool Parmazan
            {
                get => parmazan;
                set => parmazan = value;
            }
        }

        struct Uzeniny
        {
            private Boolean sunka, slanina, vysocina, klobaska;//uzeniny

            public bool Sunka
            {
                get => sunka;
                set => sunka = value;
            }

            public bool Slanina
            {
                get => slanina;
                set => slanina = value;
            }

            public bool Vysocina
            {
                get => vysocina;
                set => vysocina = value;
            }

            public bool Klobaska
            {
                get => klobaska;
                set => klobaska = value;
            }
        }

        struct Maso
        {
            private Boolean kureci, veprove;//maso

            public bool Kureci
            {
                get => kureci;
                set => kureci = value;
            }

            public bool Veprove
            {
                get => veprove;
                set => veprove = value;
            }
        }

        struct Ostatni
        {
            private Boolean kukurice, zampiony, feferonky, ananas, vejce, olivy;//ostatní

            public bool Kukurice
            {
                get => kukurice;
                set => kukurice = value;
            }

            public bool Zampiony
            {
                get => zampiony;
                set => zampiony = value;
            }

            public bool Feferonky
            {
                get => feferonky;
                set => feferonky = value;
            }

            public bool Ananas
            {
                get => ananas;
                set => ananas = value;
            }

            public bool Vejce
            {
                get => vejce;
                set => vejce = value;
            }

            public bool Olivy
            {
                get => olivy;
                set => olivy = value;
            }
        }
        
        public void selectBase()
        {
            Console.WriteLine("Vyberte si základ");
            
        }
        
        public void selectSyry()
        {
            
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