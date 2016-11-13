using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_JudgeRenew : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Yes_Click(object sender, EventArgs e)
    {
        classlogin myRenew = new classlogin();

        string uid = Session["userid"].ToString();
        int sid = Convert.ToInt32(Request.QueryString["serialnumber"]);

        string sql = "select * from UserList where userid ='" + uid + "'";

        DataTable dt = new DataTable();

        dt = myRenew.JudgeIor(sql);

        string forzen = dt.Rows[0][5].ToString();

        if (String.Compare(forzen, "1") != 0)
            Response.Write("<script>alert('该用户已经被管理员冻结不能续借图书！')</script>");
        else
        {

            string sql1 = "select * from BorrowList where serialnumber = '" + sid + "'";

            dt = myRenew.JudgeIor(sql1);

            string br_time = dt.Rows[0][4].ToString();
            string re_time = dt.Rows[0][5].ToString();

            DateTime brtime = Convert.ToDateTime(br_time);
            DateTime retime = Convert.ToDateTime(re_time);
            DateTime now = DateTime.Now;
            DateTime deadline = brtime.AddDays(+60);
            retime = retime.AddDays(+30);



            if (DateTime.Compare(deadline, retime) < 0)
                Response.Write("<script>alert('只能续借一次！');location='JudgeRenew.aspx'</script>");
            else
            {
                string sql3 = "update BorrowList set re_time = '"+ retime +"' where serialnumber='" + sid + "'";
                dt = myRenew.JudgeIor(sql3);
                Response.Write("<script>alert('续借成功！');location='JudgeRenew.aspx'</script>");
            }
        }

    }
}
