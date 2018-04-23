using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace staj_takip_sistemi
{
    public partial class StajDefteri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["giris"]) != true)
            {
                Response.Redirect("giriş sistemi.aspx?msg");
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string a = TextBox1.Text;
            string b = TextBox2.Text;
            int c = Convert.ToInt32(Session["UserID"]);
            DBislemleri.StajForm(a,b,c);
        }
    }
}