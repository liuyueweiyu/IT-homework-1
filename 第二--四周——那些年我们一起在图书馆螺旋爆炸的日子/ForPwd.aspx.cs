using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ForPwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lbtSub_Click(object sender, EventArgs e)
    {
        classlogin mySub = new classlogin();

        string uid = id.Text;
        string phone = phonenumber.Text;
        string email = emails.Text;

        string sql1 = "select * from UserList where userid='" + uid + "'and userphonenumber='" + phone + "'";
        string sql2 = "select * from UserList where userid='" + uid + "'and useremail='" + email + "'";
        int count1 = (mySub.JudgeIor(sql1)).Rows.Count;
        int count2 = (mySub.JudgeIor(sql2)).Rows.Count;

        if (count1 > 0 && count2 > 0)
        {
            Response.Write("<script>alert('信息认证成功！'),location='renewPwd.aspx'</script>");
            Session["userid"] = uid;
        }
        else
            Response.Write("<script>alert('信息认证失败！')</script>");

    }
}