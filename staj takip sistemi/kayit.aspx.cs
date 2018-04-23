using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace staj_takip_sistemi
{
    public partial class kayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet Yetkiler = new DataSet();
                Yetkiler = DBislemleri.YetkiCek();
                DropDownList1.DataTextField = "YetkiAdi";
                DropDownList1.DataValueField = "YetkiID";
                DropDownList1.DataSource = Yetkiler.Tables[0];
                DropDownList1.DataBind();
                

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string kuladi = TextBox1.Text;
            string adi = TextBox2.Text;
            string soyadi = TextBox3.Text;
            string Sifre = TextBox4.Text;
            int yetID = Convert.ToInt32(DropDownList1.SelectedValue);
            bool Kvarmi = DBislemleri.KadiKontrol(kuladi);
            if (yetID == 1)
            {
                if (Kvarmi == false)
                {
                    DBislemleri.Ekle(kuladi, adi, soyadi, Sifre, yetID);
                    Label7.Text = "Eklendi";

                }
                else
                {
                    Label7.Text = "Bu Kullanıcı Adı daha önce kullanılmıştır";
                }
            }
            else
            {
                TextBox4.Visible = false;
                if (Kvarmi == false)
                {
                    DBislemleri.Ekle(kuladi, adi,soyadi, Sifre, yetID);
                    Label7.Text = "Eklendi";

                }
                else
                {
                    Label7.Text = "Bu Kullanıcı Adı daha önce kullanılmıştır";
                }

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int yetID = Convert.ToInt32(DropDownList1.SelectedValue);
            if (yetID == 1)
            {

            }
            else
            {
                TextBox4.Visible = false;
            }
        }
    }
}