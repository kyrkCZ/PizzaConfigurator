using System;
using System.Net.Mime;
using System.Runtime.InteropServices;

namespace PizzaConfigurator
{
    internal class Pizza
    {
        
        public static void Main(string[] args)
        {
            Pizza pizza= new Pizza();
            pizza.start();
        }

        private void start()
        {
            Console.WriteLine("Vyberte možnost 1,2,3,4,5");
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
                    //Vyber pizza
                    
                    break;
                case 2: 
                    //Oblibené pizzy

                    break;
                case 3:
                    //Seznam předsestavených pizza
                    
                    break;
                case 4: 
                    //Seznam ingrediencí
                    
                    break;
                case 5: 
                    //End
                    System.Environment.Exit(0);
                    break;
                default:
                    start();
                    break;
            }
        }

        public void select()
        {
            
        }
    }
}