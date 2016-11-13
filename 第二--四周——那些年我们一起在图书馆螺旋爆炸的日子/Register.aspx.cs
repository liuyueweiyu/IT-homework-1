using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string str = @"server=LAPTOP-36VBSINT;Integrated Security=SSPI;database=Library;";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        classlogin mySubmit = new classlogin();

            string id = newid.Text;
            string newPwd = password.Text;
            string renewPwd = repassword.Text;
            string sql1 = "select * from UserList where userid = '" + id + "'";

            int loch1 = classlogin.JudgePwd(newPwd, renewPwd);
            int loch2 = mySubmit.JudgeAcc(sql1);
            int len = classlogin.PwdLen(newPwd);

            if(loch2!=0)
                Response.Write("<script>alert('账号已存在！')</script>");
            else if(id.Length==0)
                Response.Write("<script>alert('用户名不能为空！')</script>");
            else if (len==0)
                Response.Write("<script>alert('密码不能为空！')</script>");
            else if (loch1 == -1)
                Response.Write("<script>alert('前后两次密码不一样！')</script>");
            else if (len < 6)
                Response.Write("<script>alert('密码长度请大于等于6位！')</script>");
            else
            {
                string sql2 = "insert into UserList (userid,userpassword) values('" + id + "','" + newPwd + "')";
                int loch3 = mySubmit.DataSQL(sql2);
                if(loch3==1)
                    Response.Write("<script>alert('注册成功！');location='Login.aspx'</script>");
            }




    }
}