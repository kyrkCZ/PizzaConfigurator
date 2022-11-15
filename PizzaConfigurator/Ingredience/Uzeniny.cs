using System;

namespace PizzaConfigurator
{
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
}