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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void pdf_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adt = new SqlDataAdapter("select * from tbl_user", con);
            DataTable dt5 = new DataTable();
            adt.Fill(dt5);

            if (dt5.Rows.Count > 0)
            {

               // string companyName = "Car Deal";
                int orderNo = 1;
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[2] {



                            new DataColumn("name", typeof(string)),
                             new DataColumn("email", typeof(string))
    });


                //  SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\GUI\Documents\Visual Studio 2010\WebSites\WebSite1\App_Data\Database.mdf;Integrated Security=True;User Instance=True");
                SqlCommand cmd6 = new SqlCommand("select * from tbl_user", con);
                //  SqlCommand cmd1 = new SqlCommand("select * from tbl_ServiceCetagory where Service_Type='" + Session["service"] + "'", con);
               
                SqlDataAdapter ad = new SqlDataAdapter(cmd6);
                DataTable d = new DataTable();
                ad.Fill(d);



                int s = d.Rows.Count;

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
                        sb.Append(orderNo);
                        sb.Append("</td><td align = 'right'><b>Date: </b>");
                        sb.Append(DateTime.Now);
                        sb.Append(" </td></tr>");
                        sb.Append("<tr><td colspan = '2'><b>Company Name: </b>");
                        sb.Append(d.Rows[0][1]);
                        sb.Append("</td></tr>");
                        sb.Append("<tr><td colspan = '2'><b>User Name: </b>");
                        sb.Append(d.Rows[0][1]);
                        sb.Append("</td></tr>");
                        sb.Append("<tr><td colspan = '2'><b>Car Name: </b>");
                        sb.Append(d.Rows[0][1]);
                        sb.Append("</td></tr>");
                        sb.Append("<tr><td colspan = '2'><b>Car Price: </b>");
                        sb.Append(d.Rows[0][1]);
                        sb.Append("</td></tr>");
                        sb.Append("<tr><td colspan = '2'><b>Service Type: </b>");
                        sb.Append(d.Rows[0][1]);
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
                        Response.AddHeader("content-disposition", "attachment;filename=Service_" + d.Rows[0]["name"] + ".pdf");
                        Response.Cache.SetCacheability(HttpCacheability.NoCache);
                        Response.Write(pdfDoc);
                        Response.End();
                    }
                }

                Response.Write("<Script>window.location.assign('Cars.aspx')</script>");

            }

        }

    }

        }
    
