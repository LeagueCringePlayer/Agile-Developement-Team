<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="StockLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Management Login Page</title>
</head>
<body style="height: 385px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblLoginTitle" runat="server" style="z-index: 1; left: 58px; top: 26px; position: absolute; height: 31px" Text="Stock Login Page"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtUserName" runat="server" height="22px" style="z-index: 1; left: 152px; top: 91px; position: absolute" width="140px"></asp:TextBox>
        </div>
        <br />
        <asp:Label ID="lblUserName" runat="server" style="height: 23px; z-index: 1; left: 58px; top: 91px; position: absolute" Text="UserName:"></asp:Label>
        <br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 336px; top: 114px; position: absolute"></asp:Label>
        <p>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 58px; top: 145px; position: absolute" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 152px; top: 144px; position: absolute" TextMode="Password" Width="140px"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 233px; top: 200px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
            <asp:Button ID="btnLogin" runat="server" height="26px" OnClick="btnLogin_Click" style="z-index: 1; left: 115px; top: 200px; position: absolute; right: 984px" Text="Login" width="60px" />
        </p>
    </form>
</body>
</html>
