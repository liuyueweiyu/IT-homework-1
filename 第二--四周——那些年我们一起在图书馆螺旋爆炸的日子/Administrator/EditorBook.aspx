<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditorBook.aspx.cs" Inherits="Administrator_EditorBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        书名：
              <asp:TextBox ID ="bookname" runat="server"></asp:TextBox>
        <br />
        <br />
        作者：
              <asp:TextBox ID ="author" runat="server" ></asp:TextBox>
        <br />
        <br />
        数量：
              <asp:TextBox ID="count" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Button ID="changebook" runat="server" Text="提交" OnClick="changebook_Click" />
        <br />
        <br />
        <asp:LinkButton ID="return" runat="server" Text="返回上一级" PostBackUrl="~/Administrator/MaBook.aspx"></asp:LinkButton>
    </div>
    </form>
</body>
</html>
