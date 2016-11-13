using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Return : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void btnReturn_Click(object sender, EventArgs e)
    {
        classlogin myReturn = new classlogin();

        string sids = serialnumber.Text;
        string bids = bookid.Text;

        int serial = Convert.ToInt32(sids);
        int book = Convert.ToInt32(bids);

        string sql1 = "select * from BorrowList where serialnumber='" + serial + "'";
        string sql2 = "select * from BorrowList where br_bookid='" + book + "'";
        string sql3 = "select * from BorrowList where serialnumber='" + serial + "'and br_bookid='" + book + "'";


        int flag1 = myReturn.JudgeAcc(sql1);
        int flag2 = myReturn.JudgeAcc(sql2);
        DataTable dt = new DataTable();
        dt = myReturn.JudgeIor(sql3);
        int flag3 = dt.Rows.Count;

        if (flag1 == 0)
            Response.Write("<script>alert('借阅编码不存在！')</script>");
        else if (flag2 == 0)
            Response.Write("<script>alert('用户不存在或未曾借书！')</script>");
        else if (flag3 > 0)
        {
            string sql4 = "select * from Book where bookid='" + book + "'";

            dt = myReturn.JudgeIor(sql4);

            string counts = dt.Rows[0][3].ToString();

            int count = Convert.ToInt32(counts);

            count = count + 1;

            counts = Convert.ToString(count);

            string sql5 = "update Book set count = '" + counts + "'where bookid = " + book + "";
            string sql6 = "delete from BorrowList where serialnumber='" + sids + "'";

            int flag = myReturn.DataSQL(sql5);
            int flagx = myReturn.DataSQL(sql6);

            if (flag == 1&&flagx==1)
                Response.Write("<script>alert('归还成功！')，location='Register.aspx'</script>");
        }
        else
            Response.Write("<script>alert('归还失败！')</script>");



    }
}