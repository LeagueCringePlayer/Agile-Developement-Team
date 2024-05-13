<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" style="position: absolute; left: 35px; top: 26px; width: 93px;"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server" style="position: absolute; left: 147px; top: 25px;"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblStaffName" runat="server" Text="Staff Name" style="position: absolute; left: 35px; top: 66px; width: 93px;"></asp:Label>
            <asp:TextBox ID="txtStaffName" runat="server" style="position: absolute; left: 147px; top: 65px;"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblStaffEmail" runat="server" Text="Staff Email" style="position: absolute; left: 35px; top: 106px; width: 93px;"></asp:Label>
            <asp:TextBox ID="txtStaffEmail" runat="server" style="position: absolute; left: 147px; top: 105px;"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblStaffRole" runat="server" Text="Staff Role" style="position: absolute; left: 35px; top: 146px; width: 93px;"></asp:Label>
            <asp:TextBox ID="txtStaffRole" runat="server" style="position: absolute; left: 147px; top: 145px;"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblDateHired" runat="server" Text="Date Hired" style="position: absolute; left: 35px; top: 186px; width: 93px;"></asp:Label>
            <asp:TextBox ID="txtDateHired" runat="server" style="position: absolute; left: 147px; top: 185px;"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="chkIsActive" runat="server" Text="Is Active" style="position: absolute; left: 147px; top: 225px;"></asp:CheckBox>
        </div>
        <div>
            <asp:Label ID="lblHourlyRate" runat="server" Text="Hourly Rate" style="position: absolute; left: 35px; top: 265px; width: 107px; right: 1418px;"></asp:Label>
            <asp:TextBox ID="txtHourlyRate" runat="server" style="position: absolute; left: 147px; top: 264px;"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" style="position: absolute; left: 50px; top: 304px; width: 77px;" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" style="position: absolute; left: 147px; top: 304px; width: 77px;" />
        </div>
    </form>
</body>
</html>