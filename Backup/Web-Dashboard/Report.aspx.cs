using System;

namespace Web_Dashboard
{
    public partial class Report : System.Web.UI.Page
    {
        CheckLists cl = new CheckLists();
        protected void Page_Load(object sender, EventArgs e)
        {
            //gv_Report.DataSource = cl.LlenarDG("select case when backups = 1 then 'Ok' else 'No' end as 'Backup', comment_backup as 'Backup Detail', case when ac = 1 then 'Ok' else 'No' end as 'A/C', comment_ac as 'A/C Detail', case when av = 1 then 'Ok' else 'No' end as 'Antivirus', comment_av as 'Antivirus Detail', case when alarm_server = 1 then 'Ok' else 'No' end as 'Server', comment_alarmserver as 'Server Detail', case when alarm_nas = 1 then 'Ok' else 'No' end as 'NAS', comment_alarmnas as 'NAS Detail', case when other_disp = 1 then 'Ok' else 'No' end as 'Other Devices', comment_otherdisp as 'Other Device Detail', case when tel = 1 then 'Ok' else 'No' end as 'Telefono', comment_tel as 'Telefono Detail', case when internet = 1 then 'Ok' else 'No' end as 'Internet', comment_internet as 'Internet Detail', case when ptrg = 1 then 'Ok' else 'No' end as 'PTRG', comment_ptrg as 'PTRG Detail', case when wifi = 1 then 'Ok' else 'No' end as 'WIFI', comment_wifi as 'WIFI Detail', case when switch = 1 then 'Ok' else 'No' end as 'Switch', comment_switch as 'Switch Detail',username as 'User', dateReg as 'Date Check' from CheckList").Tables[0];
            //gv_Report.DataBind();
            if (!IsPostBack)
            {
                bindGridView();
            }

        }

        protected void gv_Report_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            gv_Report.PageIndex = e.NewPageIndex;
            bindGridView(); //bindgridview will get the data source and bind it again
        }

        private void bindGridView()
        {
            gv_Report.DataSource = cl.LlenarDG("select username as 'User', dateReg as 'Date Check', case when backups = 1 then 'Ok' else 'No' end as 'Backup', comment_backup as 'Backup Detail', case when ac = 1 then 'Ok' else 'No' end as 'A/C', comment_ac as 'A/C Detail', case when av = 1 then 'Ok' else 'No' end as 'Antivirus', comment_av as 'Antivirus Detail', case when alarm_server = 1 then 'Ok' else 'No' end as 'Server', comment_alarmserver as 'Server Detail', case when alarm_nas = 1 then 'Ok' else 'No' end as 'NAS', comment_alarmnas as 'NAS Detail', case when other_disp = 1 then 'Ok' else 'No' end as 'Other Devices', comment_otherdisp as 'Other Device Detail', case when tel = 1 then 'Ok' else 'No' end as 'Telefono', comment_tel as 'Telefono Detail', case when internet = 1 then 'Ok' else 'No' end as 'Internet', comment_internet as 'Internet Detail', case when ptrg = 1 then 'Ok' else 'No' end as 'PTRG', comment_ptrg as 'PTRG Detail', case when wifi = 1 then 'Ok' else 'No' end as 'WIFI', comment_wifi as 'WIFI Detail', case when switch = 1 then 'Ok' else 'No' end as 'Switch', comment_switch as 'Switch Detail' from CheckList order by dateReg desc").Tables[0];
            gv_Report.DataBind();
        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(date1.Value) < DateTime.Parse(date2.Value))
            {
                gv_Report.DataSource = cl.LlenarDG("select username as 'User', dateReg as 'Date Check', case when backups = 1 then 'Ok' else 'No' end as 'Backup', comment_backup as 'Backup Detail', case when ac = 1 then 'Ok' else 'No' end as 'A/C', comment_ac as 'A/C Detail', case when av = 1 then 'Ok' else 'No' end as 'Antivirus', comment_av as 'Antivirus Detail', case when alarm_server = 1 then 'Ok' else 'No' end as 'Server', comment_alarmserver as 'Server Detail', case when alarm_nas = 1 then 'Ok' else 'No' end as 'NAS', comment_alarmnas as 'NAS Detail', case when other_disp = 1 then 'Ok' else 'No' end as 'Other Devices', comment_otherdisp as 'Other Device Detail', case when tel = 1 then 'Ok' else 'No' end as 'Telefono', comment_tel as 'Telefono Detail', case when internet = 1 then 'Ok' else 'No' end as 'Internet', comment_internet as 'Internet Detail', case when ptrg = 1 then 'Ok' else 'No' end as 'PTRG', comment_ptrg as 'PTRG Detail', case when wifi = 1 then 'Ok' else 'No' end as 'WIFI', comment_wifi as 'WIFI Detail', case when switch = 1 then 'Ok' else 'No' end as 'Switch', comment_switch as 'Switch Detail' from CheckList where dateReg between '" + date1.Value + " 00:00:00' and '" + date2.Value + " 23:59:59' order by dateReg desc").Tables[0];
                gv_Report.DataBind();

            }
        }
    }
}