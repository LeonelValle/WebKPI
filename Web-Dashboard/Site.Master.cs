using System;
using System.Web.UI;

namespace Web_Dashboard
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LDAPAutenticador lDAP = new LDAPAutenticador();
            User user = new User();
            //WindowsIdentity identity = HttpContext.Current.Request.LogonUserIdentity;

            //lblUser.Text = identity.Name.Substring(4);
            user.Name = Session["name"].ToString();
            lblUser.Text = user.Name;

        }
    }
}