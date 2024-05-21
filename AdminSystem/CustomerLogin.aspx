<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tech Suppliers Login Page</title>
</head>
<body>
     <br class="Apple-interchange-newline">
 <form id="form1" runat="server">
     <div>
         <asp:Label ID="lblUserName" runat="server" Text="UserName: " Width="65px"></asp:Label>
         <asp:TextBox ID="txtUserName" runat="server" Width="330px" MaxLength="100"></asp:TextBox>
     </div>
     <p>
         <asp:Label ID="lblPassword" runat="server" Text="Password: " Width="65px"></asp:Label>
         <asp:TextBox ID="txtPassword" runat="server" Width="330px" TextMode="Password"></asp:TextBox>  
     </p>
         <asp:Button ID="btnLogin" runat="server" Height="35px" OnClick="btnLogin_Click" Text="Login" Width="80px" />
&nbsp;       <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" Height="36px" Width="81px" />
&nbsp;
     <p>
         <asp:Label ID="lblError" runat="server" Width="490px" ForeColor="#FF3300"></asp:Label>
</p>
     </form>
        <div>
        </div>
</body>
</html>
