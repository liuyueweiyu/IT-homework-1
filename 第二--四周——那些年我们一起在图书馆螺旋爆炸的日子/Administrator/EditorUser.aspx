<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditorUser.aspx.cs" Inherits="Administrator_EditorUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        用户名：
              <asp:TextBox ID ="username" runat="server"></asp:TextBox>
        <br />
        <br />
        邮箱：
              <asp:TextBox ID ="useremail" runat="server" ></asp:TextBox>
        <br />
        <br />
        手机号：
              <asp:TextBox ID="userphnum" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Button ID="changeuser" runat="server" Text="提交" OnClick="btnChangeuser_Click" />
    </div>
    </form>
</body>
</html>
