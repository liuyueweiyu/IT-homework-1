<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:LinkButton ID="toMaBook" runat="server" Text="管理图书" PostBackUrl="~/Administrator/MaBook.aspx"></asp:LinkButton>
        <br />
        <br />
    <asp:LinkButton ID="toMaUser" runat="server" Text="管理用户" PostBackUrl="~/Administrator/MaUser.aspx"></asp:LinkButton>
        <br />
        <br />
    <asp:LinkButton ID="toBorList" runat="server" Text="管理借阅记录" PostBackUrl="~/Administrator/MaBorList.aspx"></asp:LinkButton>
    </div>
    </form>
</body>
</html>
