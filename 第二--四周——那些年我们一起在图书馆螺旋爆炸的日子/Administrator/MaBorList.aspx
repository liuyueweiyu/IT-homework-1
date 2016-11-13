<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MaBorList.aspx.cs" Inherits="toBorList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                <asp:Repeater ID="RptMaBorList" runat="server" OnItemCommand="RptMaBook_ItemCommand">
                    <HeaderTemplate>
                        <table>
                            <tr>
                                <th>借阅编号</th>
                                <th>书籍编号</th>
                                <th>借阅书名</th>
                                <th>借阅用户</th>
                                <th>借阅时间</th>
                                <th>预计归还时间</th>
                                <th>编辑</th>
                                <th>删除</th>
                            </tr>
                    </HeaderTemplate>

                    <ItemTemplate>
                        <tr>
                             <td><%# Eval("serialnumber")%></td>
                             <td><%# Eval("br_bookid")%></td>
                             <td><%# Eval("br_bookname")%></td>
                             <td><%# Eval("br_userid")%></td>
                             <td><%# Eval("br_time")%></td>
                             <td><%# Eval("re_time") %></td>
                             <td><asp:LinkButton ID="lbtReturn" runat="server" Text="编辑" PostBackUrl='<%#"EditorBorList.aspx?serialnumber="+Eval("serialnumber") %>'></asp:LinkButton>
                             <td><asp:LinkButton ID="lbtRenew" runat="server" Text="删除" CommandName="Delete" CommandArgument='<%#Eval("serialnumber") %>'></asp:LinkButton>
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
        <asp:LinkButton ID="add" runat="server" Text="添加记录" PostBackUrl="~/Administrator/AddBorList.aspx"></asp:LinkButton>
                <br />
                <br />
        <asp:LinkButton ID="return" runat="server" Text="返回上一级" PostBackUrl="~/Administrator/Manage.aspx"></asp:LinkButton>
    </div>
    </form>
</body>
</html>
