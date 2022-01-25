<%@ Page Title="Metrics IT" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Matrics.aspx.cs" Inherits="Web_Dashboard.Matrics" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <script>

        function validateMyBtn(oSrc, args) {

            if (AC.checked == true)
                alert("Please fill in the 'Your Name' box.");
            //else
            //    args.IsValid = args.Value.trim().length > 0;
        }

    </script>

    <style type="text/css">
        .TopD {
            background-color: #eeeeee;
            margin: 30px;
            padding: 20px;
            border-radius: 5px;
            /*padding-left: 20px;
            padding-top: 10px;
            padding-bottom: 10px;*/
        }

        asp:TextBox {
            width: 300px;
        }

        label {
            display: inline-block;
        }

        .inline-rb input[type="radio"] {
            width: auto;
            margin-right: .50em;
        }

        .inline-rb label {
            display: inline;
            margin-right: 2em;
        }

        h5 {
            margin-right: 10em;
            margin-left: 29px;
        }

        .ident {
            padding-left: 30%;
        }

        label {
            display: block;
            margin: 15px 0;
        }

            label span {
                display: inline-block;
                text-align: right;
                width: 150px;
            }
    </style>


    <h1>Metrics IT</h1>

    <div class="TopD">
        <h3>Today: <%=DateTime.Now.ToString("MM/dd/yyyy") %></h3>



        <br />

        <div style="float: right">

            <asp:Button ID="btn_Edit" runat="server" Text="Edit" OnClick="btn_Edit_Click" />

            <asp:TextBox ID="txt_Date" runat="server" TextMode="Date" OnTextChanged="txt_Date_TextChanged" AutoPostBack="true" onkeypress="return false;" onpaste="return false"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btn_New" runat="server" Text="New" OnClick="Btn_New_Click" />

            <asp:Button ID="btn_Save" runat="server" Text="Save" OnClick="btn_Save_Click" />

            <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" OnClick="btn_Cancel_Click" />

            <br />
            <br />
            <h4>Name: </h4>
            <asp:DropDownList ID="ddl_Username" runat="server">
                <asp:ListItem>UserName</asp:ListItem>
                <asp:ListItem>Alfredo Tostado</asp:ListItem>
                <asp:ListItem>Omar Licon</asp:ListItem>
                <asp:ListItem>Leonel Valle</asp:ListItem>
            </asp:DropDownList>
            <br />
            <h4 style="color: red; float: right; font-size: 14px;">*Mandar ticket en caso de algun problema</h4>
            <br />
        </div>
    </div>

    <br />


    <%--    <div runat="server" id="CheckMain" class="inline-rb">--%>

    <div runat="server" id="CheckMain">

        <div style="display: inline-flex;">
            <label>
                <span>Licencia Office Apps For Business: </span>
                <input runat="server" type="text" id="txt_licenciaOfficeApps" />
            </label>

            <label>
                <span>Licencia Office Business Basic: </span>
                <input runat="server" type="text" id="txt_licenciaOfficeBasic" />
            </label>
            <label>
                <span>Licencia Office Standart: </span>
                <input runat="server" type="text" id="txt_licenciaOfficeStandart" />
            </label>
        </div>

        <label>
            <span>Licencia Antivirus</span>
            <input runat="server" type="text" id="txt_licenciasAntivirus" />
        </label>
        <label>
            <span>PC: </span>
            <input runat="server" type="text" id="txt_PC" />
        </label>
        <label>
            <span>Usuarios: </span>
            <input runat="server" type="text" id="txt_Usuarios" />
        </label>
        <label>
            <span>Laptops: </span>
            <input runat="server" type="text" id="txt_laptop" />
        </label>


        <label>

            <div style="display: inline-flex;">
                <span>Servers Down-Time:</span>

                <input runat="server" type="text" id="txt_DTServer" />
                <span>Tipo: </span>

                <asp:DropDownList runat="server" ID="ddl_server">
                    <asp:ListItem Text="N/A" />
                    <asp:ListItem Text="Programado" />
                    <asp:ListItem Text="No Programado" />
                    <asp:ListItem Text="Falla" />
                    <asp:ListItem Text="Otro" />
                </asp:DropDownList>
                <span>Descripcion: </span>
                <asp:TextBox runat="server" ID="txt_descServer" />
            </div>
        </label>

        <label>
            <div style="display: inline-flex;">
                <span>Network Down-Time:</span>
                <input runat="server" type="text" id="txt_DTNetwork" />
                <span>Tipo: </span>
                <asp:DropDownList runat="server" ID="ddl_network">
                    <asp:ListItem Text="N/A" />
                    <asp:ListItem Text="Programado" />
                    <asp:ListItem Text="No Programado" />
                    <asp:ListItem Text="Falla" />
                    <asp:ListItem Text="Otro" />
                </asp:DropDownList>
                <span>Descripcion: </span>
                <asp:TextBox runat="server" ID="txt_descNetwork" />
            </div>
        </label>

        <label>
            <div style="display: inline-flex;">
                <span>Services Down-Time:</span>
                <input runat="server" type="text" id="txt_DTServices" />
                <span>Tipo: </span>
                <asp:DropDownList runat="server" ID="ddl_services">
                    <asp:ListItem Text="N/A" />
                    <asp:ListItem Text="Programado" />
                    <asp:ListItem Text="No Programado" />
                    <asp:ListItem Text="Falla" />
                    <asp:ListItem Text="Otro" />
                </asp:DropDownList>
                <span>Descripcion: </span>
                <asp:TextBox runat="server" ID="txt_descServices" />
            </div>
        </label>

        <label>
            <div style="display: inline-flex;">
                <span>Down-Time Otro: </span>
                <input runat="server" type="text" id="txt_DTOtro" />
                <span>Tipo: </span>
                <asp:DropDownList runat="server" ID="ddl_otro">
                    <asp:ListItem Text="N/A" />
                    <asp:ListItem Text="Programado" />
                    <asp:ListItem Text="No Programado" />
                    <asp:ListItem Text="Falla" />
                    <asp:ListItem Text="Otro" />
                </asp:DropDownList>
                <span>Descripcion: </span>
                <asp:TextBox runat="server" ID="txt_DescOtro" />
            </div>
        </label>
        <br />
        <br />
        <br />


    </div>


    <%--</div>--%>
</asp:Content>



