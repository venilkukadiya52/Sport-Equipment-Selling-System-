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
    public partial class wishlist : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select p.*,w.*,u.* from tbl_wishlist AS w inner join tbl_product AS p ON w.product_id=p.product_id inner join tbl_user AS u ON w.user_id=u.user_id where w.user_id='" + Session["id"] + "' and qty between 1 and 100000000000    ", con);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                rpt.DataSource = dt;    
                rpt.DataBind();

                SqlCommand cmd1 = new SqlCommand("select p.*,w.*,u.* from tbl_wishlist AS w inner join tbl_product AS p ON w.product_id=p.product_id inner join tbl_user AS u ON w.user_id=u.user_id where w.user_id='" + Session["id"] + "' and qty between -1 and 1 ", con);
                SqlDataAdapter adt1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                adt1.Fill(dt1);
                Repeater1.DataSource = dt1;
                Repeater1.DataBind();
                //SqlCommand cmm = new SqlCommand("select * from tbl_product where product_id='" +  + "'", con);
                //SqlDataAdapter add = new SqlDataAdapter(cmm);
                //DataTable dd = new DataTable();

                //add.Fill(dd);

                //con.Close();
            }

        }
    }
}