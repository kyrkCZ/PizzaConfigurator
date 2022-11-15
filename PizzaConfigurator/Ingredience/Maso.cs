using System;

namespace PizzaConfigurator.Properties
{
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
}