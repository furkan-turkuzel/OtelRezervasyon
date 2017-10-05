using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Repositories;
using Model.Entity;

namespace OtelRezervasyonCodeFirstUI
{
    public partial class Signup : System.Web.UI.Page
    {
        ÜyelerManagementBLL üm;
        protected void Page_Load(object sender, EventArgs e)
        {
            üm = new ÜyelerManagementBLL();
            Label1.Text = "";
            Label1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Value == "" && txtlastname.Value == "" && txtfirstname.Value == "" && txtpassword.Value == "" && txtpasswordconfirm.Value == "")
            {
                Label1.Text = "Lütfen boş alan bırakmayınız!!!";
                Label1.Visible = true;

            }
            else
            {
                if (txtpassword.Value != txtpasswordconfirm.Value)
                {
                    Label1.Text = "Parolalar uyuşmuyor!!!";
                    Label1.Visible = true;
                }
                else
                {
                    Üye üye = new Üye();

                    üye.KullanıcıAdı = txtusername.Value;
                    üye.İsim = txtfirstname.Value;
                    üye.Soyisim = txtlastname.Value;
                    üye.Parola = txtpassword.Value;
                    üye.AktifMi = true;

                    üm.Ekle(üye);

                    Response.Redirect("Login.aspx");
                }
            }
        }


    }
}