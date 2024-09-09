using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Sport.customer
{
    public partial class profile : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            email.ReadOnly = true;
            if (!IsPostBack)
            {
                
                SqlCommand cmd = new SqlCommand("select * from tbl_user where user_id='" + Session["id"] + "'", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
               
                name.Text = dt.Rows[0][1].ToString();
                email.Text = dt.Rows[0][2].ToString();
                phone.Text = dt.Rows[0][8].ToString();
                pincode.Text = dt.Rows[0][7].ToString();
                city.Text = dt.Rows[0][5].ToString();
                state.Text = dt.Rows[0][6].ToString();
                address.Text = dt.Rows[0][4].ToString();
            }
        }


        protected void update_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("update tbl_user set name='" + name.Text + "',address='" + address.Text + "',city='" + city.Text + "',state='" + state.Text + "',pincode='" + Convert.ToString(pincode.Text) + "',contctnumber='" + Convert.ToString(phone.Text) + "' where user_id='" + Session["id"] + "'", con);
         
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('update profile sucessfully')</script>");
            con.Close();

        
        }
    }
}