using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace staj_takip_sistemi
{
    public partial class Stajformu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["giris"]) != true)
            {
                Response.Redirect("giriş sistemi.aspx?msg");
            }
            else
            {
                int a = Convert.ToInt32(Session["YetkiID"]);
                int b = Convert.ToInt32(Session["UserID"]);

            }
        }

            protected void Button1_Click(object sender, EventArgs e)
        {
            string StajYeri = TextBox1.Text;
            string bastarih = TextBox2.Text;
            string bittarih = TextBox3.Text;
            string Adres = TextBox4.Text;
            string tel = TextBox6.Text;
            string Gun = TextBox7.Text;
            int b = Convert.ToInt32(Session["UserID"]);
            DBislemleri.StajForm1(StajYeri,bastarih,bittarih,Adres,tel,Gun,b);
        }
    }
}