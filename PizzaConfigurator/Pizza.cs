using System;
using System.Reflection;
using System.Text.Json;

namespace PizzaConfigurator
{
    public class Pizza
    {
        private Boolean @base; //case false tomato, case true smetana
        private Boolean cheeseBase; //case false bez sýrového okraje, case false se

        public void SelectBase(Pizza pizza)
        {
            Console.Clear();
            Console.WriteLine("Vyberte si základ:");
            Console.WriteLine("1 = Rajčatový základ");
            Console.WriteLine("2 = Smetanový základ");
            Console.WriteLine("3 = Zpět");
            while (true)
            {
                int key = Program.KeyInput();
                if (key == 1)
                {
                    pizza.@base = true;
                    Program.Phase(2, pizza);
                    break;
                }
                else if (key == 2)
                {
                    pizza.@base = false;
                    Program.Phase(2, pizza);
                    break;
                }
                else if (key == 3)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Program.Main(new string[] { });
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        public void SelectCheeseBase(Pizza pizza)
        {
            Console.Clear();
            Console.WriteLine("Sýrový základ:");
            Console.WriteLine("1 = Ano");
            Console.WriteLine("2 = Ne");
            Console.WriteLine("3 = Zpět");
            while (true)
            {
                int key = Program.KeyInput();
                if (key == 1)
                {
                    pizza.cheeseBase = true;
                    Program.Phase(3, pizza);
                    break;
                }
                else if (key == 2)
                {
                    pizza.cheeseBase = false;
                    Program.Phase(3, pizza);
                    break;
                }
                else if (key == 3)
                {
                    Program.Phase(1, pizza);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        private Boolean mozzarela, eidam, hermelin, parmazan; //sýry

        public void SelectSyry(Pizza pizza)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 = Mozzarela:" + pizza.mozzarela);
                Console.WriteLine("2 = Eidam: " + pizza.eidam);
                Console.WriteLine("3 = Hermelin: " + pizza.hermelin);
                Console.WriteLine("4 = Parmazan: " + pizza.parmazan);
                Console.WriteLine("5 = Potvrdit");
                Console.WriteLine("6 = Zpět");

                switch (Program.KeyInput())
                {
                    case 1:
                        pizza.mozzarela = !pizza.mozzarela;
                        continue;
                    case 2:
                        pizza.eidam = !pizza.eidam;
                        continue;
                    case 3:
                        pizza.hermelin = !pizza.hermelin;
                        continue;
                    case 4:
                        pizza.parmazan = !pizza.parmazan;
                        continue;
                    case 5:
                        Program.Phase(4, pizza);
                        break;
                    case 6:
                        Program.Phase(2, pizza);
                        continue;
                    default:
                        continue;
                }
            }
        }


        private Boolean sunka, slanina, vysocina, klobaska; //uzeniny

        public void SelectUzeniny(Pizza pizza)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 = Šunka:" + pizza.sunka);
                Console.WriteLine("2 = Slanina: " + pizza.slanina);
                Console.WriteLine("3 = Vysocina: " + pizza.vysocina);
                Console.WriteLine("4 = Klobaska: " + pizza.klobaska);
                Console.WriteLine("5 = Potvrdit");
                Console.WriteLine("6 = Zpět");

                switch (Program.KeyInput())
                {
                    case 1:
                        pizza.sunka = !pizza.sunka;
                        continue;
                    case 2:
                        pizza.slanina = !pizza.slanina;
                        continue;
                    case 3:
                        pizza.vysocina = !pizza.vysocina;
                        continue;
                    case 4:
                        pizza.klobaska = !pizza.klobaska;
                        continue;
                    case 5:
                        Program.Phase(5, pizza);
                        break;
                    case 6:
                        Program.Phase(3, pizza);
                        continue;
                    default:
                        continue;
                }
            }
        }

        private Boolean kureci, veprove; //maso

        public void SelectMaso(Pizza pizza)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 = Kuřecí maso: " + pizza.kureci);
                Console.WriteLine("2 = Vepřové maso: " + pizza.veprove);
                Console.WriteLine("3 = Potvrdit");
                Console.WriteLine("4 = Zpět");

                int key = Program.KeyInput();
                if (key == 1)
                {
                    pizza.kureci = !pizza.kureci;
                    continue;
                }

                if (key == 2)
                {
                    pizza.veprove = !pizza.veprove;
                    continue;
                }
                else if (key == 3)
                {
                    Program.Phase(6, pizza);
                    break;
                }
                else if (key == 4)
                {
                    Program.Phase(4, pizza);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        private Boolean kukurice, zampiony, feferonky, ananas, vejce, olivy; //ostatní


        public void SelectOstatni(Pizza pizza)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 = Kukuřice:" + pizza.kukurice);
                Console.WriteLine("2 = Ananas: " + pizza.ananas);
                Console.WriteLine("3 = Feferonky: " + pizza.feferonky);
                Console.WriteLine("4 = Vejce: " + pizza.vejce);
                Console.WriteLine("5 = Olivy: " + pizza.olivy);
                Console.WriteLine("6 = Potvrdit");
                Console.WriteLine("7 = Zpět");

                switch (Program.KeyInput())
                {
                    case 1:
                        pizza.kukurice = !pizza.kukurice;
                        continue;
                    case 2:
                        pizza.ananas = !pizza.ananas;
                        continue;
                    case 3:
                        pizza.feferonky = !pizza.feferonky;
                        continue;
                    case 4:
                        pizza.vejce = !pizza.vejce;
                        continue;
                    case 5:
                        pizza.olivy = !pizza.olivy;
                        continue;
                    case 6:
                        Program.Phase(7, pizza);
                        break;
                    case 7:
                        Program.Phase(5, pizza);
                        break;
                    default:
                        continue;
                }
            }
        }

        public bool Base
        {
            get => @base;
            set => @base = value;
        }

        public bool CheeseBase
        {
            get => cheeseBase;
            set => cheeseBase = value;
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
        
        public Pizza(bool @base, bool cheeseBase, bool mozzarela, bool eidam, bool hermelin, bool parmazan, bool sunka,
            bool slanina, bool vysocina, bool klobaska, bool kureci, bool veprove, bool kukurice, bool zampiony,
            bool feferonky, bool ananas, bool vejce, bool olivy)
        {
            this.@base = @base;
            this.cheeseBase = cheeseBase;
            this.mozzarela = mozzarela;
            this.eidam = eidam;
            this.hermelin = hermelin;
            this.parmazan = parmazan;
            this.sunka = sunka;
            this.slanina = slanina;
            this.vysocina = vysocina;
            this.klobaska = klobaska;
            this.kureci = kureci;
            this.veprove = veprove;
            this.kukurice = kukurice;
            this.zampiony = zampiony;
            this.feferonky = feferonky;
            this.ananas = ananas;
            this.vejce = vejce;
            this.olivy = olivy;
        }

        public Pizza()
        {
            
        }
    }
}