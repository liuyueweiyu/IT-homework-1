<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MaUser.aspx.cs" Inherits="toMaUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                 <asp:Repeater ID="RptMaUser" runat="server" OnItemCommand="RptMaUser_ItemCommand">
            <HeaderTemplate>
                <table>
                    <tr>
                        <th>用户账号</th>
                        <th>用户名</th>
                        <th>用户邮箱</th>
                        <th>用户手机号码</th>
                        <th>借阅书本数量</th>
                        <th>用户状态</th>
                        <th>删除</th>
                        <th>重置账户信息</th>
                        <th>冻结账户</th>
                        <th>解除账户冻结</th>
                    </tr>
                

            </HeaderTemplate>

            <ItemTemplate>
                <tr>
                    <td><%# Eval("userid")%></td>
                    <td><%# Eval("username")%></td>
                    <td><%# Eval("useremail")%></td>
                    <td><%# Eval("userphonenumber")%></td>
                    <td><%# Eval("sum")%></td>
                    <td><%# Eval("frozen") %></td>
                    <td><asp:LinkButton ID="lbtDelete" runat="server" Text="删除" CommandName="Delete" CommandArgument='<%#Eval("userid") %>' ></asp:LinkButton></td>
                    <td><asp:LinkButton ID="lbtResetting" runat="server" Text="重置" CommandName="Resetting" CommandArgument='<%#Eval("userid") %>'></asp:LinkButton></td>
                    <td><asp:LinkButton ID="LinkFrozen" runat="server" Text="冻结" CommandName="Frozen" CommandArgument='<%#Eval("userid") %>' ></asp:LinkButton></td>
                    <td><asp:LinkButton ID="LinkRelieve" runat="server" Text="解除" CommandName="Relieve" CommandArgument='<%#Eval("userid") %>' ></asp:LinkButton></td>

                </tr>

            </ItemTemplate>

            <FooterTemplate>
                </table>

            </FooterTemplate>

             </asp:Repeater>
                
                 <br />
                
            <asp:Button ID="btnUp" runat="server" Text="上一页" OnClick="btnUp_Click" />
            &nbsp;<asp:Button ID="btnDrow" runat="server" Text="下一页" OnClick="btnDrow_Click" />
            &nbsp;<asp:Button ID="btnFirst" runat="server" Text="首页" OnClick="btnFirst_Click" />
            &nbsp;<asp:Button ID="btnLast" runat="server" Text="尾页" OnClick="btnLast_Click" />
            &nbsp;页次：<asp:Label ID="lbNow" runat="server" Text="1"></asp:Label>
            /<asp:Label ID="lbTotal" runat="server" Text="1"></asp:Label>

            &nbsp;

            转<asp:TextBox ID="txtJump" Text="1" runat="server" Width="23px"></asp:TextBox>
            &nbsp;<asp:Button ID="btnJump" runat="server" Text="Go" OnClick="btnJump_Click" />


                 <br />
                 <br />


        <asp:LinkButton ID="AddUser" runat="server" Text="增加用户" PostBackUrl="~/Administrator/AddUser.aspx"></asp:LinkButton>
                 <br />
                 <br />
        <asp:LinkButton ID="return" runat="server" Text="返回上一级" PostBackUrl="~/Administrator/Manage.aspx"></asp:LinkButton>

    </div>
    </form>
    <p>
        (用户状态1为正常0为冻结状态)</p>
</body>


</html>
