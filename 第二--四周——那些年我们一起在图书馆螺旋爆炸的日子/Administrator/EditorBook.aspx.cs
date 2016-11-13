using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator_EditorBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            classlogin myaddbook = new classlogin();

            int id = Convert.ToInt32(Request.QueryString["bookid"]);

            string sql = "select * from Book where bookid='" + id + "'";
            DataTable dt = new DataTable();

            dt = myaddbook.JudgeIor(sql);

            string names = dt.Rows[0][1].ToString();
            string authors = dt.Rows[0][2].ToString();
            string counts = dt.Rows[0][3].ToString();

            bookname.Text = names;
            author.Text = authors;
            count.Text = counts;
        }
    }

    public void changebook_Click(object sender, EventArgs e)
    {
        classlogin myEditor = new classlogin();
        int newid = Convert.ToInt32(Request.QueryString["bookid"]);

        string chbookname = bookname.Text;
        string chauthor = author.Text;
        string chcount = count.Text;

        string sql1 = "update Book set bookname = '" + chbookname + "' where bookid = " + newid + "";
        string sql2 = "update Book set author = '" + chauthor + "' where bookid = " + newid + "";
        string sql3 = "update Book set count = '" + chcount + "' where bookid = "+ newid +"";

        int i, loch = 1;
        for (i = 0; i < chcount.Length; i++)
        {
            byte asc = Convert.ToByte(chcount[i]);
            if (asc < 48 || asc > 57) loch = 0;
        }

        if (chbookname.Length == 0)
            Response.Write("<script>alert('书名不能为空！')</script>");
        else if (chauthor.Length == 0)
            Response.Write("<script>alert('作者不能为空！')</script>");
        else if (chcount.Length == 0)
            Response.Write("<script>alert('数量不能为空！')</script>");
        else if (loch == 0 )
            Response.Write("<script>alert('输入数量不合法！')</script>");
        else
        {
            int loch1 = myEditor.DataSQL(sql1);
            int loch2 = myEditor.DataSQL(sql2);
            int loch3 = myEditor.DataSQL(sql3);

            if (loch1 == 1 && loch2 == 1 && loch3 == 1)
                Response.Write("<script>alert('修改成功！');location='MaBook.aspx'</script>");
            else
                Response.Write("<script>alert('修改失败！');location='EditorBook.aspx'</script>");

        }
    }


}