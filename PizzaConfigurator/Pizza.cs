using System;

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
                if (Program.KeyInput() == 1)
                {
                    pizza.@base = true;
                    Program.Phase(2, pizza);
                }
                else if (Program.KeyInput() == 2)
                {
                    pizza.@base = false;
                    Program.Phase(2, pizza);
                }
                else if (Program.KeyInput() == 3)
                {
                    Program.Phase(1, pizza);
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
                if (Program.KeyInput() == 1)
                {
                    pizza.cheeseBase = true;
                    Program.Phase(3, pizza);
                }
                else if (Program.KeyInput() == 2)
                {
                    pizza.cheeseBase = false;
                    Program.Phase(3, pizza);
                }
                else if (Program.KeyInput() == 3)
                {
                    Program.Phase(1, pizza);
                }
            }
        }

        private Boolean mozzarela, eidam, hermelin, parmazan; //sýry

        public void SelectSyry(Pizza pizza)
        {
            Console.Clear();
            Console.WriteLine("Sýry:");
            Console.WriteLine("Sýry:");
            Console.WriteLine("Sýry:");
            Console.WriteLine("Sýry:");
            Console.WriteLine("5 = Zpět");
            while (true)
            {
                
                switch (Program.KeyInput())
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


        private Boolean sunka, slanina, vysocina, klobaska; //uzeniny

        public void SelectUzeniny(Pizza pizza)
        {
        }

        private Boolean kureci, veprove; //maso
        
        public void SelectMaso(Pizza pizza)
        {
        }

        private Boolean kukurice, zampiony, feferonky, ananas, vejce, olivy; //ostatní

        public void SelectOstatni(Pizza pizza)
        {
        }
    }
}