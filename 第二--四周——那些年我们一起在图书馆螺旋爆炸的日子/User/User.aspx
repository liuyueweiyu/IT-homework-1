<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        当前用户状态:<asp:Label ID="frozen" runat="server"></asp:Label>

        <br />
        <br />

        <asp:LinkButton ID="toBooklist" runat="server" Text="书籍查询" PostBackUrl="~/User/BookList.aspx"></asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="toBorrowList" runat="server" Text="借阅信息查询" PostBackUrl="~/User/BorrowList.aspx" OnClick="toBorrowList_Click"></asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="toChangeIor" runat="server" Text="修改个人资料" PostBackUrl="~/User/ChangeIor.aspx"></asp:LinkButton>


        
    </div>
    </form>
</body>
</html>
