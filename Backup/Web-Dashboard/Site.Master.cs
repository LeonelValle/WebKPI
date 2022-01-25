using System;
using System.Security.Principal;
using System.Web;
using System.Web.UI;

namespace Web_Dashboard
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WindowsIdentity identity = HttpContext.Current.Request.LogonUserIdentity;

            //lblUser.Text = identity.Name.Substring(4);
            lblUser.Text = Environment.UserName;

        }
    }
}