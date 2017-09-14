using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace partialClasses
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer C1 = new Customer();
            C1.FN = "John";
            C1.LN = "Wick";
            string FullName1 = C1.getFullName();
            Response.Write("Full name = " + C1.getFullName() + "</br>");

            PartialCustomer C2 = new PartialCustomer();
            C2.FN = "John";
            C2.LN = "Wick";
            string FullName2 = C2.getFullName();
            Response.Write(FullName2 + "</br>");
        }
    }
}