using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exceptionHandling
{
    class exceptionHandling
    {
        public static void Main()
        {
            ///<summary>
            ///0. the objective here is that we have a sample text file that we want to read and then print whatever is in the file to the console
            ///</summary>
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\Users\Varun\Desktop\C# Projects\IntroCSharp\exceptionHandling.txt");
                //1. there is built in class callled StreamReader that takes a path to the file desired and then reads it. To do this, we first have to
                //create a new instance of the class and then give the argument to the path of the file
                Console.WriteLine(streamReader.ReadToEnd()); //2. the StreamReader class has a method called ReadToEnd() that reads all characters from current
                                                             //position to the end of the stream
                //streamReader.Close();//3. What this does is that is closes and releases any system resources that may have been used by this. Frees up CPU.
            }

            ///<summary>
            ///4. we have now changed the file name to 1exceptionHandling so now the streamReader method will not be able to find the file. the problem with
            ///this is that when the compiler is running that line, the streamReader.Close will not run meaning that your resources are still being used so 
            ///we put it inside of a try/catch so if a line does not work then it will skip to the catch part and then we can close the resources and also 
            ///without having the custom exception, someone who has bad intentions can now see the directory you are trying to access.
            ///</summary>

            //5.
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine();
            //    Console.WriteLine(ex.StackTrace);
            //} //We usually dont show this to the end user but rather we store this info in some DB and then have a DBA or someone look at them. Instread we
            //use the below:

            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check if the file {0} exists",ex.FileName);
            }
            //6. the most generic exception handling is ALWAYS at the bottom, otherwise you'll get a build error
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                Console.WriteLine("Finally block is getting executed");
            }
        }
    }
}