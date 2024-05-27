<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnEdit" runat="server" height="35px" OnClick="btnEdit_Click" style="z-index: 1; left: 142px; top: 459px; position: absolute; right: 955px;" Text="Edit" width="90px" />
        </div>
        <asp:ListBox ID="lstSupplyList" runat="server" style="z-index: 1; left: 11px; top: 35px; position: absolute; height: 395px; width: 401px" OnSelectedIndexChanged="lstSupplyList_SelectedIndexChanged"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 11px; top: 459px; position: absolute; bottom: 355px; width: 90px; height: 35px; right: 1036px;" Text="Add" />
        <p>
            <asp:Label ID="lblError" runat="server" height="30px" style="z-index: 1; left: 11px; top: 672px; position: absolute; width: 219px"></asp:Label>
            <asp:Button ID="btnDelete" runat="server" height="35px" OnClick="btnDelete_Click" style="z-index: 1; left: 277px; top: 458px; position: absolute" Text="Delete" width="90px" />
            <asp:Label ID="lblEnterFilter" runat="server" style="z-index: 1; left: 14px; top: 532px; position: absolute; height: 26px; width: 155px" Text="Enter a Supplier Contact"></asp:Label>
        </p>
        <asp:TextBox ID="txtSupplierContactFilter" runat="server" height="26px" style="z-index: 1; left: 203px; top: 528px; position: absolute" width="155px"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" height="35px" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 35px; top: 585px; position: absolute; right: 1017px; width: 110px" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" height="35px" OnClick="btnClearFilter_Click" style="z-index: 1; left: 191px; top: 584px; position: absolute; width: 110px" Text="Clear Filter" />
    </form>
</body>
</html>
