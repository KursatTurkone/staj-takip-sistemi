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
    public partial class StajDefterleri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["giris"]) != true)
            {
                Response.Redirect("giriş sistemi.aspx?msg");
            }
            else
            {
                DataSet Formlar = DBislemleri.Kisilericek();
                GridView1.DataSource = Formlar.Tables[0];
                GridView1.DataBind();

            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Show")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                TableRow secilisatir = GridView1.Rows[index];
                string ID = secilisatir.Cells[5].Text;
                DataSet Formlar = DBislemleri.Deftercek(ID);
                GridView2.DataSource = Formlar.Tables[0];
                GridView2.DataBind();


            }
            if (e.CommandName == "kabulet")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                TableRow secilisatir = GridView1.Rows[index];
                string ID = secilisatir.Cells[5].Text;
                DataSet onay = DBislemleri.DefterOnay(ID);

              

            }
            if (e.CommandName == "Reddet")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                TableRow secilisatir = GridView1.Rows[index];
                string ID = secilisatir.Cells[5].Text;
                DataSet onay = DBislemleri.DefterRed(ID);
                

            }
        }
    }
}