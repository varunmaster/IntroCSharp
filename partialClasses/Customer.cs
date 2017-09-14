using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace partialClasses
{
    public class Customer
    {
        private string _FN;
        private string _LN;

        //Encapsulation
        public string FN
        {
            get
            {
                return _FN;
            }
            set
            {
                _FN = value;
            }
        }

        public string LN
        {
            get
            {
                return _LN;
            }
            set
            {
                _LN = value;
            }
        }

        public string getFullName()
        {
            return _FN + " " + _LN;
        }
    }
}