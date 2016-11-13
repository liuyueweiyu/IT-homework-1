using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class toBorList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = "select * from BorrowList";

        classlogin myBorList = new classlogin();
        DataTable dt = new DataTable();

        dt = myBorList.JudgeIor(sql);

        RptMaBorList.DataSource = dt;

        RptMaBorList.DataBind();

        DataBindToRepeater(1);
    }

    void DataBindToRepeater(int currentPage)
    {
        classlogin myList = new classlogin();

        string sql = "select * from BorrowList";

        DataTable dt = new DataTable();

        dt = myList.JudgeIor(sql);

        PagedDataSource pds = new PagedDataSource();

        pds.AllowPaging = true;

        pds.PageSize = 5;

        pds.DataSource = dt.DefaultView;

        lbTotal.Text = pds.PageCount.ToString();

        pds.CurrentPageIndex = currentPage - 1;

        RptMaBorList.DataSource = pds;

        RptMaBorList.DataBind();

    }

    protected void RptMaBook_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        classlogin myMaBorList = new classlogin();

        if (e.CommandName == "Delete")
        {
            int id = Convert.ToInt32(e.CommandArgument.ToString());

            string sql1 = "select * from BorrowList where serialnumber='" + id + "'";

            DataTable dt = new DataTable();

            dt = myMaBorList.JudgeIor(sql1);

            string bookid = dt.Rows[0][1].ToString();

            string userid = dt.Rows[0][3].ToString();

            string sql2 = "select * from Book where bookid='" + bookid + "'";

            dt = myMaBorList.JudgeIor(sql2);

            string count = dt.Rows[0][3].ToString();

            count = Convert.ToString(Convert.ToInt16(count)+1);

            string sql3 = "select * from UserList where userid='" + userid + "'";

            dt = myMaBorList.JudgeIor(sql3);

            string sum = dt.Rows[0][6].ToString();

            sum = Convert.ToString(Convert.ToInt32(sum) - 1);

            string sql4 = "update Book set count = '" + count + "'where bookid = '" + bookid + "'";

            string sql5 = "update UserList set sum = '" + sum + "'where userid = '" + userid + "'";

            int flag00 = myMaBorList.DataSQL(sql4);
            int flag01 = myMaBorList.DataSQL(sql5);


            string sql = "delete from BorrowList where serialnumber='" + id + "'";



            int flag = myMaBorList.DataSQL(sql);

            if (flag == 1&&flag00==1&&flag01==1)
                Response.Write("<script>alert('删除成功！');location='MaBorList.aspx'</script>");


        }

    }

    protected void btnUp_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt16(lbNow.Text) == 1)
            Response.Write("<script>alert('已在首页！')</script>");
        else
        {
            lbNow.Text = Convert.ToString(Convert.ToInt32(lbNow.Text) - 1);
            DataBindToRepeater(Convert.ToInt32(lbNow.Text));
        }
    }

    protected void btnDrow_Click(object sender, EventArgs e)
    {

        if (lbTotal.Text != lbNow.Text)
        {
            lbNow.Text = Convert.ToString(Convert.ToInt32(lbNow.Text) + 1);
            DataBindToRepeater(Convert.ToInt32(lbNow.Text));
        }
        else
            Response.Write("<script>alert('已在尾页！')</script>");
    }

    protected void btnFirst_Click(object sender, EventArgs e)
    {
        DataBindToRepeater(1);
        lbNow.Text = "1";
    }

    protected void btnLast_Click(object sender, EventArgs e)
    {
        DataBindToRepeater(Convert.ToInt32(lbTotal.Text));
        lbNow.Text = lbTotal.Text;
    }

    protected void btnJump_Click(object sender, EventArgs e)
    {
        string number = txtJump.Text;
        int i, flag = 1;
        for (i = 0; i < number.Length; i++)
        {
            byte asc = Convert.ToByte(number[i]);
            if (asc < 48 || asc > 57) flag = 0;
        }

        if (flag == 0)
            Response.Write("<script>alert('请正确输入数字！')</script>");
        else
        {
            int num = Convert.ToInt32(number);
            int max = Convert.ToInt32(lbTotal.Text);
            if (num < 1 || num > max)
                Response.Write("<script>alert('请正确输入数字！')</script>");
            else
            {
                DataBindToRepeater(num);
                lbNow.Text = number;
            }
        }

    }
}