<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckList.aspx.cs" Inherits="Web_Dashboard.CheckList" Title="Daily CheckList" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>

    <script>

        function validateMyBtn(oSrc, args) {

            var AC = document.getElementsByName('<%=rbl_ACfunciona.ClientID %>');
            var OTRO = document.getElementsByName('<%=rbl_AlarmaOtroDisp.ClientID %>');
            var AV = document.getElementsByName('<%=rbl_AVdeteccion.ClientID %>');
            var INTER = document.getElementsByName('<%=rbl_Internet.ClientID %>');
            var NAS = document.getElementsByName('<%=rbl_NAS.ClientID %>');
            var PTRG = document.getElementsByName('<%=rbl_PTRG.ClientID %>');
            var SERVER = document.getElementsByName('<%=rbl_SAlarma.ClientID %>');
            var SWT = document.getElementsByName('<%=rbl_switch.ClientID %>');
            var TEL = document.getElementsByName('<%=rbl_Telefonos.ClientID %>');
            var bkponp = document.getElementsByName('<%=rbl_Backup_onpremise.ClientID %>');
            var bkpcloud = document.getElementsByName('<%=rbl_Backup_cloud.ClientID %>');
            var firewall = document.getElementsByName('<%=rbl_Firewall.ClientID %>');
            var isp = document.getElementsByName('<%=rbl_ispdevices.ClientID %>');



            if (AC.checked == true)
                alert("Please fill in the 'Your Name' box.");
            if (OTRO.checked == true)
                alert("Please fill in the 'Your Name' box.");
            if (AV.checked == true)
                alert("Please fill in the 'Your Name' box.");
            if (INTER.checked == true)
                alert("Please fill in the 'Your Name' box.");
            if (NAS.checked == true)
                alert("Please fill in the 'Your Name' box.");
            if (PTRG.checked == true)
                alert("Please fill in the 'Your Name' box.");
            if (SERVER.checked == true)
                alert("Please fill in the 'Your Name' box.");
            if (SWT.checked == true)
                alert("Please fill in the 'Your Name' box.");
            if (TEL.checked == true)
                alert("Please fill in the 'Your Name' box.");
            if (bkpcloud.checked == true)
                alert("Please fill in the 'Your Name' box.");
            if (bkponp.checked == true)
                alert("Please fill in the 'Your Name' box.");
            if (firewall.checked == true)
                alert("Please fill in the 'Your Name' box.");
            if (isp.checked == true)
                alert("Please fill in the 'Your Name' box.");

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
            margin-left: 80px;
        }

        .ident {
            padding-left: 30%;
        }
    </style>

    <h1>Daily Check List</h1>

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
            <%--<h4>Name:</h4>--%>

            <%--<asp:Label runat="server" Text="Name: " Font-Bold="true" Font-Size="Larger"></asp:Label>
            <asp:Label ID="lbl_user" runat="server" Text="Label" Font-Bold="true" Font-Size="Larger"></asp:Label>--%>
            <%--<asp:DropDownList ID="ddl_Username" runat="server">
                <asp:ListItem>UserName</asp:ListItem>
                <asp:ListItem>Alfredo Tostado</asp:ListItem>
                <asp:ListItem>Omar Licon</asp:ListItem>
                <asp:ListItem>Leonel Valle</asp:ListItem>
            </asp:DropDownList>--%>
            <br />
            <h4 style="color: red; float: right; font-size: 14px;">*Mandar ticket en caso de algun problema</h4>
            <br />
        </div>
    </div>

    <br />

    <div runat="server" id="CheckMain">

        <h4 id="Label4" runat="server" text="Backup">Backup</h4>
        <div style="display: inline-flex;">
            <h5>On-Premise	</h5>
            <asp:RadioButtonList ID="rbl_Backup_onpremise" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
            <div class="ident">
                <asp:Label runat="server" Text="Comments:"></asp:Label>

                <asp:TextBox ID="txt_bkponpremise" runat="server" TextMode="MultiLine" MaxLength="1700"></asp:TextBox>

            </div>
            <h5>CLOUD	</h5>
            <asp:RadioButtonList ID="rbl_Backup_cloud" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <br />
        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>

            <asp:TextBox ID="txt_CommentBackupcloud" runat="server" TextMode="MultiLine" MaxLength="1700"></asp:TextBox>

        </div>
        <br />
        <hr />
        <br />


        <%--<asp:Label ID="Label2" runat="server" Text="A/C"></asp:Label>--%>
        <h4>A/C</h4>
        <div style="display: inline-flex;">
            <h5 style="padding-left: 80px;">Temperatura (20 - 25 C)</h5>
            <asp:RadioButtonList ID="rbl_ACfunciona" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <br />
        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>

            <asp:TextBox ID="txt_ACfuncionaCom" runat="server" TextMode="MultiLine" MaxLength="1700"></asp:TextBox>

        </div>
        <br />
        <hr />
        <br />




        <h4>Antivirus Control Panel</h4>
        <div style="display: inline-flex;">
            <h5 style="padding-left: 80px;">Amenazas Detectadas</h5>

            <asp:RadioButtonList ID="rbl_AVdeteccion" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <br />
        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>

            <asp:TextBox ID="txt_AVdeteccionCom" runat="server" TextMode="MultiLine" MaxLength="1700"></asp:TextBox>
        </div>
        <br />
        <hr />
        <br />


        <h4>Inspeccion Server Room (Visual)</h4>
        <div style="display: inline-flex;">
            <h5 style="padding-left: 80px;">Servers</h5>

            <asp:RadioButtonList ID="rbl_SAlarma" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <br />
        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>

            <asp:TextBox ID="txt_SalarmaCom" runat="server" TextMode="MultiLine" MaxLength="1700"></asp:TextBox>
        </div>
        <br />


        <div style="display: inline-flex;">
            <h5 style="padding-left: 80px;">Storage</h5>
            <asp:RadioButtonList ID="rbl_NAS" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>

            <asp:TextBox ID="txt_NASCom" runat="server" TextMode="MultiLine" MaxLength="1700"></asp:TextBox>
        </div>
        <br />
        <br />

        <div style="display: inline-flex;">
            <h5 style="padding-left: 80px;">Switches</h5>
            <asp:RadioButtonList ID="rbl_switch" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>

            <asp:TextBox ID="txt_firewall" runat="server" TextMode="MultiLine" MaxLength="1700"></asp:TextBox>
        </div>
        <div style="display: inline-flex;">
            <h5 style="padding-left: 80px;">Firewall</h5>
            <asp:RadioButtonList ID="rbl_Firewall" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>

            <asp:TextBox ID="txt_ispdevices" runat="server" TextMode="MultiLine" MaxLength="1700"></asp:TextBox>
        </div>
        <div style="display: inline-flex;">
            <h5 style="padding-left: 80px;">ISP Devices</h5>
            <asp:RadioButtonList ID="rbl_ispdevices" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </div>

        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>

            <asp:TextBox ID="txt_CommentSwitch" runat="server" TextMode="MultiLine" MaxLength="1700"></asp:TextBox>
        </div>
        <br />

        <div style="display: inline-flex;">
            <h5 style="padding-left: 80px;">Alarmas en otros dispositvios</h5>
            <asp:RadioButtonList ID="rbl_AlarmaOtroDisp" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <br />
        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>

            <asp:TextBox ID="txt_CommentOtroDisp" runat="server" TextMode="MultiLine" MaxLength="1700"></asp:TextBox>
        </div>

        <br />
        <hr />
        <br />



        <h4>Conectividad Internet / Telefonos</h4>
        <div style="display: inline-flex;">

            <h5 style="padding-left: 80px;">Telefonos</h5>
            <asp:RadioButtonList ID="rbl_Telefonos" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </div>

        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>
            <asp:TextBox ID="txt_CommentTelefono" runat="server" TextMode="MultiLine" MaxLength="1700"></asp:TextBox>
        </div>
        <br />


        <h5 style="padding-left: 80px;">Internet</h5>
        <div style="display: inline-flex;">
            <asp:RadioButtonList ID="rbl_Internet" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </div>


        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>
            <asp:TextBox ID="txt_CommentInternet" runat="server" TextMode="MultiLine" MaxLength="1700"></asp:TextBox>
        </div>

        <br />
        <hr />
        <br />


        <h4>Alarmas PTRG</h4>

        <div style="display: inline-flex;">
            <h5 style="padding-left: 80px;">Alarmas existentes</h5>
            <asp:RadioButtonList ID="rbl_PTRG" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </div>

        <br />

        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>

            <asp:TextBox ID="txt_CommentPTRG" runat="server" TextMode="MultiLine" MaxLength="1700"></asp:TextBox>
        </div>

        <br />
        <hr />
        <br />


        <h4>WIFI</h4>
        <div style="display: inline-flex;">
            <h5 style="padding-left: 80px;">Status Access Point</h5>
            <asp:RadioButtonList ID="rbl_WIFI" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <br />

        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>

            <asp:TextBox ID="txt_CommentWIFI" runat="server" TextMode="MultiLine" MaxLength="1700"></asp:TextBox>
        </div>
        <br />
        <hr />
        <br />

    </div>



</asp:Content>
