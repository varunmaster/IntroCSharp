using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class properties
    {
        static void Main()
        {
            /*student s1 = new student();
            s1.ID = -10;
            s1.name = null;
            s1.grade = 75;

            Console.WriteLine("id = {0}, name = {1}, grade = {2}", s1.ID, s1.name, s1.grade);       */

            student s1 = new student();
            s1.setID(10);
            s1.setName("Jeff");

            Console.WriteLine("id = {0}, name = {1}, grade = {2}", s1.getID(), s1.getName(), s1.getGrade());
        }
    }

    /// <summary>
    /// 1. we first created a class called student and their properties are ID, name, grade. The public in front of them allows them to be modified 
    /// anywhere in the code and allows them to take whatever type of info such as a negative ID and null Name. This is why it is bad to have them public
    /// </summary>
/*    public class student
    {
        public int ID;
        public string name;
        public int grade;
    }                           */
    
    //2. This is one way to make sure the properties dont get changed to things that are not acceptable so we mark them as private and they cannot accessed
    //anywhere outside of this class. the naming convention is usually to add a _ at the beginning of the name
    public class student
    {
        private int _ID;
        private string _name;
        private int _grade = 75;

        /// <summary>
        /// 3. in the setID method we are now setting up the conditions as to what type of ID can be set. Only IDs that positive can be set. If the ID does
        /// not match this criteria, then it will throw an error when the program is run. If they enter the correct ID then we will assign it to ID. This 
        /// method only sets the ID field
        /// </summary>
        public void setID(int ID)
        {
            if(ID <= 0)
            {
                throw new Exception("Student ID cannot be 0 or Negative");
            }
            this._ID = ID;
        }

        /// <summary>
        /// 4. In this method, we only allow this to read the ID field.
        /// </summary>
        /// <returns></returns>
        public int getID()
        {
            return this._ID;
        }

        /// <summary>
        /// 5. in this method we are setting the name. We are checking the condition that it is not empty or null. If it is, then it will throw an exception
        /// when the program is run. If the name is not null or empty then we will assign "this particular Name to _name". "this" keyword is used when 
        /// referencing a current instance of the class
        /// </summary>
        public void setName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be empty or empty");
            }
            this._name = Name;
        }

        /// <summary>
        /// 6. in this method we are getting the name that was set in the previous method and then we are assinging it to _name. if we dont initialize name
        /// using the line s1.setName and then we go to print the name then it will pring no name. We can use this in a ternary operator to shorten this.
        /// </summary>
        public string getName()
        {
            return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            /*if (string.IsNullOrEmpty(this._name))
            {
                return "No Name";
            }
            else
            {
                return this._name;
            }*/
        }

        /// <summary>
        /// 7. we dont want anyone to change the grade so we set it to only read or get. 
        /// </summary>
        /// <returns></returns>
        public int getGrade()
        {
            return this._grade;
        }
    }
}
