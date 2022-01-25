using System;
using System.Data.SqlClient;

namespace Web_Dashboard
{
    public partial class Matrics : System.Web.UI.Page
    {
        Metricos metrics = new Metricos();
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckMain.Visible = false;

        }

        protected void Btn_New_Click(object sender, EventArgs e)
        {
            CheckMain.Visible = true;

        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txt_descNetwork.Text.Trim()) || !string.IsNullOrEmpty(txt_DescOtro.Text.Trim()) || !string.IsNullOrEmpty(txt_descServer.Text.Trim()) || !string.IsNullOrEmpty(txt_descServices.Text.Trim()) ||
            //    !string.IsNullOrEmpty(txt_DTNetwork.Value.Trim()) || !string.IsNullOrEmpty(txt_DTOtro.Value.Trim()) || !string.IsNullOrEmpty(txt_DTServer.Value.Trim()) || !string.IsNullOrEmpty(txt_DTServices.Value.Trim()) ||
            //    !string.IsNullOrEmpty(txt_laptop.Value.Trim()) || !string.IsNullOrEmpty(txt_licenciaOffice.Value.Trim()) || 
            //    !string.IsNullOrEmpty(txt_licenciasAntivirus.Value.Trim()) || !string.IsNullOrEmpty(txt_PC.Value.Trim()) || !string.IsNullOrEmpty(txt_Usuarios.Value.Trim()))
            //{
            metrics.Crud("insert into kpiWeekly (license_officeApps,license_officeBasic,license_officeStandart,license_av,pc,users,laptops,downtime_Server,tipo_Server,desc_Server,downtime_Network,tipo_Network,desc_Network,downtime_Services,tipo_Services,desc_Services,downtime_otro,tipo_otro,desc_otro,username, dateReg) values('"
                    + txt_licenciaOfficeApps.Value.Trim() + "','" + txt_licenciaOfficeBasic.Value.Trim() + "','" + txt_licenciaOfficeStandart.Value.Trim() + "','" + txt_licenciasAntivirus.Value.Trim() + "','" + txt_PC.Value.Trim()
                    + "','" + txt_Usuarios.Value.Trim() + "','" + txt_laptop.Value.Trim() + "','" + txt_DTServer.Value.Trim() + "','" + ddl_server.Text.Trim() + "','" + txt_descServer.Text.Trim() + "','" + txt_DTNetwork.Value.Trim() 
                    + "','" + ddl_network.Text.Trim() + "','" + txt_descNetwork.Text.Trim() + "','" + txt_DTServices.Value.Trim() + "','" + ddl_services.Text.Trim() + "','" + txt_descServices.Text.Trim()
                    + "','" + txt_DTOtro.Value.Trim() + "','" + ddl_otro.Text.Trim() + "','" + txt_DescOtro.Text.Trim() + "','" + ddl_Username.Text.Trim() + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "')");


            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Done!');", true);

            //}
        }

        protected void btn_Cancel_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Edit_Click(object sender, EventArgs e)
        {
            if (ddl_Username.Text != "UserName" && txt_Date.Text != "")
            {
                metrics.Crud("update kpiWeekly set license_officeApps = '" + txt_licenciaOfficeApps.Value + "', license_officeBasic = '" + txt_licenciaOfficeBasic.Value + "', license_officeStandart = '" + txt_licenciaOfficeStandart.Value 
                    + "', license_av = '" + txt_licenciasAntivirus.Value + "', pc = '" + txt_PC.Value + "', users = '" + txt_Usuarios.Value +
                    "', laptops = '" + txt_laptop.Value + "', downtime_Server = '" + txt_DTServer.Value + "', tipo_Server = '" + ddl_server.Text + "', desc_Server = '" + txt_descServer.Text + "', downtime_Network = '" + txt_DTNetwork.Value
                    + "', tipo_Network = '" + ddl_network.Text + "', desc_Network = '" + txt_descNetwork.Text + "', downtime_Services = '" + txt_DTServices.Value + "', tipo_Services = '" + ddl_services.Text + "', desc_Services = '" + txt_descServices.Text
                    +  "', downtime_otro = '" + txt_DTOtro.Value + "', tipo_otro = '" + ddl_otro.Text + "', desc_otro = '" + txt_DescOtro.Text
                    + "', username = '" + ddl_Username.Text + "' where id_kpiw = '" + metrics.Id + "'");
            }
        }

        private void GetFields()
        {

            try
            {
                SqlDataReader leer = metrics.Leer("Select * from kpiWeekly where dateReg = '" + txt_Date.Text + "'");

                if (leer.Read() == true)
                {
                    metrics.Id = int.Parse(leer["id_kpiw"].ToString());

                    ddl_Username.SelectedValue = leer["username"].ToString();
                    ddl_network.SelectedValue = leer["tipo_Network"].ToString();
                    ddl_otro.SelectedValue = leer["tipo_otro"].ToString();
                    ddl_server.SelectedValue = leer["tipo_Server"].ToString();
                    ddl_services.SelectedValue = leer["tipo_Services"].ToString();
                    txt_descNetwork.Text = leer["desc_Network"].ToString();
                    txt_DescOtro.Text = leer["desc_otro"].ToString();
                    txt_descServer.Text = leer["desc_Server"].ToString();
                    txt_descServices.Text = leer["desc_Services"].ToString();
                    txt_DTNetwork.Value = leer["downtime_Network"].ToString();
                    txt_DTOtro.Value = leer["downtime_otro"].ToString();
                    txt_DTServer.Value = leer["downtime_Server"].ToString();
                    txt_DTServices.Value = leer["downtime_Services"].ToString();
                    txt_laptop.Value = leer["laptops"].ToString();
                    txt_licenciaOfficeApps.Value = leer["license_officeApps"].ToString();
                    txt_licenciaOfficeBasic.Value = leer["license_officeBasic"].ToString();
                    txt_licenciaOfficeStandart.Value = leer["license_officeStandart"].ToString();
                    txt_licenciasAntivirus.Value = leer["license_av"].ToString();
                    txt_PC.Value = leer["pc"].ToString();
                    txt_Usuarios.Value = leer["users"].ToString();



                }
                else
                {
                    ddl_Username.SelectedValue = "";
                    ddl_network.SelectedValue = "";
                    ddl_otro.SelectedValue = "";
                    ddl_server.SelectedValue = "";
                    ddl_services.SelectedValue = "";
                    txt_descNetwork.Text = "";
                    txt_DescOtro.Text = "";
                    txt_descServer.Text = "";
                    txt_descServices.Text = "";
                    txt_DTNetwork.Value = "";
                    txt_DTOtro.Value = "";
                    txt_DTServer.Value = "";
                    txt_DTServices.Value = "";
                    txt_laptop.Value = "";
                    txt_licenciaOfficeApps.Value = "";
                    txt_licenciaOfficeBasic.Value = "";
                    txt_licenciaOfficeStandart.Value = "";
                    txt_licenciasAntivirus.Value = "";
                    txt_PC.Value = "";

                }


                metrics.Cerrar();
            }
            catch (System.InvalidOperationException)
            {
                metrics.Cerrar();
                //throw;
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
    }
}