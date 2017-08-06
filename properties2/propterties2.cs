using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties2
{
    class properties2
    {
        static void Main()
        {
            //2. Previously we used this method to parse in the arguements for the different methods.
            /*            student s1 = new student();
                        s1.setID(10);
                        s1.setName("Jeff");

                        Console.WriteLine("id = {0}, name = {1}, grade = {2}", s1.getID(), s1.getName(), s1.getGrade());*/

            student s1 = new student();
            s1.ID = 10;
            s1.Name = "Jeff";

            Console.WriteLine("id = {0}, name = {1}, grade = {2}", s1.ID, s1.Name, s1.Grade);
        }
    }

    /// <summary>
    /// 1. in this method we are manually setting up the Setter and Getter methods. Below this is how to use default Getter and Setter
    /// </summary>
 /*   public class student
      {
        private int _ID;
        private string _name;
        private int _grade = 75;

        public void setID(int ID)
        {
            if (ID <= 0)
            {
                throw new Exception("Student ID cannot be 0 or Negative");
            }
            this._ID = ID;
        }

        public int getID()
        {
            return this._ID;
        }

        public void setName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be empty or empty");
            }
            this._name = Name;
        }

        public string getName()
        {
            return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
        }

        public int getGrade()
        {
            return this._grade;
       } 
    }*/

/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

    //3. this is how to use the built in set and get methods for properties.
    public class student
    {
        private int _ID; //we want this to be a read and write field
        private string _name; //we want this to be a read and write field
        private int _grade = 75; //we want this to be only a read field
        //5. these properties dont really have any logic so we can write it like this
        /*      private string _city;
                private string _email;

                public string city
                {
                    get
                    {
                        return this._city = city;
                    }
                    set
                    {
                        this._city = value;
                    }
                }

                public string email
                {
                    set
                    {
                        this._email = value;
                    }
                    get
                    {
                        return this._email = email;
                    }
                }*/
        public string city { get; set; } //this will automatically make city a private field
        public string email { get; set; }

        public int ID
        {
            set
            {
                //4. instead of using ID <= etc we use value. The acutal value of ID in the Main method, will be set into value
                if (value <= 0)
                {
                    throw new Exception("Student ID cannot be 0 or Negative");
                }
            }
            get
            {
               return this._ID;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }
        }

        public int Grade
        {
            get
            {
                return this._grade;
            }
        }
    }
}