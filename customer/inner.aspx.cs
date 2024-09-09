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
    public partial class inner : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_product where product_id='" + Request.QueryString["id"] + "'", con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            Repeater1.DataSource = dt;

            Repeater1.DataBind();
            con.Close();
            //Response.Redirect("inner.aspx");

        }



        protected void add_Click(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from tbl_product where product_id='" + Request.QueryString["id"] + "'", con);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);

                //int q;
                //if (qty.Text != null)
                //{
                //    q = 1 * Convert.ToInt32(qty.Text);

                //}
                int o = Convert.ToInt32(dt.Rows[0]["qty"]);
                if (o > Convert.ToInt32( qty.Text.ToString()) && Convert.ToInt32(qty.Text.ToString()) > 0)
                {
                    int k = Convert.ToInt32(dt.Rows[0]["qty"]) - Convert.ToInt32(qty.Text);
                    SqlCommand cmd5 = new SqlCommand("update tbl_product set qty='" + k + "' where product_id='" + Request.QueryString["id"] + "'", con);
                    cmd5.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("select order_id from tbl_order where product_id='" + Request.QueryString["id"] + "' and user_id='" + Session["id"] + "' and status='" + 1 + "'", con);
                    //con.Open();
                    int result =Convert.ToInt32(cmd1.ExecuteScalar());
                    SqlDataAdapter ad = new SqlDataAdapter(cmd1);
                    DataTable dt5 =new DataTable();
                    ad.Fill(dt5);

                    SqlCommand cm1 = new SqlCommand("select * from tbl_order where product_id='" + Request.QueryString["id"] + "' and user_id='" + Session["id"] + "' and status='" + 1 + "'", con);
                    SqlDataAdapter ad7 = new SqlDataAdapter(cm1);
                    DataTable dt55 = new DataTable();
                    ad7.Fill(dt55);

                    //con.Close();
                    if (result > 0)
                    {
                        int qt = Convert.ToInt32(qty.Text) + Convert.ToInt32(dt55.Rows[0]["quantity"]);
                        SqlCommand dt3 = new SqlCommand("update tbl_order set quantity='" + qt + "' where order_id='" + result + "'", con);
                        dt3.ExecuteNonQuery();

                    }
                    else
                    {
                        int q = Convert.ToInt32(qty.Text);
                        int total = Convert.ToInt32(dt.Rows[0]["price"]) * q;
                        SqlCommand cm = new SqlCommand("insert into tbl_order (user_id,product_id,quantity,total,price,status) values('" + Session["id"] + "','" + Request.QueryString["id"] + "','" + qty.Text + "','" + total + "','" + dt.Rows[0]["price"] + "',' " + 1 + " ')", con);
                        cm.ExecuteNonQuery();

                    }
                    //SqlDataAdapter new1 = new SqlDataAdapter("select count(order_id) from tbl_order where product_id='"+Request.QueryString["id"]+"' and user_id='"+Session["user_id"]+"' and status='"+1+"'",con);
                    //DataTable dt2 = new DataTable();
                    //new1.Fill(dt2);
                    //if (dt2.Rows.Count > 0)
                    //{
                    //    int qt = Convert.ToInt32(qty.Text) + Convert.ToInt32(dt2.Rows[0]["quantity"]);
                    //    SqlCommand dt3 = new SqlCommand("update tbl_order set quantity='"+qt+"' where order_id='"+dt2.Rows[0]["order_id"]+"'", con);
                    //    dt3.ExecuteNonQuery();

                    //}
                    //else
                    //{
                    //    int q = Convert.ToInt32(qty.Text);
                    //    int total = Convert.ToInt32(dt.Rows[0]["price"]) * q;
                    //    SqlCommand cm = new SqlCommand("insert into tbl_order (user_id,product_id,quantity,total,price,status) values('" + Session["id"] + "','" + Request.QueryString["id"] + "','" + qty.Text + "','" + total + "','" + dt.Rows[0]["price"] + "',' " + 1 + " ')", con);
                    //    cm.ExecuteNonQuery();
                    //}
                    Response.Write("<script>alert('product added sucessfully in cart')</script>");
                    Response.Write("<script>window.location.assign('prod.aspx')</script>");


                }
                else
                {
                    Response.Write("<script>alert('Something Went Wrong')</script>");
                }

                con.Close();
            }


        }

        protected void wishlist_Click(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                SqlCommand cm = new SqlCommand("select * from tbl_wishlist where product_id='"+Request.QueryString["id"]+"'", con);

                SqlDataAdapter ad = new SqlDataAdapter(cm);
                DataTable d = new DataTable();
                ad.Fill(d);
                con.Open();
                if (d.Rows.Count == 0)
                {
                    SqlCommand cmd = new SqlCommand("insert into tbl_wishlist(user_id,product_id) values('" + Session["id"] + "','" + Request.QueryString["id"] + "') ", con);
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('product added sucessfully in wishlist')</script>");
                    con.Close();
                }
                else {
                    Response.Write("<script>alert('Not Added')</script>");
                }
            }
        }
    }
}