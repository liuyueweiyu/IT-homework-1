using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    string str = @"server=LAPTOP-36VBSINT;Integrated Security=SSPI;database=ReportServer;";
    classlogin myLogin = new classlogin();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void btnLogStu_Click(object sender, EventArgs e)
    {
        classlogin myLogin = new classlogin();

        string idnumber = txtNum.Text;
        string password = txtPwd.Text;
        string sql = "select * from UserList where userid='" + idnumber + "'and userpassword='" + password + "'";
        int count = (myLogin.JudgeIor(sql)).Rows.Count;


        if (count > 0)
        {
            string sql1 = "select * from UserList where userid='" + idnumber + "'";
            DataTable dt = new DataTable();
            dt = myLogin.JudgeIor(sql1);
            string phone = dt.Rows[0][3].ToString();
            string email = dt.Rows[0][4].ToString();
            int len1 = phone.Length;
            int len2 = email.Length;

            if (len1 == 0 || len2 == 0)
            {
                Response.Write("<script>alert('登陆成功！');location='User/Information.aspx'</script>");
                Session["userid"] = idnumber;
               // FormsAuthentication.RedirectFromLoginPage(txtNum.Text, false);
                //Response.Redirect("User/User.aspx");
            }
            else
            {
                Response.Write("<script>alert('登陆成功！');location='User/User.aspx'</script>");
                Session["userid"] = idnumber;
               // FormsAuthentication.RedirectFromLoginPage(txtNum.Text, false);
               // Response.Redirect("User/User.aspx");
            }
            }
        else
            Response.Write("<script>alert('登陆失败！')</script>");


    }

    public void btnLogAd_Click(object sender, EventArgs e)
    {
        string idnumber = txtNum.Text;
        string password = txtPwd.Text;
        string sql = "select * from AdminiList where adminiid='" + idnumber + "'and adpassword='" + password + "'";

        DataTable dt = new DataTable();
        dt = myLogin.JudgeIor(sql);
        int count = dt.Rows.Count;



        if (count > 0)
        {
            Response.Write("<script>alert('登陆成功！');location='Administrator/Manage.aspx'</script>");
            Session["adminiid"] = idnumber;
        }
        else
            Response.Write("<script>alert('登陆失败！')</script>");


    }



}