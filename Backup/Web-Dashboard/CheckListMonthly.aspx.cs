using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Dashboard
{
    public partial class CheckListMonthly : System.Web.UI.Page
    {
        Monthly monthly = new Monthly();
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Disable 
            CheckMain.Visible = false;
            //txt_ACfuncionaCom.Enabled = false;
            //txt_AVdeteccionCom.Enabled = false;
            //txt_SalarmaCom.Enabled = false;
            //txt_ACfuncionaCom.Enabled = false;
            //txt_NASCom.Enabled = false;
            //txt_CommentWIFI.Enabled = false;
            //txt_CommentTelefono.Enabled = false;
            //txt_CommentPTRG.Enabled = false;
            //txt_CommentOtroDisp.Enabled = false;
            //txt_CommentInternet.Enabled = false;
            //txt_CommentBackup.Enabled = false;
            //txt_CommentSwitch.Enabled = false;
            //rbl_ACfunciona.Enabled = false;
            //rbl_AVdeteccion.Enabled = false;
            //rbl_ACfunciona.Enabled = false;
            //rbl_SAlarma.Enabled = false;
            //rbl_WIFI.Enabled = false;
            //rbl_Telefonos.Enabled = false;
            //rbl_SAlarma.Enabled = false;
            //rbl_PTRG.Enabled = false;
            //rbl_NAS.Enabled = false;
            //rbl_Internet.Enabled = false;
            //rbl_Backup.Enabled = false;
            //rbl_switch.Enabled = false;
            #endregion
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

        protected void Btn_New_Click(object sender, EventArgs e)
        {
            CheckMain.Visible = true;
        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            if (rbl_UpdateMeraki.SelectedValue != "" && rbl_UpdatesWAP.SelectedValue != "" && rbl_WindowsUpdates.SelectedValue != "" && rb_bloquearusb.SelectedValue != "")
            {
                monthly.Crud("insert into CheckListMonthly (WindowsUpdates, Comment_WindowsUpdates, UpdateMeraki, Comment_UpdateMeraki, UpdatesWAP, Comment_UpdatesWAP, BloquearUSB, Comment_BloquearUSB, username, dateReg) values('"
                    + rbl_WindowsUpdates.SelectedValue + "','" + txt_CommentWindowsUpdates.Text + "','" + rbl_UpdateMeraki.SelectedValue + "','" + txt_CommentUpdateMeraki.Text +
                    "','" + rbl_UpdatesWAP.SelectedValue + "','" + txt_CommentUpdateMeraki.Text + "','" + rbl_UpdatesWAP.SelectedValue + "','" + txt_CommentUpdatesWAP.Text +
                    "','" + ddl_Username.Text.Trim() + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "')");

            }
        }

        protected void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Commentbloquearusb.Text = "";
            txt_CommentUpdateMeraki.Text = "";
            txt_CommentUpdatesWAP.Text = "";
            txt_CommentWindowsUpdates.Text = "";
            txt_Date.Text = "";

            rbl_UpdateMeraki.SelectedIndex = -1;
            rbl_UpdatesWAP.SelectedIndex = -1;
            rbl_WindowsUpdates.SelectedIndex = -1;
            rb_bloquearusb.SelectedIndex = -1;
        }

        protected void btn_Edit_Click(object sender, EventArgs e)
        {
            if (ddl_Username.Text != "UserName" && txt_Date.Text != "" && rbl_UpdatesWAP.SelectedValue != "" && rbl_UpdateMeraki.SelectedValue != "" && rbl_WindowsUpdates.SelectedValue != "" && rb_bloquearusb.SelectedValue != "")
            {
                monthly.Crud("update CheckListMonthly set UpdateMeraki = '" + rbl_UpdateMeraki.SelectedValue + "', Comment_UpdateMeraki = '" + txt_CommentUpdateMeraki.Text.Trim()
                    + "', UpdatesWAP = '" + rbl_UpdatesWAP.SelectedValue + "', Comment_UpdatesWAP = '" + txt_CommentUpdatesWAP.Text.Trim()
                    + "', WindowsUpdates = '" + rbl_WindowsUpdates.SelectedValue + "', Comment_WindowsUpdates = '" + txt_CommentWindowsUpdates.Text.Trim()
                    + "', BloquearUSB = '" + rb_bloquearusb.SelectedValue + "', Comment_BloquearUSB = '" + txt_Commentbloquearusb.Text.Trim()
                    + "', username = '" + ddl_Username.Text
                    + "' where id_clw = '" + monthly.Id_clm + "'");

            }
        }

        private void GetFields()
        {

            try
            {
                SqlDataReader leer = monthly.Leer("Select * from CheckListMonthly where dateReg = '" + txt_Date.Text + "'");

                if (leer.Read() == true)
                {
                    monthly.Id_clm = int.Parse(leer["id_clm"].ToString());

                    ddl_Username.SelectedValue = leer["username"].ToString();

                    txt_Commentbloquearusb.Text = leer["Comment_BloquearUSB"].ToString();
                    txt_CommentUpdateMeraki.Text = leer["Comment_UpdateMeraki"].ToString();
                    txt_CommentUpdatesWAP.Text = leer["Comment_UpdatesWAP"].ToString();
                    txt_CommentWindowsUpdates.Text = leer["Comment_WindowsUpdates"].ToString();

                    rbl_UpdateMeraki.SelectedValue = Convert.ToInt32(bool.Parse(leer["UpdateMeraki"].ToString())).ToString();
                    rbl_UpdatesWAP.SelectedValue = Convert.ToInt32(bool.Parse(leer["UpdatesWAP"].ToString())).ToString();
                    rbl_WindowsUpdates.SelectedValue = Convert.ToInt32(bool.Parse(leer["WindowsUpdates"].ToString())).ToString();
                    rb_bloquearusb.SelectedValue = Convert.ToInt32(bool.Parse(leer["BloquearUSB"].ToString())).ToString();


                }
                else
                {
                    txt_Commentbloquearusb.Text = "";
                    txt_CommentUpdateMeraki.Text = "";
                    txt_CommentUpdatesWAP.Text = "";
                    txt_CommentWindowsUpdates.Text = "";

                    rbl_UpdateMeraki.SelectedIndex = -1;
                    rbl_UpdatesWAP.SelectedIndex = -1;
                    rbl_WindowsUpdates.SelectedIndex = -1;
                    rb_bloquearusb.SelectedIndex = -1;

                }


                monthly.Cerrar();
            }
            catch (System.InvalidOperationException)
            {
                monthly.Cerrar();
                //throw;
            }
        }

    }
}