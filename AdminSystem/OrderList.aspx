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
        <asp:ListBox ID="lstOrderList" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" style="z-index: 1; left: 9px; top: 52px; position: absolute; height: 259px; width: 457px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 33px; top: 424px; position: absolute; height: 29px; width: 68px;" Text="Add" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 28px; top: 617px; position: absolute; margin-top: 0px; margin-bottom: 19px"></asp:Label>
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 244px; top: 422px; position: absolute; margin-bottom: 0px; height: 31px; width: 102px;" Text="Delete" />
        </p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 137px; top: 426px; position: absolute; height: 29px; width: 64px;" Text="Edit" />
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 29px; top: 557px; position: absolute; margin-bottom: 7px" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 246px; top: 558px; position: absolute; margin-top: 3px; margin-bottom: 0px" Text="Clear Filter" />
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 246px; top: 499px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 31px; top: 502px; position: absolute; width: 258px" Text="Enter an OrderNo."></asp:Label>
    </form>
</body>
</html>
