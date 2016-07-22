using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            string performNewCalc;
            do
            {
                Console.WriteLine("Please enter a number.");
                int firstNum = int.Parse(Console.ReadLine());


                Console.WriteLine("Choose which operation to be performed:");
                Console.WriteLine("\n+ \n- \n* \n%");
                string operation = Console.ReadLine();

                Console.WriteLine("Now enter your second number.");
                int secondNum = int.Parse(Console.ReadLine());


                Console.WriteLine("Your Result is: ")
            int result = firstNum ?? secondNum


            Console.WriteLine("Your Result is: " + result);

                Console.WriteLine("Would you like to perform another calculation?");
                performNewCalc = Console.ReadLine().ToLower();
            }
            while (performNewCalc == "yes");

            {

            }

            Console.WriteLine("GOODBYE...");
            Console.ReadKey();



        }
    }
}
