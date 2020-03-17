using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace MSTest
{
    public partial class AGETEST : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            BLage bl = new BLage();
            DateTime dob = DateTime.Parse(txtdate.Text);
            try
            {
                txtage.Text = bl.age(dob).ToString();
            }
            catch(CustomException c)
            {
                Response.Write(c.Message);
            }
            


        }
    }
}