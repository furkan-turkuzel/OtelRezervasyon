using BLL.Repositories;
using Model;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtelRezervasyonCodeFirstUI
{
    public partial class Login : System.Web.UI.Page
    {
        ÜyelerManagementBLL üm;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            üm = new ÜyelerManagementBLL();
            

            Label1.Text = "";
            Label1.Visible = false;

            if (!IsPostBack)
            {
                Session.Abandon();
                FormsAuthentication.SignOut();
            }

            //OtelRezervasyonDBContext db = new OtelRezervasyonDBContext();
            //ICollection<Üye> üye = db.üyeler.ToList();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             if (txtusername.Value == "" || txtparola.Value == "")
             {
                 Label1.Text = "Boş alan bırakmayınız!!!";
                 Label1.Visible = true;
             }
             else
             {
                 string kullanıcıadı = txtusername.Value;
                 string şifre = txtparola.Value;

                 if (üm.KullanıcıAdıŞifre(kullanıcıadı,şifre) == 0)
                 {
                     Label1.Text = "Yanlış kullanıcı adı ve şifre!!!";
                     Label1.Visible = true;
                 }
                 else
                 {
                     Session["user"] = üm.KullanıcıAdıŞifre(kullanıcıadı, şifre);
                     Session["username"] = kullanıcıadı;
                     Response.Redirect("Anasayfa.aspx");
                 }
             }
        }
    }
}