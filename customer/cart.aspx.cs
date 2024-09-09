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
    public partial class cart : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");
        int ii = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("login.aspx");

            }
            else
            {
                con.Open();
                SqlCommand cm = new SqlCommand("select p.p_name,o.product_id,o.order_id,o.price,o.quantity,o.total,p.image1 from tbl_order AS o inner join tbl_product AS p ON o.product_id=p.product_id where o.user_id='" + Session["id"] + "' and o.status = '"+1+"' ", con);
               
                SqlDataAdapter adt = new SqlDataAdapter(cm);
                DataTable d = new DataTable();
                adt.Fill(d);

               rpt.DataSource = d;
                rpt.DataBind();
                con.Close();
            }
            
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
           
        //}

        protected void update_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;
            int order = Convert.ToInt32(b.CommandArgument);

            con.Open();
            //SqlCommand cmd = new SqlCommand("order", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("");
            ////SqlCommand cm = new SqlCommand("select * from tbl_order where order_id='" + order + "'", con);
            //SqlDataAdapter adt = new SqlDataAdapter(cm);
            //DataTable dt = new DataTable();
            //adt.Fill(dt);

            
           /* foreach (RepeaterItem item in dl.Items)
            {
                TextBox c = (TextBox)item.FindControl("qty.Text");
                ii = Convert.ToInt32(c.Text.ToString());
            }*/
            //int id = Convert.ToInt32(ii);
           // int pri = Convert.ToInt32(dt.Rows[0]["price"]) * id;
           
            //SqlDataAdapter a = new SqlDataAdapter("update tbl_order set quantity='"++"',price='"+pri+"' where order_id='"+order+"'",con);
            //DataTable dt2 = new DataTable();
            //a.Fill(dt2);
            //dl.DataSource = dt2;
            //dl.DataBind();


            con.Close();
        }

     

        protected void total_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cm = new SqlCommand("select * from tbl_order where status='"+1+"' and user_id='" + Session["id"] + "'", con);
            SqlDataAdapter adt = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            int total = 0;
            int i = dt.Rows.Count;
            while (i > 0)
            {
                total = Convert.ToInt32(dt.Rows[i - 1]["total"]) + total;
                i = i - 1;
            }
            Lable1.Text = total.ToString();
            Lable2.Text = total.ToString();
            Session["gtotal"] = total;
            con.Close();
        }

       
        //protected void qty_TextChanged(object sender, EventArgs e)
        //{
        //    LinkButton b = (LinkButton)sender;
        //    int order = Convert.ToInt32(b.CommandArgument);
        //    con.Open();
        //    SqlCommand cm = new SqlCommand("select * from tbl_order where order_id='" + order + "'", con);
        //    SqlDataAdapter adt = new SqlDataAdapter(cm);
        //    DataTable dt = new DataTable();
        //    adt.Fill(dt);
        //    foreach (RepeaterItem item in dl.Items)
        //    {
        //        TextBox c = (TextBox)item.FindControl("qty.Text");
        //        ii = Convert.ToInt32(c.Text);
        //    }
        //    int id = Convert.ToInt32(ii);
        //    int pri = Convert.ToInt32(dt.Rows[0]["price"]) * id;

        //    SqlDataAdapter a = new SqlDataAdapter("update tbl_order set quantity='" + id + "',price='" + pri + "' where order_id='" + order + "'", con);
        //    DataTable dt2 = new DataTable();
        //    a.Fill(dt2);
        //    dl.DataSource = dt2;
        //    dl.DataBind();
        //}


    }
}