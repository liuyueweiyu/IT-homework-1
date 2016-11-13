using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class renewPwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void sub_Click(object sender, EventArgs e)
    {
        classlogin myPwd = new classlogin();
        string id = Session["userid"].ToString();
        string pwd = password.Text;
        string repwd = repassword.Text;
        if(String.Compare(pwd,repwd)!=0)
            Response.Write("<script>alert('前后两次密码不一样！')</script>");
        else if(pwd.Length<6)
            Response.Write("<script>alert('密码请大于6位数！')</script>");
        else
        {
            string sql = "update UserList set userpassword ='" + pwd + "' where userid = '" + id + "' ";
            int flag = myPwd.DataSQL(sql);
            if(flag==1)
                Response.Write("<script>alert('重置成功！'),location='Login.aspx'</script>");
            else
                Response.Write("<script>alert('重置失败！')</script>");
        }
    }
}