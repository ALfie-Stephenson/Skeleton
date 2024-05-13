<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 451px">
    This is the Stock Data Entry page
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStockID" runat="server" BorderStyle="None" height="19px" style="z-index: 1; left: 16px; top: 100px; position: absolute; bottom: 555px" Text="Stock ID"></asp:Label>
        <asp:TextBox ID="txtStockID" runat="server" style="z-index: 1; left: 184px; top: 98px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblTicketPrice" runat="server" height="19px" style="z-index: 1; left: 16px; top: 257px; position: absolute" Text="Ticket Price"></asp:Label>
        <asp:Label ID="lblGameID" runat="server" height="19px" style="z-index: 1; left: 16px; top: 140px; position: absolute" Text="Game ID"></asp:Label>
        <asp:Label ID="lblStockAmount" runat="server" height="19px" style="z-index: 1; left: 16px; top: 215px; position: absolute" Text="Stock Amount"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblTicketLocation" runat="server" height="19px" style="z-index: 1; left: 16px; top: 175px; position: absolute" Text="Ticket Location"></asp:Label>
        <asp:Label ID="lblTimeTicketsGoOnSale" runat="server" height="19px" style="z-index: 1; left: 16px; top: 301px; position: absolute" Text="Time Tickets Go On Sale"></asp:Label>
        <asp:Label ID="lblInStock" runat="server" style="z-index: 1; left: 16px; top: 351px; position: absolute" Text="In Stock"></asp:Label>
        <asp:TextBox ID="txtGameID" runat="server" style="z-index: 1; left: 184px; top: 137px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtTicketLocation" runat="server" style="z-index: 1; left: 184px; top: 174px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtStockAmount" runat="server" style="z-index: 1; left: 184px; top: 213px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtTicketPrice" runat="server" style="z-index: 1; left: 184px; top: 255px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtTimeTicketsGoOnSale" runat="server" style="z-index: 1; left: 184px; top: 297px; position: absolute; width: 128px"></asp:TextBox>
        <asp:CheckBox ID="chkInStock" runat="server" style="z-index: 1; left: 184px; top: 348px; position: absolute" Text="Yes" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 390px; position: absolute"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 40px; top: 423px; position: absolute; right: 1445px; height: 30px;" Text="OK" />
        </p>
        <p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 154px; top: 423px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>
