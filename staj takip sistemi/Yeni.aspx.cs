using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staj_takip_sistemi
{
    public partial class Yeni : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Convert.ToBoolean(Session["giris"]) != true)
                {
                    Response.Redirect("giriş sistemi.aspx?msg");
                }
                else
                {
                    int a = Convert.ToInt32(Session["YetkiID"]);
                    int b = Convert.ToInt32(Session["UserID"]);
                 

                   if (a == 1)
                   {
                      DataSet firmalar   = DBislemleri.Firmalar();
                        
                       GridView1.DataSource = firmalar.Tables[0];
                        GridView1.DataBind();
                        GridView2.Visible = false;
                        Button6.Visible = false;
                        Button7.Visible = false;
                        Button8.Visible = false;



                    }
                   else if(a==2)
                    {
                      Button3.Visible = false;
                       Button2.Visible = false;
                        GridView1.Visible = false;
                        Button4.Visible = false;
                        Button5.Visible = false;
                        Button7.Visible = false;
                        
                        DataSet istek = DBislemleri.istekler(b);
                        GridView2.DataSource = istek.Tables[0];
                        GridView2.DataBind();
                        
                    }
                   else if (a==3)
                    {
                        Button3.Visible = false;
                        Button2.Visible = false;
                        GridView1.Visible = false;
                        Button4.Visible = false;
                        Button5.Visible = false;
                        GridView2.Visible = false;
                        Button6.Visible = false;



                    }
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("giriş sistemi.aspx?msg");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string secilen = "";
            foreach (GridViewRow satır in GridView1.Rows)
            {
                CheckBox secim = (CheckBox)satır.FindControl("CheckBox2");
                secilen = "";
                if (secim.Checked)
                {
                    secilen = satır.Cells[2].Text;
                    int a = Convert.ToInt32(secilen);
                    int b = Convert.ToInt32(Session["UserID"]);
                    DBislemleri.degistir(a,b);
                }
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string secilen = "";
            foreach (GridViewRow satır in GridView2.Rows)
            {
                CheckBox secim = (CheckBox)satır.FindControl("CheckBox3");
                CheckBox secim2 = (CheckBox)satır.FindControl("CheckBox4");
                secilen = "";
                if (secim.Checked)
                {
                    
                    secilen = satır.Cells[3].Text;
                    int a = Convert.ToInt32(secilen);
                   
                  
                    DBislemleri.kabul(a);
                }
                if (secim2.Checked)
                {
                    secilen = satır.Cells[3].Text;
                    int a = Convert.ToInt32(secilen);


                    DBislemleri.red(a);
               

                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Kabul.aspx?msg");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Stajformu.aspx?msg");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("StajDefteri.aspx?msg");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("StajFormları.aspx?msg");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("StajDefterleri.aspx?msg");
        }

      
    }
}
























