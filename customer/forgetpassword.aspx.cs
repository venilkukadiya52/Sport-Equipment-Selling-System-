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
    public partial class forgetpassword : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                email.Visible = true;
                forgetotp.Visible = true;
                entotp.Visible = false;
                verifyotp.Visible = false;
                pass.Visible = false;
                changepass.Visible = false;
                newpass.Visible = false;
            }
        }

        protected void forgetotp_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Session["Email"] = email.Text;
            int OTP = rand.Next(111111, 999999);
            Session["otp"] = OTP;

            if (login_otp.SendOTP(Session["Email"].ToString(), OTP))
            {
               
                email.Visible = false;
                forgetotp.Visible = false;
                entotp.Visible = true;
                verifyotp.Visible = true;
                pass.Visible = false;
                changepass.Visible = false;
                newpass.Visible = false;
            }
            else
            {
                Error.Visible = true;
                Error.Text = "OTP cannot be Sent.! Check Your Internet Connectivity.";
            }
        }

        protected void verifyotp_Click(object sender, EventArgs e)
        {
            if (Session["otp"].ToString() == entotp.Text)
            {
                email.Visible = false;
                forgetotp.Visible = false;
                entotp.Visible = false;
                verifyotp.Visible = false;
                pass.Visible = true;
                changepass.Visible = true;
                newpass.Visible = true;
            }
            else
            {
                email.Visible = false;
                forgetotp.Visible = false;
                entotp.Visible = false;
                verifyotp.Visible = false;
                pass.Visible = true;
                changepass.Visible = true;
                newpass.Visible = true;
            }
        }

        protected void changepass_Click(object sender, EventArgs e)
        {
            if (pass.Text == newpass.Text)
            {

                string pl = FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Text, "SHA1");

                con.Open();
                SqlCommand cmd = new SqlCommand("update tbl_user set password='" + pl + "' where email = '" + email.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("login.aspx");
            }
            else
            {
                email.Visible = false;
                forgetotp.Visible = false;
                entotp.Visible = false;
                verifyotp.Visible = false;
                pass.Visible = true;
                changepass.Visible = true;
                newpass.Visible = true;
            }
        }
    }
}