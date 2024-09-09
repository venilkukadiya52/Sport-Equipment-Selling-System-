using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Client_payment_getway_payment : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\CarDealDB.mdf;Integrated Security=True;User Instance=True");
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null)
        {
            Response.Redirect("../login.aspx");
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('you have to login first')", true);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        con.Open();

        SqlCommand c = new SqlCommand("select * from tbl_order where order_id = '" + Request.QueryString[0] + "' and user_id='" + Request.QueryString[1] + "'", con);
        //int i =  c.ExecuteNonQuery();
        SqlDataAdapter adt = new SqlDataAdapter(c);
        DataTable dt = new DataTable();
        adt.Fill(dt);



        //if (dt.Rows.Count == 0)
        //{

        //    SqlCommand cmd = new SqlCommand("insert into tbl_Booking (Car_Id,User_Id,Booking_Status,Booking_Date,Booking_Amount,Payment_Mode)values('" + Request.QueryString[0] + "','" + Request.QueryString[1] + "','" + "Booked" + "','" + DateTime.Today + "','"+25000+"','"+"Online"+"')", con);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    Response.Write("<script>alert('Car Booked Successfully')</script>");
            
        //    //Response.Redirect("../Cars.aspx");
        //    //ScriptManager.RegisterStartupScript(this, this.GetType(), "ALERT", "alert('heeloo');", true);
        //    Response.Write("<script language='javascript'>window.alert('Car Booked Successfully');window.location='../Cars.aspx';</script>");
        //}
        //else
        //{
        //    //Response.Write("<script>alert('Car mBooked Successfully')</script>");
        //    //Response.Redirect("../Cars.aspx");
        //    //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('This Car Already Booked');window.open('../Cars.aspx');", true);
        //    Response.Write("<script language='javascript'>window.alert('This Car Was Already Booked By you');window.location='../Cars.aspx';</script>");
        //}
       }
    }
