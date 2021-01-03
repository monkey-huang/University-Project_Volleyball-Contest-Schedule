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
    public partial class Arrangement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"]!=null)
            {
                    if (Session["New"].ToString() == "zxcv45628789@gmail.com")
                    {
                        Label1.Visible = true;
                        DropDownList2.Visible = true;
                        Label2.Visible = true;
                        DropDownList1.Visible = true;
                        Button1.Visible = true;
                        GridView1.Visible = true;
                        Label5.Visible = true;
                        DropDownList3.Visible = true;
                        Label6.Visible = true;
                        DropDownList4.Visible = true;

                        Label3.Text = "歡迎" + "管理員" + "登入";



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
                    Button2.Visible = true;
                    Label3.Visible = true;
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "您不是管理員 無法使用此功能喔";

                Label1.Visible = false;
                DropDownList2.Visible = false;
                Label2.Visible = false;
                DropDownList1.Visible = false;
                Label6.Visible = false;
                DropDownList4.Visible = false;
                Label5.Visible = false;
                DropDownList3.Visible = false;

                Button1.Visible = false;

            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          /*  if (Convert.ToInt32(TextBox1.Text) == 8 & DropDownList1.Text == "單淘汰")
            {

                Response.Redirect("arransingle/eightsingle.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 8 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/eight.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 9 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/nine.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 10 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/ten.aspx");
            }else if (Convert.ToInt32(TextBox1.Text) == 10 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/ten.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 11 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/eleven.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 12 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/twelve.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 13 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/thirteen.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 14 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/fourteen.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 15 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/fifteen.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 16 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/sixteen.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 17 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/Seventeen.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 18 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/Eighteenth.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 19 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/Nineteenth.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 20 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/twenty.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 21 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/twenty one.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 22 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/twenty two.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 23 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/twenty-three.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 24 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/twenty four.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 25 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/twenty five.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 26 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/Twenty-six.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 27 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/Twenty-seven.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 28 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/Twenty-eight.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 29 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/Twenty-nine.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 30 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/thirty.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 32 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/Thirty-two.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 31 & DropDownList1.SelectedItem.ToString() == "雙淘汰")
            {

                Response.Redirect("arrandouble/Thirty-onedouble.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 16 & DropDownList1.Text == "單淘汰")
            {

                Response.Redirect("arransingle/sixteen.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 15 & DropDownList1.Text == "單淘汰")
            {

                Response.Redirect("arransingle/fifteen.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 14 & DropDownList1.Text == "單淘汰")
            {

                Response.Redirect("arransingle/fourteen.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 13 & DropDownList1.Text == "單淘汰")
            {

                Response.Redirect("arransingle/thirteen.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 12 & DropDownList1.Text == "單淘汰")
            {

                Response.Redirect("arransingle/twelvesingle.aspx");
            }
            else if (Convert.ToInt32(TextBox1.Text) == 24 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/twenty foursingle.aspx");

            }else if (Convert.ToInt32(TextBox1.Text) == 23 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/twenty-three.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 22 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/twenty-two.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 21 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/twenty-one.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 20 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/twenty.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 19 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/Nineteenth.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 18 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/Eighteenth.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 17 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/Seventeen.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 32 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/Thirty-twosingle.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 9 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/ninesingle.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 10 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/tensingle.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 11 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/elevensingle.aspx");

            }                        
            else if (Convert.ToInt32(TextBox1.Text) == 31 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/Thirty-onesingle.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 30 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/Thirtysingle.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 29 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/Twenty-nine.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 28 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/Twenty-eight.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 27 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/Twenty-sevensingle.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 26 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/Twenty-sixsingle.aspx");

            }
            else if (Convert.ToInt32(TextBox1.Text) == 25 & DropDownList1.Text == "單淘汰")
            {
                Response.Redirect("arransingle/Twenty-fivesingle.aspx");

            }*/
            try
            {
                int a = 0;
                Session["Registration name"] = DropDownList2.Text; //報名名稱
                Session["Entries"] = DropDownList3.Text;// 參賽組別
                String seed;
                if (DropDownList4.Text != "無")
                {
                    Session["Seed team"] = DropDownList4.Text;
                    seed = Session["Seed team"].ToString();
                }
                else
                {
                    Session["Seed team"] = null;
                    seed = "無";
                }

                Boolean f = false;

                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    if (GridView1.Rows[i].Cells[2].Text == DropDownList2.Text & GridView1.Rows[i].Cells[8].Text == DropDownList3.Text)
                    {
                        a++;
                    }
                    if (GridView1.Rows[i].Cells[2].Text == DropDownList2.Text & GridView1.Rows[i].Cells[8].Text == DropDownList3.Text & seed == GridView1.Rows[i].Cells[3].Text.ToString())
                    {
                        f = true;
                    }
                 //    Label7.Text += GridView1.Rows[i].Cells[3].Text.ToString();
                }
                // Label7.Text += Session["Seed team"].ToString();


                if (f | DropDownList4.Text == "無")
                {
                    if (DropDownList1.Text == "單淘汰" & a == 8)
                    {
                        Response.Redirect("arransingle/eightsingle.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 16)
                    {
                        Response.Redirect("arransingle/sixteen.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 15)
                    {
                        Response.Redirect("arransingle/fifteen.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 14)
                    {
                        Response.Redirect("arransingle/fourteen.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 13)
                    {
                        Response.Redirect("arransingle/thirteen.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 12)
                    {
                        Response.Redirect("arransingle/twelvesingle.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 11)
                    {
                        Response.Redirect("arransingle/elevensingle.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 10)
                    {
                        Response.Redirect("arransingle/tensingle.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 9)
                    {
                        Response.Redirect("arransingle/ninesingle.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 24)
                    {
                        Response.Redirect("arransingle/twenty foursingle.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 23)
                    {
                        Response.Redirect("arransingle/twenty-three.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 22)
                    {
                        Response.Redirect("arransingle/twenty-two.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 21)
                    {
                        Response.Redirect("arransingle/twenty-one.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 20)
                    {
                        Response.Redirect("arransingle/twenty.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 19)
                    {
                        Response.Redirect("arransingle/Nineteenth.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 18)
                    {
                        Response.Redirect("arransingle/Eighteenth.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 17)
                    {
                        Response.Redirect("arransingle/Seventeen.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 32)
                    {
                        Response.Redirect("arransingle/Thirty-twosingle.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 31)
                    {
                        Response.Redirect("arransingle/Thirty-onesingle.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 30)
                    {
                        Response.Redirect("arransingle/Thirtysingle.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 29)
                    {
                        Response.Redirect("arransingle/Twenty-nine.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 28)
                    {
                        Response.Redirect("arransingle/Twenty-eight.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 27)
                    {
                        Response.Redirect("arransingle/Twenty-sevensingle.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 26)
                    {
                        Response.Redirect("arransingle/Twenty-sixsingle.aspx");
                    }
                    else if (DropDownList1.Text == "單淘汰" & a == 25)
                    {
                        Response.Redirect("arransingle/Twenty-fivesingle.aspx");
                    }
                        /////////////////////////////////////////////雙淘汰///////////////////////////////////////////////
                    else if (DropDownList1.Text == "雙淘汰" & a == 32)
                    {
                        Response.Redirect("arrandouble/Thirty-two.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 31)
                    {
                        Response.Redirect("arrandouble/thirty-one.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 30)
                    {
                        Response.Redirect("arrandouble/Thirty.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 29)
                    {
                        Response.Redirect("arrandouble/Twenty-nine.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 28)
                    {
                        Response.Redirect("arrandouble/Twenty-eight.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 27)
                    {
                        Response.Redirect("arrandouble/Twenty-seven.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 26)
                    {
                        Response.Redirect("arrandouble/Twenty-six.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 25)
                    {
                        Response.Redirect("arrandouble/twenty five.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 24)
                    {
                        Response.Redirect("arrandouble/twenty four.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 23)
                    {
                        Response.Redirect("arrandouble/twenty-three.aspx");

                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 22)
                    {
                        Response.Redirect("arrandouble/twenty two.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 21)
                    {
                        Response.Redirect("arrandouble/twenty one.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 20)
                    {
                        Response.Redirect("arrandouble/twenty.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 19)
                    {
                        Response.Redirect("arrandouble/Nineteenth.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 18)
                    {
                        Response.Redirect("arrandouble/Eighteenth.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 17)
                    {
                        Response.Redirect("arrandouble/Seventeen.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 16)
                    {
                        Response.Redirect("arrandouble/sixteen.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 15)
                    {
                        Response.Redirect("arrandouble/fifteen.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 14)
                    {
                        Response.Redirect("arrandouble/fourteen.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 13)
                    {
                        Response.Redirect("arrandouble/thirteen.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 12)
                    {
                        Response.Redirect("arrandouble/twelve.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 11)
                    {
                        Response.Redirect("arrandouble/eleven.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 10)
                    {
                        Response.Redirect("arrandouble/ten.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a == 9)
                    {
                        Response.Redirect("arrandouble/nine.aspx");
                    }
                    else if (DropDownList1.Text == "雙淘汰" & a ==8)
                    {
                        Response.Redirect("arrandouble/eight.aspx");
                    }
                }
                else
                {
                    Label4.Text = "種子隊伍無此隊伍";
                }
            }
            catch (Exception er)
            {
                Label4.Text = er.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["New"] = null;
            Button2.Visible = false;
            Label3.Visible = false;

            Label1.Visible = false;
            DropDownList2.Visible = false;
            Label2.Visible = false;
            DropDownList1.Visible = false;
            Button1.Visible = false;
            GridView1.Visible = false;
            Label5.Visible = false;
            DropDownList3.Visible = false;
            Response.Redirect("index.aspx");
        }
    }
}