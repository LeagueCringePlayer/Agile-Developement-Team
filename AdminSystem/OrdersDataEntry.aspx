﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="idk">
             <div>
     <asp:Label ID="lblOrderID" runat="server" Text="Order ID" Width="65px"></asp:Label>
     <asp:TextBox ID="txtOrderID" runat="server" Width="347px" MaxLength="4" TextMode="Number"></asp:TextBox>
        <asp:Button ID="BtnFind" runat="server" Height="25px" OnClick="btnFind_Click" Text="Find" Width="66px" />
     
 </div>
 <p>
     &nbsp;</p>
 <asp:Label ID="lblOrderDate" runat="server" Text="Date Of Order" Width="65px"></asp:Label>
 <asp:TextBox ID="txtOrderDate" runat="server" Width="360px"></asp:TextBox>
 <p>
     <asp:Label ID="lblShippingAddress" runat="server" Text="Address" Width="65px"></asp:Label>
     <asp:TextBox ID="txtShippingAddress" runat="server" Width="360px"></asp:TextBox>
 </p>
 <asp:Label ID="lblPaymentMethod" runat="server" Text="Method Of Payment" Width="65px"></asp:Label>
 <asp:TextBox ID="txtPaymentMethod" runat="server" Width="360px"></asp:TextBox>
 <p>
     <asp:Label ID="lblStockID" runat="server" Text="Stock ID" Width="65px"></asp:Label>
 </p>
      <asp:Label ID="lblOrderArrival" runat="server" Text="Arrived" Width="65px"></asp:Label>
      <asp:CheckBox ID="chkArrival" runat="server" Checked="True" /></asp:CheckBox>




 <p>
     <asp:Label ID="lblError" runat="server" Width="490px"></asp:Label>
   
</p>
 
 <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" Width="65px" />
 <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="68px" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>
