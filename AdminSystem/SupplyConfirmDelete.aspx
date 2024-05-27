<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 108px; top: 59px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 121px; top: 111px; position: absolute; height: 28px; width: 68px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" height="28px" OnClick="btnNo_Click" style="z-index: 1; left: 262px; top: 111px; position: absolute" Text="No" width="68px" />
    </form>
</body>
</html>
