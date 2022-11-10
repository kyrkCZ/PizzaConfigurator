using System;
using System.Net.Mime;
using System.Runtime.InteropServices;

namespace PizzaConfigurator
{
    internal class Program
    {
        struct Pizza
        {
            private Boolean zaklad; //case false tomato, case true smetana
            private Boolean syrovyZaklad;
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }

        private void start()
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