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
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 13px; top: 72px; position: absolute" Text="Name" height="19px" width="113px"></asp:Label>
        <asp:Label ID="lblCustomerCVC" runat="server" style="z-index: 1; left: 11px; top: 229px; position: absolute" Text="CVC" height="19px" width="113px"></asp:Label>
        <asp:Label ID="lblCustomerJoinDate" runat="server" style="z-index: 1; left: 9px; top: 266px; position: absolute" Text="Join Date" height="19px" width="113px"></asp:Label>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 10px; top: 109px; position: absolute" Text="Address" height="19px" width="113px"></asp:Label>
        <asp:Label ID="lblCustomerExpiryDate" runat="server" style="z-index: 1; left: 10px; top: 188px; position: absolute" Text="Expiry Date" height="19px" width="113px"></asp:Label>
        <asp:Label ID="lblCustomerCardNumber" runat="server" style="z-index: 1; left: 10px; top: 153px; position: absolute" Text="Card Number" height="19px" width="113px"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 171px; top: 66px; position: absolute; height: 22px; width: 128px;"></asp:TextBox>
        <asp:TextBox ID="txtCustomerNo" runat="server" style="z-index: 1; left: 171px; top: 28px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerJoinDate" runat="server" style="z-index: 1; left: 171px; top: 262px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerCardNo" runat="server" style="z-index: 1; left: 171px; top: 145px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerCVC" runat="server" style="z-index: 1; left: 171px; top: 223px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 171px; top: 105px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" height="19px" style="z-index: 1; left: 183px; top: 323px; position: absolute" Text="Active" width="113px" />
        <asp:Label ID="lblError" runat="server" height="19px" style="z-index: 1; left: 8px; top: 349px; position: absolute" width="113px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" style="z-index: 1; left: 28px; top: 407px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 191px; top: 407px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblCustomerNumber" runat="server" style="z-index: 1; left: 11px; top: 33px; position: absolute; width: 120px;" Text="Customer Number" height="19px"></asp:Label>
        <p>
        <asp:TextBox ID="txtCustomerExpiryDate" runat="server" style="z-index: 1; left: 171px; top: 182px; position: absolute" height="22px" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 354px; top: 30px; position: absolute" Text="Find" />
        </p>
    </form>
</body>
</html>
