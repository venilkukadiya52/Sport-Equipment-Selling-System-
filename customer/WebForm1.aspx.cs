using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sport.customer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_order where user_id='"+Session["id"]+"' and order_id='"+Request.QueryString["id"]+"'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("cart.aspx");
        }
    }
}