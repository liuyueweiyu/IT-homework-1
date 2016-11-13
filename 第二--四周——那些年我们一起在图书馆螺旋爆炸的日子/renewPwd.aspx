<%@ Page Language="C#" AutoEventWireup="true" CodeFile="renewPwd.aspx.cs" Inherits="renewPwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    请重置你的密码<br />
        <br />
        新密码：<asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        再输入你的新密码：<asp:TextBox ID="repassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="sub" runat="server" OnClick="sub_Click"  Text="重置"/>
    </div>
    </form>
</body>
</html>
