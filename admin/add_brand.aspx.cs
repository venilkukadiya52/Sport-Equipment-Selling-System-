using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sport.admin
{
    public partial class add_brand : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null)
            {
                Response.Redirect("../customer/login.aspx");
            }
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
        
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tbl_brand (brand_name,status) values ('" + txtbrd.Text + "','" + "Active" + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Brand Added Successfully')</script>");
            
        }

        //protected void btnsave_Click(object sender, EventArgs e)
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("insert into tbl_brand (brand_name,status) values ('" + txtbrd.Text + "','" + "Active" + "')", con);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    Response.Write("<script>alert('Brand Added Successfully')</script>");

        //}
    }
}