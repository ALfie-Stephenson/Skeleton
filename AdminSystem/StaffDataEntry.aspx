<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
       </div>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 23px; top: 80px; position: absolute" Text="Staff Name" height="19px" width="120px"></asp:Label>
        <asp:Label ID="lblStaffPermission" runat="server" style="z-index: 1; left: 23px; top: 177px; position: absolute" Text="Permission" height="19px" width="120px"></asp:Label>
        <asp:Label ID="lblStaffOnShift" runat="server" style="z-index: 1; left: 23px; top: 208px; position: absolute; margin-right: 1px;" Text="On Shift" height="19px" width="120px"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 135px; top: 74px; position: absolute; height: 22px; width: 113px;"></asp:TextBox>
        <asp:TextBox ID="txtStaffNo" runat="server" style="z-index: 1; left: 135px; top: 40px; position: absolute" height="22px" width="113px"></asp:TextBox>
        <asp:TextBox ID="txtStaffRole" runat="server" style="z-index: 1; left: 135px; top: 108px; position: absolute" height="22px" width="113px"></asp:TextBox>
        <asp:CheckBox ID="chkDataDelete" runat="server" height="19px" style="z-index: 1; left: 141px; top: 243px; position: absolute" Text="Delete" width="113px"/>
        <asp:Label ID="lblError" runat="server" height="19px" style="z-index: 1; left: 17px; top: 302px; position: absolute" width="113px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" style="z-index: 1; left: 79px; top: 346px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 190px; top: 348px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblStaffDataDelete" runat="server" style="z-index: 1; left: 23px; top: 244px; position: absolute; width: 120px; right: 788px;" Text="Delete Staff Data?" height="19px"></asp:Label>
        <asp:Label ID="lblStaffNo" runat="server" style="z-index: 1; left: 23px; top: 44px; position: absolute; width: 120px;" Text="Staff No." height="19px"></asp:Label>
        <p>
        <asp:TextBox ID="txtStaffStart" runat="server" style="z-index: 1; left: 135px; top: 146px; position: absolute" height="22px" width="113px"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="lblStaffStart" runat="server" style="z-index: 1; left: 23px; top: 148px; position: absolute" Text="Start Date" height="19px" width="120px"></asp:Label>
        </p>
        <p>
        <asp:CheckBox ID="chkPermission" runat="server" height="19px" style="z-index: 1; left: 135px; top: 176px; position: absolute; margin-bottom: 0px;" Text="Yes" width="113px"/>
        <asp:CheckBox ID="chkShift" runat="server" height="19px" style="z-index: 1; left: 135px; top: 206px; position: absolute; margin-bottom: 0px;" Text="Attendance" width="113px"/>
        </p>
        <p>
        <asp:Label ID="lblStaffRole" runat="server" style="z-index: 1; left: 23px; top: 117px; position: absolute" Text="Staff Role" height="19px" width="120px"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 278px; top: 40px; position: absolute" Text="Find" />
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 90px; top: 390px; position: absolute" Text="Return to Main Menu" />
          <p>
    </form>
</body>
</html>
