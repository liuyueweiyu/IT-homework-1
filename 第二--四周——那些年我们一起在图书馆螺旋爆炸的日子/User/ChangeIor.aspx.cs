using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_ChangeIor : System.Web.UI.Page
{
    classlogin myChangeIor = new classlogin();
    protected void Page_Load(object sender, EventArgs e)
    {
        string idnumber = Session["userid"].ToString();
        id.Text = idnumber;
        if (!IsPostBack)
        {


            DataTable dt = new DataTable();
            string sql = "select * from UserList where userid='" + idnumber + "'";
            dt = myChangeIor.JudgeIor(sql);

            string names = dt.Rows[0][2].ToString();
            string emails = dt.Rows[0][4].ToString();
            string phones = dt.Rows[0][3].ToString();

            preName.Text = names;
            preEmail.Text = emails;
            prePhonum.Text = phones;
        }
    }

    protected void changePwd_Click(object sender, EventArgs e)                      //  修改密码
    {
        string idnumber = Session["userid"].ToString();
        string password = prePwd.Text;
        string newpassword = newPwd.Text;


        string sql = "select * from UserList where userid='" + idnumber + "'";
        DataTable dt = new DataTable();

        dt = myChangeIor.JudgeIor(sql);
        string pwd = dt.Rows[0][1].ToString();


        if (pwd == password)
        {
            //Response.Write(String.Compare(pwd, password));
            Response.Write("<script>alert('原始密码输入错误！')</script>");
        }
        else
        {
            string sql2 = "update UserList set userpassword= '" + password + "' where userid='" + idnumber + "'";

            int flag = myChangeIor.DataSQL(sql2);

            if (flag == 1)
                Response.Write("<script>alert('修改成功！'),location='ChangeIor.aspx'</script>");
            else
                Response.Write("<script>alert('修改失败！')</script>");
        }
    }


    protected void changeEmail_Click(object sender, EventArgs e)            //修改邮箱
    {
        classlogin myChange = new classlogin();

        string idnumber = Session["userid"].ToString();
        string email = newEmail.Text;
        string sql1 = "select * from UserList where useremail = '" + email + "'";
        int flag0 = classlogin.Email(email);//检验邮箱是否合法
        int flag00 = myChange.JudgeAcc(sql1);

        if (flag0 == 0)
            Response.Write("<script>alert('邮箱不合法！')</script>");
        else if(flag00 != 0)
            Response.Write("<script>alert('邮箱已存在！')</script>");
        else
        {

            string sql = "update UserList set useremail = '" + email + "' where userid='" + idnumber + "'";

            int flag = myChangeIor.DataSQL(sql);

            if (flag == 1)
                Response.Write("<script>alert('修改成功！'),location='ChangeIor.aspx'</script>");
            else
                Response.Write("<script>alert('修改失败！')</script>");
        }
    }

    protected void changePhonum_Click(object sender, EventArgs e)                   //  修改手机号码
    {
        string idnumber = Session["userid"].ToString();
        string phone = newPhonum.Text;

        int i, loch3 = 1;                                                  //检测手机号码是否合法
        for (i = 0; i < phone.Length; i++)
        {
            byte asc = Convert.ToByte(phone[i]);
            if (asc < 48 || asc > 57) loch3 = 0;
        }

        classlogin myChange = new classlogin();
        string sql1 = "select * from UserList where userphonenumber = '" + phone + "'";
        int flag00 = myChange.JudgeAcc(sql1);


        if (phone.Length != 11 || loch3 != 1)
            Response.Write("<script>alert('手机号码不合法！')</script>");
        else if (flag00 != 0)
            Response.Write("<script>alert('已存在！')</script>");
        else
        {
            string sql = "update UserList set userphonenumber = '" + phone + "' where userid='" + idnumber + "'";
            int flag = myChangeIor.DataSQL(sql);

            if (flag == 1)
                Response.Write("<script>alert('修改成功！'),location='ChangeIor.aspx'</script>");
            else
                Response.Write("<script>alert('修改失败！')</script>");
        }
    }

    protected void changeName_Click(object sender, EventArgs e)
    {
        string idnumber = Session["userid"].ToString();
        string name = newName.Text;

        string sql = "update UserList set username = '" + name + "' where userid='" + idnumber + "'";

        int flag = myChangeIor.DataSQL(sql);
        
        if(flag==1)
            Response.Write("<script>alert('修改成功！'),location='ChangeIor.aspx'</script>");
        else
            Response.Write("<script>alert('修改失败！')</script>");
    }
}