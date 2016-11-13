using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_JudgeBorrow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void btnYes_Click(object sender, EventArgs e)
    {
        classlogin myBook = new classlogin();

        string uid = Session["userid"].ToString();

        string sql = "select * from UserList ";

        DataTable dt = new DataTable();

        dt = myBook.JudgeIor(sql);

        string forzen = dt.Rows[0][5].ToString();
        int sum = Convert.ToInt16(dt.Rows[0][6].ToString());


        if (String.Compare(forzen, "1") != 0)
            Response.Write("<script>alert('该用户已经被管理员冻结不能借阅书籍！')</script>");
        else if(sum>=3)
            Response.Write("<script>alert('借阅书籍数量不能超过3！');location='BookList.aspx'</script>");
        else
        {


            int bid = Convert.ToInt32(Request.QueryString["bookid"]);

            string sql1 = "select * from Book where bookid='" + bid + "'";


            dt = myBook.JudgeIor(sql1);

            string counts = dt.Rows[0][3].ToString();

            int count = Convert.ToInt32(counts);
            if (count == 0)
                Response.Write("<script>alert('书本数量为0，不能借阅！')</script>");
            else
            {
                count = count - 1;
                counts = Convert.ToString(count);


                string sql2 = "update Book set count = '" + counts + "'where bookid = '" + bid + "'";

                int flag = myBook.DataSQL(sql2);

                string newsum = Convert.ToString(sum + 1);
                string sql00 = "update UserList set sum = '" + newsum + "'where userid = '" + uid + "'";
                int flag00 = myBook.DataSQL(sql00);


                string sql3 = "select * from Book where bookid='" + bid + "'";
                dt = myBook.JudgeIor(sql3);
                string bookname = dt.Rows[0][1].ToString();
                string sql4 = "select * from UserList where userid='" + uid + "'";
                dt = myBook.JudgeIor(sql4);
                string username = dt.Rows[0][2].ToString();

                DateTime now = System.DateTime.Now;

                DateTime returntime = System.DateTime.Now.AddDays(+30);

                string sql6 = "insert into BorrowList (br_bookid,br_bookname,br_userid,br_time,re_time) values('" + bid + "','" + bookname + "','" + uid + "','" + now + "','"+ returntime +"')";
                int flag3 = myBook.DataSQL(sql6);
                if (flag == 1 && flag3 == 1&&flag00==0)
                    Response.Write("<script>alert('借阅成功！');location='BookList.aspx'</script>");
            }


        }
    }
}