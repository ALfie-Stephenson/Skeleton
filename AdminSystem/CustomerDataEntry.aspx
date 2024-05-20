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
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 10px; top: 80px; position: absolute" Text="Name" height="19px" width="113px"></asp:Label>
        <asp:Label ID="lblCustomerCVC" runat="server" style="z-index: 1; left: 10px; top: 346px; position: absolute" Text="CVC" height="19px" width="113px"></asp:Label>
        <asp:Label ID="lblCustomerJoinDate" runat="server" style="z-index: 1; left: 10px; top: 410px; position: absolute" Text="Join Date" height="19px" width="113px"></asp:Label>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 10px; top: 138px; position: absolute" Text="Address" height="19px" width="113px"></asp:Label>
        <asp:Label ID="lblCustomerExpiryDate" runat="server" style="z-index: 1; left: 10px; top: 275px; position: absolute" Text="Expiry Date" height="19px" width="113px"></asp:Label>
        <asp:Label ID="lblCustomerCardNumber" runat="server" style="z-index: 1; left: 10px; top: 211px; position: absolute" Text="Card Number" height="19px" width="113px"></asp:Label>
        <asp:Label ID="lblCustomerNumber" runat="server" style="z-index: 1; left: 9px; top: 31px; position: absolute" Text="Customer Number" height="19px" width="113px"></asp:Label>
        <asp:TextBox ID="txtCustomerExpiryDate" runat="server" style="z-index: 1; left: 177px; top: 274px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 177px; top: 79px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerNo" runat="server" style="z-index: 1; left: 177px; top: 28px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerJoinDate" runat="server" style="z-index: 1; left: 177px; top: 409px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerCardNo" runat="server" style="z-index: 1; left: 177px; top: 210px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerCVC" runat="server" style="z-index: 1; left: 177px; top: 345px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 177px; top: 137px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" height="19px" style="z-index: 1; left: 10px; top: 465px; position: absolute" Text="Active" width="113px" />
        <asp:Label ID="lblError" runat="server" height="19px" style="z-index: 1; left: 10px; top: 521px; position: absolute" width="113px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" style="z-index: 1; left: 18px; top: 578px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 181px; top: 579px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
