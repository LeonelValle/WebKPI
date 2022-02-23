using System;
using System.Data.SqlClient;

namespace Web_Dashboard
{
    public partial class CheckListMonthly : System.Web.UI.Page
    {
        Monthly monthly = new Monthly();
        User users = new User();
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
            if (rbl_WindowsUpdates.SelectedValue != "" && rbl_active.SelectedValue != "" && rbl_WindowsUpdates.SelectedValue != "" && rbl_antivirus.SelectedValue != "")
            {
                monthly.Crud("insert into CheckListMonthly (WindowsUpdates, Comment_WindowsUpdates, antivirus, comment_antivirus, active, comment_active, licenciasOffice, comment_licenciasOffice , username, dateReg) values('"
                    + rbl_WindowsUpdates.SelectedValue + "','" + txt_CommentWindowsUpdates.Text + "','" + rbl_antivirus.SelectedValue + "','" + txt_antivirus.Text +
                    "','" + rbl_active.SelectedValue + "','" + txt_active.Text + "','" + rb_licenciasoffices.SelectedValue + "','" + txt_licenciasoffices.Text + "','" +
                    "','" + users.Name + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "')");

            }
        }

        protected void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_active.Text = "";
            txt_antivirus.Text = "";
            txt_CommentWindowsUpdates.Text = "";
            txt_Date.Text = "";

            rbl_active.SelectedIndex = -1;
            rbl_antivirus.SelectedIndex = -1;
            rbl_WindowsUpdates.SelectedIndex = -1;
            rb_licenciasoffices.SelectedIndex = -1;
        }

        protected void btn_Edit_Click(object sender, EventArgs e)
        {
            if ( txt_Date.Text != "" && rb_licenciasoffices.SelectedValue != "" && rbl_WindowsUpdates.SelectedValue != "" && rbl_antivirus.SelectedValue != "" && rbl_active.SelectedValue != "")
            {
                monthly.Crud("update CheckListMonthly set antivirus = '" + rbl_antivirus.SelectedValue + "', comment_antivirus = '" + txt_antivirus.Text.Trim()
                    + "', licenciasOffice = '" + rb_licenciasoffices.SelectedValue + "', comment_licenciasOffice = '" + txt_licenciasoffices.Text.Trim()
                    + "', WindowsUpdates = '" + rbl_WindowsUpdates.SelectedValue + "', Comment_WindowsUpdates = '" + txt_CommentWindowsUpdates.Text.Trim()
                    + "', active = '" + rbl_active.SelectedValue + "', comment_active = '" + txt_active.Text.Trim()
                    + "', username = '" + users.Name
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


                    txt_licenciasoffices.Text = leer["comment_licenciasOffice"].ToString();
                    txt_antivirus.Text = leer["comment_antivirus"].ToString();
                    txt_active.Text = leer["comment_active"].ToString();
                    txt_CommentWindowsUpdates.Text = leer["Comment_WindowsUpdates"].ToString();

                    rbl_active.SelectedValue = Convert.ToInt32(bool.Parse(leer["active"].ToString())).ToString();
                    rbl_antivirus.SelectedValue = Convert.ToInt32(bool.Parse(leer["antivirus"].ToString())).ToString();
                    rbl_WindowsUpdates.SelectedValue = Convert.ToInt32(bool.Parse(leer["WindowsUpdates"].ToString())).ToString();
                    rb_licenciasoffices.SelectedValue = Convert.ToInt32(bool.Parse(leer["licenciasOffice"].ToString())).ToString();


                }
                else
                {
                    txt_active.Text = "";
                    txt_antivirus.Text = "";
                    txt_licenciasoffices.Text = "";
                    txt_CommentWindowsUpdates.Text = "";

                    rbl_antivirus.SelectedIndex = -1;
                    rbl_active.SelectedIndex = -1;
                    rbl_WindowsUpdates.SelectedIndex = -1;
                    rb_licenciasoffices.SelectedIndex = -1;

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