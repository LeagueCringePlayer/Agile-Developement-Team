<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstSupplyList" runat="server" style="z-index: 1; left: 11px; top: 35px; position: absolute; height: 367px; width: 370px" OnSelectedIndexChanged="lstSupplyList_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 11px; top: 425px; position: absolute" Text="Add" />
    </form>
</body>
</html>
