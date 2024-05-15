<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerNumber" runat="server" style="z-index: 1; top: 28px; position: absolute; left: 12px" Text="Customer Number"></asp:Label>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 16px; top: 77px; position: absolute" Text="Customer Name"></asp:Label>
        <asp:Label ID="lblCardExpiryDate" runat="server" style="z-index: 1; left: 17px; top: 221px; position: absolute" Text="Card Expiry Date"></asp:Label>
        <asp:Label ID="lblJoinDate" runat="server" style="z-index: 1; left: 18px; top: 318px; position: absolute" Text="Join Date"></asp:Label>
        <asp:Label ID="lblCardNumber" runat="server" style="z-index: 1; left: 17px; top: 176px; position: absolute" Text="Card Number"></asp:Label>
        <asp:Label ID="lblCVC" runat="server" style="z-index: 1; left: 17px; top: 265px; position: absolute" Text="CVC"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 173px; top: 27px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 169px; top: 77px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; top: 133px; position: absolute; left: 16px" Text="Customer Address"></asp:Label>
        <p>
            <asp:CheckBox ID="lblActive" runat="server" style="z-index: 1; left: 16px; top: 363px; position: absolute" Text="Active" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 411px; position: absolute"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 171px; top: 132px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 171px; top: 178px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 168px; top: 221px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 167px; top: 265px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 164px; top: 315px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 216px; top: 481px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 41px; top: 474px; position: absolute" Text="OK" />
    </form>
</body>
</html>
