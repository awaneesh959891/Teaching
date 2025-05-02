<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .contact-form {
            width: 50%;
            margin: 0 auto;
            border: 1px solid #ccc;
            padding: 20px;
            border-radius: 10px;
            background-color: #f9f9f9;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        .contact-form h2 {
            text-align: center;
            color: #333;
        }

        .contact-form label {
            font-weight: bold;
            display: block;
            margin-bottom: 5px;
        }

        .contact-form input[type="text"],
        .contact-form input[type="email"],
        .contact-form textarea {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .contact-form input[type="submit"] {
            background-color: #006699;
            color: white;
            border: none;
            padding: 10px 20px;
            border-radius: 5px;
            cursor: pointer;
        }

        .contact-form input[type="submit"]:hover {
            background-color: #004466;
        }

        .success-message {
            color: green;
            text-align: center;
            font-weight: bold;
        }

        .error-message {
            color: red;
            text-align: center;
            font-weight: bold;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="contact-form">
        <h2>Contact Us</h2>
        <asp:Label ID="lblMessage" runat="server" CssClass="success-message"></asp:Label>
        <asp:Label ID="lblError" runat="server" CssClass="error-message"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" Placeholder="Name"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" Placeholder="Email"></asp:TextBox>
        <asp:TextBox ID="txtSubject" runat="server" Placeholder="Subject"></asp:TextBox>
        <asp:TextBox ID="txtMessage" runat="server" Placeholder="Your Message" TextMode="MultiLine" Rows="5"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </div>
</asp:Content>
