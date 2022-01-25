<%@ Page Title="Reports" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="Web_Dashboard.Report" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <meta name="viewport" content="width = device-width, initial-scale = 1.0, minimum-scale = 1.0, maximum-scale = 1.0, user-scalable = no" />
    <link href="Styles/footable-0.1.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/1.8.2/jquery.min.js" type="text/javascript"></script>
    <script src="Scripts/footable-0.1.js" type="text/javascript"></script>


    <h1>Reports</h1>
    <br />
    <br />
    <br />
    <input runat="server" type="date" name="date1" id="date1" value="" />
    <input runat="server" type="date" name="date2" id="date2" value="" />
    <br />
    <br />
    <telerik:RadButton ID="btn_Search" runat="server" Text="Search" OnClick="btn_Search_Click"></telerik:RadButton>
    <br />
    <br />
    <div class="table-responsive">

        <asp:GridView ID="gv_Report" runat="server" CssClass="table table-striped table-bordered table-hover" Width="100%"
            GridLines="None" AllowPaging="true" PageSize="10" OnPageIndexChanging="gv_Report_PageIndexChanging">
        </asp:GridView>

    </div>
</asp:Content>
