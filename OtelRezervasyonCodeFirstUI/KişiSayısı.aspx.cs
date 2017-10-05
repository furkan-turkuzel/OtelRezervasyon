using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtelRezervasyonCodeFirstUI.Rezervasyonİşlemleri
{
    public partial class KişiSayısı : System.Web.UI.Page
    {
        OtelRezervasyonDBContext db;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["user"] == null)
            //{
            //    Response.Redirect("~/Login.aspx");
            //}
            //else
            //{
            //    Panel panel = (Panel)Master.FindControl("Panel1");
            //    panel.Visible = true;

            //    Panel panel1 = (Panel)Master.FindControl("Panel2");
            //    panel1.Visible = true;
            //}
            db = new OtelRezervasyonDBContext();
            Label2.Visible = false;
            Label2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int toplamKişi;
            toplamKişi = (from r in db.rezervasyon
                          select (int?)r.KişiSayısı).Sum() ?? 0;
            if (txtkişisayısı.Text == "")
            {
                Label2.Text = "Bir sonraki sayfaya geçmek için kişi sayısı girilmelidir!!!";
                Label2.Visible = true;
            }
            else
            {
                try
                {
                    int kişiSayısı = Convert.ToInt32(txtkişisayısı.Text);
                    if (kişiSayısı == 0)
                    {
                        Label2.Text = "0'dan farklı bir sayı girmelisiniz!!!";
                        Label2.Visible = true;
                    }
                    else if (kişiSayısı > (60 - toplamKişi))
                    {
                        Label2.Text = "Otelimizde şu an bu kadar boş yer bulunmamaktadır!!!";
                        Label2.Visible = true;
                    }
                    else
                    {
                        Session["kişiSayısı"] = txtkişisayısı.Text;
                        Response.Redirect("RezervasyonOdalar.aspx");
                    }
                
                }
                catch (Exception)
                {

                    Label2.Text = "Lütfen sayı formatında veri girişi yapınız!!!";
                    Label2.Visible = true;
                }
            }
                
           
        }
    }
}