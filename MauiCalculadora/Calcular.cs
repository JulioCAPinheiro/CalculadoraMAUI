using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCalculadora
{
    public static class Calcular
    {
        public static double FazerCalculo(double valor1, double valor2, string operadorMath)
        {
            double result = 0;

            switch (operadorMath)
            {
                case "/":
                    result = valor1 / valor2;
                    break;
                case "-":
                    result = valor1 - valor2;
                    break;
                case "*":
                    result = valor1 * valor2;
                    break;
                case "+":
                    result = valor1 + valor2;
                    break;

                default:
                    break;
            }

            return result;
        }
    }
}
