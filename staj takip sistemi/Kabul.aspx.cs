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
    public partial class Kabul : System.Web.UI.Page
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
                    
                    int b = Convert.ToInt32(Session["UserID"]);
                    DataSet kabuller = DBislemleri.Kabuller(b);

                    GridView1.DataSource = kabuller.Tables[0];
                    GridView1.DataBind();
                    DataSet kabuller2 = DBislemleri.Kabuller2(b);

                    GridView4.DataSource = kabuller2.Tables[0];
                    GridView4.DataBind();

                  

    
                    DataSet kabuller3 = DBislemleri.Kabuller3(b);

                    GridView3.DataSource = kabuller3.Tables[0];
                    GridView3.DataBind();

                }






















            }
        }
    }
}