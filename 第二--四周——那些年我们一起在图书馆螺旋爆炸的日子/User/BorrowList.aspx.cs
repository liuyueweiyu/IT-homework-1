using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_BorrowList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string idnumber = Session["userid"].ToString();

        string sql = "select * from BorrowList where br_userid='" + idnumber + "'";

        classlogin myBorrowList = new classlogin();

        DataTable dt = new DataTable();

        dt = myBorrowList.JudgeIor(sql);

        rptBorrowList.DataSource = dt;

        rptBorrowList.DataBind();
    }

}