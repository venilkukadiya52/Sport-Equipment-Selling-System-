using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sport.admin
{
    public partial class admin_product : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null)
            {
                Response.Redirect("../customer/login.aspx");
            }
            if (!IsPostBack)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_brand", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                txtbrand.DataSource = dt;
                txtbrand.DataBind();
                txtbrand.DataTextField = "brand_name";
                txtbrand.DataValueField = "brand_id";
               
                txtbrand.DataBind();
                txtbrand.Items.Insert(0, "Select");
                con.Close();
            }

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            if (FileUpload1.PostedFile != null)
            {
                string imgfile = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.SaveAs(Server.MapPath("../image/" + imgfile));
                //string imgfile = "-../customer/assets/images/"+ FileUpload1.FileName;

                string imgfile2 = Path.GetFileName(FileUpload2.PostedFile.FileName);
                FileUpload2.SaveAs(Server.MapPath("../image/" + imgfile2));

                string imgfile3 = Path.GetFileName(FileUpload3.PostedFile.FileName);
                FileUpload3.SaveAs(Server.MapPath("../image/" + imgfile3));

                string imgfile4 = Path.GetFileName(FileUpload4.PostedFile.FileName);
                FileUpload4.SaveAs(Server.MapPath("../image/" + imgfile4));

                //int val = Convert.ToInt32(txtbrand.SelectedValue);

               
                string img1= "../image/" + imgfile;
                string img2 = "../image/" + imgfile2;
                string img3 = "../image/" + imgfile3;
                string img4 = "../image/" + imgfile4;
                SqlCommand cmd = new SqlCommand("insert into tbl_product (image1,image2,image3,image4,p_name,price,sport_name,brand,size,material,age_range,status,qty)  values('"+img1+"','"+ img2+"','"+img3+"','"+img4+"','" + txtname.Text + "','" + txtprice.Text + "','" + txtspname.Text + "','"+Convert.ToInt32(txtbrand.SelectedValue)+"','" + txtsize.SelectedValue + "','" + txtmaterial.Text + "','" + txtagerange.SelectedValue + "','" + 1 + "','"+txtqty.Text+"')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Product Added Successfully')</script>");
                
            }
            else
            {
                Response.Write("<script>alert('Something Went Wrong')</script>");
            }

        }
    }
}