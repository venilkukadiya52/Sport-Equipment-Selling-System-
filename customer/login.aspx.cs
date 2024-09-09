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
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

            otp.Visible = false;
            verify.Visible = false;
            password.Visible = false;
            register.Visible = false;
        }
        protected void login_Clicked(object sender, EventArgs e)
        {
            string pl = FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Text, "SHA1");

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_user where email='" + username.Text + "' and password='" + pl + "'", con);
            DataTable dt = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(dt);
            con.Close();
            try
            {
                Session["id"] = dt.Rows[0]["user_id"];
                Session["name"] = dt.Rows[0]["name"];
                if (dt.Rows[0]["role"].ToString() == "1")
                {
                    Response.Redirect("index.aspx");
                }
                else
                {
                    if (dt.Rows[0]["role"].ToString() == "0")
                    {
                        Session["name"] = "admin";
                        Response.Redirect("../admin/admin-index.aspx");
                    }
                }
            }
            catch
            {
                Response.Write("<script>alert('Invalid UserName Or Password')</script>");
            }
            
        }

        protected void sendotp_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("select * from tbl_user where email='" + email.Text + "'", con);
            DataTable dt = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter(cmd1);
            adt.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                Random rand = new Random();
                Session["Email"] = email.Text;
                int OTP = rand.Next(111111, 999999);
                Session["otp"] = OTP;

                if (login_otp.SendOTP(Session["Email"].ToString(), OTP))
                {

                    otp.Visible = true;
                    verify.Visible = true;
                    password.Visible = false;
                    register.Visible = false;
                }
                else
                {
                    Error.Visible = true;
                    Error.Text = "OTP cannot be Sent.! Check Your Internet Connectivity.";
                }
            }

            else
            {
                Response.Write("<script>alert('Email Id Already Exist')</script>");
            }
        }

        protected void verify_Click(object sender, EventArgs e)
        {

            sendotp.Visible = false;
            if (Session["otp"].ToString() == otp.Text.ToString())
            {
                password.Visible = true;
                register.Visible = true;
                otp.Visible = false;
                verify.Visible = false;
                sendotp.Visible = false;
            }
            else
            {
                Response.Write("<script>alert('Enter Valid OTP')</script>");
            }
        }

        protected void register_Click(object sender, EventArgs e)
        {
            
                string pl = FormsAuthentication.HashPasswordForStoringInConfigFile(password.Text, "SHA1");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tbl_user (name , email , password, status , role) values('" + name.Text + "','" + email.Text + "','" + pl + "', ' " + "active" + " ',' " + 1 + " ')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Register Successfull')</script>");
            


        }
    }
}