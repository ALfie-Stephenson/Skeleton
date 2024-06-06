<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerStaffLoginPage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 49px; top: 141px; position: absolute" Text="UserName"></asp:Label>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 413px; top: 188px; position: absolute"></asp:Label>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 46px; top: 224px; position: absolute" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 152px; top: 222px; position: absolute" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 152px; top: 139px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 222px; top: 310px; position: absolute" Text="Cancel" />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 143px; top: 308px; position: absolute" Text="Login" />
        </div>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 50px; top: 35px; position: absolute; height: 21px" Text="Staff Login Page"></asp:Label>
    </form>
</body>
</html>
