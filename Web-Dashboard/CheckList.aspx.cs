using System;
using System.Data.SqlClient;

namespace Web_Dashboard
{
    public partial class CheckList : System.Web.UI.Page
    {
        CheckLists cl = new CheckLists();
        User users = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Disable 
            CheckMain.Visible = false;
            txt_ACfuncionaCom.Enabled = false;
            txt_AVdeteccionCom.Enabled = false;
            txt_SalarmaCom.Enabled = false;
            txt_ACfuncionaCom.Enabled = false;
            txt_NASCom.Enabled = false;
            txt_CommentWIFI.Enabled = false;
            txt_CommentTelefono.Enabled = false;
            txt_CommentPTRG.Enabled = false;
            txt_CommentOtroDisp.Enabled = false;
            txt_CommentInternet.Enabled = false;
            txt_bkponpremise.Enabled = false;
            txt_CommentSwitch.Enabled = false;
            txt_CommentBackupcloud.Enabled = false;
            txt_firewall.Enabled = false;
            txt_ispdevices.Enabled = false;
            

            rbl_ACfunciona.Enabled = false;
            rbl_AVdeteccion.Enabled = false;
            rbl_ACfunciona.Enabled = false;
            rbl_SAlarma.Enabled = false;
            rbl_WIFI.Enabled = false;
            rbl_Telefonos.Enabled = false;
            rbl_SAlarma.Enabled = false;
            rbl_PTRG.Enabled = false;
            rbl_NAS.Enabled = false;
            rbl_Internet.Enabled = false;
            rbl_Backup_onpremise.Enabled = false;
            rbl_switch.Enabled = false;
            rbl_Backup_cloud.Enabled = false;
            rbl_Firewall.Enabled = false;
            rbl_ispdevices.Enabled = false;
            

            #endregion

        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            if (rbl_ACfunciona.SelectedValue != "" && rbl_AlarmaOtroDisp.SelectedValue != "" && rbl_AVdeteccion.SelectedValue != "" && rbl_Backup_onpremise.SelectedValue != "" && rbl_Internet.SelectedValue != "" && rbl_NAS.SelectedValue != ""
                && rbl_PTRG.SelectedValue != "" && rbl_SAlarma.SelectedValue != "" && rbl_switch.SelectedValue != "" && rbl_Telefonos.SelectedValue != "" && rbl_WIFI.SelectedValue != "" && rbl_switch.SelectedValue != "")
            {
                cl.Crud("insert into CheckList (ac, comment_ac, av, comment_av, alarm_server, comment_alarmserver, alarm_nas, comment_alarmnas, other_disp, comment_otherdisp, tel, comment_tel, internet, comment_internet, ptrg,comment_ptrg," +
                    " wifi,comment_wifi, switch,comment_switch,bkp_onpremise, bkp_onpremise_comment, bkp_cloud, bkp_cloud_comment, firewall, firewall_comment, isp, isp_comment, switch, comment_switch username, dateReg) values('"
                    + rbl_ACfunciona.SelectedValue + "','" + txt_ACfuncionaCom.Text + 
                    "','" + rbl_AVdeteccion.SelectedValue + "','" + txt_AVdeteccionCom.Text +
                    "','" + rbl_SAlarma.SelectedValue + "','" + txt_SalarmaCom.Text + 
                    "','" + rbl_NAS.SelectedValue + "','" + txt_NASCom.Text + 
                    "','" + rbl_AlarmaOtroDisp.SelectedValue + "','" + txt_CommentOtroDisp.Text +
                    "','" + rbl_Telefonos.SelectedValue + "','" + txt_CommentTelefono.Text + 
                    "','" + rbl_Internet.SelectedValue + "','" + txt_CommentInternet.Text + 
                    "','" + rbl_PTRG.SelectedValue + "','" + txt_CommentPTRG.Text +
                    "','" + rbl_WIFI.SelectedValue + "','" + txt_CommentWIFI.Text + 
                    "','" + rbl_Backup_onpremise.SelectedValue + "','" + txt_bkponpremise.Text + 
                    "','" + rbl_Backup_cloud.SelectedValue + "','" + txt_CommentBackupcloud.Text + 
                    "','" + rbl_Firewall.SelectedValue + "','" + txt_firewall.Text + 
                    "','" + rbl_ispdevices.SelectedValue + "','" + txt_ispdevices.Text +
                    "','" + rbl_switch.SelectedValue + "','" + txt_CommentSwitch.Text +
                    users.Name + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "')");

            }
        }

        protected void txt_Date_TextChanged(object sender, EventArgs e)
        {
            txt_Date.Text.ToString();

            if (DateTime.Parse(txt_Date.Text) < DateTime.Now)
            {
                GetFields();
                CheckMain.Visible = true;
            }
        }

        private void GetFields()
        {

            try
            {
                SqlDataReader leer = cl.Leer("Select * from CheckList where dateReg = '" + txt_Date.Text + "'");

                if (leer.Read() == true)
                {
                    cl.id_cl = int.Parse(leer["id_cl"].ToString());

                    //ddl_Username.SelectedValue = leer["username"].ToString();

                    txt_ACfuncionaCom.Text = leer["comment_ac"].ToString();
                    txt_AVdeteccionCom.Text = leer["comment_av"].ToString();
                    txt_SalarmaCom.Text = leer["comment_alarmserver"].ToString();
                    txt_NASCom.Text = leer["comment_alarmnas"].ToString();
                    txt_CommentPTRG.Text = leer["comment_ptrg"].ToString();
                    txt_CommentWIFI.Text = leer["comment_wifi"].ToString();
                    txt_CommentTelefono.Text = leer["comment_tel"].ToString();
                    txt_CommentOtroDisp.Text = leer["comment_otherdisp"].ToString();
                    txt_CommentInternet.Text = leer["comment_internet"].ToString();
                    //txt_CommentBackup.Text = leer["comment_backup"].ToString();
                    txt_CommentSwitch.Text = leer["comment_backup"].ToString();

                    rbl_ACfunciona.SelectedValue = Convert.ToInt32(bool.Parse(leer["ac"].ToString())).ToString();
                    rbl_AVdeteccion.SelectedValue = Convert.ToInt32(bool.Parse(leer["av"].ToString())).ToString();
                    rbl_Backup_onpremise.SelectedValue = Convert.ToInt32(bool.Parse(leer["backups"].ToString())).ToString();
                    rbl_Telefonos.SelectedValue = Convert.ToInt32(bool.Parse(leer["tel"].ToString())).ToString();
                    rbl_WIFI.SelectedValue = Convert.ToInt32(bool.Parse(leer["wifi"].ToString())).ToString();
                    rbl_SAlarma.SelectedValue = Convert.ToInt32(bool.Parse(leer["alarm_server"].ToString())).ToString();
                    rbl_PTRG.SelectedValue = Convert.ToInt32(bool.Parse(leer["ptrg"].ToString())).ToString();
                    rbl_NAS.SelectedValue = Convert.ToInt32(bool.Parse(leer["alarm_nas"].ToString())).ToString();
                    rbl_Internet.SelectedValue = Convert.ToInt32(bool.Parse(leer["internet"].ToString())).ToString();
                    rbl_switch.SelectedValue = Convert.ToInt32(bool.Parse(leer["switch"].ToString())).ToString();
                    rbl_AlarmaOtroDisp.SelectedValue = Convert.ToInt32(bool.Parse(leer["other_disp"].ToString())).ToString();


                }
                else
                {
                    txt_SalarmaCom.Text = "";
                    txt_NASCom.Text = "";
                    txt_CommentWIFI.Text = "";
                    txt_CommentTelefono.Text = "";
                    txt_CommentPTRG.Text = "";
                    txt_CommentOtroDisp.Text = "";
                    txt_CommentInternet.Text = "";
                    //txt_CommentBackup.Text = "";
                    txt_AVdeteccionCom.Text = "";
                    txt_ACfuncionaCom.Text = "";
                    txt_CommentSwitch.Text = "";

                    rbl_WIFI.SelectedIndex = -1;
                    rbl_Telefonos.SelectedIndex = -1;
                    rbl_SAlarma.SelectedIndex = -1;
                    rbl_PTRG.SelectedIndex = -1;
                    rbl_NAS.SelectedIndex = -1;
                    rbl_Internet.SelectedIndex = -1;
                    rbl_Backup_onpremise.SelectedIndex = -1;
                    rbl_AVdeteccion.SelectedIndex = -1;
                    rbl_AlarmaOtroDisp.SelectedIndex = -1;
                    rbl_ACfunciona.SelectedIndex = -1;
                    rbl_switch.SelectedIndex = -1;

                }


                cl.Cerrar();
            }
            catch (System.InvalidOperationException)
            {
                cl.Cerrar();
                //throw;
            }
        }

        protected void Btn_New_Click(object sender, EventArgs e)
        {
            CheckMain.Visible = true;
            txt_ACfuncionaCom.Enabled = true;
            txt_AVdeteccionCom.Enabled = true;
            txt_SalarmaCom.Enabled = true;
            txt_ACfuncionaCom.Enabled = true;
            txt_NASCom.Enabled = true;
            txt_CommentWIFI.Enabled = true;
            txt_CommentTelefono.Enabled = true;
            txt_CommentPTRG.Enabled = true;
            txt_CommentOtroDisp.Enabled = true;
            txt_CommentInternet.Enabled = true;
            //txt_CommentBackup.Enabled = true;
            //txt_CommentBackup.Enabled = true;
            txt_CommentSwitch.Enabled = true;
            rbl_ACfunciona.Enabled = true;
            rbl_AVdeteccion.Enabled = true;
            rbl_ACfunciona.Enabled = true;
            rbl_SAlarma.Enabled = true;
            rbl_WIFI.Enabled = true;
            rbl_Telefonos.Enabled = true;
            rbl_SAlarma.Enabled = true;
            rbl_PTRG.Enabled = true;
            rbl_NAS.Enabled = true;
            rbl_Internet.Enabled = true;
            rbl_Backup_onpremise.Enabled = true;
            rbl_switch.Enabled = true;
        }

        protected void btn_Edit_Click(object sender, EventArgs e)
        {
            if ( txt_Date.Text != ""
                && rbl_ACfunciona.SelectedValue != "" && rbl_AlarmaOtroDisp.SelectedValue != "" && rbl_AVdeteccion.SelectedValue != "" && rbl_Backup_onpremise.SelectedValue != "" && rbl_Internet.SelectedValue != "" && rbl_NAS.SelectedValue != ""
                && rbl_PTRG.SelectedValue != "" && rbl_SAlarma.SelectedValue != "" && rbl_switch.SelectedValue != "" && rbl_Telefonos.SelectedValue != "" && rbl_WIFI.SelectedValue != "" && rbl_switch.SelectedValue != "")
            {
                cl.Crud("update CheckList set ac = '" + rbl_ACfunciona.SelectedValue
                    + "', comment_ac = '" + txt_ACfuncionaCom.Text.Trim() + "', av = '" + rbl_AVdeteccion.SelectedValue + "', comment_av = '" + txt_AVdeteccionCom.Text.Trim() + "', alarm_server = '"
                    + rbl_SAlarma.SelectedValue + "', comment_alarmserver = '" + txt_SalarmaCom.Text.Trim() + "', alarm_nas = '" + rbl_NAS.SelectedValue + "', comment_alarmnas = '" + txt_NASCom.Text.Trim()
                    + "', other_disp = '" + rbl_AlarmaOtroDisp.SelectedValue + "', comment_otherdisp = '" + txt_CommentOtroDisp.Text.Trim() + "', tel = '" + rbl_Telefonos.SelectedValue + "', comment_tel = '"
                    + txt_CommentTelefono.Text.Trim() + "', internet = '" + rbl_Internet.SelectedValue + "', comment_internet = '" + txt_CommentInternet.Text.Trim() + "', ptrg = '" + rbl_PTRG.SelectedValue 
                    + "', firewall = '" + rbl_Internet.SelectedValue + "', firewall_comment = '" + txt_CommentInternet.Text.Trim() + "', isp = '" + rbl_PTRG.SelectedValue + "', isp_comment = '" + txt_ispdevices.Text.Trim()
                    + "', ap = '" + rbl_Internet.SelectedValue + "', ap_comment = '" + txt_CommentInternet.Text.Trim() + "', bkp_onpremise = '" + rbl_PTRG.SelectedValue + "', bkp_onpremise_comment = '" + rbl_Backup_onpremise.Text.Trim()
                    + "', bkp_cloud = '" + rbl_PTRG.SelectedValue + "', bkp_cloud_comment = '"
                    + "', comment_ptrg = '" + txt_CommentPTRG.Text.Trim() + "', wifi = '" + rbl_WIFI.SelectedValue + "', comment_wifi = '" + txt_CommentWIFI.Text.Trim() + "', username = '" + users.Name
                    + "' where id_cl = '" + cl.id_cl + "'");

            }

        }

        protected void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Date.Text = "";
            txt_ACfuncionaCom.Text = "";
            txt_AVdeteccionCom.Text = "";
            //txt_CommentBackup.Text = "";
            txt_CommentInternet.Text = "";
            txt_CommentOtroDisp.Text = "";
            txt_CommentPTRG.Text = "";
            txt_CommentSwitch.Text = "";
            txt_CommentTelefono.Text = "";
            txt_CommentWIFI.Text = "";
            txt_NASCom.Text = "";
            txt_SalarmaCom.Text = "";

            rbl_ACfunciona.SelectedIndex = -1;
            rbl_AlarmaOtroDisp.SelectedIndex = -1;
            rbl_AVdeteccion.SelectedIndex = -1;
            rbl_Backup_onpremise.SelectedIndex = -1;
            rbl_Internet.SelectedIndex = -1;
            rbl_NAS.SelectedIndex = -1;
            rbl_PTRG.SelectedIndex = -1;
            rbl_SAlarma.SelectedIndex = -1;
            rbl_switch.SelectedIndex = -1;
            rbl_Telefonos.SelectedIndex = -1;
            rbl_WIFI.SelectedIndex = -1;

        }
    }
}