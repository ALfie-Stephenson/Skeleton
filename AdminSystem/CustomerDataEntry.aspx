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
        <asp:Label ID="lblCustomerNo" runat="server" style="z-index: 1; left: 10px; top: 38px; position: absolute" Text="Customer Number" height="19px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 136px; top: 34px; position: absolute; right: 1328px" height="22px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 10px; top: 95px; position: absolute" Text="Name" height="19px" width="113px"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 136px; top: 91px; position: absolute" height="22px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 10px; top: 148px; position: absolute" Text="Address" height="19px" width="113px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblCustomerCardNo" runat="server" style="z-index: 1; left: 10px; position: absolute; top: 210px" Text="Card Number" height="19px" width="113px"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 136px; top: 144px; position: absolute" height="22px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblCustomerExpiryDate" runat="server" style="z-index: 1; left: 10px; top: 265px; position: absolute" Text="Expiry Date" height="19px" width="113px"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 136px; top: 206px; position: absolute" height="22px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="CustomerCVC" runat="server" style="z-index: 1; left: 10px; top: 311px; position: absolute; height: 19px; right: 637px;" Text="CVC" width="113px"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 136px; top: 309px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerJoinDate" runat="server" style="z-index: 1; left: 10px; top: 362px; position: absolute; height: 19px" Text="Join Date" width="113px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 136px; top: 359px; position: absolute" height="22px"></asp:TextBox>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 73px; top: 513px; position: absolute" Text="Cancel" />
        </p>
        <p>
            <asp:CheckBox ID="lblAccountActivity" runat="server" style="z-index: 1; left: 10px; top: 417px; position: absolute" Text="Active" height="19px" />
        </p>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 136px; top: 261px; position: absolute" height="22px"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 14px; top: 513px; position: absolute" Text="OK" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 463px; position: absolute"></asp:Label>
    </form>
</body>
</html>
