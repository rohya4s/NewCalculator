using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculator
{
    public class Calci
    {
        public static void Operation(int v1,int v2,char op)
        {
            if (op == '+')
            {
                Console.WriteLine("addition of two number is. " + (v1 + v2));
            }
            else if (op == '-')
            {
                Console.WriteLine("addition of two number is. " + (v1 - v2));
            }
            else if (op == '*')
            {
                Console.WriteLine("addition of two number is. " + (v1 * v2));
            }
            else if (op == '/')
            {
                Console.WriteLine("addition of two number is. " + (v1 / v2));
            }
            
            else
            {
                Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                return;
            }
        }
    }
}
