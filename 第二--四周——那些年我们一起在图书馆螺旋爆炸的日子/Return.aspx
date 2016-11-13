<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Return.aspx.cs" Inherits="Return" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        借阅编号：<asp:TextBox ID ="serialnumber" runat="server"></asp:TextBox>
        <br />
        <br />
        借阅书编号：<asp:TextBox ID="bookid" runat="server"></asp:TextBox>

        <br />
        <br />

        <asp:Button ID="return" runat="server" Text="归还" OnClick="btnReturn_Click" />

        <br />
        <br />

        <asp:LinkButton ID="return0" runat="server" PostBackUrl="~/Login.aspx" Text="返回上一级"></asp:LinkButton>
    </div>
    </form>
</body>
</html>
