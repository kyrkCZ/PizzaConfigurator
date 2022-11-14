using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;

namespace PizzaConfigurator
{
    internal class Program
    {
        struct Pizza
        {
            public Pizza(Boolean _zaklad, Boolean _syrovyZaklad)
            {
                zaklad = _zaklad;
                syrovyZaklad = _syrovyZaklad;
                mozzarela = false;
                eidam = false;
                hermelin = false;
                parmazan = false;
                sunka = false;
                slanina = false;
                vysocina = false;
                klobaska = false;
                kureci = false;
                veprove = false;
                kukurice = false;
                zampiony = false;
                feferonky = false;
                ananas = false;
                vejce = false;
                olivy = false;
            }
            private Boolean zaklad; //case false tomato, case true smetana
            private Boolean syrovyZaklad;
            private Boolean mozzarela, eidam, hermelin, parmazan;//sýry
            private Boolean sunka, slanina, vysocina, klobaska;//uzeniny
            private Boolean kureci, veprove;//maso
            private Boolean kukurice, zampiony, feferonky, ananas, vejce, olivy;//ostatní
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }

        public void start()
        {
            while (true)
            {
                Console.WriteLine("Vyberte možnost 1,2,3");
                int input = 0;
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Zkuste to znovu");
                }

                switch (input)
                {
                    case 1:
                        //Sestaveni pizza
                        selectPizza();
                        break;
                    case 2:
                        //Oblibené pizzy

                        break;
                    case 3:
                        //End
                        System.Environment.Exit(0);
                        break;
                    default:
                        continue;
                }

                break;
            }
        }

        public void selectPizza()
        {
            
        }

        public void showFavoritePizza()
        {
            
        }

        public void showDefaultPizza()
        {
            
        }

        public void showIng()
        {
            
        }
    }
}