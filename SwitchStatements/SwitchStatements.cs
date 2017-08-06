using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    class SwitchStatements
    {
        static void Main()
        {
            Console.WriteLine("Enter numb");
            int UserNumb = int.Parse(Console.ReadLine());

            if (UserNumb == 10)
            {
                Console.WriteLine("numb is 10");
            }

            else if (UserNumb == 20)
            {
                Console.WriteLine("numb is 20");
            }

            else if (UserNumb == 30)
            {
                Console.WriteLine("numb is 30");
            }

            else
            {
                Console.WriteLine("numb is neither");
            }

            //all of this can be shrunken down using the switch statement:

            switch (UserNumb)
            {
                case 10:
                    Console.WriteLine("numb is 10");
                    break;
                case 20:
                    Console.WriteLine("numb is 20");
                    break;
                case 30:
                    Console.WriteLine("numb is 30");
                    break;
                default:
                    Console.WriteLine("Numb is neither");
                    break;
            }

            //and even faster way is this:

            switch (UserNumb)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("numb is {0}", UserNumb);
                    break;
                default:
                    Console.WriteLine("num is neither");
                    break;
            }

            /* coffee shop example */

            Start:
            Console.WriteLine("$1 - Small, $2 - Med, $3 - Large");
            int UserChoice = int.Parse(Console.ReadLine());

            int TotalCost = 0;

            switch (UserChoice)
            {
                case 1:
                    TotalCost += 1;
                    break;
                case 2:
                    TotalCost += 2;
                    break;
                case 3:
                    TotalCost += 3;
                    break;
                default:
                    Console.WriteLine("Please chose a valid size");
                    goto Start;
            }

            Decide:
            Console.WriteLine("want more coffee?");
            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper()) //we use the ToUpper function because this variable is case sensitive so we just make it all upper and not deal with it
            {
                case "YES":
                    goto Start; //Don't have to put a break here because if the user decides yes then it'll go to start and it'll be a never ending loop
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice of {0} is invalid", UserDecision);
                    goto Decide;
            }

            Console.WriteLine("total cost is {0}", TotalCost);

            




        }
    }
}
