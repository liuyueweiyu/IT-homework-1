using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class toMaUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = "select * from UserList";

        classlogin mylogin = new classlogin();
        DataTable dt = new DataTable();

        dt = mylogin.JudgeIor(sql);

        RptMaUser.DataSource = dt;

        RptMaUser.DataBind();

        DataBindToRepeater(1);
    }

    void DataBindToRepeater(int currentPage)
    {
        classlogin myList = new classlogin();

        string sql = "select * from User";

        DataTable dt = new DataTable();

        dt = myList.JudgeIor(sql);

        PagedDataSource pds = new PagedDataSource();

        pds.AllowPaging = true;

        pds.PageSize = 5;

        pds.DataSource = dt.DefaultView;

        lbTotal.Text = pds.PageCount.ToString();

        pds.CurrentPageIndex = currentPage - 1;

        RptMaUser.DataSource = pds;

        RptMaUser.DataBind();

    }
    protected void RptMaUser_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        classlogin myMaUser = new classlogin();

        if (e.CommandName == "Delete")
        {
            string id = e.CommandArgument.ToString();

            string sql = "delete from UserList where userid='" + id + "'";

            int flag = myMaUser.DataSQL(sql);

            if (flag == 1)
                Response.Write("<script>alert('删除成功！');location='MaUser.aspx'</script>");


        }

        if (e.CommandName == "Frozen")
        {
            string id = e.CommandArgument.ToString();

            string sql = "update UserList set frozen = '0' where userid='" + id + "'";

            int flag = myMaUser.DataSQL(sql);

            if (flag == 1)
                Response.Write("<script>alert('冻结账户成功！');location='MaUser.aspx'</script>");


        }

        if (e.CommandName == "Relieve")
        {
            string id = e.CommandArgument.ToString();

            string sql = "update UserList set frozen = '1' where userid='" + id + "'";

            int flag = myMaUser.DataSQL(sql);

            if (flag == 1)
                Response.Write("<script>alert('解除账户冻结成功！');location='MaUser.aspx'</script>");


        }

        if (e.CommandName == "Resetting")
        {
            string id = e.CommandArgument.ToString();

            string sql = "update UserList set username = null,userphonenumber = null,useremail = null,userpassword = null where userid='" + id + "'";

            int flag = myMaUser.DataSQL(sql);

            if (flag == 1)
                Response.Write("<script>alert('重置成功！');location='MaUser.aspx'</script>");


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
