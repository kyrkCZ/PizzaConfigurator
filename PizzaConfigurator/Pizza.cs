using System;

namespace PizzaConfigurator
{
    public class Pizza
    {
        private Boolean zaklad; //case false tomato, case true smetana
        private Boolean syrovyZaklad;
        
        public Pizza(bool zaklad = default, bool syrovyZaklad = default)
        {
            this.zaklad = zaklad;
            this.syrovyZaklad = syrovyZaklad;
        }

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
                    Program program = new Program();
                    program.Start();
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
                    Program program = new Program();
                    program.Start();
                }
                else
                {
                    continue;
                }
            }
        }
        public class Syry
        {
            private Boolean mozzarela, eidam, hermelin, parmazan; //sýry

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

            public Syry(bool zaklad = default, bool syrovyZaklad = default)
            {
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
                            break;
                        default:
                            continue;
                    }
                }
            }
        }
        public class Uzeniny
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

            public Uzeniny(bool zaklad= default, bool syrovyZaklad= default)
            {
            }
            public void selectUzeniny()
            {
            }
        }
        public class Maso
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

            public Maso(bool zaklad= default, bool syrovyZaklad= default)
            {
            }
            public void selectMaso()
            {
            }
        }
        public class Ostatni
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

            public Ostatni(bool zaklad= default, bool syrovyZaklad= default)
            {
            }
            public void selectOstatni()
            {
            }
        }
    }
}