using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sport.admin
{
    public partial class Add_staff : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null)
            {
                Response.Redirect("../customer/login.aspx");
            }

        }

       

        protected void btnaddstaff_Click1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_staff (fname,mname,lname,address,email,doj,status) values ('" + txtfname.Text + "','" + txtmname.Text + "','" + txtlname.Text + "','" + txtaddress.Text + "','" + txtemail.Text + "','" + DateTime.Today + "','" + "Active" + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Staff Added Successfully')</script>");


        }
    }
}