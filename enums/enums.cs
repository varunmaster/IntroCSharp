using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    class enums
    {
        public static void Main()
        {
            //over here we cant tell what gender means untill we scroll down
            customer[] customers = new customer[] { };
            customers[0] = new customer
            {
                custName = "Mark",
                gender = Gender.Male
            };
            customers[1] = new customer
            {
                custName = "Mary",
                gender = Gender.Female
            };
            customers[2] = new customer
            {
                custName = "Jack",
                gender = Gender.unknown
            };

            //1. the problem here is that if we display 0,1,2 to the users then they wont know what that means so what we instead do is create a new class
            //that takes in the gender numbers and then parses in the english name for it. another problem with this is that when someone else is working
            //on this code then they wont know which numbers represent which gender so we use Enums to take place of the gender number. this will also get
            //rid of the switch function down below.
            foreach (customer c in customers)
            {
                Console.WriteLine("Name = {0} & Gender = {1}", c.custName, getGender(c.gender));
            }
        }

        //convert the gender numbers to words
        public static string getGender(Gender gender)
        {
            switch (gender)
            {
                //case 0: //instead of us specifying that 0 is unkown, we use the Gender type enum that we created below and then use the paramter we set
                          //in that enum
                case Gender.unknown:
                    return "unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid gender";
            }
        }
    }

    public enum Gender
    {
        unknown,
        Male,
        Female
    }

    //gender 0 - Unknown
    //gender 1 - Male
    //gender 2 - female
    public class customer
    {
        public string custName { get; set; }
        //public int gender { get; set; }  //we remove the int value type and enter Gender so the program knows it is referring to the Gender enum
        public Gender gender { get; set; }
    }
}
