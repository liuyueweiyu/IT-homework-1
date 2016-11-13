<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditorBorList.aspx.cs" Inherits="Administrator_EditorBorList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        借阅编号：
              <asp:Label ID="snumber" runat="server"></asp:Label>

        <br />
        <br />

        书籍编号：
              <asp:TextBox ID ="bookid" runat="server"></asp:TextBox>

        <br />
        <br />
        借阅书名：
               <asp:Label ID="bookname" runat="server"></asp:Label>

        <br />
        <br />

        学生编号：
              <asp:TextBox ID="userid" runat="server"></asp:TextBox>
        <br />
        <br />
        借阅时间：
              <asp:Label ID="brtime" runat="server"></asp:Label>
        <br />
        <br />
        归还时间
               <asp:Label ID="retime" runat="server"></asp:Label>

        <br />
        <br />
        延期归还时间：
               <asp:TextBox ID="days" runat="server" Width="71px" ></asp:TextBox>
        &nbsp;（单位/天）<br />
        <br />

        <asp:Button ID="changebook" runat="server" Text="提交" OnClick="changebook_Click" />

        <br />
        <br />
        <br />

        <asp:LinkButton ID="return" runat="server" Text="返回上一级" PostBackUrl="~/Administrator/MaBorList.aspx"></asp:LinkButton>
    </div>
    </form>
</body>
</html>
