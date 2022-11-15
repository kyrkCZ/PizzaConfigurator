using System;

namespace PizzaConfigurator
{
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