using System;

namespace PizzaConfigurator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
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
                        Console.WriteLine();

                        break;
                    case 2:
                        //Oblibené pizzy
                        //showFavoritePizza();
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

    public class Pizza
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
                if (Program.keyInput() == 1)
                {
                    return zaklad == true;
                }
                else if (Program.keyInput() == 2)
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
                if (Program.keyInput() == 1)
                {
                    return SyrovyZaklad == true;
                }
                else if (Program.keyInput() == 2)
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
                Console.WriteLine("5 = Zpět");
                switch (Program.keyInput())
                {
                    case 1:
                        continue;
                    case 2:
                        continue;
                    case 3:
                        continue;
                    case 4:
                        
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

    public class Syry : Pizza
    {

private Boolean mozzarela, eidam, hermelin, parmazan; //sýry

        public Syry(bool mozzarela, bool eidam, bool hermelin, bool parmazan)
        {
            this.mozzarela = mozzarela;
            this.eidam = eidam;
            this.hermelin = hermelin;
            this.parmazan = parmazan;
        }

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
    public class Uzeniny : Pizza
    {
        private Boolean sunka, slanina, vysocina, klobaska; //uzeniny

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
    public class Maso : Pizza
    {
        private Boolean kureci, veprove; //maso

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
    public class Ostatni : Pizza
    {
        private Boolean kukurice, zampiony, feferonky, ananas, vejce, olivy; //ostatní

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
    
}