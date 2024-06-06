<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 79px; top: 73px; position: absolute; height: 22px; width: 325px; margin-bottom: 0px" Text="Are You Sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 134px; top: 132px; position: absolute; height: 23px; width: 39px" Text="Yes" />
        <asp:Button ID="btnNO" runat="server" OnClick="btnNO_Click" style="z-index: 1; top: 131px; position: absolute; width: 44px; left: 202px" Text="No" />
    </form>
</body>
</html>
