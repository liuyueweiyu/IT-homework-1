<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JudgeBorrow.aspx.cs" Inherits="User_JudgeBorrow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    确认借阅？<br />
&nbsp;<br />

        <asp:Button ID="Yes" runat="server" Text="确认" OnClick="btnYes_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="No" runat="server" Text="取消" PostBackUrl="~/User/BookList.aspx" />
    </div>
    </form>
</body>
</html>
