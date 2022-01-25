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
            float: left;
            padding-top: 5em;
        }

        table {
            border: 1px solid #ccc;
        }

            table th {
                background-color: #F7F7F7;
                color: #333;
                font-weight: bold;
            }

            table th, table td {
                padding: 5px;
                border-color: #ccc;
            }

        input {
            width: 100%;
        }

        .orangeButton {
            box-shadow: inset 0px 1px 0px 0px #fff6af;
            background: linear-gradient(to bottom, #ffcc66 5%, #d18717 100%);
            background-color: #ffcc66;
            border-radius: 6px;
            border: 1px solid #ffaa22;
            display: inline-block;
            cursor: pointer;
            color: #333333;
            font-family: Arial;
            font-size: 15px;
            font-weight: bold;
            padding: 6px 24px;
            text-decoration: none;
            text-shadow: 0px 1px 0px #ffee66;
            float: right;
            height: 42px;
            width: 100px;
            margin-bottom: 30px;
        }

            .orangeButton:disabled {
                background-color: #808080;
                color: black;
            }

            .orangeButton:hover {
                background: linear-gradient(to bottom, #d18717 5%, #ffcc66 100%);
                background-color: #d18717;
            }

            .orangeButton:active {
                position: relative;
                top: 1px;
            }

        .FixedHeader {
            
            top: expression(this.parentNode.parentNode.parentNode.scrollTop-1);
        }
    </style>


    <h1>KPI's Metrics</h1>

    <br />
    <br />
    <br />


    <telerik:ReportViewer ID="ReportViewer1" runat="server" Width="1800px" EnableViewState="true" ViewStateMode="Enabled" ViewMode="Interactive" KeepClientAlive="true" PageMode="ContinuousScroll" ScaleMode="FitPageWidth">
        <%--<ReportSource Identifier="C:\inetpub\wwwroot\CheckList\Reports/Report1.trdp" IdentifierType="UriReportSource">--%>
        <ReportSource Identifier="C:\Users\leonel.valle\Desktop/Report1.trdp" IdentifierType="UriReportSource">
        </ReportSource>
    </telerik:ReportViewer>

</asp:Content>
