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
    public partial class Team_Information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"] != null)
            {
                if (Session["New"].ToString() == "zxcv45628789@gmail.com")
                {
                    Label2.Text = "歡迎" + "管理員" + "登入";
                }
                else
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    con.Open();
                    String cmdStr2 = "select 身分 from 管理員資料 where 電子郵件='" + Session["New"].ToString() + "'";
                    SqlCommand pass = new SqlCommand(cmdStr2, con);
                    String correct = pass.ExecuteScalar().ToString();

                    Label2.Text = "歡迎 " + correct + " 登入";

                    try
                    {
                        pass.ExecuteNonQuery();

                    }
                    catch (Exception er)
                    {
                        Label2.Text = er.Message;
                    }
                    con.Close();

                }
                Button2.Visible = true;
                Label2.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

  
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["New"] = null;
            Button2.Visible = false;
            Label2.Visible = false;
            Response.Redirect("index.aspx");
        }
    }
}