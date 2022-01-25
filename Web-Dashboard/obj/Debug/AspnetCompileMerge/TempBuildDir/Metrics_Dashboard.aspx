<%@ Page Title="KPI's Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Metrics_Dashboard.aspx.cs" Inherits="Web_Dashboard.Metrics_Dashboard" %>

<%@ Register Assembly="Telerik.ReportViewer.Html5.WebForms, Version=15.2.21.915, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.Html5.WebForms" TagPrefix="telerik" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style type="text/css">
        body {
            font-family: Arial;
            font-size: 10pt;
            margin: 0;
            padding: 0;
            padding-left: 63px;
            /*float: left;*/
            padding-top: 5em;
        }
    </style>


    <h1>KPI's Metrics</h1>

    <br />
    <br />
    <br />

    <telerik:ReportViewer ID="ReportViewer1" runat="server" EnableTheming="true" Width="100%" EnableAccessibility="true" ScaleMode="FitPage">
        <ReportSource Identifier="Reports\MetricsKPI.trdp"></ReportSource>
    </telerik:ReportViewer>



</asp:Content>
