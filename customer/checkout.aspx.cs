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
using Paytm;


namespace Sport.customer
{
    public partial class checkout : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");
        int io;
        protected void Page_Load(object sender, EventArgs e)
        {
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
                total.Text = Session["gtotal"] + "";
                Label1.Text = Session["gtotal"] + "";


                SqlDataAdapter a = new SqlDataAdapter("select o.*,p.* from tbl_order AS o INNER JOIN tbl_product AS p ON o.product_id=p.product_id where o.status='" + 1 + "' and o.user_id='" + Session["id"] + "'", con);
                DataTable dt2 = new DataTable();
                a.Fill(dt2);
                rpt.DataSource = dt2;
                rpt.DataBind();
            }

        }



        protected void btncheckout_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand c = new SqlCommand("insert into tbl_checkout (name,address,city,state,pincode,phone,userid,paymentmode,date,total,status) values ('" + name.Text + "','" + address.Text + "','" + city.Text + "','" + state.Text + "','" + pincode.Text + "','" + phone.Text + "','" + Session["id"] + "','" + "online" + "','" + DateTime.Today.Date + "','" + Session["gtotal"] + "','" + "pending" + "') ", con);
            c.ExecuteNonQuery();
            con.Close();


            con.Open();
            SqlDataAdapter adt = new SqlDataAdapter("select o.*,p.* from tbl_order AS o INNER JOIN tbl_product AS p ON o.product_id=p.product_id where o.status='" + 1 + "' and o.user_id='" + Session["id"] + "'", con);
            DataTable dt5 = new DataTable();
            adt.Fill(dt5);
            int count = dt5.Rows.Count;

            SqlDataAdapter adt1 = new SqlDataAdapter("select * from tbl_checkout", con);
            DataTable dt12 = new DataTable();
            adt1.Fill(dt12);
            int count23 = (dt12.Rows.Count);
            int i = count23;
            while (count23 >= i)
            {
                SqlDataAdapter adt12 = new SqlDataAdapter("select * from tbl_checkout", con);
                DataTable dt122 = new DataTable();
                adt12.Fill(dt122);
                io = Convert.ToInt32(dt122.Rows[count23 - 1]["check_id"]);
                count23 -= 1;
            }

            SqlCommand cc = new SqlCommand("update tbl_order set status='" + 0 + "', cid='" + io + "'where status='" + 1 + "' and user_id='" + Session["id"] + "'", con);
            cc.ExecuteNonQuery();
            //        if (dt5.Rows.Count > 0)
            //        {

            //            // string companyName = "Car Deal";
            //            int orderNo = 1;
            //            DataTable dt = new DataTable();
            //            dt.Columns.AddRange(new DataColumn[4] {



            //                        new DataColumn("Product name", typeof(string)),
            //                         new DataColumn("Quantity", typeof(int)),
            //                         new DataColumn("Price", typeof(int)),
            //                         new DataColumn("Total", typeof(int))
            //});



            //            while (count > 0)
            //            {
            //                dt.Rows.Add(dt5.Rows[count - 1]["p_name"], dt5.Rows[count - 1]["quantity"], dt5.Rows[count - 1]["price"], dt5.Rows[count - 1]["total"]);
            //                count -= 1;
            //            }
            //            string na = "MOLLA";
            //            string kl = Session["gtotal"] + "";
            //            con.Close();

            //            using (StringWriter sw = new StringWriter())
            //            {
            //                using (HtmlTextWriter hw = new HtmlTextWriter(sw))
            //                {
            //                    StringBuilder sb = new StringBuilder();

            //                    //Generate Invoice (Bill) Header.
            //                    sb.Append("<table width='100%' cellspacing='0' cellpadding='2'>");
            //                    sb.Append("<tr><h2><td align='center' style='background-color: #18B5F0' colspan = '2'><b>SPORT STORE</b></td></h2></tr>");
            //                    sb.Append("<tr><td colspan = '2'></td></tr>");
            //                    //sb.Append("<tr><td><img src='");
            //                    //sb.Append(image);
            //                    //sb.Append("' style='height:100px;' /></td></tr>");
            //                    //sb.Append("<div class=col-sm-4 col-6> <div><img src='");
            //                    //sb.Append(image);
            //                    //    sb.Append("' alt='' class='img-fluid'></div><br></div>");
            //                    sb.Append("<td><b>Order No: </b>");
            //                    sb.Append(orderNo);
            //                    sb.Append("</td><td align = 'right'><b>Date: </b>");
            //                    sb.Append(DateTime.Now);
            //                    sb.Append(" </td></tr>");
            //                    sb.Append("<tr><td colspan = '2'><b>Company Name: </b>");
            //                    sb.Append(na);
            //                    sb.Append("</td></tr>");
            //                    sb.Append("<tr><td colspan = '2'><b>User Name: </b>");
            //                    sb.Append(Session["name"]);
            //                    sb.Append("</td></tr>");
            //                    sb.Append("</table>");
            //                    sb.Append("<br />");

            //                    //Generate Invoice (Bill) Items Grid.
            //                    sb.Append("<table border = '1'>");
            //                    sb.Append("<tr>");
            //                    foreach (DataColumn column in dt.Columns)
            //                    {
            //                        sb.Append("<b><th style = 'background-color: #f06f06;color:black'></b>");
            //                        sb.Append(column.ColumnName);
            //                        sb.Append("</th>");
            //                    }
            //                    sb.Append("</tr>");
            //                    foreach (DataRow row in dt.Rows)
            //                    {
            //                        sb.Append("<tr>");
            //                        foreach (DataColumn column in dt.Columns)
            //                        {
            //                            sb.Append("<td>");
            //                            sb.Append(row[column]);
            //                            sb.Append("</td>");
            //                        }
            //                        sb.Append("</tr>");
            //                    }
            //                    sb.Append("<tr><td align = 'right' colspan = '");
            //                    sb.Append(dt.Columns.Count - 1);
            //                    sb.Append("'>Total Amount</td>");
            //                    sb.Append("<td>");
            //                    sb.Append(kl);

            //                    sb.Append("</td>");
            //                    sb.Append("</tr></table>");

            //                    //Export HTML String as PDF.
            //                    StringReader sr = new StringReader(sb.ToString());
            //                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            //                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            //                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            //                    pdfDoc.Open();
            //                    htmlparser.Parse(sr);
            //                    pdfDoc.Close();
            //                    Response.ContentType = "application/pdf";
            //                    Response.AddHeader("content-disposition", "attachment;filename=Service_" + Session["name"] + ".pdf");
            //                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //                    Response.Write(pdfDoc);
            //                    Response.End();


            // payment gateway
            Random rnd = new Random();
            int txtorderid = rnd.Next(111111, 999999);
            string merchantKey = "_PCA7C2GSZgp#3Bg";  //Change this constant's value with Merchant key

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("MID", "ZFEmpP44145925215951");
            parameters.Add("CHANNEL_ID", "WEB");
            parameters.Add("INDUSTRY_TYPE_ID", "Retail");
            parameters.Add("WEBSITE", "WEBSTAGING");
            //parameters.Add("EMAIL", txtemailid.Text);
            //parameters.Add("MOBILE_NO", txtcontactno.Text);
            parameters.Add("CUST_ID", "custo");
            parameters.Add("ORDER_ID", txtorderid.ToString());
            parameters.Add("TXN_AMOUNT", Session["gtotal"].ToString());
            parameters.Add("CALLBACK_URL", "https://localhost:44348/customer/PaytmResponse.aspx");


            string checksum = Paytm.Checksum.generateSignature(parameters, merchantKey);

            //bool verifySignature = Paytm.Checksum.verifySignature(parameters, merchantKey, checksum);
            //Response.Write(checksum + "<br>");
            //Response.Write(verifySignature+"<br>");

            //if (verifySignature.ToString() == "True" )
            //{
            string paytmURL = "https://securegw-stage.paytm.in/theia/processTransaction";
            string outputHTML = "<html>";
            outputHTML += "<head>";
            outputHTML += "<title>Merchant check out page</title>";
            outputHTML += "</head>";
            outputHTML += "<body>";
            outputHTML += "<center><h1>Please do not refresh this page...</h1></center>";
            outputHTML += "<form method='post' action='" + paytmURL + "' name='f1'>";
            outputHTML += "<table border='1'>";
            outputHTML += "<tbody>";
            foreach (string Key in parameters.Keys)
            {
                outputHTML += "<input type='hidden' name='" + Key + "' value='" + parameters[Key] + "'>";
            }
            outputHTML += "<input type='hidden' name='CHECKSUMHASH' value='" + checksum + "'>";
            outputHTML += "</tbody>";
            outputHTML += "</table>";
            outputHTML += "<script type='text/javascript'>";
            outputHTML += "document.f1.submit();";
            outputHTML += "</script>";
            outputHTML += "</form>";
            outputHTML += "</body>";
            outputHTML += "</html>";
            Response.Write(outputHTML);



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adt = new SqlDataAdapter("select o.*,p.* from tbl_order AS o INNER JOIN tbl_product AS p ON o.product_id=p.product_id where o.status='" + 1 + "' and o.user_id='" + Session["id"] + "'", con);
            DataTable dt5 = new DataTable();
            adt.Fill(dt5);
            int count = dt5.Rows.Count;

            SqlDataAdapter adt1 = new SqlDataAdapter("select * from tbl_checkout", con);
            DataTable dt12 = new DataTable();
            adt1.Fill(dt12);
            int count23 = (dt12.Rows.Count);
            int i = count23;
            while (count23 >= i)
            {
                SqlDataAdapter adt12 = new SqlDataAdapter("select * from tbl_checkout", con);
                DataTable dt122 = new DataTable();
                adt12.Fill(dt122);
                io = Convert.ToInt32(dt122.Rows[count23 - 1]["check_id"]);
                count23 -= 1;
            }

            SqlCommand cc = new SqlCommand("update tbl_order set status='" + 0 + "', cid='" + io + "'where status='" + 1 + "' and user_id='" + Session["id"] + "'", con);
            cc.ExecuteNonQuery();
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
                    count -= 1;
                }
                string na = "MOLLA";
                string kl = Session["gtotal"] + "";
                con.Close();

                using (StringWriter sw = new StringWriter())
                {
                    using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                    {
                        StringBuilder sb = new StringBuilder();

                        //Generate Invoice (Bill) Header.
                        sb.Append("<table width='100%' cellspacing='0' cellpadding='2'>");
                        sb.Append("<tr><h2><td align='center' style='background-color: #18B5F0' colspan = '2'><b>SPORT STORE</b></td></h2></tr>");
                        sb.Append("<tr><td colspan = '2'></td></tr>");
                        //sb.Append("<tr><td><img src='");
                        //sb.Append(image);
                        //sb.Append("' style='height:100px;' /></td></tr>");
                        //sb.Append("<div class=col-sm-4 col-6> <div><img src='");
                        //sb.Append(image);
                        //    sb.Append("' alt='' class='img-fluid'></div><br></div>");
                        sb.Append("<td><b>Order No: </b>");
                        sb.Append(orderNo);
                        sb.Append("</td><td align = 'right'><b>Date: </b>");
                        sb.Append(DateTime.Now);
                        sb.Append(" </td></tr>");
                        sb.Append("<tr><td colspan = '2'><b>Company Name: </b>");
                        sb.Append(na);
                        sb.Append("</td></tr>");
                        sb.Append("<tr><td colspan = '2'><b>User Name: </b>");
                        sb.Append(Session["name"]);
                        sb.Append("</td></tr>");
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
                        sb.Append(kl);

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
    }
}

       

    

    