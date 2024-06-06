<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" style="z-index: 1; left: 17px; top: 54px; position: absolute; height: 194px; width: 208px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 46px; top: 333px; position: absolute" Text="Button" />
    </form>
</body>
</html>
