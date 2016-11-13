<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    登陆界面
         
        <br />
        <br />
        账号：<asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
        <br />
        <br />
        密码：<asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        &nbsp; <asp:Button ID ="btnRegstu" runat="server" Text="学生登录" OnClick="btnLogStu_Click" />
        &nbsp; <asp:Button ID ="btnRegadi" runat="server" Text="管理员登陆" OnClick="btnLogAd_Click" />
        
        &nbsp;<br />
        &nbsp;<br />
        &nbsp;<asp:Button ID ="btnLogin" runat="server"  PostBackUrl="~/Register.aspx" Text="注册" />
        &nbsp;<asp:Button ID ="btnForPwd" runat="server" PostBackUrl="~/ForPwd.aspx" Text="忘记密码" />
        &nbsp;<asp:Button ID ="btnReturn" runat="server" PostBackUrl="~/Return.aspx" Text="无登陆归还" />
    </div>
    </form>
</body>
</html>
