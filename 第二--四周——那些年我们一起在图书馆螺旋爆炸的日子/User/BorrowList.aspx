<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BorrowList.aspx.cs" Inherits="User_BorrowList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                <asp:Repeater ID="rptBorrowList" runat="server">
                    <HeaderTemplate>
                        <table>
                            <tr>
                                <th>借阅编号</th>
                                <th>书籍编号</th>
                                <th>借阅书名</th>
                                <th>借阅时间</th>
                                <th>预计归还时间</th>
                                <th>归还</th>
                                <th>续借</th>
                            </tr>
                    </HeaderTemplate>

                    <ItemTemplate>
                        <tr>
                             <td><%# Eval("serialnumber")%></td>
                             <td><%# Eval("br_bookid")%></td>
                             <td><%# Eval("br_bookname")%></td>
                             <td><%# Eval("br_time")%></td>
                             <td><%# Eval("re_time") %></td>
                             <td><asp:LinkButton ID="lbtReturn" runat="server" Text="归还" PostBackUrl='<%#"JudgeReturn.aspx?serialnumber="+Eval("serialnumber") %>'></asp:LinkButton></td></td>
                             <td><asp:LinkButton ID="lbtRenew" runat="server" Text="续借" PostBackUrl='<%#"JudgeRenew.aspx?serialnumber="+Eval("serialnumber") %>'></asp:LinkButton></td></td>
                        </tr>

                    </ItemTemplate>

                    <FooterTemplate>
                        </table>

                    </FooterTemplate>



                </asp:Repeater>

                <br />

        <asp:LinkButton ID="return" runat="server" PostBackUrl="~/User/User.aspx" Text="返回上一级"></asp:LinkButton>
    </div>
    </form>
</body>
</html>
