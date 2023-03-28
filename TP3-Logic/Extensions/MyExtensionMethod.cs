using System;

namespace TP3_Logic
{
    public static class MyExtensionMethod
    {
        public static string DivisionBy (this double dividend, double divider)
        {
            try
            {
                if (divider == 0) throw new DivideByZeroException();
                else
                {
                    double result = dividend / divider;
                    return "La operación se realizó exitosamente. El resultado es: " + result;
                } 
            }
            catch (DivideByZeroException)
            {
                return "Solo Goku divide por cero!";
            }
            
        }
    }
}
