using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Twilio;

namespace testWebforms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ACCOUNT_SID = "AC79b803fc2b40d78256710d5f35db3e4c";
            string AUTH_TOKEN = "6c406cef49041d34ab9b558f3f549f64";

            TwilioRestClient client = new TwilioRestClient(ACCOUNT_SID, AUTH_TOKEN);
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    client.SendSmsMessage("+14242752396", "+905327662418", " cagatay from c#");
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }


        }
    }
}