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
    public partial class StajFormları : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["giris"]) != true)
            {
                Response.Redirect("giriş sistemi.aspx?msg");
            }
            else
            {
                DataSet Formlar = DBislemleri.Formcek();
                GridView1.DataSource = Formlar.Tables[0];
                GridView1.DataBind();

            }

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "secme")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                TableRow secilisatir = GridView1.Rows[index];
                string ID = secilisatir.Cells[4].Text;
                DataSet Formlar = DBislemleri.KisiForm(ID);

                GridView2.DataSource = Formlar.Tables[0];
                GridView2.DataBind();

            }
            if (e.CommandName == "Onay")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                TableRow secilisatir = GridView1.Rows[index];

                string FormID = secilisatir.Cells[5].Text;
                DataSet Onay = DBislemleri.FormOnay(FormID);
            }
            if (e.CommandName == "Reddet")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                TableRow secilisatir = GridView1.Rows[index];

                string FormID = secilisatir.Cells[5].Text;
                DataSet Onay = DBislemleri.FormRed(FormID);
            }
        }
    }
}