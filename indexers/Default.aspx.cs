using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace indexers
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Session 1"] = "Session 1 data";
            Session["Session 2"] = "Session 2 data";

            Response.Write("Sesstion 1 data = " + Session[0].ToString());
            Response.Write("</br>");
            Response.Write("Sesstion 2 data = " + Session["Session 2"].ToString());
            Response.Write("</br>");
            Response.Write("</br>");
            Response.Write("</br>");
            Response.Write("</br>");

            company comp = new company();
            Response.Write("Name of emp with ID = 2: " + comp[2]);
            Response.Write("</br>");
            Response.Write("Name of emp with ID = 5: " + comp[5]);
            Response.Write("</br>");
            Response.Write("Name of emp with ID = 8: " + comp[8]);
            Response.Write("</br>");

            Response.Write("Changing names of employees with ID = 2, 5, 8");
            Response.Write("</br>");
            Response.Write("</br>");

            comp[1] = "Emp with ID 1 name changed";
            comp[3] = "Emp with ID 3 name changed";
            comp[4] = "Emp with ID 4 name changed";

            Response.Write("Name of emp with ID = 1: " + comp[1]);
            Response.Write("</br>");
            Response.Write("Name of emp with ID = 3: " + comp[3]);
            Response.Write("</br>");
            Response.Write("Name of emp with ID = 4: " + comp[4]);
            Response.Write("</br>");

            Response.Write("</br>");
            Response.Write("</br>");
            Response.Write("</br>");
            Response.Write("Here begins on overloading of the indexers");
            Response.Write("Total male employees = " + comp["Male"]);
            Response.Write("Total female employees = " + comp["Female"]);
            Response.Write("Now we will change the gender of the employee");
            Response.Write("</br>");
            Response.Write("</br>");
            //change the male employee's gender to female
            comp["Male"] = "Female";
            Response.Write("Total female employees = " + comp["Female"]);
        }
    }
}