<%@ Page Title="KPI's Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Metrics_Dashboard.aspx.cs" Inherits="Web_Dashboard.Metrics_Dashboard" %>

<%@ Register Assembly="Telerik.ReportViewer.Html5.WebForms, Version=15.2.21.915, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.Html5.WebForms" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <h1>KPI's Metrics</h1>

    <br />  
    <br />  
    <br />  

    <telerik:ReportViewer ID="ReportViewer1" runat="server" Width="100%" ViewMode="Interactive" ScaleMode="FitPageWidth" Deferred="true" PageMode="SinglePage">
        <ReportSource IdentifierType="UriReportSource" Identifier="Reports/MetricsKPI.trdp"></ReportSource>
    </telerik:ReportViewer>

    
    <%--<telerik:DeferredScripts ID="DeferredScripts1" runat="server" />--%>


</asp:Content>
