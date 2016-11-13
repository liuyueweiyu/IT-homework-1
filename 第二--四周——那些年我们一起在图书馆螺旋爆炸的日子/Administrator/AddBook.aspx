<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddBook.aspx.cs" Inherits="Administrator_AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        书名：<asp:TextBox ID ="newbookname" runat="server"></asp:TextBox>
        <br />
        <br />
        作者：<asp:TextBox ID ="newauthor" runat="server"></asp:TextBox>
        <br />
        <br />
        数量：<asp:TextBox ID="newcount" runat="server"></asp:TextBox>


        <br />
        <br />
&nbsp;&nbsp;&nbsp;

        <asp:Button ID ="subBook" runat="server" Text="保存" OnClick="subBook_Click" />
        <br />
        <br />
        <asp:LinkButton ID="return" runat="server" Text="返回上一级" PostBackUrl="~/Administrator/MaBook.aspx"></asp:LinkButton>



    </div>
    </form>
</body>
</html>
