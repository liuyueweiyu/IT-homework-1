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
    protected void Page_Load(object sender, EventArgs e)
    {
        classlogin myinformation = new classlogin();

        string  idnumber = Session["userid"].ToString();
        id.Text = idnumber;
    }

    classlogin myinformation = new classlogin();
    public void btnSub_Click(object sender, EventArgs e)
    {
        string uid = Session["userid"].ToString();
        string username = txtName.Text;
        string phonenumber = txtPho.Text;
        string email = txtEmail.Text;

        string sql = "update UserList set username = '" + username + "',userphonenumber = '" + phonenumber + "',useremail='" + email + "' where userid = '" + uid + "'"; 


        int loch1 = classlogin.PwdLen(phonenumber);
        int loch2 = classlogin.Email(email);

        int i,loch3 = 1;
        for(i=0;i<phonenumber.Length;i++)
        {
            byte asc = Convert.ToByte(phonenumber[i]);
            if (asc < 48 || asc > 57) loch3 = 0;
        }

        classlogin myClass = new classlogin();
        string sql1 = "select * from UserList where userphonenumber = '" + phonenumber + "'";
        int flag00 = myClass.JudgeAcc(sql1);
        string sql2 = "select * from UserList where useremail = '" + email + "'";
        int flag01 = myClass.JudgeAcc(sql2);



        if (loch1 != 11)
            Response.Write("<script>alert('手机号码不合法！')</script>");
        else if (loch3 == 0)
            Response.Write("<script>alert('手机号码不合法！')</script>");
        else if (loch2 == 0)
            Response.Write("<script>alert('邮箱不合法！')</script>");
        else if (flag00 != 0)
            Response.Write("<script>alert('手机号码已存在！')</script>");
        else if (flag01 != 0)
            Response.Write("<script>alert('邮箱已存在！')</script>");


        else if (username.Length == 0)
            Response.Write("<script>alert('用户名不能为空！')</script>");
        else
        {
            int flag = myinformation.DataSQL(sql);
            if (flag == 1)
                Response.Write("<script>alert('完善信息成功！'),location='User.aspx'</script>");
            

        }

        
    }

}
