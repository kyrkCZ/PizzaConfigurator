using System;

namespace PizzaConfigurator
{
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
                        Pizza.Phase(1);
                        break;
                    default:
                        continue;
                }
            }
        }
    }
}