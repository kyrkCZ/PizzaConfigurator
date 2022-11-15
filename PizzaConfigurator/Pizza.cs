using System;
using PizzaConfigurator.Properties;

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

        public static void Phase(int phase)
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
                    Syry syry = new Syry();
                    syry.selectSyry();
                    break;
                case 4:
                    Uzeniny uzeniny = new Uzeniny();
                    Uzeniny.selectUzeniny();
                    break;
                case 5:
                    Maso maso = new Maso();
                    Maso.selectMaso();
                    break;
                case 6:
                    Ostatni ostatni = new Ostatni();
                    Ostatni.selectOstatni();
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
                    Program program = new Program();
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
    }
}