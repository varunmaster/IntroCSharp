using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandlingAbuse
{
    class exceptionHandlingAbuse
    {
        public static void Main()
        {/* 1. this is overusing the exception handling methods
            try
            {
                Console.WriteLine("Enter first number");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second number");
                int denomerator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / denomerator;
                Console.WriteLine("Result = {0}", result);
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter numbers only");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter smaller number; between {0} and {1}", Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cannot divide by 0");
            }
        */

            ///<summary>
            ///Instead of having all the exceptions we just put them inside of if statements and have a base exception rule to catch any exception that we
            ///may have missed or didnt account for
            ///</summary>
            try
            {
                Console.WriteLine("Enter first number");
                int numerator;
                bool isNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out numerator);//2. returns bool
                if(isNumeratorConversionSuccessful)
                {
                    Console.WriteLine("Enter Second number");
                    int denominator;
                    bool isDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out denominator);
                    if (isDenominatorConversionSuccessful && denominator != 0)
                    {
                        int result = numerator / denominator;
                        Console.WriteLine("Result = {0}", result);
                    }
                    else
                    {
                        if (denominator == 0)
                        {
                            Console.WriteLine("Denominator cannot be 0");
                        }
                        else
                        {
                            Console.WriteLine("Please enter smaller denominator between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter smaller number; between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
