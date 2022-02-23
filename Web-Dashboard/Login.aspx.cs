using System;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Dashboard
{
    public partial class Login : System.Web.UI.Page
    {
        LDAPAutenticador LDAP = new LDAPAutenticador();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {

            //if (user.Login(txtUsuario.Value, txtPassword.Value))
            //{

            //    Session["username"] = txtUsuario.Value;
            //    Session["id_user"] = user.ReturnID("select id_user from users where username = '" + txtUsuario.Value.Trim() + "' and password = '" + txtPassword.Value.Trim() + "'");

            //    Response.Redirect("~/MainMenu.aspx", false);
            //}
            //else
            //{
            //    string script = "alert(\"Login Error!\");";
            //    ScriptManager.RegisterStartupScript(this, GetType(), "User or Password incorrect!", script, true);
            //}
            Session["user"] = txtUsuario.Value;
            Session["pass"] = txtPassword.Value;
            login(txtPassword.Value,txtPassword.Value);
            //if (txtPassword.Value == "" || txtPassword.Value == "")
            //{
            //    ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "error", "alert('Login failed!');", true);
            //    Response.Redirect("Login.aspx");

            //}
            //else
            //{
            //    Session["user"] = txtUsuario.Value;
            //    //Session["dominio"] = "masterworkelectronics.com";
            //    Session["pass"] = txtPassword.Value;
            //    Response.Redirect("CheckList.aspx");
            //    //Response.Redirect("info.aspx?contrasena=" + txtPassword.Text + "&usuario=" + txtUsername.Text + "&dom=" + txtDomain.Text);
            //}

        }


        void login(string nom, string pass)
        {
            //string adPath = "LDAP://MEX-AD-001." + Session["dominio"];
            LDAPAutenticador aut = new LDAPAutenticador(LDAP.AdPath);
            ArrayList gruposDe = new ArrayList();
            ArrayList propUsuarios = new ArrayList();

            try
            {
                if (aut.autenticado(LDAP.Dominio, (string)Session["user"], (string)Session["pass"]) == true)
                {
                    //lblUsuario.Text = aut.getCN();

                    propUsuarios = aut.getListaPropiedades();
                    //ddlUsuarios.Items.Clear();
                    //ddlUsuarios.Items.Add(new ListItem(propUsuarios[0] as string));

                    if (propUsuarios.Count > 1)
                    {
                        //lblName.Text = propUsuarios[1] as string;
                        //lblApellido.Text = propUsuarios[2] as string;
                        //lblUsuario.Text = propUsuarios[0] as string;
                    }

                    //llenarGrupos(lblUsuario.Text);

                    //gruposDe = aut.GetGroups();
                    //listaGrupos.Items.Clear();
                    //for (int i = 0; i < gruposDe.Count; i++)
                    //{
                    //    listaGrupos.Items.Add(new ListItem(gruposDe[i] as string));
                    //    if (gruposDe[i] as string == "Administrators")
                    //    {
                    //        Response.Write("Bienvenido administrador");
                    //    }
                    //}
                    Session["name"] = aut.getListaPropiedades()[0].ToString();
                    Response.Redirect("CheckList.aspx");

                }
            }
            catch (Exception ex)
            {
                //ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "error", "alert('" + ex.ToString() + "');", true);
                string script = "alert(\"Login Error!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "User or Password incorrect!", script, true);

                //Response.Redirect("Login.aspx");
            }

        }

        void Cambiar_Cotraseña(Object origen, EventArgs args)
        {

            //lblActualPass.Visible = true;
            //txtActualPass.Visible = true;
            //lblNuevaPass.Visible = true;
            //txtNewPass.Visible = true;
            //lblConfirmPass.Visible = true;
            //txtConfirmPass.Visible = true;
            //btnConfirm.Visible = true;
        }

        void llenarDdl(Object origen, EventArgs args)
        {
            //llenarGrupos(ddlUsuarios.SelectedItem.Value);
            //Response.Write(ddlUsuarios.SelectedItem.Value);
        }

        void llenarGrupos(string cn)
        {
            //string adPath = "LDAP://" + Session["dominio"];
            LDAPAutenticador aut = new LDAPAutenticador(LDAP.AdPath);
            ArrayList gruposDe = new ArrayList();
            ArrayList todosLosUsuarios = new ArrayList();
            gruposDe = aut.GetGroups(cn);
            //listaGrupos.Items.Clear();
            for (int i = 0; i < gruposDe.Count; i++)
            {
                //listaGrupos.Items.Add(new ListItem(gruposDe[i] as string));
                if (gruposDe[i] as string == "administrators")
                {
                    Response.Write("Bienvenido administrador");
                    //llamar todos los usuarios y agregarlos al ddl
                    todosLosUsuarios = aut.getTodosUsuarios();
                    for (int e = 0; e < todosLosUsuarios.Count; e++)
                    {
                        //ddlUsuarios.Items.Add(new ListItem(todosLosUsuarios[e] as string));
                    }
                }
            }
        }

        void Guardar_Cotraseña(Object origen, EventArgs args)
        {
            //if (txtNewPass.Text == txtConfirmPass.Text)
            //{
            //    string adPath = "LDAP://" + Session["dominio"];
            //    LDAPAutenticador aut = new LDAPAutenticador(adPath);

            //    Response.Write(aut.modificaPass(txtConfirmPass.Text, (string)Session["user"], txtActualPass.Text));

            //    errorLabel.Text = "";
            //    lblActualPass.Visible = false;
            //    txtActualPass.Visible = false;
            //    lblNuevaPass.Visible = false;
            //    txtNewPass.Visible = false;
            //    lblConfirmPass.Visible = false;
            //    txtConfirmPass.Visible = false;
            //    btnConfirm.Visible = false;
            //}
            //else
            //{
            //    errorLabel.Text = "Contraseñas no coinciden";
            //}
        }
    }
}