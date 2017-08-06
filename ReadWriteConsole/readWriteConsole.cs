using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class readWriteConsole
{
    static void Main()
    {
        //how to do it the noob way:
        //Console.WriteLine("User input name");
        //string UserName = Console.ReadLine();
        //Console.WriteLine("Hello " + UserName);
        //Or you can use a place holder (with multiple placeholders
        //string UserName1 = Console.ReadLine();
        //Console.WriteLine("Hello {0}, {1}", UserName, UserName1);

        //Or you can write it the cool way like this:
        //Console.WriteLine("Please enter your name");
        //Console.WriteLine("Hello " + Console.ReadLine());

        //Continue program depending on user input:
        Console.WriteLine("Please enter your name");
        Console.WriteLine("Hello " + Console.ReadLine());

        Console.WriteLine("Would you like to continue? Y/N");
        string userInput = Console.ReadLine();
        if (userInput == "Y" || userInput == "y" || userInput == "Yes" || userInput == "yes")
        {
            Console.WriteLine("The world will blow up because you agreed. Good job.");
        }
        else
        {
            Console.WriteLine("You either broke my program or you didn't want the world to blow up.");
            Console.WriteLine("You fucking nerd.");
        }
    }
}
