using System;
using System.Net.Mime;

namespace PizzaConfigurator
{
    internal class Pizza
    {
        
        public static void Main(string[] args)
        {
            Pizza pizza= new Pizza();
            pizza.start();
        }

        public void start()
        {
            Console.WriteLine();
            int input = Console.Read();
            switch (input)
            {
                case 1: 
                    //Vyber pizza
                    
                    break;
                case 2: 
                    //Oblibené pizzy
                    
                    break;
                case 3: 
                    //Seznam ingrediencí
                    
                    break;
                case 4: 
                    //End
                    System.Environment.Exit(0);
                    break;
                default:
                    start();
                    break;
            }
        }
    }
}