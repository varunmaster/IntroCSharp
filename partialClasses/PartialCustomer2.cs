using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace partialClasses
{
    public partial class PartialCustomer
    {
        public string getFullName()
        {
            return _FN + " " + _LN;
        }
    }
}