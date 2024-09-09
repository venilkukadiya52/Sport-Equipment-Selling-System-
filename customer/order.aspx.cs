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
    public partial class order : System.Web.UI.Page
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
                con.Open();
                SqlCommand cm1 = new SqlCommand("select p.p_name,o.product_id,o.order_id,o.price,o.quantity,o.status,o.total,p.image1 from tbl_order AS o inner join tbl_product AS p ON o.product_id=p.product_id where o.user_id='" + Session["id"] + "' and o.status = '" + 1 + "' ", con);

                SqlDataAdapter adt1 = new SqlDataAdapter(cm1);
                DataTable d1 = new DataTable();
                adt1.Fill(d1);
                //int count = d.Rows.Count;
                //while ()
                //{
                //    if (d.Rows[count -1]["status"] == "2")
                //    {


                //    }
                //        }
                Repeater1.DataSource = d1;
                Repeater1.DataBind();
                con.Close();
                SqlCommand cm = new SqlCommand("select p.p_name,o.product_id,o.order_id,o.price,o.quantity,o.status,o.total,p.image1 from tbl_order AS o inner join tbl_product AS p ON o.product_id=p.product_id where o.user_id='" + Session["id"] + "' and o.status = '" + 2 + "' ", con);

                SqlDataAdapter adt = new SqlDataAdapter(cm);
                DataTable d = new DataTable();
                adt.Fill(d);
                //int count = d.Rows.Count;
                //while ()
                //{
                //    if (d.Rows[count -1]["status"] == "2")
                //    {

                        
                //    }
                //        }
                rpt.DataSource = d;
                rpt.DataBind();
                con.Close();
            }
        }
    }
}