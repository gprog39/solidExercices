using System;
using System.ComponentModel;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace SolidExercices
{
    public class Calculator
    {

        public double Calculate(string operation)
        {
            string[] splitOperation = operation.Split('+', '-', '*', '/');
            
            if (operation.Contains('+') && !String.IsNullOrEmpty(operation))
            {

                return Convert.ToDouble(splitOperation[0]) + Convert.ToDouble(splitOperation[1]);
            }
            else
            {
                if (operation.Contains(('-'))&& !String.IsNullOrEmpty(operation))
                {
                    return Convert.ToDouble(splitOperation[0]) - Convert.ToDouble(splitOperation[1]);
                }
                else
                {
                    if (operation.Contains(('*')) && !String.IsNullOrEmpty(operation))
                    {
                        return Convert.ToDouble(splitOperation[0]) * Convert.ToDouble(splitOperation[1]);
                    }
                    else

                    {
                        try
                        {
                            return Convert.ToDouble(splitOperation[0]) / Convert.ToDouble(splitOperation[1]);
                        }
                        catch (Exception edbz)
                        {
                            Console.WriteLine("Erreur: division par zéro");
                        }

                    }
                    return 0.0;
                }
            }
        }
    }
}
