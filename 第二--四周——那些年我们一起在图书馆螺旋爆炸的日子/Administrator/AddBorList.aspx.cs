using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator_AddBorList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void subBorList_Click(object sender, EventArgs e)
    {
        classlogin mysubbook = new classlogin();

        string newbookids = newbookid.Text;
        string newuserids = newuserid.Text;

        DateTime now = DateTime.Now;
        DateTime returntime = DateTime.Now.AddDays(+30);

        string sql2 = "select * from UserList where userid='" + newuserids + "'";
        string sql3 = "select * from Book where bookid='" + newbookids + "'";


        int loch2 = mysubbook.JudgeAcc(sql2);
        int loch3 = mysubbook.JudgeAcc(sql3);

        if (loch3 == 0)
            Response.Write("<script>alert('书本编号不存在！')</script>");
        else if (loch2 == 0)
            Response.Write("<script>alert('用户不存在！')</script>");
        else 
        {
            DataTable dt = new DataTable();

            dt = mysubbook.JudgeIor(sql3);
            string count = dt.Rows[0][3].ToString();
            if (String.Compare(count,"0")==0)
                Response.Write("<script>alert('书本数量为0不能借阅！')</script>");
            else
            {
                string bookname = dt.Rows[0][1].ToString();


                string sql = "insert into BorrowList (br_bookid,br_userid,br_bookname,br_time,re_time) values('" + newbookids + "','" + newuserids + "','" + bookname + "','" + now + "','" + returntime + "')";

                int loch = mysubbook.DataSQL(sql);
                if (loch == 1)
                    Response.Write("<script>alert('添加成功！');location='MaBorList.aspx'</script>");
                else
                    Response.Write("<script>alert('添加失败！');location='AddBorList.aspx'</script>");
            }

   
        }
    }
}