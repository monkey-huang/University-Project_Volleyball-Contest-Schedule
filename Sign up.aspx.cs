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
    public partial class Sign_up : System.Web.UI.Page
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
                    Label2.Text = correct;


                    con.Close();
                    Button1.Visible = true;
                    Label1.Visible = true;
                }
            }
            else
            {
                Button2.Visible = false;
                Label1.Text = "您不是會員 無法使用此功能喔";
            }




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["New"] = null;
            Button1.Visible = false;
            Label1.Visible = false;
            Response.Redirect("index.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          
           if (TextBox2.Text != "" & TextBox3.Text != "" & TextBox4.Text != "" & TextBox5.Text != ""&
                TextBox6.Text != "" & TextBox7.Text != "" & TextBox8.Text != "" &          //隊員1  
               TextBox9.Text != "" & TextBox10.Text != "" & TextBox11.Text != "" & //隊員2
                TextBox12.Text != "" & TextBox13.Text != "" & TextBox14.Text != "" &   //隊員3
               TextBox15.Text != "" & TextBox16.Text != "" & TextBox17.Text != "" &   //隊員4
               TextBox18.Text != "" & TextBox19.Text != "" & TextBox20.Text != "" &   //隊員5
               TextBox21.Text != "" & TextBox22.Text != "" & TextBox23.Text != ""   //隊員6
                )
            {

                String[] s=new String[12];
                s[0] = s[0] + TextBox6.Text + " " + TextBox7.Text + " "+TextBox8.Text;   //1
                s[1] = s[1] + TextBox9.Text + " " + TextBox10.Text + " " + TextBox11.Text;  //2
                s[2] = s[2] + TextBox12.Text + " " + TextBox13.Text + " " + TextBox14.Text;  //3 
                s[3] = s[3] + TextBox15.Text + " " + TextBox16.Text + " " + TextBox17.Text;  //4
                s[4] = s[4] + TextBox18.Text + " " + TextBox19.Text + " " + TextBox20.Text;     //5
                s[5] = s[5] + TextBox21.Text + " " + TextBox22.Text + " " + TextBox23.Text;     //6
                s[6] = s[6] + TextBox14.Text + " " + TextBox24.Text + " " + TextBox25.Text;     //7
                s[7] = s[7] + TextBox26.Text + " " + TextBox26.Text + " " + TextBox27.Text;     //8
                s[8] = s[8] + TextBox28.Text + " " + TextBox29.Text + " " + TextBox30.Text;     //8
                s[9] = s[9] + TextBox31.Text + " " + TextBox32.Text + " " + TextBox33.Text;     //8
                s[10] = s[10] + TextBox34.Text + " " + TextBox35.Text + " " + TextBox36.Text;     //8
                s[11] = s[11] + TextBox37.Text + " " + TextBox38.Text + " " + TextBox39.Text;     //8

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                con.Open();
                string inscmd = "INSERT INTO 報名資料 (比賽項目,系別,主要聯絡電話,領隊,教練,管理,參賽組別,隊長1,隊員2,隊員3,隊員4,隊員5,隊員6,隊員7,隊員8,隊員9,隊員10,隊員11,隊員12 ) values (@比賽項目,@系別,@主要聯絡電話,@領隊,@教練,@管理,@參賽組別,@隊長1,@隊員2,@隊員3,@隊員4,@隊員5,@隊員6,@隊員7,@隊員8,@隊員9,@隊員10,@隊員11,@隊員12)";
                SqlCommand User = new SqlCommand(inscmd, con);


               // User.Parameters.AddWithValue("@Id", "5");// User.Parameters.AddWithValue("@Id"," ");//,隊員7,隊員8,隊員9,隊員10,隊員11,隊員12   ,@隊員7,@隊員8,@隊員9,@隊員10,@隊員11,@隊員12 ,隊長1,隊員2,隊員3,隊員4,隊員5,隊員6,隊員7,隊員8,隊員9,隊員10,隊員11,隊員12  ,@隊長1,@隊員2,@隊員3,@隊員4,@隊員5,@隊員6,@隊員7,@隊員8,@隊員9,@隊員10,@隊員11,@隊員12
                User.Parameters.AddWithValue("@比賽項目", DropDownList2.SelectedItem.ToString());
                User.Parameters.AddWithValue("@系別", Label2.Text);
                User.Parameters.AddWithValue("@主要聯絡電話", TextBox2.Text);
                User.Parameters.AddWithValue("@領隊", TextBox3.Text);
                User.Parameters.AddWithValue("@教練", TextBox4.Text);
                User.Parameters.AddWithValue("@管理", TextBox5.Text);
                User.Parameters.AddWithValue("@參賽組別", DropDownList1.SelectedItem.ToString());

                User.Parameters.AddWithValue("@隊長1", s[0]);
                User.Parameters.AddWithValue("@隊員2", s[1]);
                User.Parameters.AddWithValue("@隊員3", s[2]);
                User.Parameters.AddWithValue("@隊員4", s[3]);
                User.Parameters.AddWithValue("@隊員5", s[4]);
                User.Parameters.AddWithValue("@隊員6", s[5]);

                User.Parameters.AddWithValue("@隊員7", s[6]);
                User.Parameters.AddWithValue("@隊員8", s[7]);
                User.Parameters.AddWithValue("@隊員9", s[8]);
                User.Parameters.AddWithValue("@隊員10", s[9]);
                User.Parameters.AddWithValue("@隊員11", s[10]);
                User.Parameters.AddWithValue("@隊員12", s[11]);


                try
                {
                    User.ExecuteNonQuery();
                    
                }
                catch (Exception er)
                {
                    Label3.Text = er.Message;
                }
                finally
                {
                    con.Close();

                }


                Label3.Text = "您已成功送出資料";

                s[0] = "";
                s[1] = "";
                s[2] = "";
                s[3] = "";
                s[4] = "";
                s[5] = "";

                s[6] = "";
                s[7] = "";
                s[8] = "";
                s[9] = "";
                s[10] = "";
                s[11] = "";
                

            }
            else
            {
                Label3.Text = "你還有資料尚未填寫喔 選手至少一定要6位唷!";

            }
        }
    }
}