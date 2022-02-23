<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddDevice.aspx.cs" Inherits="Web_Dashboard.AddDevice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <style type="text/css">
        @import "lesshat";

        .clearfix() {
            zoom: 1;
            &:before, &:after

        {
            content: "";
            display: block;
        }

        &:after {
            clear: both;
        }

        }

        .col() {
            padding-right: 10px;
            float: left;
            &:last-of-type

        {
            padding-right: 0;
        }

        }

        .transition(@speed, @easing) {
            transition: all @speed @easing;
        }

        // VARIABLES

        @white: #fff;
        @grey-lightest: #f9f9f9;
        @grey-light: #e3e3e3;
        @grey: #e5e5e5;
        @grey-dark: #b9b9b9;

        @purple: #c68eaa;
        @green: #7ed321;
        @emerald: #04BDBD;
        @blue: #04AEC5;
        @blue-dark: #0F6CC9;
        @color-primary: @green;
        @color-primary-strong: darken(saturate(@color-primary, 5%), 10%);

        @br: 3px;

        @fast: 0.35s;

        @ease: ease-in-out;

        // GENERAL

        * {
            &, &:before, &:after

        {
            box-sizing: border-box;
        }

        }

        body {
            padding: 1em;
            font-family: 'Open Sans', 'Helvetica Neue', Helvetica, Arial, sans-serif;
            font-size: 15px;
            // font-size: 1vw;
            color: @grey-dark;
            background-color: @grey-light;
        }

        // TYPOGRAPHY

        h4 {
            color: @color-primary;
        }

        // FORM

        input {
            width: -webkit-fill-available;
            width: 100%;
            padding: 1em;
            line-height: 1.4;
            background-color: @grey-lightest;
            border: 1px solid @grey;
            border-radius: 3px;
            .transition(@fast, @ease);
            &:focus

        {
            width: -webkit-fill-available;
            outline: 0;
            border-color: @color-primary-strong;
            & + .input-icon

        {
            i

        {
            color: @color-primary;
        }

        &:after {
            border-right-color: @color-primary;
        }

        }
        }

        &[type="radio"] {
            display: none;
            & + label

        {
            &:extend(input);
            display: inline-block;
            width: 50%;
            text-align: center;
            float: left;
            border-radius: 0;
            &:first-of-type

        {
            border-top-left-radius: @br;
            border-bottom-left-radius: @br;
        }

        &:last-of-type {
            border-top-right-radius: @br;
            border-bottom-right-radius: @br;
        }

        i {
            padding-right: 0.4em;
        }

        }

        &:checked + label {
            background-color: @color-primary;
            color: @white;
            border-color: @color-primary-strong;
        }

        }

        &[type="checkbox"] {
            display: none;
            & + label

        {
            position: relative;
            display: block;
            padding-left: 1.6em;
            &:before

        {
            &:extend(input);
            position: absolute;
            top: 0.2em;
            left: 0;
            display: block;
            width: 1em;
            height: 1em;
            padding: 0;
            content: "";
        }

        &:after {
            position: absolute;
            top: 0.45em;
            left: 0.2em;
            font-size: 0.8em;
            color: @white;
            opacity: 0;
            font-family: FontAwesome;
            content: "\f00c";
        }

        }
        }

        &:checked + label {
            &:before

        {
            &:extend(input[type="radio"]:checked + label);
        }

        &:after {
            opacity: 1;
        }

        }
        }

        select {
            &:extend(input[type="radio"] + label);
            height: 3.4em;
            line-height: 2;
            &:first-of-type

        {
            border-top-left-radius: @br;
            border-bottom-left-radius: @br;
        }

        &:last-of-type {
            border-top-right-radius: @br;
            border-bottom-right-radius: @br;
        }

        &:focus, &:active {
            outline: 0;
            &:extend(input[type="radio"]:checked + label);
        }

        option {
            &:extend(input);
            background-color: @color-primary;
            color: @white;
        }

        }

        .input-group {
            margin-bottom: 1em;
            display: block;
            .clearfix();
        }

        .input-group-icon {
            position: relative;
            input

        {
            padding-left: 4.4em;
        }

        .input-icon {
            position: absolute;
            top: 0;
            left: 0;
            width: 3.4em;
            height: 3.4em;
            line-height: 3.4em;
            text-align: center;
            pointer-events: none;
            &:after

        {
            position: absolute;
            top: 0.6em;
            bottom: 0.6em;
            left: 3.4em;
            /*display: block;*/
            display: inherit;
            border-right: 1px solid @grey;
            content: "";
            .transition(@fast, @ease);
        }

        i {
            .transition(@fast, @ease);
        }

        }
        }


        .container1 {
            max-width: 55em;
            padding: 0em 2em 2em 3em;
            /*margin: 0em auto;*/
            margin: 4em 0em 0em 15%;
            background-color: @white;
            border-radius: @br * 1.4;
            box-shadow: 0px 3px 10px -2px rgba(0,0,0,0.2);
            padding-top: 25px;
        }

        .row {
            .clearfix();
        }

        .col-half {
            .col();
            width: 100% / 2;
        }

        .col-third {
            .col();
            width: 100% / 3;
        }

        @media only screen and (max-width: 540px) {
            .col-half {
                width: 100%;
                padding-right: 0;
            }
        }

        .btn-style {
            float: right;
        }

        .ddl-style {
            height: 25px;
        }
    </style>

    <style type="text/css">
        .WindowsStyle .ajax__combobox_inputcontainer .ajax__combobox_textboxcontainer input {
            /*margin: 0;*/
            border: solid 1px #444;
            border-right: 0px none;
            padding: 1px 0px 0px 5px;
            /*font-size: 16px;*/
            /*height: 26px;*/
            width: 257px;
            /*position: relative;
            margin-top: -11px;*/
        }

        .WindowsStyle .ajax__combobox_inputcontainer .ajax__combobox_buttoncontainer button {
            /*margin-left: -2px;
            border-bottom: solid 1px #444;
            border-top: solid 1px #444;
            height: 26px;
            width: 26px;
            margin-top: 3px;
            margin-top: -6px;
            background-color: white;*/
        }


        .WindowsStyle .ajax__combobox_itemlist {
            border-color: #444;
        }

        input[type="checkbox"] {
            width: 30px;
        }

        input[type="radio"] {
            width: 30px;
        }
    </style>



    <div class="container1">
        <form id="form1" method="post" autocomplete="off">

            <div class="row">
                <h3>Add New Device</h3>

                <div class="input-group input-group-icon">



                    <div class="input-icon"><i class="fa fa-envelope"></i></div>
                </div>

                <div class="input-group input-group-icon">
                    <input runat="server" type="text" placeholder="Service Tag" id="txt_servicetag" name="txt_servicetag" />
                    <div class="input-icon"><i class="fa fa-user"></i></div>
                </div>

                <div class="input-group input-group-icon">

                    <asp:DropDownList ID="ddl_make" runat="server" CssClass="ddl-style" AutoPostBack="true">
                        <asp:ListItem Value="-1" Text="Select Options">Select Options</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddl_os" runat="server" CssClass="ddl-style" AutoPostBack="true">
                        <asp:ListItem Value="-1" Text="Select Options">Select Options</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddl_cpu" runat="server" CssClass="ddl-style" AutoPostBack="true">
                        <asp:ListItem Value="-1" Text="Select Options">Select Options</asp:ListItem>
                    </asp:DropDownList>
                     <asp:DropDownList ID="ddl_type" runat="server" CssClass="ddl-style" AutoPostBack="true">
                        <asp:ListItem Value="-1" Text="Select Options">Select Options</asp:ListItem>
                        <asp:ListItem Value="-1" Text="Laptop">Laptop</asp:ListItem>
                        <asp:ListItem Value="-1" Text="Desktop">Desktop</asp:ListItem>
                    </asp:DropDownList>
                    <%--<input runat="server" type="text" placeholder="Client" id="txt_Client" name="txt_Client" />--%>

                    <div class="input-icon"><i class="fa fa-key"></i></div>
                </div>

                <div class="input-group input-group-icon">
                    <div class="input-icon"><i class="fa fa-key"></i></div>
                </div>
                <div class="input-group input-group-icon">
                    <input runat="server" type="text" placeholder="Departament" id="txt_departament" name="txt_departament" />
                    <div class="input-icon"><i class="fa fa-user"></i></div>
                </div>
                <div class="input-group input-group-icon">
                    <input runat="server" type="text" placeholder="Monitor" id="txt_monitor" name="txt_monitor" />
                    <div class="input-icon"><i class="fa fa-user"></i></div>
                </div>
            
            </div>

            <div class="row">
                <h4>Comment</h4>
                <div class="input-group input-group-icon">
                    <textarea runat="server" id="txt_Comment" name="txt_Comment" placeholder="Comments" style="width: 100%; height: 75px;" maxlength="1700"></textarea>
                </div>

            </div>
            <div class="row">
                <div class="input-group input-group-icon">
                    <asp:Button ID="btn_Submit" runat="server" Text="Submit" class="btn btn-lg btn-success " OnClick="btn_Submit_Click" />
                    <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" class="btn btn-lg btn-danger btn-style " OnClick="btn_Cancel_Click" />

                    <div class="input-icon"><i class="fa fa-key"></i></div>
                </div>
            </div>
        </form>
    </div>






</asp:Content>
