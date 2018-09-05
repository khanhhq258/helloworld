using System;
using com.khanh.calculator.operation;

namespace com.khanh.calculator.console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write(CalculatorOperation.DevideTwoNumber(1, 0));
            }
            catch (Exception ex) {
                Console.Write(ex.Message);

            }
            Console.ReadKey();
        
        }
    }
}
