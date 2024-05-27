﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
            <asp:ListBox ID="lstOrderList" runat="server" Height="351px" Width="406px" ></asp:ListBox>
        <asp:Button ID="BtnClear" runat="server" Height="39px" OnClick="BtnClear_Click" Text="Clear Filter" Width="89px" />
        <asp:Button ID="BtnDelete" runat="server" Height="37px" OnClick="btnDelete_Click" Text="Delete" Width="116px" />
        <asp:Button ID="BtnApply" runat="server" Height="36px" style="margin-top: 0px" Text="Apply Filter" Width="101px" OnClick="BtnApply_Click" />
    <br />
    <br />
    <asp:Button ID="btnAdd" runat="server" Height="35px" OnClick="btnAdd_Click" Text="Add" Width="80px" />
&nbsp;
       <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Height="36px" Width="81px" />
&nbsp;
       <asp:Label ID="lblError" runat="server" Width="420px"></asp:Label>
        <p>
            <asp:Label ID="lblFilter" runat="server" Text="Enter Adress"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 27px; margin-bottom: 0px" Width="301px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Back To Main Menu" Width="237px" OnClick="Button1_Click2" />
        </p>
    </form>
</body>
</html>
