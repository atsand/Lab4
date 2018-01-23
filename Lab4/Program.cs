using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the factorial calculator!");
            Factorial();
        }
        private static void Factorial()
        {
            long input, output=1;
            string answer;
            Console.WriteLine("Please enter an integer between 1 and 20.");
            input = long.Parse(Console.ReadLine()); //retrieve intiger
            
            for (int i = 1; i <= input; i++)  //run factorial math
            {
                output = output * i;
            }

            Console.WriteLine("{0}! equals {1}.", input, output);
            Console.WriteLine();
            Console.WriteLine("Would you like to try again? (Y/N)");  //ask to repeat
            answer = Console.ReadLine();
            Console.WriteLine();
            if (answer=="y" || answer=="Y")
            {
                Factorial();  //recursive function if answer is y/Y
            }
        }
    }
}
