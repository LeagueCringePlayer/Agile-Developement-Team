<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnEdit" runat="server" height="35px" OnClick="btnEdit_Click" style="z-index: 1; left: 142px; top: 459px; position: absolute" Text="Edit" width="90px" />
        </div>
        <asp:ListBox ID="lstSupplyList" runat="server" style="z-index: 1; left: 11px; top: 35px; position: absolute; height: 395px; width: 401px" OnSelectedIndexChanged="lstSupplyList_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 11px; top: 459px; position: absolute; bottom: 355px; width: 90px; height: 35px; right: 1036px;" Text="Add" />
        <p>
            <asp:Label ID="lblError" runat="server" height="30px" style="z-index: 1; left: 11px; top: 516px; position: absolute; width: 219px"></asp:Label>
        </p>
    </form>
</body>
</html>
