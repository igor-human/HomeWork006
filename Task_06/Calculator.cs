using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    public static class Calculator
    {
        // Додавання двох чисел
        public static double Add(double a, double b)
        {
            return a + b;
        }

        // Віднімання двох чисел
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        // Множення двох чисел
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        // Ділення двох чисел
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Ділити на нуль не можна");
            }
            return a / b;
        }
    }
}
