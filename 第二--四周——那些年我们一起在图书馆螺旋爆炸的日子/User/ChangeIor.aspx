<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangeIor.aspx.cs" Inherits="User_ChangeIor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    账号:<asp:Label ID="id" runat="server"></asp:Label>
        <br />
        <br />
        ------------------------------------
        <br />
        <br />
        修改用户名<br />
        <br />
&nbsp;&nbsp;&nbsp;
        当前用户名：<asp:Label ID="preName" runat="server"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        修改用户名：<asp:TextBox ID="newName" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="changeName" runat="server" Text="确认提交" OnClick="changeName_Click" />
        <br />
        <br />
        ------------------------------------
        <br />
        <br />
&nbsp;修改密码
         
        <br />
         
        <br />
&nbsp;&nbsp;&nbsp; 当前密码:<asp:TextBox ID ="prePwd" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        修改密码:<asp:TextBox ID ="newPwd" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID ="changePwd" runat="server" Text="确认修改" OnClick="changePwd_Click" />
        <br />
        <br />
        ------------------------------------
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    修改邮箱
         
         
        <br />
         
        <br />
&nbsp;&nbsp;&nbsp; 原始邮箱:<asp:Label ID ="preEmail" runat="server"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        修改邮箱：<asp:TextBox ID="newEmail" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="changeEmail" runat="server" Text="确认修改" OnClick="changeEmail_Click" />



        <br />
        ------------------------------------
        <br />
        <br />
        修改手机号码
         
        <br />
        <br />
&nbsp;&nbsp;&nbsp; 原始手机号码：<asp:Label ID ="prePhonum" runat="server"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        修改手机号码：<asp:TextBox ID="newPhonum" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="changePhonum" runat="server" Text="确认修改" OnClick="changePhonum_Click" />

                <br />
        <br />

                ------------------------------------<br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="toUser" runat="server" Text="返回上一级" PostBackUrl="~/User/User.aspx"></asp:LinkButton>


    </div>
    </form>
</body>
</html>
