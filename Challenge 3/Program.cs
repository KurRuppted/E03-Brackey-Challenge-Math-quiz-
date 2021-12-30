using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // variables
            double answer01;
            double answer02;
            double answer03;
            

            // problems
            Console.Write("10+9*9: ");
            answer01 = Convert.ToDouble(Console.ReadLine());
            
            if (answer01 == 91)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.Write("7+9*7-8: ");
            answer02 = Convert.ToDouble(Console.ReadLine());

            if (answer02 == 62)
            {
                Console.WriteLine("Correct");
                
            }
            else{
                Console.WriteLine("Incorrect");
            }

            Console.Write("9*8-8/2+7: ");
            answer03 = Convert.ToDouble(Console.ReadLine());

            if (answer03 == 75)
            {
                Console.WriteLine("Correct");
                
            }
            else 
            {
                Console.WriteLine("Incorrect");
            }

            // end
            Console.WriteLine("You have finished the math problem quiz thing!");


            Console.ReadKey();
        }
    }
}
