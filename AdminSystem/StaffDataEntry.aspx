<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
     <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #2c3e50;
            color: #ecf0f1;
            margin: 0;
            padding: 20px;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
        form {
            background-color: #34495e;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 4px 8px rgba(0,0,0,0.1);
            width: 300px;
        }
        .form-group {
            margin-bottom: 15px;
        }
        label {
            display: block;
            margin-bottom: 5px;
        }
        input[type="text"], input[type="number"], input[type="email"], input[type="date"], .form-control {
            width: 100%;
            padding: 8px;
            border: none;
            border-radius: 4px;
            box-sizing: border-box;
        }
        input[type="submit"], input[type="button"], button {
            background-color: #1abc9c;
            color: white;
            border: none;
            padding: 10px;
            text-transform: uppercase;
            border-radius: 4px;
            cursor: pointer;
            width: 100%;
            box-shadow: 0 2px 4px rgba(0,0,0,0.2);
            transition: background 0.3s ease;
        }
        input[type="submit"]:hover, input[type="button"]:hover, button:hover {
            background-color: #16a085;
        }
        .checkbox {
            margin: 5px 0 15px 0;
            position: relative;
            line-height: 1;
        }
        .checkbox input[type="checkbox"] {
            margin-right: 5px;
        }
        .error-label {
            color: red;
            font-weight: bold;
            margin-top: 15px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" Width="110px" style="margin-left: 26px"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server" Width="195px" MaxLength="4" TextMode="Number"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Height="25px" OnClick="btnFind_Click" Text="Find" Width="66px" />
        </div>
        <div>
            <asp:Label ID="lblStaffName" runat="server" Text="Staff Name" style="position: absolute; left: 35px; top: 66px; width: 166px;"></asp:Label>
            <asp:TextBox ID="txtStaffName" runat="server" style="position: absolute; left: 147px; top: 65px;" width="198px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblStaffEmail" runat="server" Text="Staff Email" style="position: absolute; left: 35px; top: 106px; width: 166px;"></asp:Label>
            <asp:TextBox ID="txtStaffEmail" runat="server" style="position: absolute; left: 147px; top: 105px;" width="198px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblStaffRole" runat="server" Text="Staff Role" style="position: absolute; left: 35px; top: 146px; width: 166px;"></asp:Label>
            <asp:TextBox ID="txtStaffRole" runat="server" style="position: absolute; left: 147px; top: 145px;" width="198px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblDateHired" runat="server" Text="Date Hired" style="position: absolute; left: 35px; top: 186px; width: 166px;"></asp:Label>
            <asp:TextBox ID="txtDateHired" runat="server" style="position: absolute; left: 147px; top: 185px;" width="198px"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="chkIsActive" runat="server" Text="Is Active" style="position: absolute; left: 147px; top: 225px;" width="198px"></asp:CheckBox>
        </div>
        <div>
            <asp:Label ID="lblHourlyRate" runat="server" Text="Hourly Rate" style="position: absolute; left: 35px; top: 265px; width: 166px; right: 1418px;"></asp:Label>
            <asp:TextBox ID="txtHourlyRate" runat="server" style="position: absolute; left: 147px; top: 264px;" width="198px"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" style="position: absolute; left: 50px; top: 304px; width: 66px;" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" style="position: absolute; left: 147px; top: 304px; width: 66px;" />
        </div>
        <div>
            <asp:Label ID="lblError" runat="server" CssClass="error-label" />
        </div>
    </form>
</body>
</html>
