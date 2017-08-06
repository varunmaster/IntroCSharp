using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypesConversion
{
    class DatatypeConversion
    {
        static void Main()
        {
            int i = 100;
            float f = i; //we are using an implicit conversion because converting int to float does not lose information 

            float a = 123.45f; //because this is a float, we have to put a F after it 
            int j = f; //we get an error because float is a larger data type than int and converting causes a loss of information

            //In order to convert one data type to another, we have to explicitly do it (type cast operator):
            float b = 123.45f;
            int k = (int)b;

            float c = 123.45f;
            int l = Convert.ToInt32 (c);

            string strNumb = "100";
            int m = int.Parse(strNumb); //In this case, if the strNumb contained some sort of letters in it, then the int.Parse would throw an error. Instead we can use int.TryParse
            //which will return a boolean data type which can then be converted. Ex, strNumb contains 876TA, tryParse will return false, and not return anything or returns the default
            //value (which is 0 in this case). If, strNumb contains 57 then tryParse will return True, and then convert it from str to int

            string strNumb1 = "687TA"; //try removing the TA, and see what result you get
            int Result = 0;
            bool IsConversionSuccessful = int.TryParse(strNumb1, out Result);

            if (IsConversionSuccessful)
            {
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }
          

        }
    }
}