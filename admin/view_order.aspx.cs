using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sport.admin
{
    public partial class view_order : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sess.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cd = new SqlCommand("select o.*,c.*,p.* from tbl_checkout AS o INNER JOIN tbl_user AS p ON o.userid=p.user_id INNER JOIN tbl_order AS c ON c.cid=o.check_id where c.status='" + 0 + "'", con);

            SqlDataAdapter adc = new SqlDataAdapter(cd);
            DataTable dc = new DataTable();
            adc.Fill(dc);
            rpt.DataSource = dc;
            rpt.DataBind();
            con.Close();
        }
    }
}