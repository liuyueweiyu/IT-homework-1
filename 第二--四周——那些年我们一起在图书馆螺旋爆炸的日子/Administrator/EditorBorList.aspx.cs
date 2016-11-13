using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator_EditorBorList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            classlogin myEditor = new classlogin();

            string id = Request.QueryString["serialnumber"];

            string sql = "select * from BorrowList where serialnumber='" + id + "'";
            DataTable dt = new DataTable();

            dt = myEditor.JudgeIor(sql);

            string serialnumber = dt.Rows[0].ToString();
            string br_bookid = dt.Rows[0][1].ToString();
            string br_bookname = dt.Rows[0][2].ToString();
            string br_userid = dt.Rows[0][3].ToString();
            string br_time = dt.Rows[0][4].ToString();
            string re_time = dt.Rows[0][5].ToString();

            string m = "0";

            snumber.Text = id;
            bookid.Text = br_bookid;
            bookname.Text = br_bookname;
            userid.Text = br_userid;
            brtime.Text = br_time;
            retime.Text = re_time;
            days.Text = m;
        }
    }

    protected void changebook_Click(object sender, EventArgs e)
    {
        classlogin myEditor = new classlogin();

        string id = Request.QueryString["serialnumber"];


        string bid = bookid.Text;
        string uid = userid.Text;
        string Day = days.Text;

        string sql2 = "select * from UserList where userid='" + uid + "'";
        string sql3 = "select * from Book where bookid='" + bid + "'";

        int i, loch = 1;
        for (i = 0; i < Day.Length; i++)
        {
            byte asc = Convert.ToByte(Day[i]);
            if (asc < 48 || asc > 57) loch = 0;
        }


        int loch2 = myEditor.JudgeAcc(sql2);
        int loch3 = myEditor.JudgeAcc(sql3);

        if (loch3 == 0)
            Response.Write("<script>alert('书本编号不存在！')</script>");
        else if (loch2 == 0)
            Response.Write("<script>alert('用户不存在！')</script>");
        else if(loch == 0)
            Response.Write("<script>alert('输入时间不合法！')</script>");
        else
        {
            string sql1 = "select * from BorrowList where serialnumber='" + id + "'";

            double day = Convert.ToDouble(Day);
            DataTable dt = new DataTable();
            dt = myEditor.JudgeIor(sql1);
            string retime = dt.Rows[0][5].ToString();
            DateTime re_time = Convert.ToDateTime(retime);
            DateTime newretime = re_time.AddDays(day);
            string prebid = dt.Rows[0][1].ToString();

            string BookSQL1 = "select * from Book where bookid='" + prebid + "'";
            dt = myEditor.JudgeIor(BookSQL1);
            string pre_counts = dt.Rows[0][3].ToString();
            int pre_count = Convert.ToInt16(pre_counts);
            pre_counts = Convert.ToString(pre_count + 1);

            string BookSQL2 = "select * from Book where bookid='" + bid + "'";
            dt = myEditor.JudgeIor(BookSQL2);
            string counts = dt.Rows[0][3].ToString();
            int count = Convert.ToInt16(counts);
            counts = Convert.ToString(count - 1);

            dt = myEditor.JudgeIor(sql3);
            string newbookname = dt.Rows[0][1].ToString();

            string sql = "update BorrowList set br_bookid='"+bid+"',br_bookname = '" + newbookname + "',br_userid='"+uid+"',re_time='"+newretime+"' where serialnumber = " + id + "";
            string countsql1 = "update Book set count='" + pre_counts + "' where bookid='" + prebid + "'";
            string countsql2 = "update Book set count='" + counts + "' where bookid='" + bid + "'";
            int flag = myEditor.DataSQL(sql);
            int flagcount1 = myEditor.DataSQL(countsql1);
            int flagcount2 = myEditor.DataSQL(countsql2);


            if(flag==1&&flagcount1==1&&flagcount2==1)
                Response.Write("<script>alert('修改成功！')，location='Administrator/MaBorList.aspx'</script>");
            else
                Response.Write("<script>alert('修改失败！')</script>");
        }
    }
}