using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringAndStringBuilder
{
    class stringAndStringBuilder
    {
        public static void Main()
        {
            ///<summary>
            ///1. the difference between system.string and system.StringBuilder is that stringbuilder is more efficient than the other. the reason for this
            ///is because when you use system.string (in this case) it creates a reference variable that is on the heap and will point to the value of "C#"
            ///then when you concatenate it or want to add more strings to it, it will then point to "C# Video" and the reference to "C#" will still be 
            ///there on the heap that will take up space. Whereas, if you used stringbuilder, it will update the same refernce variable in the heap and 
            ///will no longer have orphaned refernces in the heap. 
            ///</summary>
            string userString = "C#";
            userString += "video";
            userString += "tutorial";
            userString += "text";
            userString += "stuff";

            StringBuilder userString1 = new StringBuilder("C#");
            userString1.Append("Video");
            userString1.Append("tutorial");
            userString1.Append("text");
            userString1.Append("stuff");
            userString1.ToString();
        }
    }
}
