<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddBorList.aspx.cs" Inherits="Administrator_AddBorList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        书籍编号：<asp:TextBox ID ="newbookid" runat="server"></asp:TextBox>
        <br />
        <br />
        借阅用户编号：<asp:TextBox ID="newuserid" runat="server"></asp:TextBox>

        <br />
        <br />
&nbsp;&nbsp;&nbsp;

        <asp:Button ID ="subBorList" runat="server" Text="保存" OnClick="subBorList_Click" />


        <asp:LinkButton ID="return" runat="server" PostBackUrl="~/Administrator/MaBorList.aspx"></asp:LinkButton>
    </div>
    </form>
</body>
</html>
