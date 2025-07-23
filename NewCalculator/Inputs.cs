using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculator
{
    public  class Inputs
    {
        public static void GetInputs()
        {
            Console.WriteLine("Please enter two numbers to add, separated by a opearator:");
            char[] operators = { '+', '-', '*', '/' };

            string input= Console.ReadLine();

            char op = input.FirstOrDefault(c => operators.Contains(c));
                
            string[] str=input.Split(op);
            int v1;
           
            bool correct=int.TryParse(str[0], out v1);
            if(!correct)
            {
                Console.WriteLine("Invalid input for the first number. Please enter a valid integer.");
                GetInputs();
                return;
            }
             int  v2=int.Parse(str[1]);
           Calci.Operation(v1, v2, op);

            Console.WriteLine("Do you want to continue? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                GetInputs();
            }
            else
            {
                Console.WriteLine("Thank you for using the calculator!");
            }







        }
    }
}
