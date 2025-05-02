<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Teaching</title>
    <!-- External CSS and Animation Libraries -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" rel="stylesheet" />
    <style>
        /* General Styles */
        body {
            font-family: 'Arial', sans-serif;
            margin: 0;
            padding: 0;
            background: linear-gradient(to right, #006699, #003366);
            color: #fff;
        }

        #top {
            text-align: center;
            padding: 20px;
        }

        #top img {
            max-width: 200px;
            animation: fadeInDown 1s;
        }

        #menu {
            background-color: #004466;
            padding: 10px 0;
            text-align: center;
        }

        #menu a {
            color: #fff;
            text-decoration: none;
            margin: 0 15px;
            font-size: 18px;
            font-weight: bold;
            transition: color 0.3s;
        }

        #menu a:hover {
            color: #ffcc00;
        }

        #main {
            display: flex;
            justify-content: space-between;
            padding: 20px;
            flex-wrap: wrap;
        }

        #left, #right {
            width: 45%;
            margin-bottom: 20px;
        }

        .login-area {
            background: rgba(255, 255, 255, 0.1);
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);
            animation: fadeInUp 1s;
        }

        .login-area h2 {
            text-align: center;
            color: #ffcc00;
            margin-bottom: 20px;
        }

        .login-area label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }

        .login-area input[type="text"],
        .login-area input[type="password"] {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            border: none;
            border-radius: 5px;
        }

        .login-area button {
            width: 100%;
            padding: 10px;
            background-color: #ffcc00;
            border: none;
            border-radius: 5px;
            font-size: 16px;
            font-weight: bold;
            color: #003366;
            cursor: pointer;
            transition: background-color 0.3s;
        }

        .login-area button:hover {
            background-color: #e6b800;
        }

        #footer {
            text-align: center;
            padding: 10px;
            background-color: #003366;
            color: #fff;
            position: fixed;
            bottom: 0;
            width: 100%;
        }

        .marquee {
            font-size: 18px;
            font-weight: bold;
            color: #ffcc00;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Top Section -->
        <div id="top">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/ot.jpg" />
        </div>

        <!-- Navigation Menu -->
     <div id="menu">
    <a href="/Default.aspx">HOME</a>
    <a href="/Registartion.aspx">REGISTRATION</a>
    <a href="/Feedback.aspx">FEEDBACK</a>
    <a href="/StaffReport.aspx">STAFF REPORT</a>
    <a href="/Download.aspx">DOWNLOAD</a>
    <a href="/Admin/Default.aspx">ADMIN</a>
    <a href="/ContactUs.aspx">CONTACT US</a>
</div>



        <!-- Main Content -->
        <div id="main">
            <!-- Staff Login -->
            <div id="left" class="login-area">
                <h2>Staff Login</h2>
                <asp:Label ID="lblstaff" runat="server" ForeColor="Red"></asp:Label>
                <label for="txtstaffuname">Login Name:</label>
                <asp:TextBox ID="txtstaffuname" runat="server" CssClass="txt"></asp:TextBox>
                <label for="txtstaffpass">Password:</label>
                <asp:TextBox ID="txtstaffpass" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox>
                <asp:Button ID="btnstafflogin" runat="server" CssClass="btn" Text="Login" onclick="btnstafflogin_Click" />
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/StaffFPass.aspx">Forgot Password?</asp:LinkButton>
            </div>

            <!-- Student Login -->
            <div id="right" class="login-area">
                <h2>Student Login</h2>
                <asp:Label ID="lblstudent" runat="server" ForeColor="Red"></asp:Label>
                <label for="txtxstuuname">Login Name:</label>
                <asp:TextBox ID="txtxstuuname" runat="server" CssClass="txt"></asp:TextBox>
                <label for="txtstupassword">Password:</label>
                <asp:TextBox ID="txtstupassword" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox>
                <asp:Button ID="btnstulogin" runat="server" CssClass="btn" Text="Login" onclick="btnstulogin_Click" />
                <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/StudentFPass.aspx">Forgot Password?</asp:LinkButton>
            </div>
        </div>

        <!-- Footer -->
        <div id="footer">
            <marquee class="marquee">...Online Teaching... Learn Everything at One Place... Online Teaching...</marquee>
            All Copy Rights @ Online Teaching 2025
        </div>
    </form>
</body>
</html>
