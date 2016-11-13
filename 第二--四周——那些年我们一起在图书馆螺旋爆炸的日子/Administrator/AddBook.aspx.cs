using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator_AddBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void subBook_Click(object sender, EventArgs e)
    {
        classlogin mysubbook = new classlogin();
       
        string newname = newbookname.Text;
        string newauthors = newauthor.Text;
        string newcounts = newcount.Text;

        string sql2 = "insert into Book (bookname,author,count) values('" + newname + "','" + newauthors + "','" + newcounts + "')";

        int i, loch = 1;
        for (i = 0; i < newcounts.Length; i++)
        {
            byte asc = Convert.ToByte(newcounts[i]);
            if (asc < 48 || asc > 57) loch = 0;
        }

        string sql00 = "select * from Book where bookname = '" + newname + "'";
        int flag00 = mysubbook.JudgeAcc(sql00);


        int loch2 = mysubbook.DataSQL(sql2);
        if (newname.Length == 0)
            Response.Write("<script>alert('书名不能为空！')</script>");
        else if (newauthors.Length == 0)
            Response.Write("<script>alert('作者不能为空！')</script>");
        else if (newcounts.Length == 0)
            Response.Write("<script>alert('数量不能为空！')</script>");
        else if (loch == 0)
            Response.Write("<script>alert('输入数量不合法！')</script>");
        else if (flag00 != 0)
            Response.Write("<script>alert('该书已存在！')</script>");
        else if (loch2 == 1)
            Response.Write("<script>alert('添加成功！');location='MaBook.aspx'</script>");
        else
            Response.Write("<script>alert('添加失败！');location='AddBook.aspx'</script>");
    }
}