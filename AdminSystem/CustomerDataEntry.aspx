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
        <asp:Label ID="lblCustomerNumber" runat="server" style="z-index: 1; top: 28px; position: absolute; left: 16px" Text="Customer Number" height="19px" width="121px"></asp:Label>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 16px; top: 77px; position: absolute" Text="Customer Name" height="19px" width="121px"></asp:Label>
        <asp:Label ID="lblCardExpiryDate" runat="server" style="z-index: 1; left: 16px; top: 221px; position: absolute" Text="Card Expiry Date" height="19px" width="121px"></asp:Label>
        <asp:Label ID="lblJoinDate" runat="server" style="z-index: 1; left: 16px; top: 318px; position: absolute" Text="Join Date" height="19px" width="121px"></asp:Label>
        <asp:Label ID="lblCardNumber" runat="server" style="z-index: 1; left: 16px; top: 176px; position: absolute" Text="Card Number" height="19px" width="121px"></asp:Label>
        <asp:Label ID="lblCVC" runat="server" style="z-index: 1; left: 16px; top: 265px; position: absolute" Text="CVC" height="19px" width="121px"></asp:Label>
        <asp:TextBox ID="txtCustomerNo" runat="server" style="z-index: 1; left: 173px; top: 27px; position: absolute" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 169px; top: 77px; position: absolute" height="22px" OnTextChanged="TextBox2_TextChanged" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; top: 133px; position: absolute; left: 16px; width: 121px;" Text="Customer Address"></asp:Label>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 16px; top: 363px; position: absolute" Text="Active" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 411px; position: absolute"></asp:Label>
        </p>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 169px; top: 132px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerCardNo" runat="server" style="z-index: 1; left: 169px; top: 178px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerExpiryDate" runat="server" style="z-index: 1; left: 169px; top: 221px; position: absolute; bottom: 416px;" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerCVC" runat="server" style="z-index: 1; left: 169px; top: 265px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtJoinDate" runat="server" style="z-index: 1; left: 169px; top: 315px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 216px; top: 481px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 41px; top: 474px; position: absolute" Text="OK" OnClick="btnOK_Click" />
    </form>
</body>
</html>
