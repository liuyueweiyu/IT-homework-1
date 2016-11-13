<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ForPwd.aspx.cs" Inherits="ForPwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    验证信息
         
        <br />
        <br />
        账号：<asp:TextBox ID="id" runat="server"></asp:TextBox>
        
        <br />
        <br />
        
        手机号：<asp:TextBox ID="phonenumber" runat="server"></asp:TextBox>

        <br />
        <br />

        邮箱：<asp:TextBox ID="emails" runat="server"></asp:TextBox>

        <br />
        <br />

        <asp:Button ID="lbtSub" runat="server" Text="提交" OnClick="lbtSub_Click" />
    </div>
    </form>
</body>
</html>
