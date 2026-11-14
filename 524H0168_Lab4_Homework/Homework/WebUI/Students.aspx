<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="WebUI.Students" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Student Management</h2>
            
            <asp:Label ID="lblId" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox><br />
            
            <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
            
            <asp:Label ID="lblCity" runat="server" Text="Living:"></asp:Label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox><br />

            <asp:Label ID="lblAge" runat="server" Text="Age:"></asp:Label>
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox><br />

            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" /><br />
            <asp:Button ID="btnGet" runat="server" Text="Get" OnClick="btnGet_Click" /><br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" /><br />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" /><br />
            <br /><br />
            
            <asp:GridView ID="gvStudents" runat="server" AutoGenerateColumns="true"></asp:GridView>
            <p>Developed by Dang Hieu Minh</p>
        </div>
    </form>
</body>
</html>