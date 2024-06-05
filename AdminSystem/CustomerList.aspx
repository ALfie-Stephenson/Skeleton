<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="591px" Width="629px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 137px; top: 645px; position: absolute" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 727px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
