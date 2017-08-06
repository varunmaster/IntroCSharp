using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInTypes
{
    class Types
    {
        static void Main()
        {
            // floats and long can hold decimals 
            bool foo = true;
            int i = 0;
            int j = 0;

            //Console.WriteLine("Min = {0}", int.MinValue);

            // USING STRINGS // 
            
            //if you want to print the quotes then or have "special charcters" (double quotes, new line, etc.) then you have to use the forward slash to tell the compiler to treat it as 
            //stirng. These are called escape sequence. Basically, whatever you want to print out, just put a forward slash in front of it and it'll pring that character.
            Console.WriteLine("\"hello\"");
            Console.WriteLine("One\nTwo\nThree");
            Console.WriteLine("C:\\Users\\Varun\\Desktop");

            //if you have an long directory to write out then using the double forward slashes will get tedious. Instead you use the @ symbol and it will treat all escape sequences as 
            //string instead. Basically, everything will be treated as a string. 
            string dir = @"C:\Users\Varun\Desktop\Folder1\stuff";
            Console.WriteLine(dir);
        }
    }
}
