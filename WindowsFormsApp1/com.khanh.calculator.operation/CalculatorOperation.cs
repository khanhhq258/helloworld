using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.khanh.calculator.operation
{
    public class CalculatorOperation
    {
        public static long AddTowNumber(long num1, long num2)
        {
            return num1 + num2;
        }

        public static long SubtractTowNumber(long num1, long num2)
        {
            return num1 - num2;
        }
        public static double DevideTwoNumber(long num1, long num2)
        {
            double result=0;
            
            
                if (num2 != 0) {
                    result = (double)num1 / num2;
                    
                }
                else
                {
                    throw (new CalculatorException("Can not devide by zero number"));
                }
            
           
            return result;
        }

        public static long MultipleTowNumber(long num1, long num2)
        {
            return num1 * num2;
        }
    }
}
