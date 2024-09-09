using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sport.customer
{
    public partial class header : System.Web.UI.MasterPage
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["name"] == null)
            {
                lbllogin.Visible = true;
                lbllogout.Visible = false;
                A4.Visible = false;
                A3.Visible = false;
                A1.Visible = false;


            }
            else
            {
                A4.Visible = true;
                A3.Visible = true;
                A1.Visible = true;
                lbllogin.Visible = false;
                lbllogout.Visible = true;
                lblname.Text = "Welcome " + Session["name"];
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_order where user_id='"+ Session["id"] +"' and status='"+1+"'",con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            
            adt.Fill(dt);
            cart.Text = dt.Rows.Count.ToString();
            
            SqlCommand cm = new SqlCommand("select * from tbl_wishlist where user_id='" + Session["id"] + "'", con);
            SqlDataAdapter ad = new SqlDataAdapter(cm);
            DataTable d = new DataTable();

            ad.Fill(d);
            wishlist.Text = d.Rows.Count.ToString();
            con.Close();
           


        }
    }
}