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
    public partial class Restration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                con.Open();
                String cmdstr = "Select count(*) from 管理員資料 where 電子郵件='" + TextBox1.Text + "'";
                SqlCommand userExist = new SqlCommand(cmdstr, con);
                int temp = Convert.ToInt32(userExist.ExecuteScalar().ToString());
                con.Close();
                if (temp == 1)
                {
                    Label5.Text="user name Already Exist.....!! <br /> Please Choose Another User Name.";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            string inscmd = "Insert into 管理員資料 (電子郵件,密碼,身分證字號,姓名,性別,身分) values (@電子郵件,@密碼,@身分證字號,@姓名,@性別,@身分)";
            SqlCommand insertUser = new SqlCommand(inscmd, con);
            insertUser.Parameters.AddWithValue("@電子郵件", TextBox1.Text);
            insertUser.Parameters.AddWithValue("@密碼", TextBox2.Text);
            insertUser.Parameters.AddWithValue("@身分證字號", TextBox3.Text);
            insertUser.Parameters.AddWithValue("@姓名", TextBox4.Text);
            insertUser.Parameters.AddWithValue("@性別", DropDownList1.SelectedItem.ToString());
            insertUser.Parameters.AddWithValue("@身分", "會員");

            try
            {
                insertUser.ExecuteNonQuery();
                con.Close();
                Response.Redirect("Sign in.aspx");
            }
            catch (Exception er)
            {
                Label5.Text=er.Message+"Something really  Bad happened..... Please Try again.</b>";
            }
            finally
            {

            }
        }
    }
}