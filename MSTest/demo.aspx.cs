using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MSTest
{
    public partial class demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            BLclass b = new BLclass();
            
            try
            {
               txtresult.Text= (txtnum.Text, txtdeno.Text).ToString();
            }
            catch(DivideByZeroException d)
            {
                Response.Write(d.Message);
            }
            catch(FormatException f)
            {
                Response.Write(f.Message);
            }
        }
    }
}