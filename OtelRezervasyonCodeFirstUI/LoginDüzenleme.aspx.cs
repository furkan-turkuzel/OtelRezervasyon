using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtelRezervasyonCodeFirstUI
{
    public partial class LoginDüzenleme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Panel panel = (Panel)Master.FindControl("Panel1");
                panel.Visible = true;

                Panel panel1 = (Panel)Master.FindControl("Panel2");
                panel1.Visible = true;
            }
        }
    }
}