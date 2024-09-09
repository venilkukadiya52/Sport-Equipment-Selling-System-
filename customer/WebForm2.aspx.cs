using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sport.customer
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<script>alert('helo')</script>");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_wishlist where user_id='" + Session["id"] + "' and wish_id='" + Request.QueryString["id"] + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("wishlist.aspx");

        }
    }
}