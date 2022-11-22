using System;
using System.Reflection;

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

        public bool Base => @base;

        public bool CheeseBase => cheeseBase;

        public bool Mozzarela => mozzarela;

        public bool Eidam => eidam;

        public bool Hermelin => hermelin;

        public bool Parmazan => parmazan;

        public bool Sunka => sunka;

        public bool Slanina => slanina;

        public bool Vysocina => vysocina;

        public bool Klobaska => klobaska;

        public bool Kureci => kureci;

        public bool Veprove => veprove;

        public bool Kukurice => kukurice;

        public bool Zampiony => zampiony;

        public bool Feferonky => feferonky;

        public bool Ananas => ananas;

        public bool Vejce => vejce;

        public bool Olivy => olivy;

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