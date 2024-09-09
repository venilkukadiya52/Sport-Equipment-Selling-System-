using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sport.admin
{
    public partial class view_deactiveproduct : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null)
            {
                Response.Redirect("../customer/login.aspx");
            }


            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_product where status='" + 0 + "'", con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            rpt.DataSource = dt;
            rpt.DataBind();
            con.Close();
        }

        protected void active_Command(object sender, CommandEventArgs e)
        {
            con.Open();
            LinkButton btn = (LinkButton)sender;
            int product_id = Convert.ToInt32(btn.CommandArgument);
            SqlCommand cmd = new SqlCommand("update tbl_product set status='" + 1 + "' where product_id='" + product_id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}