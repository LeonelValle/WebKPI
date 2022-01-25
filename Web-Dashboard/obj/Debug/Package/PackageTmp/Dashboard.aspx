<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Web_Dashboard.Dashboard" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <style>
        body {
            font-family: "Lato", sans-serif;
        }

        .sidenav {
            height: 100%;
            width: 150px;
            position: fixed;
            z-index: 1;
            top: 50px;
            left: 0;
            background-color: #f1f1f1;
            overflow-x: hidden;
            padding-top: 20px;
        }

            .sidenav a {
                padding: 6px 6px 6px 22px;
                text-decoration: none;
                font-size: 20px;
                color: #818181;
                display: block;
            }

        .sidenav a.active {
            background-color: #4CAF50;
            color: white;
        }

        .sidenav a:hover:not(.active) {
            background-color: #555;
            color: white;
        }

        .sidenav a:hover {
            color: #000000;
        }

        .main {
            margin-left: 200px; /* Same as the width of the sidenav */
        }

        @media screen and (max-height: 450px) {
            .sidenav {
                padding-top: 15px;
            }

                .sidenav a {
                    font-size: 18px;
                }
        }
    </style>


    <div class="sidenav">
        <a class="active" href="#">Shortcut</a>
        <a href="http://192.168.1.5:8080/public/login.htm?loginurl=%2Fwelcome.htm&errorid=0">PRTG</a>
        <a href="https://cp.hornetsecurity.com/login">Hornet Security</a>
        <a href="https://masterworkelectronics.freshdesk.com/a/tickets/filters/unresolved">Tickets</a>
        <a href="https://n220.meraki.com/MEI-Mexicali-Ele/n/QablsbBc/manage/nodes/new_wired_status/summary?timespan=86400">Meraki</a>
        <a href="https://login.cylance.com/Login?from=VenueWeb">Cylance</a>
        <a href="https://192.168.1.16:8443/manage/account/login?redirect=%2Fmanage">Ubiquiti</a>
    </div>



    <div>
        <h1>Dashboard</h1>
        <br />
        <br />



        <h2>PRTG</h2>
        <iframe width="1024" height="600" src="https://app.powerbi.com/view?r=eyJrIjoiMjI5ZjgyZmEtMjE3Mi00ZDkyLTg3ZDItOGFlNWNjYTk0MzEwIiwidCI6IjI1ZjZjMGZlLTczY2MtNDY3Mi1iMDRmLWU5ZmYxYWM5NjVmZiJ9" frameborder="0" allowfullscreen="true"></iframe>

        <br />
        <br />
        <br />
        <br />


        <h2>Tickets</h2>
        <iframe width="1024" height="600" src="https://app.powerbi.com/view?r=eyJrIjoiYjZiZGE2ZTMtMGZiMS00YjIwLTgxZmYtMTljOTQ5NTNiOThhIiwidCI6IjI1ZjZjMGZlLTczY2MtNDY3Mi1iMDRmLWU5ZmYxYWM5NjVmZiJ9&pageName=ReportSection" frameborder="0" allowfullscreen="true"></iframe>

    </div>
</asp:Content>
