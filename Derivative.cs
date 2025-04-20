using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4VichMatka
{
    public static class Derivative
    {
        public static float CalculateDerivative(float x, float h)
        {
          
            float xPlusH = x + h;
            float fx = 4 * x * x;  
            float fxPlusH = 4 * xPlusH * xPlusH; 

            float derivative = (fxPlusH - fx) / h;
            return derivative;
        }

        public static double CalculateDerivative(double x, double h)
        {
     
            double xPlusH = x + h;
            double fx = 4 * x * x; 
            double fxPlusH = 4 * xPlusH * xPlusH; 

            double derivative = (fxPlusH - fx) / h;
            return derivative;
        }

        public static decimal CalculateDerivative(decimal x, decimal h)
        {

            decimal xPlusH = x + h;
            decimal fx = 4 * x * x;
            decimal fxPlusH = 4 * xPlusH * xPlusH;

            decimal derivative = (fxPlusH - fx) / h;
            return derivative;
        }
    }
}
