<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 453px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 20px; top: 29px; position: absolute; height: 21px; width: 112px; bottom: 627px" Text="Supplier ID"></asp:Label>
        </div>
        <asp:TextBox ID="txtSupplierID" runat="server" height="22px" style="z-index: 1; left: 172px; top: 27px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblSupplierContact" runat="server" height="21px" style="z-index: 1; left: 16px; top: 72px; position: absolute" Text="Supplier Contact" width="112px"></asp:Label>
        <asp:TextBox ID="txtSupplierContact" runat="server" height="22px" style="z-index: 1; left: 171px; position: absolute; top: 70px" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblPriceOfResource" runat="server" height="21px" style="z-index: 1; left: 13px; top: 117px; position: absolute" Text="Price Of Resource" width="112px"></asp:Label>
        <asp:Label ID="lblDateRequested" runat="server" style="z-index: 1; left: 17px; top: 166px; position: absolute; height: 21px; width: 112px" Text="Date Requested"></asp:Label>
        <asp:TextBox ID="txtDateRequested" runat="server" height="22px" style="z-index: 1; left: 172px; top: 167px; position: absolute" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtPriceOfResource" runat="server" height="22px" style="z-index: 1; top: 117px; position: absolute; left: 170px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkAvailabilityOfSupplier" runat="server" style="z-index: 1; left: 174px; top: 216px; position: absolute" Text="Availability Of Supplier" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 27px; top: 301px; position: absolute; width: 60px" Text="OK" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 21px; top: 258px; position: absolute"></asp:Label>
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 121px; top: 301px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
