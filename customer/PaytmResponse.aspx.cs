using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sport.customer
{
    public partial class PaytmResponse : System.Web.UI.Page
    {
        string merchantKey = "_PCA7C2GSZgp#3Bg";  //Change this constant's value with Merchant key
        Dictionary<string, string> paramList = new Dictionary<string, string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string paytmChecksum = string.Empty;
            foreach (string key in Request.Form.Keys)
            {
                if (key.Equals("CHECKSUMHASH"))
                {
                    paytmChecksum = Request.Form[key];
                }
                else
                {
                    paramList.Add(key.Trim(), Request.Form[key].Trim());
                }
            }
            bool isValidChecksum = Paytm.Checksum.verifySignature(paramList, merchantKey, paytmChecksum);
            //string TXNID = paramList["TXNID"];
            Session["ORDER_ID"] = paramList["ORDERID"];

            if (isValidChecksum)
            {
                if (paramList["STATUS"].Equals("TXN_SUCCESS"))
                {
                    Response.Redirect("success.aspx");
                }
            }
            else
            {

                //Send Order
                Response.Redirect("error.aspx");
            }

        }
    }
}