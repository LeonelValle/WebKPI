<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckListMonthly.aspx.cs" Inherits="Web_Dashboard.CheckListMonthly" Title="Monthly CheckList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



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


    <h1>Monthly Check List</h1>

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

    <div runat="server" id="CheckMain">

        <h4 id="Label4" runat="server" text="Updates">Updates</h4>
        <div style="display: inline-flex;">
            <h5>Instalacion de Windows Update Servers</h5>
            <asp:RadioButtonList ID="rbl_WindowsUpdates" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>

        </div>
        <br />
        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>

            <asp:TextBox ID="txt_CommentWindowsUpdates" runat="server" TextMode="MultiLine"></asp:TextBox>

        </div>

        <br />

        <div style="display: inline-flex;">
            <h5 style="padding-left: 80px;">Actualizacion de Firmware Meraki</h5>
            <asp:RadioButtonList ID="rbl_UpdateMeraki" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <br />
        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>

            <asp:TextBox ID="txt_CommentUpdateMeraki" runat="server" TextMode="MultiLine"></asp:TextBox>

        </div>
        <hr />
        <br />

        <br />

        <div style="display: inline-flex;">
            <h5 style="padding-left: 80px;">Actualizacion firmware WAP</h5>
            <asp:RadioButtonList ID="rbl_UpdatesWAP" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <br />
        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>

            <asp:TextBox ID="txt_CommentUpdatesWAP" runat="server" TextMode="MultiLine"></asp:TextBox>

        </div>
        <hr />
        <br />



        <h4 id="H1" runat="server" text="Revision">Revision</h4>
        <div style="display: inline-flex;">
            <h5>Bloquear USB clientes</h5>
            <asp:RadioButtonList ID="rb_bloquearusb" runat="server" RepeatDirection="Horizontal" CellSpacing="30" CellPadding="30" ClientIDMode="AutoID" CssClass="inline-rb">
                <asp:ListItem Value="1">Ok</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:RadioButtonList>

        </div>
        <br />
        <div class="ident">
            <asp:Label runat="server" Text="Comments:"></asp:Label>

            <asp:TextBox ID="txt_Commentbloquearusb" runat="server" TextMode="MultiLine"></asp:TextBox>

        </div>

        <br />

    </div>


</asp:Content>
