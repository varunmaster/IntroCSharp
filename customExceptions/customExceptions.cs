using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace customExceptions
{
    class customException
    {
        public static void Main()
        {
            try
            {
                throw new userAlreadyLoggedInException("User already logged in");
            }
            catch (userAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    /// <summary>
    /// 1. whenever we have our own custom exception, we always inherit from the
    /// exceptions class since the groundwork is already there
    /// </summary>

    [Serializable]
    public class userAlreadyLoggedInException : Exception
    {
        //2. here we are taking our own exceptions and then we are passing in a base class to our constructor
        public userAlreadyLoggedInException() : base()
        {
        }
        //3. in this one we are overloading our constructor
        public userAlreadyLoggedInException(string message) : base(message) { }
        public userAlreadyLoggedInException(string message, Exception innerexception) : base(message, innerexception) { }
        //4. this exception is for having multiple applications and using the same exception. Moving application object from one application to another
        public userAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
