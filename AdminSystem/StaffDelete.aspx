﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            </div>
    <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 250px; top: 170px; position: absolute" Text="Yes." />
    <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 351px; top: 170px; position: absolute" Text="No." />
    <p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 150px; top: 144px; position: absolute; width: 394px" Text="Wait! Are you sure that you want to delete this record?"></asp:Label>
    </p>
</form>
</body>
</html>
