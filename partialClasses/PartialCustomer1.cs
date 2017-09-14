using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace partialClasses
{
    public partial class PartialCustomer
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
    }
}