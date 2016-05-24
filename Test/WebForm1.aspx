<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Test.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <div style="float: left"><asp:Image ID="Image1" runat="server" BackColor="#990099" Height="128px" Width="182px" /></div>
        <div style="float: left">
            <asp:Label ID="Label1" runat="server" Text="北京小吃"></asp:Label>
            <asp:Image ID="Image2" runat="server" BackColor="#FF99CC" Height="22px" Width="74px" />
        </div>
        
        <asp:Label ID="Label2" runat="server" Text="北京小吃"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="京酱小说"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="地址："></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="电话："></asp:Label>
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
    </form>
    <div>
        <span>简介</span>
        <p></p>
    </div>
</body>
</html>
