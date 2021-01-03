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
    public partial class Scoring : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"] != null)
            {
                if (Session["New"].ToString() == "zxcv45628789@gmail.com")
                {
                    Label1.Text = "歡迎" + "管理員" + "登入";
                }
                else
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    con.Open();
                    String cmdStr2 = "select 身分 from 管理員資料 where 電子郵件='" + Session["New"].ToString() + "'";
                    SqlCommand pass = new SqlCommand(cmdStr2, con);
                    String correct = pass.ExecuteScalar().ToString();

                    Label1.Text = "歡迎 " + correct + " 登入";

                    try
                    {
                        pass.ExecuteNonQuery();

                    }
                    catch (Exception er)
                    {
                        Label1.Text = er.Message;
                    }
                    con.Close();

                }
                Button1.Visible = true;
                Label1.Visible = true;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["New"] = null;
            Button1.Visible = false;
            Label1.Visible = false;
            Response.Redirect("index.aspx");
        }
    }
}