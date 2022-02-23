using System;
using System.Data.SqlClient;

namespace Web_Dashboard
{
    public partial class CheckListWeekly : System.Web.UI.Page
    {
        Weekly weekly = new Weekly();
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckMain.Visible = false;
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
            if (rbl_BackupControlAcceso.SelectedValue != "" && rb_bloquearusb.SelectedValue != "" && rb_RevisionclinetesWIFI.SelectedValue != "")
            {
                //weekly.Crud("insert into CheckListWeekly (MoverFuerabkp, Comment_MoverFuerabkp, ControlAccesobkp, Comment_ControlAccesobkp, RevisionClientesWIFI, Comment_RevisionClientesWIFI, username, dateReg) values('"
                //    + rb_bloquearusb.SelectedValue + "','" + txt_Commentbloquearusb.Text + "','" + rbl_BackupControlAcceso.SelectedValue + "','" + txt_BackupControlAcceso.Text +
                //    "','" + rb_RevisionclinetesWIFI.SelectedValue + "','" + txt_CommentRevisionclinetesWIFI.Text +
                //    "','" + ddl_Username.Text.Trim() + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "')");

            }
        }

        protected void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_BackupControlAcceso.Text = "";
            txt_CommentBackupFuera.Text = "";
            txt_CommentRevisionclinetesWIFI.Text = "";
            txt_Date.Text = "";

            rbl_BackupControlAcceso.SelectedIndex = -1;
            rb_bloquearusb.SelectedIndex = -1;
            rb_RevisionclinetesWIFI.SelectedIndex = -1;


        }

        protected void btn_Edit_Click(object sender, EventArgs e)
        {
            //if (ddl_Username.Text != "UserName" && txt_Date.Text != "" && rbl_BackupControlAcceso.SelectedValue != "" && rbl_BackupFuera.SelectedValue != "" && rb_RevisionclinetesWIFI.SelectedValue != "")
            //{
            //    weekly.Crud("update CheckListWeekly set RevisionClientesWIFI = '" + rb_RevisionclinetesWIFI.SelectedValue + "', Comment_RevisionClientesWIFI = '" + txt_CommentRevisionclinetesWIFI.Text.Trim() +
            //        "', MoverFuerabkp = '" + rbl_BackupFuera.SelectedValue + "', Comment_MoverFuerabkp = '" + txt_CommentBackupFuera.Text.Trim() + "', ControlAccesobkp = '" + rbl_BackupControlAcceso.SelectedValue
            //        + "', Comment_ControlAccesobkp = '" + txt_BackupControlAcceso.Text.Trim() + "', username = '" + ddl_Username.Text
            //        + "' where id_clw = '" + weekly.Id_clw + "'");

            //}
        }

        private void GetFields()
        {

            try
            {
                SqlDataReader leer = weekly.Leer("Select * from CheckListWeekly where dateReg = '" + txt_Date.Text + "'");

                if (leer.Read() == true)
                {
                    weekly.Id_clw = int.Parse(leer["id_clw"].ToString());

                    //ddl_Username.SelectedValue = leer["username"].ToString();

                    txt_BackupControlAcceso.Text = leer["Comment_ControlAccesobkp"].ToString();
                    txt_CommentBackupFuera.Text = leer["Comment_MoverFuerabkp"].ToString();
                    txt_CommentRevisionclinetesWIFI.Text = leer["Comment_RevisionClientesWIFI"].ToString();

                    rbl_BackupControlAcceso.SelectedValue = Convert.ToInt32(bool.Parse(leer["ControlAccesobkp"].ToString())).ToString();
                    //rbl_BackupFuera.SelectedValue = Convert.ToInt32(bool.Parse(leer["MoverFuerabkp"].ToString())).ToString();
                    rb_RevisionclinetesWIFI.SelectedValue = Convert.ToInt32(bool.Parse(leer["RevisionClientesWIFI"].ToString())).ToString();


                }
                else
                {
                    txt_CommentRevisionclinetesWIFI.Text = "";
                    txt_CommentBackupFuera.Text = "";
                    txt_BackupControlAcceso.Text = "";

                    rb_RevisionclinetesWIFI.SelectedIndex = -1;
                    //rbl_BackupFuera.SelectedIndex = -1;
                    rbl_BackupControlAcceso.SelectedIndex = -1;

                }


                weekly.Cerrar();
            }
            catch (System.InvalidOperationException)
            {
                weekly.Cerrar();
                //throw;
            }
        }

    }
}