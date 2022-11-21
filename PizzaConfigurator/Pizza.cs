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
            Console.WriteLine("2 = Eidam: " +pizza.eidam);
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
                        Program.Phase(4,pizza);
                        break;
                    case 6:
                        Program.Phase(2,pizza);
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
                Console.WriteLine("2 = Slanina: " +pizza.slanina);
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
                        Program.Phase(5,pizza);
                        break;
                    case 6:
                        Program.Phase(3,pizza);
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
            
        }
    }
}