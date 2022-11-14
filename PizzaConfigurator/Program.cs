using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;

namespace PizzaConfigurator
{
    internal class Pizza
    {
        private Boolean zaklad; //case false tomato, case true smetana
        private Boolean syrovyZaklad;
        public Pizza(Boolean _zaklad, Boolean _syrovyZaklad)
            {
                zaklad = _zaklad;
                syrovyZaklad = _syrovyZaklad;
            }

        struct Syry
        {
            private Boolean mozzarela, eidam, hermelin, parmazan;//sýry
        }

        struct Uzeniny
        {
            private Boolean sunka, slanina, vysocina, klobaska;//uzeniny
        }

        struct Maso
        {
            private Boolean kureci, veprove;//maso
        }

        struct Ostatni
        {
            private Boolean kukurice, zampiony, feferonky, ananas, vejce, olivy;//ostatní
        }
        public static void Main(string[] args)
        {
            Pizza pizza = new Pizza();
            pizza.start();
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
                        Pizza pizza = new Pizza();
                        selectBase();
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

        public void selectBase()
        {

        }

        public void keyInput()
        {
            switch (choice)
            {
                // 1 ! key
                case ConsoleKey.D1:
                    Console.WriteLine("1. Choice");
                    break;
                //2 @ key
                case ConsoleKey.D2:
                    Console.WriteLine("2. Choice");
                    break;
            }
        }

        public void selectSyry()
        {
            
        }

        public void selectUzeniny()
        {
            
        }

        public void selectMaso()
        {
            
        }

        public void selectExtra()
        {
            
        }
    }
}