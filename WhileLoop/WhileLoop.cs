using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop_doWhile
{
    class WhileLoop_doWhile
    {
        static void Main()
        {
            /* //Create a program that prints all even numbers until a user specified target
             Console.WriteLine("Enter target");
             int Target = int.Parse(Console.ReadLine());
             int Start = 0;

             while(Start <= Target)
             {
                 Console.WriteLine(Start);
                 Start = Start + 2;
             }
             */
            //doing the above program with a do while loop.
            string userChoice = "";

            do
            {
                Console.WriteLine("Enter target");
                int userTarget = int.Parse(Console.ReadLine());
                int userStart = 0;

            
                while (userStart <= userTarget)
                {
                    Console.WriteLine(userStart);
                    userStart = userStart + 2;
                }

                
                do //this do while loop is there in case the user puts in words that are neither no or yes. So while the userChoice is neither No or Yes,
                   //keep prompting them to put in a valid input. Keep doing this while this is true
                {
                    Console.WriteLine("Do you want to continue? - Yes or No");
                    userChoice = Console.ReadLine().ToUpper();
                    if ((userChoice != "YES" && userChoice != "NO") && (userChoice != "Y" && userChoice != "N"))
                    {
                        Console.WriteLine("Choose a given option");
                    }
                } while ((userChoice != "YES" && userChoice != "NO") && (userChoice != "Y" && userChoice != "N"));
            } while (userChoice == "Yes" || userChoice == "Y");
        }
    }
}
