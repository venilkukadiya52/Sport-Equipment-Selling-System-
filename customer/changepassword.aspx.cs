using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;
using System.Text;

namespace Sport.customer
{
    public partial class changepassword : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void changepass_Click(object sender, EventArgs e)
        {
            if(pass.Text == newpass.Text)
            {
                string pl = FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Text, "SHA1");
                con.Open();
                SqlCommand cmd = new SqlCommand("update tbl_user set password= '"+pl+"' where user_id='"+Session["id"]+"'",con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Password change successfully')</script>");
                Response.Write("<script>window.location.assign('logout.aspx')</script>");
                //Response.Redirect("logout.aspx");
            }
            else
            {
                Response.Write("<script>alert('Password is not  change')</script>");
            }
        }
    }
}