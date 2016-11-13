using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator_AddUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void subUser_Click(object sender, EventArgs e)
    {
        classlogin mysubuser = new classlogin();

        string newid = newuserid.Text;
        string newname = newusername.Text;
        string newpwd = newuserpwd.Text;
        string newemail = newuseremail.Text;
        string newphnum = newuserphonenumber.Text;

        string sql2 = "insert into UserList (userid,username,userpassword,useremail,userphonenumber) values('" + newid + "','" + newname + "','" + newpwd + "','" + newemail + "','" + newphnum + "')";
        string sql1 = "select * from UserList where userid='" + newid + "'";

        int loch1 = mysubuser.JudgeAcc(sql1);


        string sql00 = "select * from UserList where userphonenumber = '" + newphnum + "'";
        int flag00 = mysubuser.JudgeAcc(sql00);
        string sql01 = "select * from UserList where useremail = '" + newemail + "'";
        int flag01 = mysubuser.JudgeAcc(sql01);


        if (newid.Length == 0)
            Response.Write("<script>alert('用户账号不能为空！')</script>");
        else if (newname.Length == 0)
            Response.Write("<script>alert('用户名不能为空！')</script>");
        else if (newpwd.Length == 0)
            Response.Write("<script>alert('密码不能为空！')</script>");
        else if (loch1 != 0)
            Response.Write("<script>alert('用户已存在！')</script>");
        else if (flag00 != 0)
            Response.Write("<script>alert('手机号码已被绑定！')</script>");
        else if (flag01 != 0)
            Response.Write("<script>alert('邮箱已被绑定！')</script>");
        else
        {
            int loch2 = mysubuser.DataSQL(sql2);
            if (loch2 == 1)
                Response.Write("<script>alert('添加成功！');location='MaUser.aspx'</script>");
            else
                Response.Write("<script>alert('添加失败！');location='AddUser.aspx'</script>");
        }
    }
}