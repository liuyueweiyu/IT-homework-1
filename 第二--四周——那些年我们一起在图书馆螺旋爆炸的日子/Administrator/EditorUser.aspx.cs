using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator_EditorUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            classlogin myaddbook = new classlogin();

            string id = Request.QueryString["userid"];

            string sql = "select * from UserList where userid='" + id + "'";
            DataTable dt = new DataTable();

            dt = myaddbook.JudgeIor(sql);

            string names = dt.Rows[0][2].ToString();
            string emails = dt.Rows[0][4].ToString();
            string phnums = dt.Rows[0][3].ToString();

            username.Text = names;
            useremail.Text = emails;
            userphnum.Text = phnums;
        }
    }

    public void btnChangeuser_Click(object sender, EventArgs e)
    {
        classlogin myEditor = new classlogin();
        string newid = Request.QueryString["userid"];

        string chusername = username.Text;
        string chphnum = userphnum.Text;
        string chemail = useremail.Text;

        string sql1 = "update UserList set username = '" + chusername + "' where userid = " + newid + "";
        string sql2 = "update UserList set userphonenumber = '" + chphnum + "' where userid = " + newid + "";
        string sql3 = "update UserList set useremail = '" + chemail + "' where userid = " + newid + "";


        int flag1 = classlogin.PwdLen(chphnum);
        int flag2 = classlogin.Email(chemail);

        if (flag1 != 11)
            Response.Write("<script>alert('手机号码不合法！')</script>");
        else if (flag2 == 0)
            Response.Write("<script>alert('邮箱不合法！')</script>");
        else
        {
            int loch1 = myEditor.DataSQL(sql1);
            int loch2 = myEditor.DataSQL(sql2);
            int loch3 = myEditor.DataSQL(sql3);

            if (loch1 == 1 && loch2 == 1 && loch3 == 1)
                Response.Write("<script>alert('修改成功！');location='MaUser.aspx'</script>");
            else
                Response.Write("<script>alert('修改失败！');location='EditorUser.aspx'</script>");
        }

    }

    protected void changeuser_Click(object sender, EventArgs e)
    {

    }
}