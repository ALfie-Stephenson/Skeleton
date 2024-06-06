<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 388px; top: 762px; position: absolute" Text="Return to Main Menu" />
        </div>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 259px; top: 646px; position: absolute" Text="Delete" />
        <asp:ListBox ID="lstCustomerList" runat="server" Height="591px" Width="629px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 13px; top: 716px; position: absolute" Text="Enter an Address"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 138px; top: 644px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 827px; position: absolute"></asp:Label>
        </p>
        <asp:TextBox ID="txtAddressFilter" runat="server" style="z-index: 1; left: 152px; top: 717px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 186px; top: 761px; position: absolute" Text="Clear Filter" />
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 11px; top: 761px; position: absolute" Text="Apply Filter" />
    </form>
</body>
</html>
