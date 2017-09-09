using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace innerException
{
    class innerException
    { 
        public static void Main()
        {
            try
            {
                try
                {
                    Console.WriteLine("enter first number");
                    int FN = Convert.ToInt32(Console.ReadLine()); //ReadLine stores it as a string so we must convert it to int first

                    Console.WriteLine("enter second number");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int result = FN / SN;
                    Console.WriteLine("result is = {0}", result);
                }
                ///<summary>
                ///1. So we have a program that does a simple division. So we ask the user to put in two numbers and the program divides it. The problem with
                ///this is that the user can put in alphabets, large number, or 0 which can all cause a problem for the program. So we put the program in a 
                ///TryCatch where the Catch will contain all the errors/exceptions. What we want to do with the exceptions is that we want to catch it and 
                ///store it in a log. So we first use a StreamWriter class and within that class we use a method called Write() to write the exception to the
                ///log table.
                ///</summary>
                catch (Exception ex)
                {
                    string filePath = @"C: \Users\Varun\Desktop\C# Projects\IntroCSharp\log1.txt"; //Change to log.txt to remove the innerException failure
                    if (File.Exists(filePath)) //1a. We only want to throw this exception if this file exists, if not then we want to throw a new exception
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().FullName); //2. Gets the exceptions fullname then closes all the resources being used by this 
                                                         //(variable.getErrorType.NameOfError)
                        sw.Write(" - ");
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem, try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + "not present", ex); //1b. the second parameter is what the original exception was. If the 
                                                                                       //system does not have a log file, then we will throw the new exception
                                                                                       //but we still want to keep track of the original exception that caused
                                                                                       //this new exception. Problem is that this message will be cryptic. So 
                                                                                       //we put this in a outter TryCatch block
                    }
                }
            }
            ///<summary>
            ///1C. this catch block is used when the log.txt file does not exist. This is because when this file does not exits, the else statement gets
            ///invoked where we are throwing a new exception and this catch block will catch the new filenotfoundexception. The second param we passed in the 
            ///throw new exception will be the inner exception.
            ///</summary>
            catch(Exception ex1)
            {
                Console.WriteLine("current exception = {0}", ex1.GetType().FullName);
                if (ex1.InnerException != null)
                {
                    Console.WriteLine("inner exception = {0}", ex1.InnerException.GetType().FullName);
                }
            }
        }
    }
    ///<summary>
    ///0. In a few short words, inner exceptions are just exceptions that initially caused the program to fail. But this failure caused another failure and
    ///thus to keep track of the initial failure, we use an innerException
    ///</summary>
}
