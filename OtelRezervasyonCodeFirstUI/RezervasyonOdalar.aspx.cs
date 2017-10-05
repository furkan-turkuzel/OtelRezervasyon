using BLL.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace OtelRezervasyonCodeFirstUI
{
    public partial class RezervasyonOdalar : System.Web.UI.Page
    {
        OtelRezervasyonDBContext db;
        int kişiSayısı;
        int OdaSayısı;
        public static int yeterliOdaSayısı;
        RezervasyonManagementBLL rm = new RezervasyonManagementBLL();
        OdalarManagementBLL om = new OdalarManagementBLL();
        MüşteriOdaRezervasyonBLL mor = new MüşteriOdaRezervasyonBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new OtelRezervasyonDBContext();
            OdaSayısıHesapla(); //kalacak kişi sayısına göre minimum oda sayısını bulan metot
            OdaSayısı = db.oda.Count();
            
            for (int i = 0; i < OdaSayısı; i++)
            {
                int OdaTip = (from o in db.oda where o.OdaNumarası == (i + 1) select o.OdaTipiID).FirstOrDefault();
                bool OdaBoşMu = (from o in db.oda where o.OdaNumarası == (i + 1) select o.BoşMu).SingleOrDefault();
                int sonRezerv = (from mşr in db.müşteriodarezervasyon where mşr.OdaNumarası == (i + 1) orderby mşr.RezervasyonID 
                                     descending select mşr.RezervasyonID).FirstOrDefault();
                DateTime çıkış = (from r in db.rezervasyon where r.RezervasyonID == sonRezerv select r.ÇıkışTarihi).SingleOrDefault();

                Panel panel = new Panel();
                panel.ID = "OdaPanel0" + (i + 1);
                panel.Width = 200;
                panel.Height = 250;

                if (OdaBoşMu == false && çıkış > DateTime.Now)
                {
                   panel.BackColor = System.Drawing.Color.Orange;  
                }
                else
                {
                   panel.BackColor = System.Drawing.Color.Green;
                }
                

                panel.Attributes.Add("runat", "server");
                panel.Style.Add("float","left");
                panel.Style.Add("padding", "10px");
                panel.Style.Add("margin", "20px");
                panel.Style.Add("margin-left","100px");
                panel.Style.Add("text-align","center");
                panel.Style.Add("position","absulute");


                Image image = new Image();
                image.Width = 180;
                image.Height = 150;

                if (OdaTip == 1)
                {
                    image.ImageUrl = "Assets/img/standart.jpg";
                }
                else if (OdaTip == 2)
                {
                    image.ImageUrl = "Assets/img/suit.jpg";
                }
                else if (OdaTip == 3)
                {
                    image.ImageUrl = "Assets/img/lux.jpg";
                }


                Button btn1 = new Button();
                Button btn2 = new Button();
                btn1.ID = "btn1" + (i + 1);
                btn2.ID = "btn2" + (i + 1);
                btn1.Width=80;
                btn2.Width=80;
                btn1.BackColor = System.Drawing.Color.Yellow;
                btn2.BackColor = System.Drawing.Color.LightBlue;

                btn1.Height = 40;
                btn2.Height = 40;

                btn1.Style.Add("margin-top","10px;");
                btn2.Style.Add("margin-top", "10px;");

                btn1.Style.Add("margin-right","20px");

                btn1.Style.Add("font-size","12px");
                btn2.Style.Add("font-size","12px");

                btn1.Text = "Detay Gör";
                btn2.Text = "Rezerve et";

                btn1.Click += new EventHandler(btn1_Click);
                btn2.Click += new EventHandler(btn2_Click);

                TextBox no = new TextBox();
                no.Width=120;
                no.Height=30;
                no.Style.Add("border-radius","30px");
                no.Style.Add("left","20px");
                no.Style.Add("top","0px");
                no.Style.Add("margin-left","20px");
                no.Style.Add("font-size","16px");
                no.Style.Add("font-weight","bold");
                no.BackColor = System.Drawing.Color.Red;
                no.Style.Add("text-align","center");
                int Odano = (from o in db.oda where o.OdaNumarası == (i + 1) select o.OdaNumarası).FirstOrDefault();
                string tür = (from ot in db.odatipi where ot.OdaTipiID == (from o in db.oda where o.OdaNumarası == (Odano) 
                              select o.OdaTipiID).FirstOrDefault() select ot.OdaTipleri).FirstOrDefault();
                no.Text = Odano.ToString()+" - "+tür;

                if (!IsPostBack)
                {
                    if (çıkış < DateTime.Now && OdaBoşMu == false)
                    {
                        Oda güncellecek = om.Getir(i + 1);
                        güncellecek.BoşMu = true;
                        güncellecek.AktifMi = true;
                        om.Güncelle(güncellecek);
                    }
                }
                    

                panel.Controls.Add(no);
                ana.Controls.Add(panel);
                panel.Controls.Add(image);
                panel.Controls.Add(btn1);
                panel.Controls.Add(btn2);
            }
        }

        public void OdaSayısıHesapla()
        {
            kişiSayısı = Convert.ToInt32(Session["kişiSayısı"]);

            if (kişiSayısı % 3 == 0)
            {
                yeterliOdaSayısı = kişiSayısı / 3;
            }
            else
            {
                yeterliOdaSayısı = (kişiSayısı / 3) + 1;
            }
        }


        protected void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string ID = btn.ID;
            int number = 0;
            int oda;

            try
            {
                int.TryParse(ID.Substring(3, 3), out number);
                oda = Convert.ToInt32(ID.Substring(4, 2));
            }
            catch (Exception)
            {
                oda = Convert.ToInt32(ID.Substring(4, 1));
            }

            bool boşmu = (from o in db.oda where o.OdaNumarası == (oda) select o.BoşMu).Single();
            bool müsaitmi = (from o in db.oda where o.OdaNumarası == (oda) select o.AktifMi).Single();
            int sonRezerv = (from mşr in db.müşteriodarezervasyon where mşr.OdaNumarası == (oda) orderby mşr.RezervasyonID 
                                 descending select mşr.RezervasyonID).FirstOrDefault();
            DateTime çıkış = (from r in db.rezervasyon where r.RezervasyonID == sonRezerv select r.ÇıkışTarihi).SingleOrDefault();
            string açıklama = (from ot in db.odatipi
                               where ot.OdaTipiID == (from o in db.oda where o.OdaNumarası == (oda)
                                    select o.OdaTipiID).FirstOrDefault() select ot.Açıklama).FirstOrDefault();
            decimal fiyat = (from ot in db.odatipi
                             where ot.OdaTipiID == (from o in db.oda where o.OdaNumarası == (oda)
                                                   select o.OdaTipiID).FirstOrDefault() select ot.OdaFiyatı).FirstOrDefault();
            string mesaj;

                if (boşmu == true)
                {
                    mesaj = "Bu oda : "+açıklama + " " + "Bu odanın fiyatı : "+ fiyat + "TL."+" " 
                        +"Bu oda Şu an müsaittir. Rezervasyon yapabilirsiniz...";
                }
                else
                {
                    if (sonRezerv != 0)
                    {
                        mesaj = "Bu oda : "+açıklama + " " + "Bu odanın fiyatı : "+ fiyat + "TL."+" "+
                            "Bu oda "+çıkış.ToString().Substring(0,9) + " tarihine kadar doludur!!!";
                    }
                    else
                    {
                        mesaj = "Bir hata oluştu!!!";
                    }
                    
                 }
            DetayBilgiEkranı(mesaj);
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string ID = btn.ID;
            int number = 0;
            int oda;

            try
            {
                int.TryParse(ID.Substring(3, 3), out number);
                oda = Convert.ToInt32(ID.Substring(4, 2));
            }
            catch (Exception)
            {
                oda = Convert.ToInt32(ID.Substring(4, 1));
            }

            if (btn.Text == "Rezerve et")
            {
                Oda rezerveOda = om.Getir(oda);
                rezerveOda.BoşMu = false;
                rezerveOda.AktifMi = false;
                om.Güncelle(rezerveOda);

                btn.BackColor = System.Drawing.Color.Blue;
                btn.Text = "Çıkar";
                btn.ForeColor = System.Drawing.Color.Red;

                string mesaj = oda + " numaralı odalar rezerve edilenler listesine eklendi";

                RezervasyonBilgiEkranı(mesaj);
            }
            else
            {
                Oda rezerveOda = om.Getir(oda);
                rezerveOda.BoşMu = true;
                rezerveOda.AktifMi = true;
                om.Güncelle(rezerveOda);

                btn.BackColor = System.Drawing.Color.LightBlue;
                btn.Text = "Rezerve Et";
                btn.ForeColor = System.Drawing.Color.Black;
            }

                
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("KişiSayısı.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int seçilenodasayısı = (from o in db.oda where o.AktifMi == false && o.BoşMu == false select o.OdaNumarası).Count();
            if (seçilenodasayısı == 0)
            {
                string mesaj = "Hiç oda seçmediniz!!! Lütfen en az " + yeterliOdaSayısı + " oda seçiniz";
                OdaSayısıBilgiEkranı(mesaj);
            }
            else if (seçilenodasayısı < yeterliOdaSayısı)
	        {
		        string mesaj = "Seçtiğiniz odalar kalacak kişi sayısı için yeterli değil!!! En az "+ yeterliOdaSayısı+" oda seçmelisiniz";
                OdaSayısıBilgiEkranı(mesaj);
	        }
            else
            {
                Session["seçiliOdaSayısı"] = seçilenodasayısı;
                Response.Redirect("RezervasyonBilgiler.aspx");
            }
            
            
        }


        protected void DetayBilgiEkranı(string mesaj)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), 
                "Message Box", "<script language='javascript'>alert('" + mesaj + "')</script>");
        }

        protected void RezervasyonBilgiEkranı(string mesaj)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(),
                "Message Box", "<script language='javascript'>alert('"+mesaj+"')</script>");
        }

        protected void OdaSayısıBilgiEkranı(string mesaj)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(),
                "Message Box", "<script language='javascript'>alert('" + mesaj + "')</script>");  
        }

   
    }
}