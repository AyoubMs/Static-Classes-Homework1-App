using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesHomework1
{
    public static class Calculations
    {
        public static double CalculateDoubles(double a, double b, char operation)
        {
            switch (operation)
            {
                case '*':
                    return a * b;
                case '/':
                    return a / b;
                case '-':
                    return a - b;
                case '+':
                    return a + b;
                default:
                    break;
            }
            return 0.0;
        }

        public static int CalculateInts(int a, int b, char operation)
        {
            switch (operation)
            {
                case '*':
                    return a * b;
                case '/':
                    return a / b;
                case '-':
                    return a - b;
                case '+':
                    return a + b;
                default:
                    break;
            }
            return 0;
        }

        public static decimal CalculateDecimals(decimal a, decimal b, char operation)
        {
            switch (operation)
            {
                case '*':
                    return a * b;
                case '/':
                    return a / b;
                case '-':
                    return a - b;
                case '+':
                    return a + b;
                default:
                    break;
            }
            return 0m;
        }
    }
}
