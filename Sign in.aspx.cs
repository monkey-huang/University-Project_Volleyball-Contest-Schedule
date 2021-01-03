using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace 專題
{
    public partial class Sign_in : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"] != null)
            {
                if (Session["New"].ToString() == "zxcv45628789@gmail.com")
                {
                    Label3.Text = "歡迎" + " 管理員 " + "登入";
                }
                else
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    con.Open();
                    String cmdStr2 = "select 身分 from 管理員資料 where 電子郵件='" + Session["New"].ToString() + "'";
                    SqlCommand pass = new SqlCommand(cmdStr2, con);
                    String correct = pass.ExecuteScalar().ToString();

                    Label3.Text = "歡迎 " + correct + " 登入";

                    try
                    {
                        pass.ExecuteNonQuery();

                    }
                    catch (Exception er)
                    {
                        Label3.Text = er.Message;
                    }
                    con.Close();
                }

                Button4.Visible = true;
                Label3.Visible = true;
                Label1.Visible = false;
                Label2.Visible = false;
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                Button3.Visible = false;
                Label6.Text = "您已經登入";
            }
            else
            {
                Label1.Visible = true;
                Label2.Visible = true;
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                Button3.Visible = true;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            String cmdStr = "Select count(*) from 管理員資料 where 電子郵件='" + TextBox1.Text + "'";
            SqlCommand Checkuser = new SqlCommand(cmdStr, con);
            int temp = Convert.ToInt32(Checkuser.ExecuteScalar().ToString());
            if (temp == 1)
            {
                String cmdStr2 = "select 密碼 from 管理員資料 where 電子郵件='" + TextBox1.Text + "'";
                SqlCommand pass = new SqlCommand(cmdStr2, con);
                String password = pass.ExecuteScalar().ToString();

                con.Close();
                if (password == TextBox2.Text)
                {
                    Session["New"] = TextBox1.Text;
                    Response.Redirect("index.aspx");
                }
                else
                {
                    Label4.Visible = true;
                    Label4.Text = "無效密碼......";
                }
            }
            else
            { 
                    Label4.Visible = true;
                    Label4.Text = "無效帳號......";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["New"] = null;
            Button4.Visible = false;
            Label3.Visible = false;
            Response.Redirect("index.aspx");
        }

    }
}