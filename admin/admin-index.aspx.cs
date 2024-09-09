    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace Sport.admin
{
    public partial class admin_index : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");
        int tot;
        int total;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null)
            {
                Response.Redirect("../customer/login.aspx");
            }
            SqlDataAdapter adttt = new SqlDataAdapter("select * from tbl_user",con);
            DataTable dtt = new DataTable();
            adttt.Fill(dtt);
            int i=Convert.ToInt32(dtt.Rows.Count)-1;
            cust.Text = i.ToString();
            SqlDataAdapter adttt1 = new SqlDataAdapter("select * from tbl_order where status='"+2+"'", con);
            DataTable dtt1 = new DataTable();
            adttt1.Fill(dtt1);
            int iii = Convert.ToInt32(dtt1.Rows.Count);
            while (iii > 0)
            {
                total = Convert.ToInt32(dtt1.Rows[iii - 1]["total"]) + total;
                iii = iii - 1;
            }
            profit.Text = total.ToString();
            SqlDataAdapter adttt2 = new SqlDataAdapter("select * from tbl_order", con);
            DataTable dtt2 = new DataTable();
            adttt2.Fill(dtt2);
            int iiii = Convert.ToInt32(dtt2.Rows.Count);
            sales.Text= iiii.ToString();
            updatedata.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_product where status='"+1+"'", con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            rpt.DataSource = dt;
            rpt.DataBind();
            con.Close();


            con.Open();
            SqlCommand c = new SqlCommand("select o.*,p.*,u.* from tbl_order AS o INNER JOIN tbl_product AS p ON o.product_id=p.product_id INNER JOIN tbl_user AS u ON o.user_id=u.user_id where o.status='"+1+"'",con);

            SqlDataAdapter ad = new SqlDataAdapter(c);
            DataTable d= new DataTable();
            ad.Fill(d);
           
            order.DataSource = d;
            order.DataBind();
            con.Close();


            con.Open();
            SqlCommand cd = new SqlCommand("select o.*,c.*,p.* from tbl_checkout AS o INNER JOIN tbl_user AS p ON o.userid=p.user_id INNER JOIN tbl_order AS c ON c.cid=o.check_id where c.status='"+ 0 +"'", con);

            SqlDataAdapter adc = new SqlDataAdapter(cd);
            DataTable dc = new DataTable();
            adc.Fill(dc);
            Repeater1.DataSource = dc;
            Repeater1.DataBind();
            con.Close();

        }



        protected void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            LinkButton btn = (LinkButton)sender;
            int product_id = Convert.ToInt32(btn.CommandArgument);
            SqlCommand cmd = new SqlCommand("update tbl_product set status='"+0+"' where product_id='" + product_id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void update_Click(object sender, EventArgs e)
        {
            updatedata.Visible=true;
            con.Open();
            LinkButton btn = (LinkButton)sender;
            int product_id = Convert.ToInt32(btn.CommandArgument);
            SqlCommand cmd = new SqlCommand("select * from tbl_product where product_id='" + product_id + "'", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable d = new DataTable();
            ad.Fill(d);
            updatedata.DataSource = d;
            updatedata.DataBind();
            con.Close();

        }

        protected void updatebtn_Click(object sender, EventArgs e)
        {
            string pname = null;
            string spname = null;
            int price = 0;
            int  qty= 0; 
            string material = null;
            string size = null;
            string age = null;
            
            foreach(RepeaterItem item in updatedata.Items)
            {
                TextBox txtpname = (TextBox)item.FindControl("txtname");
                pname = txtpname.Text;

                TextBox txtsname = (TextBox)item.FindControl("txtspname");
                spname = txtsname.Text;

                TextBox txtprice = (TextBox)item.FindControl("txtprice");
                price = Convert.ToInt32(txtprice.Text);

                TextBox txtqty = (TextBox)item.FindControl("txtqty");
                qty = Convert.ToInt32(txtqty.Text);

                DropDownList txtpsize = (DropDownList)item.FindControl("txtsize");
                size = txtpsize.Text;

                TextBox txtmaterial = (TextBox)item.FindControl("txtmaterial");
                material = txtmaterial.Text;

                DropDownList txtage = (DropDownList)item.FindControl("txtagerange");
                age = txtage.Text;
            }
        
            updatedata.Visible = true;
            con.Open();
            LinkButton btn = (LinkButton)sender;
            int product_id = Convert.ToInt32(btn.CommandArgument);
            SqlCommand cmd = new SqlCommand("update tbl_product set p_name='"+ pname + "',sport_name='" + spname + "',price='" + price + "',qty='" + qty + "',size='" + size + "',material='" + material + "',age_range='" + age + "' where product_id='" + product_id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        protected void lable_Command(object sender, CommandEventArgs e)
        {   LinkButton btn = (LinkButton)sender;
            int id= Convert.ToInt32(btn.CommandArgument);
            con.Open();
            SqlDataAdapter adt = new SqlDataAdapter("select p.*,o.*,c.* from tbl_order AS o INNER JOIN tbl_checkout AS c ON o.user_id=c.userid INNER JOIN tbl_product AS p ON p.product_id=o.product_id where o.cid='"+id+"' and o.status='"+0+"'",con);
            DataTable dt5 = new DataTable();
            adt.Fill(dt5);

            SqlDataAdapter hj = new SqlDataAdapter("select * from tbl_checkout where check_id='"+id+"'",con);
            DataTable po = new DataTable();
            hj.Fill(po);

            SqlDataAdapter gh = new SqlDataAdapter("select * from tbl_order where cid='"+id+"' and status='"+0+"'",con);
            DataTable dt55 = new DataTable();
            gh.Fill(dt55);
            int count = Convert.ToInt32(dt55.Rows.Count);
            if (dt5.Rows.Count > 0)
            {

                // string companyName = "Car Deal";
                int orderNo = 1;
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[4] {



                            new DataColumn("Product name", typeof(string)),
                             new DataColumn("Quantity", typeof(int)),
                             new DataColumn("Price", typeof(int)),
                             new DataColumn("Total", typeof(int))
    });



                while (count > 0)
                {
                    dt.Rows.Add(dt5.Rows[count - 1]["p_name"], dt5.Rows[count - 1]["quantity"], dt5.Rows[count - 1]["price"], dt5.Rows[count - 1]["total"]);
                   
                    tot += Convert.ToInt32( dt5.Rows[count - 1]["total"].ToString());
                    count -= 1;
                }
                string na = "MOLLA";
                string kl = Session["gtotal"] + "";
                string address = po.Rows[0]["address"].ToString();
                string city = po.Rows[0]["city"].ToString();
                string state = po.Rows[0]["state"].ToString();
                string pincode = po.Rows[0]["pincode"].ToString();
                string phone = po.Rows[0]["phone"].ToString();
                string name1=dt5.Rows[0]["name"].ToString();
                string num = dt5.Rows[0]["check_id"] + "";

                con.Close();

                using (StringWriter sw = new StringWriter())
                {
                    using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                    {
                        StringBuilder sb = new StringBuilder();

                        //Generate Invoice (Bill) Header.
                        sb.Append("<table width='100%' cellspacing='0' cellpadding='2'>");
                        sb.Append("<tr><h2><td align='center' style='background-color: #18B5F0' colspan = '2'><b>Car Service Bill</b></td></h2></tr>");
                        sb.Append("<tr><td colspan = '2'></td></tr>");
                        //sb.Append("<tr><td><img src='");
                        //sb.Append(image);
                        //sb.Append("' style='height:100px;' /></td></tr>");
                        //sb.Append("<div class=col-sm-4 col-6> <div><img src='");
                        //sb.Append(image);
                        //    sb.Append("' alt='' class='img-fluid'></div><br></div>");
                        sb.Append("<td><b>Order No: </b>");
                        sb.Append(id);
                        sb.Append("</td><td align = 'right'><b>Date: </b>");
                        sb.Append(DateTime.Now);
                        sb.Append(" </td></tr>");

                        sb.Append("<tr><td><b>Company Name: </b>");
                        sb.Append(na);
                        
                        sb.Append("</td><td align = 'right'><b>Address : </b>");
                        sb.Append(address);
                        sb.Append(" </td></tr>");
                        sb.Append("<tr><td><b>User Name: </b>");
                        sb.Append(name1);
                        sb.Append("</td><td align = 'right'><b>City : </b>");
                        sb.Append(city);
                        sb.Append(" </td></tr>");
                        sb.Append("<tr><td><b>Phone Number: </b>");
                        sb.Append(phone);
                        sb.Append("</td><td align = 'right'><b>State: </b>");
                        sb.Append(state);
                        sb.Append(" </td></tr>");
                        sb.Append("<tr><td><b>invoice number : </b>");
                        sb.Append(num);
                        sb.Append("</td><td align = 'right'><b>Pincode: </b>");
                        sb.Append(pincode);
                        sb.Append(" </td></tr>");


                        sb.Append("</table>");
                        sb.Append("<br />");

                        //Generate Invoice (Bill) Items Grid.
                        sb.Append("<table border = '1'>");
                        sb.Append("<tr>");
                        foreach (DataColumn column in dt.Columns)
                        {
                            sb.Append("<b><th style = 'background-color: #f06f06;color:black'></b>");
                            sb.Append(column.ColumnName);
                            sb.Append("</th>");
                        }
                        sb.Append("</tr>");
                        foreach (DataRow row in dt.Rows)
                        {
                            sb.Append("<tr>");
                            foreach (DataColumn column in dt.Columns)
                            {
                                sb.Append("<td>");
                                sb.Append(row[column]);
                                sb.Append("</td>");
                            }
                            sb.Append("</tr>");
                        }
                        sb.Append("<tr><td align = 'right' colspan = '");
                        sb.Append(dt.Columns.Count - 1);
                        sb.Append("'>Total Amount</td>");
                        sb.Append("<td>");
                        sb.Append(tot);

                        sb.Append("</td>");
                        sb.Append("</tr></table>");

                        //Export HTML String as PDF.
                        StringReader sr = new StringReader(sb.ToString());
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
                        pdfDoc.Open();
                        htmlparser.Parse(sr);
                        pdfDoc.Close();
                        Response.ContentType = "application/pdf";
                        Response.AddHeader("content-disposition", "attachment;filename=Service_" + Session["name"] + ".pdf");
                        Response.Cache.SetCacheability(HttpCacheability.NoCache);
                        Response.Write(pdfDoc);
                        Response.End();
                    }
                }

                //Response.Write("<Script>window.location.assign('Cars.aspx')</script>");

            }
        }

        protected void done_Command(object sender, CommandEventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int id = Convert.ToInt32(btn.CommandArgument);
            SqlCommand cmd = new SqlCommand("update tbl_order set status='"+2+ "' where cid='"+id+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();  
            con.Close();
        }

        protected void done_Command1(object sender, CommandEventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            string m = btn.CommandArgument.ToString();
            log.SendOTP(m.ToString());
        }




        //protected void delete_Click(object sender, EventArgs e)
        //{
        //    con.Open();
        //    //SqlCommand cmd = new SqlCommand("update tbl_product set product_id='" + product_id + "'", con);
        //    // cmd.ExecuteNonQuery();
        //    con.Close();
        //    Response.Redirect("admin-product.aspx");
        //}


    }
}