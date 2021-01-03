using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace 專題.arrandouble
{
    public partial class eight : System.Web.UI.Page
    {

        static int[] arr = new int[8];//B區專用
        static int[] arr2 = new int[8];//A區專用
        static int[] arr3 = new int[8];//C區專用
        static int[] arr4 = new int[8];///決賽用
        static int[] arr5 = new int[8]; //D區專用  
        static int[] arr6 = new int[8];//A區敗部
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["New"] != null)
                {
                    if (Session["New"].ToString() == "zxcv45628789@gmail.com")
                    {
                        Button1.Visible = true;
                        Label34.Text = "歡迎" + "管理員" + "登入";

                        Random r = new Random();
                        String[] s = new String[8];
                        int j = 0;
                        for (int i = 0; i < s.Length; i++)
                        {
                            s[i] = "";
                        }


                        if (Session["Seed team"] != null)/////有種子時
                        {
                            s[7] = Session["Seed team"].ToString();

                            for (int i = 0; i < GridView1.Rows.Count; i++)
                            {
                                if (GridView1.Rows[i].Cells[1].Text == Session["Registration name"].ToString() & GridView1.Rows[i].Cells[4].Text == Session["Entries"].ToString() & GridView1.Rows[i].Cells[2].Text.ToString() != Session["Seed team"].ToString())
                                {
                                    while (true)
                                    {
                                        j = r.Next(0, 7);
                                        if (s[j] == "")
                                        {
                                            s[j] = GridView1.Rows[i].Cells[2].Text;
                                            break;
                                        }
                                    }
                                }
                            }

                            Label1.Text = s[0];
                            Label2.Text = s[1];
                            Label3.Text = s[2];
                            Label4.Text = s[3];
                            Label5.Text = s[4];
                            Label6.Text = s[5];
                            Label7.Text = s[6];
                            Label8.Text = s[7];
                            ///////////////////////8




                        }
                        else  ///沒種子時
                        {
                            for (int i = 0; i < GridView1.Rows.Count; i++)
                            {
                                if (GridView1.Rows[i].Cells[1].Text == Session["Registration name"].ToString() & GridView1.Rows[i].Cells[4].Text == Session["Entries"].ToString())
                                {
                                    while (true)
                                    {
                                        j = r.Next(0, 8);
                                        if (s[j] == "")
                                        {
                                            s[j] = GridView1.Rows[i].Cells[2].Text;
                                            break;
                                        }
                                    }
                                }
                            }

                            Label1.Text = s[0];
                            Label2.Text = s[1];
                            Label3.Text = s[2];
                            Label4.Text = s[3];
                            Label5.Text = s[4];
                            Label6.Text = s[5];
                            Label7.Text = s[6];
                            Label8.Text = s[7];
                            ///////////////////////8




                            /* for (int i = 0; i < 8; i++)
                             {
                                 Label37.Text += s[i] + " ";
                             }*/
                        }
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                        con.Open();
                        String cmdStr2 = "select 身分 from 管理員資料 where 電子郵件='" + Session["New"].ToString() + "'";
                        SqlCommand pass = new SqlCommand(cmdStr2, con);
                        String correct = pass.ExecuteScalar().ToString();
                        Label34.Text = "歡迎 " + correct + " 登入";

                        try
                        {
                            pass.ExecuteNonQuery();
                        }
                        catch (Exception er)
                        {
                            Label34.Text = er.Message;
                        }

                        con.Close();
                    }

                    ///////////////////////////////////////////////////////////乾好亂喔////////////////////////////////////
                    Button4.Visible = true;//登出的按鈕
                    Label34.Visible = true;//登入時的文字
                    Label256.Text = Session["Registration name"] + "「" + Session["Entries"] + "」";   ////設置大標題是甚麼
                }
                else
                {
                    Label34.Visible = true;
                    Label34.Text = "您尚未登入 無法使用此功能喔";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            DateTime date = DateTime.Now;
            String str = date.ToString();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            string inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
            SqlCommand User = new SqlCommand(inscmd, con);

            if (TextBox1.Text != "" && TextBox2.Text != "")
            {

                a = Convert.ToInt32(TextBox1.Text);
                b = Convert.ToInt32(TextBox2.Text);
                if (a != b)
                {
                    Label11.Text += a;
                    Label12.Text += b;
                    TextBox1.Visible = false;
                    TextBox2.Visible = false;
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox9.Visible = true;

                    User.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User.Parameters.AddWithValue("@賽制", "8人雙淘汰");
                    User.Parameters.AddWithValue("@隊伍A", Label1.Text);
                    User.Parameters.AddWithValue("@分數A", a);
                    User.Parameters.AddWithValue("@隊伍B", Label2.Text);
                    User.Parameters.AddWithValue("@分數B", b);
                    User.Parameters.AddWithValue("@區域幾輪", "A區第一輪");
                    User.Parameters.AddWithValue("@日期", str);
                    User.ExecuteNonQuery();

                    if (a > b)
                    {
                        Label149.Text = Label2.Text;
                        Image1.ImageUrl = "~/img/普通LR.jpg";
                        arr2[0] += 1;
                    }
                    else if (a < b)
                    {
                        Label149.Text = Label1.Text;
                        Image1.ImageUrl = "~/img/普通RR.jpg";
                        arr2[1] += 1;
                    }
                }
            }
            if (TextBox3.Text != "" && TextBox4.Text != "")
            {
                a = Convert.ToInt32(TextBox3.Text);
                b = Convert.ToInt32(TextBox4.Text);
                if (a != b)
                {
                    Label13.Text += a;
                    Label14.Text += b;
                    TextBox3.Visible = false;
                    TextBox4.Visible = false;
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox10.Visible = true;
                    Button15.Visible = true;//開敗部按鈕功能

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_2 = new SqlCommand(inscmd, con);
                    User_2.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_2.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_2.Parameters.AddWithValue("@賽制", "8人雙淘汰");
                    User_2.Parameters.AddWithValue("@隊伍A", Label3.Text);
                    User_2.Parameters.AddWithValue("@分數A", a);
                    User_2.Parameters.AddWithValue("@隊伍B", Label4.Text);
                    User_2.Parameters.AddWithValue("@分數B", b);
                    User_2.Parameters.AddWithValue("@區域幾輪", "A區第一輪");
                    User_2.Parameters.AddWithValue("@日期", str);
                    User_2.ExecuteNonQuery();

                    if (a > b)
                    {
                        Label150.Text = Label4.Text;
                        Image2.ImageUrl = "~/img/普通LR.jpg";
                        arr2[2] += 1;
                    }
                    else if (a < b)
                    {
                        Label150.Text = Label3.Text;
                        Image2.ImageUrl = "~/img/普通RR.jpg";
                        arr2[3] += 1;
                    }
                }
            }
            if (TextBox5.Text != "" && TextBox6.Text != "")
            {
                a = Convert.ToInt32(TextBox5.Text);
                b = Convert.ToInt32(TextBox6.Text);
                if (a != b)
                {
                    Label15.Text += a;
                    Label16.Text += b;
                    TextBox5.Visible = false;
                    TextBox6.Visible = false;
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox11.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_3 = new SqlCommand(inscmd, con);
                    User_3.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_3.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_3.Parameters.AddWithValue("@賽制", "8人雙淘汰");
                    User_3.Parameters.AddWithValue("@隊伍A", Label5.Text);
                    User_3.Parameters.AddWithValue("@分數A", a);
                    User_3.Parameters.AddWithValue("@隊伍B", Label6.Text);
                    User_3.Parameters.AddWithValue("@分數B", b);
                    User_3.Parameters.AddWithValue("@區域幾輪", "A區第一輪");
                    User_3.Parameters.AddWithValue("@日期", str);
                    User_3.ExecuteNonQuery();

                    if (a > b)
                    {
                        Label151.Text = Label6.Text;
                        Image3.ImageUrl = "~/img/普通LR.jpg";
                        arr2[4] += 1;
                    }
                    else if (a < b)
                    {
                        Label151.Text = Label5.Text;
                        Image3.ImageUrl = "~/img/普通RR.jpg";
                        arr2[5] += 1;
                    }
                }
            }
            if (TextBox7.Text != "" && TextBox8.Text != "")
            {
                a = Convert.ToInt32(TextBox7.Text);
                b = Convert.ToInt32(TextBox8.Text);
                if (a != b)
                {
                    Label17.Text += a;
                    Label18.Text += b;
                    TextBox7.Visible = false;
                    TextBox8.Visible = false;
                    TextBox7.Text = "";
                    TextBox8.Text = "";
                    TextBox12.Visible = true;
                    Button15.Visible = true;//開敗部按鈕功能

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_4 = new SqlCommand(inscmd, con);
                    User_4.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_4.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_4.Parameters.AddWithValue("@賽制", "8人雙淘汰");
                    User_4.Parameters.AddWithValue("@隊伍A", Label7.Text);
                    User_4.Parameters.AddWithValue("@分數A", a);
                    User_4.Parameters.AddWithValue("@隊伍B", Label8.Text);
                    User_4.Parameters.AddWithValue("@分數B", b);
                    User_4.Parameters.AddWithValue("@區域幾輪", "A區第一輪");
                    User_4.Parameters.AddWithValue("@日期", str);
                    User_4.ExecuteNonQuery();

                    if (a > b)
                    {
                        Label152.Text = Label8.Text;
                        Image4.ImageUrl = "~/img/普通LR.jpg";
                        arr2[6] += 1;
                    }
                    else if (a < b)
                    {
                        Label152.Text = Label7.Text;
                        Image4.ImageUrl = "~/img/普通RR.jpg";
                        arr2[7] += 1;
                    }
                }
            }
            //第一輪結束

            if (TextBox9.Text != "" && TextBox10.Text != "")
            {
                a = Convert.ToInt32(TextBox9.Text);
                b = Convert.ToInt32(TextBox10.Text);
                if (a != b)
                {
                    Label19.Text += a;
                    Label20.Text += b;
                    TextBox9.Visible = false;
                    TextBox10.Visible = false;
                    TextBox9.Text = "";
                    TextBox10.Text = "";
                    TextBox13.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_5 = new SqlCommand(inscmd, con);
                    User_5.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_5.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_5.Parameters.AddWithValue("@賽制", "8人雙淘汰");
                    if (arr2[0] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label1.Text);
                    }
                    else if (arr2[1] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label2.Text);
                    }

                    User_5.Parameters.AddWithValue("@分數A", a);

                    if (arr2[2] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍B", Label3.Text);
                    }
                    else if (arr2[3] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍B", Label4.Text);
                    }
                    User_5.Parameters.AddWithValue("@分數B", b);
                    User_5.Parameters.AddWithValue("@區域幾輪", "A區第二輪");
                    User_5.Parameters.AddWithValue("@日期", str);
                    User_5.ExecuteNonQuery();

                    if (a > b)
                    {
                        if (arr2[2] > arr2[3])
                        {
                            Label153.Text = Label3.Text;
                        }
                        else if (arr2[2] < arr2[3])
                        {
                            Label153.Text = Label4.Text;
                        }
                        Image5.ImageUrl = "~/img/大普通LR.jpg";
                        arr2[0] += 1;
                        arr2[1] += 1;
                    }
                    else if (a < b)
                    {
                        if (arr2[0] > arr2[1])
                        {
                            Label153.Text = Label1.Text;
                        }
                        else if (arr2[0] < arr2[1])
                        {
                            Label153.Text = Label2.Text;
                        }
                        Image5.ImageUrl = "~/img/大普通RR.jpg";
                        arr2[2] += 1;
                        arr2[3] += 1;
                    }
                }
            }//-1
            if (TextBox11.Text != "" && TextBox12.Text != "")
            {
                a = Convert.ToInt32(TextBox11.Text);
                b = Convert.ToInt32(TextBox12.Text);
                if (a != b)
                {
                    Label21.Text += a;
                    Label22.Text += b;
                    TextBox11.Visible = false;
                    TextBox12.Visible = false;
                    TextBox11.Text = "";
                    TextBox12.Text = "";
                    TextBox14.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_6 = new SqlCommand(inscmd, con);
                    User_6.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_6.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_6.Parameters.AddWithValue("@賽制", "8人雙淘汰");
                    if (arr2[4] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label5.Text);
                    }
                    else if (arr2[5] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label6.Text);
                    }

                    User_6.Parameters.AddWithValue("@分數A", a);

                    if (arr2[6] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍B", Label7.Text);
                    }
                    else if (arr2[7] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍B", Label8.Text);
                    }
                    User_6.Parameters.AddWithValue("@分數B", b);
                    User_6.Parameters.AddWithValue("@區域幾輪", "A區第二輪");
                    User_6.Parameters.AddWithValue("@日期", str);
                    User_6.ExecuteNonQuery();

                    if (a > b)
                    {
                        if (arr2[6] > arr2[7])
                        {
                            Label154.Text = Label7.Text;
                        }
                        else if (arr2[6] < arr2[7])
                        {
                            Label154.Text = Label8.Text;
                        }
                        Image6.ImageUrl = "~/img/大普通LR.jpg";
                        arr2[4] += 1;
                        arr2[5] += 1;
                    }
                    else if (a < b)
                    {
                        if (arr2[4] > arr2[5])
                        {
                            Label154.Text = Label5.Text;
                        }
                        else if (arr2[4] < arr2[5])
                        {
                            Label154.Text = Label6.Text;
                        }

                        Image6.ImageUrl = "~/img/大普通RR.jpg";
                        arr2[6] += 1;
                        arr2[7] += 1;
                    }
                }
            }////-2

            //第二輪結束
            if (TextBox13.Text != "" && TextBox14.Text != "")
            {
                a = Convert.ToInt32(TextBox13.Text);
                b = Convert.ToInt32(TextBox14.Text);
                if (a != b)
                {
                    Label23.Text += a;
                    Label24.Text += b;
                    TextBox13.Visible = false;
                    TextBox14.Visible = false;
                    TextBox13.Text = "";
                    TextBox14.Text = "";
                    Label67.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_7 = new SqlCommand(inscmd, con);
                    User_7.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_7.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_7.Parameters.AddWithValue("@賽制", "8人雙淘汰");
                    if (arr2[0] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label1.Text);
                    }
                    else if (arr2[1] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label2.Text);
                    }
                    else if (arr2[2] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label3.Text);
                    }
                    else if (arr2[3] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label4.Text);
                    }

                    User_7.Parameters.AddWithValue("@分數A", a);

                    if (arr2[4] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label5.Text);
                    }
                    else if (arr2[5] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label6.Text);
                    }
                    else if (arr2[6] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label7.Text);
                    }
                    else if (arr2[7] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label8.Text);
                    }

                    User_7.Parameters.AddWithValue("@分數B", b);
                    User_7.Parameters.AddWithValue("@區域幾輪", "A區第三輪");
                    User_7.Parameters.AddWithValue("@日期", str);
                    User_7.ExecuteNonQuery();

                    if (a > b)
                    {
                        if (arr2[4] > arr2[5] & arr2[4] > arr2[6] & arr2[4] > arr2[7])
                        {
                            Label155.Text = Label5.Text;
                        }
                        else if (arr2[5] > arr2[4] & arr2[5] > arr2[6] & arr2[5] > arr2[7])
                        {
                            Label155.Text = Label6.Text;
                        }
                        else if (arr2[6] > arr2[4] & arr2[6] > arr2[5] & arr2[6] > arr2[7])
                        {
                            Label155.Text = Label7.Text;
                        }
                        else if (arr2[7] > arr2[4] & arr2[7] > arr2[5] & arr2[7] > arr2[6])
                        {
                            Label155.Text = Label8.Text;
                        }
                        Image7.ImageUrl = "~/img/大大普通LR.jpg";
                        arr2[0] += 1;
                        arr2[1] += 1;
                        arr2[2] += 1;
                        arr2[3] += 1;
                    }

                    else if (a < b)
                    {
                        if (arr2[0] > arr2[1] & arr2[0] > arr2[2] & arr2[0] > arr2[3])
                        {
                            Label155.Text = Label1.Text;
                        }
                        else if (arr2[1] > arr2[0] & arr2[1] > arr2[2] & arr2[1] > arr2[3])
                        {
                            Label155.Text = Label2.Text;
                        }
                        else if (arr2[2] > arr2[0] & arr2[2] > arr2[1] & arr2[2] > arr2[3])
                        {
                            Label155.Text = Label3.Text;
                        }
                        else if (arr2[3] > arr2[0] & arr2[3] > arr2[2] & arr2[3] > arr2[0])
                        {
                            Label155.Text = Label4.Text;
                        }
                        Image7.ImageUrl = "~/img/大大普通RR.jpg";
                        arr2[4] += 1;
                        arr2[5] += 1;
                        arr2[6] += 1;
                        arr2[7] += 1;
                    }
                }
            }

            //OVER

            /*  if (c == 0 & TextBox1.Visible == false & TextBox2.Visible == false & TextBox3.Visible == false & TextBox4.Visible
                  == false & TextBox5.Visible == false & TextBox6.Visible == false & TextBox7.Visible == false & TextBox8.Visible == false
                  /*& Label11.Text!="" & Label12.Text!="" & Label13.Text!="" & Label14.Text!="" & Label15.Text!="" & Label16.Text!="" & Label17.Text!="" &
                  Label18.Text!="")
              {
                  c++;
                  TextBox9.Visible = true;
                  TextBox10.Visible = true;
                  TextBox11.Visible = true;
                  TextBox12.Visible = true;
              }
              else if (d == 0 & TextBox9.Visible == false & TextBox10.Visible == false & TextBox11.Visible == false & TextBox12.Visible == false & TextBox1.Visible == false & TextBox2.Visible == false & TextBox3.Visible == false & TextBox4.Visible
                 == false & TextBox5.Visible == false & TextBox6.Visible == false & TextBox7.Visible == false & TextBox8.Visible == false)
              {
                  d++;
                  TextBox13.Visible = true;
                  TextBox14.Visible = true;
              }
              else if (c == 1 & d == 1 & f == 0 & TextBox13.Visible == false & TextBox14.Visible == false)
              {
                  c = 0;
                  d = 0;
                  f = 0;
                  Button1.Visible = false;
              }*/


            if (arr2[0] > arr2[1] && arr2[0] > arr2[2] & arr2[0] > arr2[3] & arr2[0] > arr2[4] & arr2[0] > arr2[5] & arr2[0] > arr2[6] & arr2[0] > arr2[7] & Label67.Visible == true)
            {
                Label67.Text = Label1.Text;
                Label241.Text = Label67.Text;
            }
            else if (arr2[1] > arr2[0] && arr2[1] > arr2[2] & arr2[1] > arr2[3] & arr2[1] > arr2[4] & arr2[1] > arr2[5] & arr2[1] > arr2[6] & arr2[1] > arr2[7] & Label67.Visible == true)
            {
                Label67.Text = Label2.Text;
                Label241.Text = Label67.Text;
            }
            else if (arr2[2] > arr2[1] && arr2[2] > arr2[0] & arr2[2] > arr2[3] & arr2[2] > arr2[4] & arr2[2] > arr2[5] & arr2[2] > arr2[6] & arr2[2] > arr2[7] & Label67.Visible == true)
            {
                Label67.Text = Label3.Text;
                Label241.Text = Label67.Text;
            }
            else if (arr2[3] > arr2[1] && arr2[3] > arr2[2] & arr2[3] > arr2[0] & arr2[3] > arr2[4] & arr2[3] > arr2[5] & arr2[3] > arr2[6] & arr2[3] > arr2[7] & Label67.Visible == true)
            {
                Label67.Text = Label4.Text;
                Label241.Text = Label67.Text;
            }
            else if (arr2[4] > arr2[1] && arr2[4] > arr2[2] & arr2[4] > arr2[3] & arr2[4] > arr2[0] & arr2[4] > arr2[5] & arr2[4] > arr2[6] & arr2[4] > arr2[7] & Label67.Visible == true)
            {
                Label67.Text = Label5.Text;
                Label241.Text = Label67.Text;
            }
            else if (arr2[5] > arr2[1] && arr2[5] > arr2[2] & arr2[5] > arr2[3] & arr2[5] > arr2[4] & arr2[5] > arr2[0] & arr2[5] > arr2[6] & arr2[5] > arr2[7] & Label67.Visible == true)
            {
                Label67.Text = Label6.Text;
                Label241.Text = Label67.Text;
            }
            else if (arr2[6] > arr2[1] && arr2[6] > arr2[2] & arr2[6] > arr2[3] & arr2[6] > arr2[4] & arr2[6] > arr2[5] & arr2[6] > arr2[0] & arr2[6] > arr2[7] & Label67.Visible == true)
            {
                Label67.Text = Label7.Text;
                Label241.Text = Label67.Text;
            }
            else if (arr2[7] > arr2[1] && arr2[7] > arr2[2] & arr2[7] > arr2[3] & arr2[7] > arr2[4] & arr2[7] > arr2[5] & arr2[7] > arr2[6] & arr2[7] > arr2[0] & Label67.Visible == true)
            {
                Label67.Text = Label8.Text;
                Label241.Text = Label67.Text;
            }

            if (Label67.Text == Label241.Text)
            {
                Button1.Visible = false;
                TextBox129.Visible = true;
                arr2[0] = 0;
                arr2[1] = 0;
                arr2[2] = 0;
                arr2[3] = 0;
                arr2[4] = 0;
                arr2[5] = 0;
                arr2[6] = 0;
                arr2[7] = 0;

            }
            con.Close();

        }//A區比賽

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["New"] = null;
            Button4.Visible = false;
            Label34.Visible = false;
            Response.Redirect("../index.aspx");
        }//登出

        protected void Button8_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            DateTime date = DateTime.Now;
            String str = date.ToString();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            string inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
            SqlCommand User = new SqlCommand(inscmd, con);

            /*    if (TextBox129.Text != "" && TextBox130.Text != "")
                {

                    a = Convert.ToInt32(TextBox129.Text);
                    b = Convert.ToInt32(TextBox130.Text);
                    if (a != b)
                    {
                        Label249.Text += a;
                        Label250.Text += b;
                        TextBox129.Visible = false;
                        TextBox130.Visible = false;
                        TextBox129.Text = "";
                        TextBox130.Text = "";
                        TextBox125.Visible = true;

                        User.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                        User.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                        User.Parameters.AddWithValue("@賽制", "24人雙淘汰");
                        User.Parameters.AddWithValue("@隊伍A", Label241.Text);
                        User.Parameters.AddWithValue("@分數A", a);
                        User.Parameters.AddWithValue("@隊伍B", Label242.Text);
                        User.Parameters.AddWithValue("@分數B", b);
                        User.Parameters.AddWithValue("@區域幾輪", "決賽區第一輪");
                        User.Parameters.AddWithValue("@日期", str);
                        User.ExecuteNonQuery();

                        if (a > b)
                        {

                            Image67.ImageUrl = "~/img/普通LR.jpg";
                            arr4[0] += 1;
                        }
                        else if (a < b)
                        {
                            Image67.ImageUrl = "~/img/普通RR.jpg";
                            arr4[1] += 1;
                        }
                    }
                }*/
            /*     if (TextBox131.Text != "" && TextBox132.Text != "")
                 {
                     a = Convert.ToInt32(TextBox131.Text);
                     b = Convert.ToInt32(TextBox132.Text);
                     if (a != b)
                     {
                         Label251.Text += a;
                         Label252.Text += b;
                         TextBox131.Visible = false;
                         TextBox132.Visible = false;
                         TextBox131.Text = "";
                         TextBox132.Text = "";
                         TextBox126.Visible = true;

                         inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                         SqlCommand User_2 = new SqlCommand(inscmd, con);
                         User_2.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                         User_2.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                         User_2.Parameters.AddWithValue("@賽制", "24人雙淘汰");
                         User_2.Parameters.AddWithValue("@隊伍A", Label243.Text);
                         User_2.Parameters.AddWithValue("@分數A", a);
                         User_2.Parameters.AddWithValue("@隊伍B", Label244.Text);
                         User_2.Parameters.AddWithValue("@分數B", b);
                         User_2.Parameters.AddWithValue("@區域幾輪", "決賽區第一輪");
                         User_2.Parameters.AddWithValue("@日期", str);
                         User_2.ExecuteNonQuery();

                         if (a > b)
                         {

                             Image68.ImageUrl = "~/img/普通LR.jpg";
                             arr4[2] += 1;
                         }
                         else if (a < b)
                         {

                             Image68.ImageUrl = "~/img/普通RR.jpg";
                             arr4[3] += 1;
                         }
                     }
                 }
                 if (TextBox133.Text != "" && TextBox134.Text != "")
                 {
                     a = Convert.ToInt32(TextBox133.Text);
                     b = Convert.ToInt32(TextBox134.Text);
                     if (a != b)
                     {
                         Label253.Text += a;
                         Label254.Text += b;
                         TextBox133.Visible = false;
                         TextBox134.Visible = false;
                         TextBox133.Text = "";
                         TextBox134.Text = "";
                         TextBox127.Visible = true;

                         inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                         SqlCommand User_3 = new SqlCommand(inscmd, con);
                         User_3.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                         User_3.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                         User_3.Parameters.AddWithValue("@賽制", "24人雙淘汰");
                         User_3.Parameters.AddWithValue("@隊伍A", Label245.Text);
                         User_3.Parameters.AddWithValue("@分數A", a);
                         User_3.Parameters.AddWithValue("@隊伍B", Label246.Text);
                         User_3.Parameters.AddWithValue("@分數B", b);
                         User_3.Parameters.AddWithValue("@區域幾輪", "決賽區第一輪");
                         User_3.Parameters.AddWithValue("@日期", str);
                         User_3.ExecuteNonQuery();

                         if (a > b)
                         {
                             Image69.ImageUrl = "~/img/普通LR.jpg";
                             arr4[4] += 1;
                         }
                         else if (a < b)
                         {
                             Image69.ImageUrl = "~/img/普通RR.jpg";
                             arr4[5] += 1;
                         }
                     }
                 }*/
            /*   if (TextBox135.Text != "" && TextBox136.Text != "")
               {
                   a = Convert.ToInt32(TextBox135.Text);
                   b = Convert.ToInt32(TextBox136.Text);
                   if (a != b)
                   {
                       Label255.Text += a;
                       Label256.Text += b;
                       TextBox135.Visible = false;
                       TextBox136.Visible = false;
                       TextBox135.Text = "";
                       TextBox136.Text = "";
                       TextBox128.Visible = true;

                       inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                       SqlCommand User_4 = new SqlCommand(inscmd, con);
                       User_4.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                       User_4.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                       User_4.Parameters.AddWithValue("@賽制", "24人雙淘汰");
                       User_4.Parameters.AddWithValue("@隊伍A", Label247.Text);
                       User_4.Parameters.AddWithValue("@分數A", a);
                       User_4.Parameters.AddWithValue("@隊伍B", Label248.Text);
                       User_4.Parameters.AddWithValue("@分數B", b);
                       User_4.Parameters.AddWithValue("@區域幾輪", "決賽區第一輪");
                       User_4.Parameters.AddWithValue("@日期", str);
                       User_4.ExecuteNonQuery();

                       if (a > b)
                       {
                           Image70.ImageUrl = "~/img/普通LR.jpg";
                           arr4[6] += 1;
                       }
                       else if (a < b)
                       {
                           Image70.ImageUrl = "~/img/普通RR.jpg";
                           arr4[7] += 1;
                       }
                   }
               }*/
            //第一輪結束

          /*  if (TextBox125.Text != "" && TextBox126.Text != "")
            {
                a = Convert.ToInt32(TextBox125.Text);
                b = Convert.ToInt32(TextBox126.Text);
                if (a != b)
                {
                    Label237.Text += a;
                    Label238.Text += b;
                    TextBox125.Visible = false;
                    TextBox126.Visible = false;
                    TextBox125.Text = "";
                    TextBox126.Text = "";
                    TextBox123.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_5 = new SqlCommand(inscmd, con);
                    User_5.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_5.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_5.Parameters.AddWithValue("@賽制", "16人雙淘汰");

                    User_5.Parameters.AddWithValue("@隊伍A", Label241.Text);


                    User_5.Parameters.AddWithValue("@分數A", a);

                    User_5.Parameters.AddWithValue("@隊伍B", Label243.Text);


                    User_5.Parameters.AddWithValue("@分數B", b);
                    User_5.Parameters.AddWithValue("@區域幾輪", "決賽區第二輪");
                    User_5.Parameters.AddWithValue("@日期", str);
                    User_5.ExecuteNonQuery();

                    if (a > b)
                    {

                        Image65.ImageUrl = "~/img/大普通LR.jpg";
                        arr4[0] += 2;
                        arr4[1] += 1;
                    }
                    else if (a < b)
                    {

                        Image65.ImageUrl = "~/img/大普通RR.jpg";
                        arr4[2] += 2;
                        arr4[3] += 1;
                    }
                }
            }//-1
            if (TextBox127.Text != "" && TextBox128.Text != "")
            {
                a = Convert.ToInt32(TextBox127.Text);
                b = Convert.ToInt32(TextBox128.Text);
                if (a != b)
                {
                    Label239.Text += a;
                    Label240.Text += b;
                    TextBox127.Visible = false;
                    TextBox128.Visible = false;
                    TextBox127.Text = "";
                    TextBox128.Text = "";
                    TextBox124.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_6 = new SqlCommand(inscmd, con);
                    User_6.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_6.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_6.Parameters.AddWithValue("@賽制", "16人雙淘汰");


                    User_6.Parameters.AddWithValue("@隊伍A", Label245.Text);



                    User_6.Parameters.AddWithValue("@分數A", a);

                    User_6.Parameters.AddWithValue("@隊伍B", Label247.Text);

                    User_6.Parameters.AddWithValue("@分數B", b);
                    User_6.Parameters.AddWithValue("@區域幾輪", "決賽區第二輪");
                    User_6.Parameters.AddWithValue("@日期", str);
                    User_6.ExecuteNonQuery();

                    if (a > b)
                    {

                        Image66.ImageUrl = "~/img/大普通LR.jpg";
                        arr4[4] += 2;
                        arr4[5] += 1;
                    }
                    else if (a < b)
                    {

                        Image66.ImageUrl = "~/img/大普通RR.jpg";
                        arr4[6] += 2;
                        arr4[7] += 1;
                    }
                }
            }////-2*/

            //第二輪結束
            if (TextBox129.Text != "" && TextBox135.Text != "")
            {
                a = Convert.ToInt32(TextBox129.Text);
                b = Convert.ToInt32(TextBox135.Text);
                if (a != b)
                {
                    Label249.Text += a;
                    Label255.Text += b;
                    TextBox129.Visible = false;
                    TextBox135.Visible = false;
                    TextBox129.Text = "";
                    TextBox135.Text = "";
                    Label234.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_7 = new SqlCommand(inscmd, con);
                    User_7.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_7.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_7.Parameters.AddWithValue("@賽制", "8人雙淘汰");
                    
                    
                    
                    User_7.Parameters.AddWithValue("@隊伍A", Label241.Text);

                    User_7.Parameters.AddWithValue("@分數A", a);

                    User_7.Parameters.AddWithValue("@隊伍B", Label247.Text);
                    
                    User_7.Parameters.AddWithValue("@分數B", b);
                    User_7.Parameters.AddWithValue("@區域幾輪", "決賽區總決賽");
                    User_7.Parameters.AddWithValue("@日期", str);
                    User_7.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image19.ImageUrl = "~/img/大大普通LR.jpg";
                        arr4[0] += 2;

                    }
                    else if (a < b)
                    {
                        Image19.ImageUrl = "~/img/大大普通RR.jpg";
                        arr4[6] += 2;

                    }
                }
            }

            //OVER

            /*  if (c == 0 & TextBox1.Visible == false & TextBox2.Visible == false & TextBox3.Visible == false & TextBox4.Visible
                  == false & TextBox5.Visible == false & TextBox6.Visible == false & TextBox7.Visible == false & TextBox8.Visible == false
                  /*& Label11.Text!="" & Label12.Text!="" & Label13.Text!="" & Label14.Text!="" & Label15.Text!="" & Label16.Text!="" & Label17.Text!="" &
                  Label18.Text!=""*/
            /*)
{
c++;
TextBox9.Visible = true;
TextBox10.Visible = true;
TextBox11.Visible = true;
TextBox12.Visible = true;
}
else if (d == 0 & TextBox9.Visible == false & TextBox10.Visible == false & TextBox11.Visible == false & TextBox12.Visible == false & TextBox1.Visible == false & TextBox2.Visible == false & TextBox3.Visible == false & TextBox4.Visible
== false & TextBox5.Visible == false & TextBox6.Visible == false & TextBox7.Visible == false & TextBox8.Visible == false)
{
d++;
TextBox13.Visible = true;
TextBox14.Visible = true;
}
else if (c == 1 & d == 1 & f == 0 & TextBox13.Visible == false & TextBox14.Visible == false)
{
c = 0;
d = 0;
f = 0;
Button1.Visible = false;
}*/


            if (arr4[0] > arr4[1] && arr4[0] > arr4[2] & arr4[0] > arr4[3] & arr4[0] > arr4[4] & arr4[0] > arr4[5] & arr4[0] > arr4[6] & arr4[0] > arr4[7] & Label234.Visible == true)
            {
                Label234.Text = Label241.Text;
            }
            else if (arr4[6] > arr4[1] && arr4[6] > arr4[2] & arr4[6] > arr4[3] & arr4[6] > arr4[4] & arr4[6] > arr4[5] & arr4[6] > arr4[0] & arr4[6] > arr4[7] & Label234.Visible == true)
            {
                Label234.Text = Label247.Text;
            }

            if (Label234.Text != "")
            {
                //TextBox129.Visible = true;
                Button8.Visible = false;
                arr4[0] = 0;
                arr4[1] = 0;
                arr4[2] = 0;
                arr4[3] = 0;
                arr4[4] = 0;
                arr4[5] = 0;
                arr4[6] = 0;
                arr4[7] = 0;

            }
            con.Close();
        }//////////決賽要改喔

        protected void Button15_Click(object sender, EventArgs e) /////////A區敗部復活
        {
            int a = 0;
            int b = 0;

            DateTime date = DateTime.Now;
            String str = date.ToString();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            string inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
            SqlCommand User = new SqlCommand(inscmd, con);

            if (TextBox73.Text != "" && TextBox74.Text != "")
            {

                a = Convert.ToInt32(TextBox73.Text);
                b = Convert.ToInt32(TextBox74.Text);
                if (a != b)
                {
                    Label157.Text += a;
                    Label158.Text += b;
                    TextBox73.Visible = false;
                    TextBox74.Visible = false;
                    TextBox73.Text = "";
                    TextBox74.Text = "";
                    TextBox69.Visible = true; //開啟上面

                    User.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User.Parameters.AddWithValue("@賽制", "8人雙淘汰");
                    User.Parameters.AddWithValue("@隊伍A", Label149.Text);
                    User.Parameters.AddWithValue("@分數A", a);
                    User.Parameters.AddWithValue("@隊伍B", Label150.Text);
                    User.Parameters.AddWithValue("@分數B", b);
                    User.Parameters.AddWithValue("@區域幾輪", "A區敗部第一輪");
                    User.Parameters.AddWithValue("@日期", str);
                    User.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image39.ImageUrl = "~/img/普通LR.jpg";
                        arr6[0] += 1;
                    }
                    else if (a < b)
                    {
                        Image39.ImageUrl = "~/img/普通RR.jpg";
                        arr6[1] += 1;
                    }
                }
            }
            if (TextBox75.Text != "" && TextBox76.Text != "")
            {
                a = Convert.ToInt32(TextBox75.Text);
                b = Convert.ToInt32(TextBox76.Text);
                if (a != b)
                {
                    Label159.Text += a;
                    Label160.Text += b;
                    TextBox75.Visible = false;
                    TextBox76.Visible = false;
                    TextBox75.Text = "";
                    TextBox76.Text = "";
                    TextBox70.Visible = true; //開啟上面

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_2 = new SqlCommand(inscmd, con);
                    User_2.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_2.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_2.Parameters.AddWithValue("@賽制", "8人雙淘汰");
                    User_2.Parameters.AddWithValue("@隊伍A", Label151.Text);
                    User_2.Parameters.AddWithValue("@分數A", a);
                    User_2.Parameters.AddWithValue("@隊伍B", Label152.Text);
                    User_2.Parameters.AddWithValue("@分數B", b);
                    User_2.Parameters.AddWithValue("@區域幾輪", "A區敗部第一輪");
                    User_2.Parameters.AddWithValue("@日期", str);
                    User_2.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image40.ImageUrl = "~/img/普通LR.jpg";
                        arr6[2] += 1;
                    }
                    else if (a < b)
                    {
                        Image40.ImageUrl = "~/img/普通RR.jpg";
                        arr6[3] += 1;
                    }
                }
            }
            if (TextBox77.Text != "" && TextBox78.Text != "")
            {
                a = Convert.ToInt32(TextBox77.Text);
                b = Convert.ToInt32(TextBox78.Text);
                if (a != b)
                {
                    Label161.Text += a;
                    Label162.Text += b;
                    TextBox77.Visible = false;
                    TextBox78.Visible = false;
                    TextBox77.Text = "";
                    TextBox78.Text = "";
                    TextBox71.Visible = true; //開啟上面

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_3 = new SqlCommand(inscmd, con);
                    User_3.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_3.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_3.Parameters.AddWithValue("@賽制", "8人雙淘汰");
                    User_3.Parameters.AddWithValue("@隊伍A", Label153.Text);
                    User_3.Parameters.AddWithValue("@分數A", a);
                    User_3.Parameters.AddWithValue("@隊伍B", Label154.Text);
                    User_3.Parameters.AddWithValue("@分數B", b);
                    User_3.Parameters.AddWithValue("@區域幾輪", "A區敗部第一輪");
                    User_3.Parameters.AddWithValue("@日期", str);
                    User_3.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image41.ImageUrl = "~/img/普通LR.jpg";
                        arr6[4] += 1;
                    }
                    else if (a < b)
                    {
                        Image41.ImageUrl = "~/img/普通RR.jpg";
                        arr6[5] += 1;
                    }
                }
            }


            //第一輪結束

            if (TextBox69.Text != "" && TextBox70.Text != "")
            {
                a = Convert.ToInt32(TextBox69.Text);
                b = Convert.ToInt32(TextBox70.Text);
                if (a != b)
                {
                    Label145.Text += a;
                    Label146.Text += b;
                    TextBox69.Visible = false;
                    TextBox70.Visible = false;
                    TextBox69.Text = "";
                    TextBox70.Text = "";
                    TextBox67.Visible = true; //開啟上面

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_5 = new SqlCommand(inscmd, con);
                    User_5.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_5.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_5.Parameters.AddWithValue("@賽制", "8人雙淘汰");
                    if (arr6[0] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label149.Text);
                    }
                    else if (arr6[1] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label150.Text);
                    }

                    User_5.Parameters.AddWithValue("@分數A", a);

                    if (arr6[2] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍B", Label151.Text);
                    }
                    else if (arr6[3] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍B", Label152.Text);
                    }

                    User_5.Parameters.AddWithValue("@分數B", b);
                    User_5.Parameters.AddWithValue("@區域幾輪", "A區敗部第二輪");
                    User_5.Parameters.AddWithValue("@日期", str);
                    User_5.ExecuteNonQuery();


                    if (a > b)
                    {

                        Image37.ImageUrl = "~/img/大普通LR.jpg";
                        arr6[0] += 1;
                        arr6[1] += 1;
                    }
                    else if (a < b)
                    {
                        Image37.ImageUrl = "~/img/大普通RR.jpg";
                        arr6[2] += 1;
                        arr6[3] += 1;
                    }
                }
            }
            if (TextBox71.Text != "" && TextBox72.Text != "")
            {
                a = Convert.ToInt32(TextBox71.Text);
                b = Convert.ToInt32(TextBox72.Text);
                if (a != b)
                {
                    Label147.Text += a;
                    Label148.Text += b;
                    TextBox71.Visible = false;
                    TextBox72.Visible = false;
                    TextBox71.Text = "";
                    TextBox72.Text = "";
                    TextBox68.Visible = true; //開啟上面

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_6 = new SqlCommand(inscmd, con);
                    User_6.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_6.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_6.Parameters.AddWithValue("@賽制", "8人雙淘汰");
                    if (arr6[4] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label153.Text);
                    }
                    else if (arr6[5] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label154.Text);
                    }

                    User_6.Parameters.AddWithValue("@分數A", a);

                    User_6.Parameters.AddWithValue("@隊伍B", Label155.Text);

                    User_6.Parameters.AddWithValue("@分數B", b);
                    User_6.Parameters.AddWithValue("@區域幾輪", "A區敗部第二輪");
                    User_6.Parameters.AddWithValue("@日期", str);
                    User_6.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image38.ImageUrl = "~/img/大普通LR.jpg";
                        arr6[4] += 1;
                        arr6[5] += 1;
                    }
                    else if (a < b)
                    {

                        Image38.ImageUrl = "~/img/大普通RR.jpg";
                        arr6[6] += 2;
                        arr6[7] += 1;
                    }
                }
            }

            //第二輪結束
            if (TextBox67.Text != "" && TextBox68.Text != "")
            {
                a = Convert.ToInt32(TextBox67.Text);
                b = Convert.ToInt32(TextBox68.Text);
                if (a != b)
                {
                    Label143.Text += a;
                    Label144.Text += b;
                    TextBox67.Visible = false;
                    TextBox68.Visible = false;
                    TextBox67.Text = "";
                    TextBox68.Text = "";
                    Label142.Visible = true; //必改

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_7 = new SqlCommand(inscmd, con);
                    User_7.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_7.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_7.Parameters.AddWithValue("@賽制", "8人雙淘汰");
                    if (arr6[0] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label149.Text);
                    }
                    else if (arr6[1] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label150.Text);
                    }
                    else if (arr6[2] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label151.Text);
                    }
                    else if (arr6[3] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label152.Text);
                    }

                    User_7.Parameters.AddWithValue("@分數A", a);

                    if (arr6[4] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label153.Text);
                    }
                    else if (arr6[5] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label154.Text);
                    }
                    else if (arr6[6] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label155.Text);
                    }


                    User_7.Parameters.AddWithValue("@分數B", b);
                    User_7.Parameters.AddWithValue("@區域幾輪", "A區敗部第三輪");
                    User_7.Parameters.AddWithValue("@日期", str);
                    User_7.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image36.ImageUrl = "~/img/大大普通LR.jpg";
                        arr6[0] += 1;
                        arr6[1] += 1;
                        arr6[2] += 1;
                        arr6[3] += 1;
                    }
                    else if (a < b)
                    {

                        Image36.ImageUrl = "~/img/大大普通RR.jpg";
                        arr6[4] += 1;
                        arr6[5] += 1;
                        arr6[6] += 1;
                        arr6[7] += 1;
                    }
                }
            }

            //OVER

            /*    if (c == 0 & TextBox1.Visible == false & TextBox2.Visible == false & TextBox3.Visible == false & TextBox4.Visible
                    == false & TextBox5.Visible == false & TextBox6.Visible == false & TextBox7.Visible == false & TextBox8.Visible == false
                    /*& Label11.Text!="" & Label12.Text!="" & Label13.Text!="" & Label14.Text!="" & Label15.Text!="" & Label16.Text!="" & Label17.Text!="" &
                    Label18.Text!=""*/
            /*)
{
c++;
TextBox9.Visible = true;
TextBox10.Visible = true;
TextBox11.Visible = true;
TextBox12.Visible = true;
}
else if (d == 0 & TextBox9.Visible == false & TextBox10.Visible == false & TextBox11.Visible == false & TextBox12.Visible == false & TextBox1.Visible == false & TextBox2.Visible == false & TextBox3.Visible == false & TextBox4.Visible
== false & TextBox5.Visible == false & TextBox6.Visible == false & TextBox7.Visible == false & TextBox8.Visible == false)
{
d++;
TextBox13.Visible = true;
TextBox14.Visible = true;
}
else if (c == 1 & d == 1 & f == 0 & TextBox13.Visible == false & TextBox14.Visible == false)
{
c = 0;
d = 0;
f = 0;
Button1.Visible = false;
}*/


            if (arr6[0] > arr6[1] && arr6[0] > arr6[2] & arr6[0] > arr6[3] & arr6[0] > arr6[4] & arr6[0] > arr6[5] & arr6[0] > arr6[6] & arr6[0] > arr6[7] & Label142.Visible == true)
            {
                Label142.Text = Label149.Text;
                Label247.Text = Label142.Text;
            }
            else if (arr6[1] > arr6[0] && arr6[1] > arr6[2] & arr6[1] > arr6[3] & arr6[1] > arr6[4] & arr6[1] > arr6[5] & arr6[1] > arr6[6] & arr6[1] > arr6[7] & Label142.Visible == true)
            {
                Label142.Text = Label150.Text;
                Label247.Text = Label142.Text;
            }
            else if (arr6[2] > arr6[1] && arr6[2] > arr6[0] & arr6[2] > arr6[3] & arr6[2] > arr6[4] & arr6[2] > arr6[5] & arr6[2] > arr6[6] & arr6[2] > arr6[7] & Label142.Visible == true)
            {
                Label142.Text = Label151.Text;
                Label247.Text = Label142.Text;
            }
            else if (arr6[3] > arr6[1] && arr6[3] > arr6[2] & arr6[3] > arr6[0] & arr6[3] > arr6[4] & arr6[3] > arr6[5] & arr6[3] > arr6[6] & arr6[3] > arr6[7] & Label142.Visible == true)
            {
                Label142.Text = Label152.Text;
                Label247.Text = Label142.Text;
            }
            else if (arr6[4] > arr6[1] && arr6[4] > arr6[2] & arr6[4] > arr6[3] & arr6[4] > arr6[0] & arr6[4] > arr6[5] & arr6[4] > arr6[6] & arr6[4] > arr6[7] & Label142.Visible == true)
            {
                Label142.Text = Label153.Text;
                Label247.Text = Label142.Text;
            }
            else if (arr6[5] > arr6[1] && arr6[5] > arr6[2] & arr6[5] > arr6[3] & arr6[5] > arr6[4] & arr6[5] > arr6[0] & arr6[5] > arr6[6] & arr6[5] > arr6[7] & Label142.Visible == true)
            {
                Label142.Text = Label154.Text;
                Label247.Text = Label142.Text;
            }
            else if (arr6[6] > arr6[1] && arr6[6] > arr6[2] & arr6[6] > arr6[3] & arr6[6] > arr6[4] & arr6[6] > arr6[5] & arr6[6] > arr6[0] & arr6[6] > arr6[7] & Label142.Visible == true)
            {
                Label142.Text = Label155.Text;
                Label247.Text = Label142.Text;
            }
            /*   else if (arr2[7] > arr2[1] && arr2[7] > arr2[2] & arr2[7] > arr2[3] & arr2[7] > arr2[4] & arr2[7] > arr2[5] & arr2[7] > arr2[6] & arr2[7] > arr2[0] & Label67.Visible == true)
               {
                   Label67.Text = Label8.Text;
                   Label69.Text = Label67.Text;
               }*/
            //沒第八隊

            if (Label142.Text == Label247.Text)  //最後改
            {
                TextBox135.Visible = true;
                Button15.Visible = false;
                arr6[0] = 0;
                arr6[1] = 0;
                arr6[2] = 0;
                arr6[3] = 0;
                arr6[4] = 0;
                arr6[5] = 0;
                arr6[6] = 0;
                arr6[7] = 0;

            }
            con.Close();
        }

    }
}