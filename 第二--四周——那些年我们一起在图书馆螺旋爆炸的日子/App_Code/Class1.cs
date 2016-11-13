using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class classlogin
{
    string str = @"server=LAPTOP-36VBSINT;Integrated Security=SSPI;database=Library;";
    public classlogin()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    static public int JudgePwd(string password,string repassword)           //测定两次密码是否相同
    {
       if (string.Compare(password, repassword) == 0)
            return 1;
       else
            return -1;
    }

    static public int PwdLen(string password)                   //测量字符串长度
    {
        int len;
        len = password.Length;
        return len;
    }


    static public int Email(string email)                       // 检验邮箱合法性
    {
        string str1 = "@", str2 = ".com";
        if (email.Contains(str1) && email.Contains(str2))
            return 1;
        else
            return 0;
    }

     public int  DataSQL(string sql)         //执行SQL语句
    {
        SqlConnection conn = new SqlConnection(str);
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, conn);

        cmd.ExecuteNonQuery();
        return 1;
        conn.Close();
    }

    public int JudgeAcc(string sql)                                                  //检测账号是否重复
    {
        SqlConnection conn = new SqlConnection(str);
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return (ds.Tables[0].Rows.Count);
        conn.Close();
    }

    public DataTable JudgeIor(string sql)                 //  查找信息
    {
        SqlConnection conn = new SqlConnection(str);
        DataTable dt = new DataTable();
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        da.Fill(dt);
    
        return dt;
        conn.Close();
    }


}