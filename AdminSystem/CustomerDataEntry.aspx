<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <br class="Apple-interchange-newline">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" Width="65px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" Width="347px" MaxLength="4" TextMode="Number"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Height="25px" OnClick="btnFind_Click" Text="Find" Width="66px" />
        </div>
        <p>
            <asp:Label ID="lblCustomerName" runat="server" Text="Full Name" Width="65px"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server" Width="360px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerDateOfBirth" runat="server" Text="Date Of Birth" Width="65px"></asp:Label>
        <asp:TextBox ID="txtCustomerDateOfBirth" runat="server" Width="360px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerAddress" runat="server" Text="Address" Width="65px"></asp:Label>
            <asp:TextBox ID="txtCustomerAddress" runat="server" Width="360px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerEmail" runat="server" Text="Email" Width="65px"></asp:Label>
        <asp:TextBox ID="txtCustomerEmail" runat="server" Width="360px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerPassword" runat="server" Text="Password" Width="65px"></asp:Label>
            <asp:TextBox ID="txtCustomerPassword" runat="server" TextMode="Password" Width="360px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerActive" runat="server" Text="Active" Width="65px"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" Checked="True" OnCheckedChanged="chkCustomerActive_CheckedChanged" />
        <p>
            <asp:Label ID="lblError" runat="server" Width="490px"></asp:Label>
        </p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" Width="65px" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="68px" OnClick="btnCancel_Click" />

    </form>
</body>
</html>
