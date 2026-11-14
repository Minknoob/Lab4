<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebUI.Main" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Dashboard</title>
    <style>
        .menu-bar { background-color: #333; overflow: hidden; }
        .menu-bar a { float: left; color: #f2f2f2; text-align: center; padding: 14px 16px; text-decoration: none; font-size: 17px; }
        .menu-bar a:hover { background-color: #ddd; color: black; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="menu-bar">

            <a href="CustomerWForm.aspx">Manage Customers</a>

            <a href="ProductWForm.aspx">Manage Products</a>
            <a href="SupplierWForm.aspx">Manage Suppliers</a>
            <a href="Login.aspx" style="float:right;">Logout</a>
        </div>
        
        <div style="padding: 20px;">
            <h2>Welcome to the System Dashboard</h2>
            <p>Please select an option from the menu above to proceed.</p>
        </div>
        <p>Developed by Dang Hieu Minh</p>
    </form>
</body>
</html>