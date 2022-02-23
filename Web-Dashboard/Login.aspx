<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web_Dashboard.Login" %>

<!DOCTYPE html>


<html lang="en">

<head>
    <meta charset="utf-8">
    <title>Login IT page</title>
    <meta name="description" content="particles.js is a lightweight JavaScript library for creating particles.">
    <meta name="author" content="Vincent Garreau" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no">
    <link rel="stylesheet" media="screen" href="Content/style.css">
</head>
<body>

    <style type="text/css">
        .text {
            position: absolute;
            top: 50%;
            right: 50%;
            transform: translate(50%, -50%);
            color: $text;
            max-width: 90%;
            padding: 2em 3em;
            background: rgba(0, 0, 0, 0.4);
            text-shadow: 0px 0px 2px #131415;
            font-family: "Open Sans", sans-serif;
        }

        h1 {
            font-size: 2.25em;
            font-weight: 700;
            letter-spacing: -1px;
        }

        a,
        a:visited {
            color: $link;
            transition: 0.25s;
        }

            a:hover,
            a:focus {
                color: $link-hover;
            }
    </style>

    <!-- particles.js container -->
    <div id="particles-js"></div>

    <!-- scripts -->
    <script src="Scripts/particles.js"></script>
    <script src="Scripts/app.js"></script>

    <!-- stats.js -->
    <%--<script src="Scripts/lib/stats.js"></script>--%>

    <script>
        var count_particles, stats, update;
        stats = new Stats;
        stats.setMode(0);
        stats.domElement.style.position = 'absolute';
        stats.domElement.style.left = '0px';
        stats.domElement.style.top = '0px';
        document.body.appendChild(stats.domElement);
        count_particles = document.querySelector('.js-count-particles');
        update = function () {
            stats.begin();
            stats.end();
            if (window.pJSDom[0].pJS.particles && window.pJSDom[0].pJS.particles.array) {
                count_particles.innerText = window.pJSDom[0].pJS.particles.array.length;
            }
            requestAnimationFrame(update);
        };
        requestAnimationFrame(update);
    </script>

    <form id="form1" runat="server" >
        <div class="text">
            <h1 style="color: white;">Sign In</h1>
            <br />
            <div class="form-group">
                <input class="form-control" placeholder="User Name" name="usuario" type="text" autofocus="autofocus" autocomplete="off" id="txtUsuario" runat="server">
            </div>
            <br />
            <div class="form-group">
                <input class="form-control" placeholder="Password" name="password" type="password" id="txtPassword" runat="server">
            </div>
            <br />
            <asp:Button ID="btn_login" runat="server" Text="Login" class="btn btn-lg btn-success btn-block" Width="100%" BackColor="#5cb85c" Height="30px" OnClick="btn_login_Click" />
        </div>
    </form>
</body>
</html>
