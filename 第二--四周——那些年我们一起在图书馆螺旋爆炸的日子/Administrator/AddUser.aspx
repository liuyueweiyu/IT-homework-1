<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="Administrator_AddUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        新增用户账号：<asp:TextBox ID="newuserid" runat="server"></asp:TextBox>
    
        <br />
        <br />
        新增用户名：<asp:TextBox ID ="newusername" runat="server"></asp:TextBox>
        <br />
        <br />
        新增用户密码：<asp:TextBox ID ="newuserpwd" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        新增用户邮箱：<asp:TextBox ID ="newuseremail" runat="server"></asp:TextBox>
        <br />
        <br />
        新增用户手机号：<asp:TextBox ID ="newuserphonenumber" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Button ID ="subUser" runat="server" Text="保存" OnClick="subUser_Click" />

        <asp:LinkButton ID="return" runat="server" Text="返回上一级" PostBackUrl="~/Administrator/MaUser.aspx"></asp:LinkButton>


    </div>
    </form>
</body>
</html>
