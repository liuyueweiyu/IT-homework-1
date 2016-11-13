<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Information.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        欢迎登陆图书馆管理系统,请完善个人信息：<br />
        <br />
        学号：<asp:Label ID="id" runat="server"></asp:Label>
        <br />
        <br />
        姓名：<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <br />
        手机号：<asp:TextBox ID="txtPho" runat="server"></asp:TextBox>
         
        <br />
        <br />
        邮箱：<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

        <br />
        <br />

        <asp:Button ID ="resubmit" runat="server" Text="提交" OnClick="btnSub_Click" />


    </div>
    </form>
</body>
</html>
