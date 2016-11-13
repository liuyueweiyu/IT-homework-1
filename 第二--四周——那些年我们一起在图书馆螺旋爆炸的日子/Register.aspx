<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    注册界面

         
        <br />
        &nbsp;&nbsp;
        账号:<asp:TextBox ID="newid" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
        密码:<asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
        （密码长度不小于6位）<br />
        <br />
        再次输入密码：<asp:TextBox ID="repassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID ="submit" runat="server" Text="注册" OnClick="btnSubmit_Click" />
    </div>
    </form>
</body>
</html>
