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
    public partial class update : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");
        int price;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_product where product_id='" + Request.QueryString["id"] + "'", con);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                Repeater1.DataSource = dt;

                Repeater1.DataBind();

                SqlCommand cmd1 = new SqlCommand("select * from tbl_order where order_id='" + Request.QueryString["i"] + "'", con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd1);
                DataTable d = new DataTable();
                ad.Fill(d);
                
                qty.Text = d.Rows[0]["quantity"] + "";
                con.Close();
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adt = new SqlDataAdapter("select * from tbl_product where product_id='"+Request.QueryString["id"]+"'",con);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            int o = Convert.ToInt32(qty.Text);
            if (Convert.ToInt32(dt.Rows[0]["qty"].ToString()) > o)
            {
                con.Open();

                int k = Convert.ToInt32(dt.Rows[0]["qty"]) - o ;
                SqlCommand cmd5 = new SqlCommand("update tbl_product set qty='" + k + "' where product_id='" + Request.QueryString["id"] + "'", con);
                cmd5.ExecuteNonQuery();
               


                price = Convert.ToInt32(Request.QueryString["price"]);

                int t = o * price;
                SqlCommand cmd = new SqlCommand("update tbl_order set quantity='" + qty.Text + "', total='" + t + "' where order_id='" + Request.QueryString["i"] + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("cart.aspx");
            }
            else {
                Response.Write("<script>alert('You Can not Add This Many Quantity')</script>");
            }
        }
    }
}