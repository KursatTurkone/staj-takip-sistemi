using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace staj_takip_sistemi
{
    public partial class giriş_sistemi : System.Web.UI.Page
    {
        public string capca;
        static string baglantiyolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=stajsistemi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                Random r = new Random();
                string captcha = "";
                string[] karakterler = {"1","2","3","4","5","6","7","8","9","0" };
for (int i = 0; i < 4; i++)
                {
                    string a = karakterler[r.Next(0, karakterler.Length)];
                    captcha += a;


                }
                Label3.Text = captcha;
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Kadi = TextBox1.Text;
            string sifre = TextBox2.Text;
            string captchaK = TextBox3.Text;
            string cpt = Label3.Text;
            SqlConnection conn = new SqlConnection(baglantiyolu);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand sorgula = new SqlCommand("select * from Kisi where KullaniciAdi='"+Kadi+"'and Sifre ='"+sifre+"'",conn);
            SqlDataReader dr = sorgula.ExecuteReader();

            if (dr.Read() && (captchaK == cpt))
            {
                string YID = dr["YetkiID"].ToString();
                string UID = dr["UserID"].ToString();
                Session["Giris"] = true;
                Session["YetkiID"] = YID;
                Session["UserID"] = UID;
                Response.Redirect("Yeni.aspx");
            }
            else
            {
                Label5.Text = "Kullanıcı Adı/şifre/captcha Yanlış";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("kayit.aspx");
        }
    }
}




























