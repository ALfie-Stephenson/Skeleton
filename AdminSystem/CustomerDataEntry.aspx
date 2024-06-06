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
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 11px; top: 72px; position: absolute" Text="Name" height="19px" width="145px"></asp:Label>
        <asp:Label ID="lblCustomerCVC" runat="server" style="z-index: 1; left: 11px; top: 281px; position: absolute" Text="CVC" height="19px" width="145px"></asp:Label>
        <asp:Label ID="lblCustomerJoinDate" runat="server" style="z-index: 1; left: 11px; top: 322px; position: absolute" Text="Join Date" height="19px" width="145px"></asp:Label>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 11px; top: 159px; position: absolute" Text="Address" height="19px" width="145px"></asp:Label>
        <asp:Label ID="lblCustomerExpiryDate" runat="server" style="z-index: 1; left: 11px; top: 241px; position: absolute" Text="Expiry Date" height="19px" width="145px"></asp:Label>
        <asp:Label ID="lblCustomerCardNumber" runat="server" style="z-index: 1; left: 11px; top: 201px; position: absolute" Text="Card Number" height="19px" width="145px"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 162px; top: 66px; position: absolute; height: 25px; width: 168px;"></asp:TextBox>
        <asp:TextBox ID="txtCustomerNo" runat="server" style="z-index: 1; left: 162px; top: 28px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerJoinDate" runat="server" style="z-index: 1; left: 162px; top: 320px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerCardNo" runat="server" style="z-index: 1; left: 162px; top: 195px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerCVC" runat="server" style="z-index: 1; left: 162px; top: 278px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 162px; top: 155px; position: absolute" height="25px" width="168px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" height="19px" style="z-index: 1; left: 195px; top: 365px; position: absolute" Text="Active" width="113px" />
        <asp:Label ID="lblError" runat="server" height="19px" style="z-index: 1; left: 13px; top: 392px; position: absolute; width: 756px;"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" style="z-index: 1; left: 31px; top: 465px; position: absolute; height: 26px; width: 33px;" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 196px; top: 465px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblCustomerNumber" runat="server" style="z-index: 1; left: 11px; top: 33px; position: absolute; width: 145px;" Text="Customer Number" height="19px"></asp:Label>
        <p>
        <asp:TextBox ID="txtCustomerExpiryDate" runat="server" style="z-index: 1; left: 162px; top: 237px; position: absolute" height="25px" width="168px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 372px; top: 26px; position: absolute" Text="Find" />
            <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 349px; top: 464px; position: absolute" Text="Return to Main Menu" />
        </p>
        <asp:Label ID="lblCustomerEmailAddress" runat="server" height="19px" style="z-index: 1; left: 11px; top: 115px; position: absolute; bottom: 688px; right: 1410px" Text="Email Address" width="145px"></asp:Label>
        <asp:TextBox ID="txtCustomerEmailAddress" runat="server" style="z-index: 1; left: 162px; top: 112px; position: absolute; height: 25px; width: 168px;"></asp:TextBox>
    </form>
</body>
</html>
