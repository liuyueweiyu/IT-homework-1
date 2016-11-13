<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MaBook.aspx.cs" Inherits="MaBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
             <asp:Repeater ID="RptMaBook" runat="server" OnItemCommand="RptMaBook_ItemCommand">
            <HeaderTemplate>
                <table>
                    <tr>
                        <th>编号</th>
                        <th>书名</th>
                        <th>作者</th>
                        <th>数量</th>
                        <th>编辑</th>
                        <th>删除</th>
                    </tr>
                

            </HeaderTemplate>

            <ItemTemplate>
                <tr>
                    <td><%# Eval("bookid")%></td>
                    <td><%# Eval("bookname")%></td>
                    <td><%# Eval("author")%></td>
                    <td><%# Eval("count")%></td>
                     <td><asp:LinkButton ID="lbtDelete" runat="server" Text="删除" CommandName="Delete" CommandArgument='<%#Eval("bookid") %>' ></asp:LinkButton></td>
                    <td><asp:LinkButton ID="lbtEditor" runat="server" Text="修改" PostBackUrl='<%#"EditorBook.aspx?bookid="+Eval("bookid") %>'></asp:LinkButton></td>
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

        <asp:LinkButton ID="AddBook" runat="server" Text="增加图书" PostBackUrl="~/Administrator/AddBook.aspx"></asp:LinkButton>
             <br />
             <br />
        <asp:LinkButton ID="return" runat="server" Text="返回上一级" PostBackUrl="~/Administrator/Manage.aspx"></asp:LinkButton>

    </div>
    </form>
</body>
</html>
