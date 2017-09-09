using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Look at assemblyOne and assemblyTwo for internal and protected internal
namespace accessModifiers
{
    #region Private and Protected Access Modifiers
    public class accessModifiers
    {
        private static void Main()
        {
            //PART A: here we see that we cannot access _id because of the private field that we added below.
            //customer c1 = new customer();
            //Console.WriteLine(c1._id);
        }
    }

    public class customer
    {
        //PART A: in this section we have a private field called _id. then we are setting up another field called ID that we can use to let a customer put
        //in their ID. ID is an intermediary between what a user sets and setting the _id. We have a get where we get the private field _id and use the set
        //to get the value that the user puts in. userinput (value) = ID = _id
        //private int _id;
        //private int ID
        //{
        //    get
        //    {
        //        return _id;
        //    }
        //    set
        //    {
        //        _id = value;
        //    }
        //}

        //PART B: protected is similar to private but the only difference is that protected can be accessed only if the parent class is being inherited.
        //In other words, since ID is in the customer class, and the CorporateCustomer class is inheriting customer class, it can now be accessed but
        //if we do no inherit from the customer class, we cannot use ID.
        protected int ID;
    }

    public class CorporateCustomer : customer
    {
        public void printID()
        {
            CorporateCustomer CC = new CorporateCustomer();
            CC.ID = 101;
        }
    }
    #endregion

    #region Internal and Protected Internal Access Modifier
    #endregion

}
