<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyLogin.aspx.cs" Inherits="SupplyLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSupplyLoginPage" runat="server" style="z-index: 1; left: 166px; top: 31px; position: absolute; height: 33px; width: 130px" Text="Supply Login Page"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 57px; top: 96px; position: absolute; height: 34px; width: 90px; right: 1369px" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 156px; top: 94px; position: absolute; width: 137px; height: 21px; bottom: 555px"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 58px; top: 163px; position: absolute; height: 34px" Text="Password:" width="90px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" height="21px" style="z-index: 1; left: 155px; top: 159px; position: absolute" TextMode="Password" width="137px"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 87px; top: 213px; position: absolute; height: 30px; width: 68px; right: 1330px" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" height="30px" style="z-index: 1; left: 208px; top: 212px; position: absolute" Text="Cancel" width="68px" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 359px; top: 130px; position: absolute; height: 74px; width: 316px"></asp:Label>
    </form>
</body>
</html>
