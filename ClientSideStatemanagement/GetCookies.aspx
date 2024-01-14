<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetCookies.aspx.cs" Inherits="ClientSideStatemanagement.GetCookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
    Use Cokies to store single value<br />
    <br />
    Name:
    <asp:TextBox ID="TextBox1" runat="server" Height="22px"></asp:TextBox>
    <br />
    Mobile:<asp:TextBox ID="TextBox2" runat="server" Height="22px"></asp:TextBox>
    <br />
    Email:
    <asp:TextBox ID="TextBox3" runat="server" Height="22px"></asp:TextBox>
    <br />
    <br />
            <asp:Button ID="Button1" runat="server" Text="GetCookies" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>

    </form>
</body>
</html>
