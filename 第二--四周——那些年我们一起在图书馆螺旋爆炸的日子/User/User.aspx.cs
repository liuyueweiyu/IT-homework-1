using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        classlogin myUser = new classlogin();

        string idnumber = Session["userid"].ToString();
        DataTable dt = new DataTable();
        string sql = "select * from UserList where userid='" + idnumber + "'";
        dt = myUser.JudgeIor(sql);

        string freeze = dt.Rows[0][5].ToString();

        if (String.Compare(freeze, "yes") != 0)
            frozen.Text = "当前账号可继续借书";
        else
            frozen.Text = "当前账号被管理员冻结，不能再借书";

    }

   /* protected void toLogin_Click(object sender, EventArgs e)
    {
        //System.Web.Security.FormsAuthentication.SignOut();
       // HttpContext context;
        //context.Session.Clear(); 
        //context.Session.Abandon();
        //context.Response.Redirect("Login.aspx");
        //Response.Write("<script>alert('注销成功！')</script>");
    }*/

    protected void toBorrowList_Click(object sender, EventArgs e)
    {
        string idnumber = Session["userid"].ToString();
        Session["userid"] = idnumber;
    }
}