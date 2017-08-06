using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Classes
    {
        static void Main()
        {
            customer c1 = new customer("Hugh", "Mungus"); //we are creating an instance of the class customer aka creating an object.
                                                          //customer(...) is the constructor that shows up. We get the constuctor because
                                                          //we cant directly go into "building a house". We give the params (name) to the 
                                                          //constructor and he assembles it the way we want (FirstName = fname etc.). This 
                                                          //will create a new instance of customer
            c1.PrintName();

            customer c2 = new customer();
            c2.PrintName();
        }
    }
}

class customer
{
    string fname;
    string lname;

    public customer(string FirstName, string LastName) //this is a constructor. can be identified by not returning anything. used to
                                                       //initialize fname and lname
    {
        this.fname = FirstName;
        this.lname = LastName; //the "this." refers a instance of the class customer
    }

    public customer() : this("No FirstName", "No LastName") //this is used when there are no params passed in the Main() method.
    {

    }

    public void PrintName()
    {
        Console.WriteLine(this.fname + " " + this.lname);
    }

    ~customer() //destructors are used to clean up any resources that the classes are using. doesn't take any params
    {
        //clean up code
    }
}