using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_JudgeReturn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Yes_Click(object sender, EventArgs e)
    {
        classlogin myReturn = new classlogin();

        string uid = Session["userid"].ToString();
        int sid = Convert.ToInt32(Request.QueryString["serialnumber"]);

        //string sql = "select * from BorrowList where serialnumber='" + sid + "'";
        string sql = "select * from UserList where userid='" + uid + "'";

        DataTable dt = new DataTable();

        dt = myReturn.JudgeIor(sql);

        string forzen = dt.Rows[0][5].ToString();
        string sums = dt.Rows[0][6].ToString();

        if (String.Compare(forzen, "1") != 0)
            Response.Write("<script>alert('该用户已经被管理员冻结不能借阅书籍！')</script>");
        else
        {

            string sql1 = "select * from BorrowList where serialnumber='" + sid + "'";


            dt = myReturn.JudgeIor(sql1);

            string bid = dt.Rows[0][1].ToString();

            string sql12 = "select * from Book where bookid='" + bid + "'";

            dt = myReturn.JudgeIor(sql12);

            string counts = dt.Rows[0][3].ToString();

            int count = Convert.ToInt16(counts);

            count = count + 1;
            counts = Convert.ToString(count);


            string sql2 = "update Book set count = '" + counts + "'where bookid = " + bid + "";

            int flag = myReturn.DataSQL(sql2);


            string newsum = Convert.ToString(Convert.ToInt16(sums) - 1);
            string sql00 = "update UserList set sum = '" + newsum + "'where userid = '" + uid + "'";
            int flag00 = myReturn.DataSQL(sql00);



            string sql3 = "delete from BorrowList where serialnumber='" + sid + "'";
            int flag3 = myReturn.DataSQL(sql3);
            if (flag == 1 && flag3 == 1 && flag00 ==1)
                Response.Write("<script>alert('归还成功！');location='BookList.aspx'</script>");



        }
    }
}