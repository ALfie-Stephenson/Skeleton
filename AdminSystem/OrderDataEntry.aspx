<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 350px">
      fThis is the order data entry page
    <form id="form1" runat="server">
        <div>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 204px; top: 82px; position: absolute; height: 25px;" width="188px"></asp:TextBox>
        </div>
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 10px; top: 96px; position: absolute; width: 174px; height: 26px" Text="Order ID"></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server" style="z-index: 1; left: 203px; top: 116px; position: absolute; height: 25px" width="188px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblOrderNo" runat="server" style="z-index: 1; left: 10px; top: 130px; position: absolute; margin-top: 0px" Text="Order No" width="174px"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblOrderSummary" runat="server" style="z-index: 1; left: 12px; top: 231px; position: absolute" Text="Order Summary" width="174px"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 11px; position: absolute; top: 198px; margin-bottom: 0px" Text="Date Added" width="174px"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 12px; top: 166px; position: absolute; margin-bottom: 4px" Text="Price" width="174px"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblOrderColour" runat="server" style="z-index: 1; left: 11px; top: 271px; position: absolute; width: 174px" Text="Order Colour"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 203px; top: 151px; position: absolute; width: 188px; height: 25px"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 202px; top: 185px; position: absolute; margin-top: 3px" width="188px"></asp:TextBox>
        <asp:TextBox ID="txtOrderSummary" runat="server" style="z-index: 1; left: 201px; top: 227px; position: absolute; height: 27px; margin-top: 0px" width="188px"></asp:TextBox>
        <asp:TextBox ID="txtOrderColour" runat="server" style="z-index: 1; left: 201px; top: 265px; position: absolute; height: 25px; width: 192px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 202px; top: 331px; position: absolute" Text="In Stock" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 370px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 13px; top: 424px; position: absolute; height: 35px; right: 1137px;" Text="OK" width="90px" />
        <p>
        <asp:Button ID="btnCancel0" runat="server" style="z-index: 1; left: 132px; top: 426px; position: absolute; margin-top: 1px" Text="Cancel" />
        </p>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 510px; top: 85px; position: absolute" Text="Find" />
        <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; left: 477px; top: 427px; position: absolute; width: 212px" Text="Return to Main Menu" />
    </form>
</body>
</html>
