<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 239px; top: 237px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 239px; top: 316px; position: absolute" TextMode="Password"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 31px; top: 115px; position: absolute; width: 408px" Text="Order Login Page"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 55px; top: 237px; position: absolute; width: 100px; right: 826px" Text="UserName"></asp:Label>
        <p>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 62px; top: 318px; position: absolute; width: 101px" Text="Password"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 601px; top: 262px; position: absolute; height: 27px; width: 127px"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 240px; top: 394px; position: absolute" Text="Login" />
        </p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 339px; top: 394px; position: absolute; height: 34px; width: 83px" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
