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
    public partial class Nineteenth : System.Web.UI.Page
    {

        static int[] arr = new int[8];//B區專用
        static int[] arr2 = new int[8];//A區專用
        static int[] arr3 = new int[8];//C區專用
        static int[] arr4 = new int[8];///決賽用
        static int[] arr5 = new int[8]; //D區專用   

        static int[] arr6 = new int[8];//A區敗部//
        static int[] arr7 = new int[8];//B區敗部//
        static int[] arr8 = new int[8];//C區敗部//
        static int[] arr9 = new int[8];//D區敗部// 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["New"] != null)
                {
                    if (Session["New"].ToString() == "zxcv45628789@gmail.com")
                    {
                        Button1.Visible = true;
                        Button5.Visible = true;
                        Button11.Visible = true;

                        Label34.Text = "歡迎" + "管理員" + "登入";

                        Random r = new Random();
                        String[] s = new String[19];
                        int j = 0;
                        for (int i = 0; i < s.Length; i++)
                        {
                            s[i] = "";
                        }


                        if (Session["Seed team"] != null)/////有種子時
                        {
                            s[18] = Session["Seed team"].ToString();

                            for (int i = 0; i < GridView1.Rows.Count; i++)
                            {
                                if (GridView1.Rows[i].Cells[1].Text == Session["Registration name"].ToString() & GridView1.Rows[i].Cells[4].Text == Session["Entries"].ToString() & GridView1.Rows[i].Cells[2].Text.ToString() != Session["Seed team"].ToString())
                                {
                                    while (true)
                                    {
                                        j = r.Next(0, 18);
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

                            ///////////////////////7
                            Label41.Text = s[8];
                            Label42.Text = s[9];
                            Label43.Text = s[10];

                            Label45.Text = s[12];
                            Label46.Text = s[13];
                            Label47.Text = s[14];

                            ///////////////////////6
                            Label80.Text = s[16];
                            Label81.Text = s[17];
                            Label82.Text = s[11];


                            Label84.Text = s[7];
                            Label85.Text = s[15];

                            Label86.Text = s[18];/////種子
                            /////////////////////////////////6


                        }
                        else  ///沒種子時
                        {
                            for (int i = 0; i < GridView1.Rows.Count; i++)
                            {
                                if (GridView1.Rows[i].Cells[1].Text == Session["Registration name"].ToString() & GridView1.Rows[i].Cells[4].Text == Session["Entries"].ToString())
                                {
                                    while (true)
                                    {
                                        j = r.Next(0, 19);
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

                            ///////////////////////7
                            Label41.Text = s[8];
                            Label42.Text = s[9];
                            Label43.Text = s[10];

                            Label45.Text = s[12];
                            Label46.Text = s[13];
                            Label47.Text = s[14];

                            /////////////////////////6
                            Label80.Text = s[16];
                            Label81.Text = s[17];
                            Label82.Text = s[18];


                            Label84.Text = s[11];
                            Label85.Text = s[7];

                            Label86.Text = s[15];
                            //////////////////////////6


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
                    Label257.Text = Session["Registration name"] + "「" + Session["Entries"] + "」";   ////設置大標題是甚麼
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
                    User.Parameters.AddWithValue("@賽制", "19人雙淘汰");
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
                    User_2.Parameters.AddWithValue("@賽制", "19人雙淘汰");
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
                    User_3.Parameters.AddWithValue("@賽制", "19人雙淘汰");
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
            /*     if (TextBox7.Text != "" && TextBox8.Text != "")
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
                         User_4.Parameters.AddWithValue("@賽制", "21人雙淘汰");
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
                 }*/
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
                    User_5.Parameters.AddWithValue("@賽制", "19人雙淘汰");
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
                    User_6.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    if (arr2[4] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label5.Text);
                    }
                    else if (arr2[5] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label6.Text);
                    }

                    User_6.Parameters.AddWithValue("@分數A", a);

                    User_6.Parameters.AddWithValue("@隊伍B", Label7.Text);

                    User_6.Parameters.AddWithValue("@分數B", b);
                    User_6.Parameters.AddWithValue("@區域幾輪", "A區第二輪");
                    User_6.Parameters.AddWithValue("@日期", str);
                    User_6.ExecuteNonQuery();

                    if (a > b)
                    {
                        Label154.Text = Label7.Text;

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
                        arr2[6] += 2;
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
                    User_7.Parameters.AddWithValue("@賽制", "19人雙淘汰");
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

        protected void Button5_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;



            DateTime date = DateTime.Now;
            String str = date.ToString();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            string inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
            SqlCommand User = new SqlCommand(inscmd, con);

            if (TextBox16.Text != "" && TextBox17.Text != "")
            {
                a = Convert.ToInt32(TextBox16.Text);
                b = Convert.ToInt32(TextBox17.Text);

                if (a != b)
                {
                    Label49.Text += a;
                    Label50.Text += b;
                    TextBox16.Visible = false;
                    TextBox17.Visible = false;
                    TextBox16.Text = "";
                    TextBox17.Text = "";
                    TextBox24.Visible = true;

                    User.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    User.Parameters.AddWithValue("@隊伍A", Label41.Text);
                    User.Parameters.AddWithValue("@分數A", a);
                    User.Parameters.AddWithValue("@隊伍B", Label42.Text);
                    User.Parameters.AddWithValue("@分數B", b);
                    User.Parameters.AddWithValue("@區域幾輪", "B區第一輪");
                    User.Parameters.AddWithValue("@日期", str);
                    User.ExecuteNonQuery();

                    if (a > b)
                    {
                        Label172.Text = Label42.Text;
                        Image15.ImageUrl = "~/img/普通LR.jpg";
                        arr[0] += 1;
                    }
                    else if (a < b)
                    {
                        Label172.Text = Label41.Text;
                        Image15.ImageUrl = "~/img/普通RR.jpg";
                        arr[1] += 1;
                    }
                }
            }
          /*  if (TextBox18.Text != "" && TextBox19.Text != "")
            {
                a = Convert.ToInt32(TextBox18.Text);
                b = Convert.ToInt32(TextBox19.Text);
                if (a != b)
                {
                    Label51.Text += a;
                    Label52.Text += b;
                    TextBox18.Visible = false;
                    TextBox19.Visible = false;
                    TextBox18.Text = "";
                    TextBox19.Text = "";
                    TextBox25.Visible = true;
                    Button16.Visible = true;//B區敗部

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_2 = new SqlCommand(inscmd, con);
                    User_2.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_2.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_2.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    User_2.Parameters.AddWithValue("@隊伍A", Label43.Text);
                    User_2.Parameters.AddWithValue("@分數A", a);
                    User_2.Parameters.AddWithValue("@隊伍B", Label44.Text);
                    User_2.Parameters.AddWithValue("@分數B", b);
                    User_2.Parameters.AddWithValue("@區域幾輪", "B區第一輪");
                    User_2.Parameters.AddWithValue("@日期", str);
                    User_2.ExecuteNonQuery();

                    if (a > b)
                    {
                        Label173.Text = Label44.Text;
                        Image16.ImageUrl = "~/img/普通LR.jpg";
                        arr[2] += 1;
                    }
                    else if (a < b)
                    {
                        Label173.Text = Label43.Text;
                        Image16.ImageUrl = "~/img/普通RR.jpg";
                        arr[3] += 1;
                    }
                }
            }*/
            if (TextBox20.Text != "" && TextBox21.Text != "")
            {
                a = Convert.ToInt32(TextBox20.Text);
                b = Convert.ToInt32(TextBox21.Text);
                if (a != b)
                {
                    Label53.Text += a;
                    Label54.Text += b;
                    TextBox20.Visible = false;
                    TextBox21.Visible = false;
                    TextBox20.Text = "";
                    TextBox21.Text = "";
                    TextBox26.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_3 = new SqlCommand(inscmd, con);
                    User_3.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_3.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_3.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    User_3.Parameters.AddWithValue("@隊伍A", Label45.Text);
                    User_3.Parameters.AddWithValue("@分數A", a);
                    User_3.Parameters.AddWithValue("@隊伍B", Label46.Text);
                    User_3.Parameters.AddWithValue("@分數B", b);
                    User_3.Parameters.AddWithValue("@區域幾輪", "B區第一輪");
                    User_3.Parameters.AddWithValue("@日期", str);
                    User_3.ExecuteNonQuery();

                    if (a > b)
                    {
                        Label173.Text = Label46.Text;
                        Image17.ImageUrl = "~/img/普通LR.jpg";
                        arr[4] += 1;
                    }
                    else if (a < b)
                    {
                        Label173.Text = Label45.Text;
                        Image17.ImageUrl = "~/img/普通RR.jpg";
                        arr[5] += 1;
                    }
                }
            }
            /*   if (TextBox22.Text != "" && TextBox23.Text != "")
               {
                   a = Convert.ToInt32(TextBox22.Text);
                   b = Convert.ToInt32(TextBox23.Text);
                   if (a != b)
                   {
                       Label55.Text += a;
                       Label56.Text += b;
                       TextBox22.Visible = false;
                       TextBox23.Visible = false;
                       TextBox22.Text = "";
                       TextBox23.Text = "";
                       TextBox27.Visible = true;
                       Button16.Visible = true;//B區敗部

                       inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                       SqlCommand User_4 = new SqlCommand(inscmd, con);
                       User_4.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                       User_4.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                       User_4.Parameters.AddWithValue("@賽制", "23人雙淘汰");
                       User_4.Parameters.AddWithValue("@隊伍A", Label47.Text);
                       User_4.Parameters.AddWithValue("@分數A", a);
                       User_4.Parameters.AddWithValue("@隊伍B", Label48.Text);
                       User_4.Parameters.AddWithValue("@分數B", b);
                       User_4.Parameters.AddWithValue("@區域幾輪", "B區第一輪");
                       User_4.Parameters.AddWithValue("@日期", str);
                       User_4.ExecuteNonQuery();

                       if (a > b)
                       {
                           Label175.Text = Label48.Text;
                           Image18.ImageUrl = "~/img/普通LR.jpg";
                           arr[6] += 1;
                       }
                       else if (a < b)
                       {
                           Label175.Text = Label47.Text;
                           Image18.ImageUrl = "~/img/普通RR.jpg";
                           arr[7] += 1;
                       }
                   }
               }*/
            //第一輪結束

            if (TextBox24.Text != "" && TextBox25.Text != "")
            {
                a = Convert.ToInt32(TextBox24.Text);
                b = Convert.ToInt32(TextBox25.Text);
                if (a != b)
                {
                    Label37.Text += a;
                    Label38.Text += b;
                    TextBox24.Visible = false;
                    TextBox25.Visible = false;
                    TextBox24.Text = "";
                    TextBox25.Text = "";
                    TextBox28.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_5 = new SqlCommand(inscmd, con);
                    User_5.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_5.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_5.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    if (arr[0] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label41.Text);
                    }
                    else if (arr[1] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label42.Text);
                    }

                    User_5.Parameters.AddWithValue("@分數A", a);

                    
                    User_5.Parameters.AddWithValue("@隊伍B", Label43.Text);


                    User_5.Parameters.AddWithValue("@分數B", b);
                    User_5.Parameters.AddWithValue("@區域幾輪", "B區第二輪");
                    User_5.Parameters.AddWithValue("@日期", str);
                    User_5.ExecuteNonQuery();

                    if (a > b)
                    {
                        
                        Label176.Text = Label43.Text;

                        Image9.ImageUrl = "~/img/大普通LR.jpg";
                        arr[0] += 1;
                        arr[1] += 1;
                    }
                    else if (a < b)
                    {
                        if (arr[0] > arr[1])
                        {
                            Label176.Text = Label41.Text;
                        }
                        else if (arr[0] < arr[1])
                        {
                            Label176.Text = Label42.Text;
                        }
                        Image9.ImageUrl = "~/img/大普通RR.jpg";
                        arr[2] += 2;
                        arr[3] += 1;
                    }
                }
            }//// -1
            if (TextBox26.Text != "" && TextBox27.Text != "")
            {
                a = Convert.ToInt32(TextBox26.Text);
                b = Convert.ToInt32(TextBox27.Text);
                if (a != b)
                {
                    Label39.Text += a;
                    Label40.Text += b;
                    TextBox26.Visible = false;
                    TextBox27.Visible = false;
                    TextBox26.Text = "";
                    TextBox27.Text = "";
                    TextBox29.Visible = true;
                    Button16.Visible = true;//B區敗部

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_6 = new SqlCommand(inscmd, con);
                    User_6.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_6.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_6.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    if (arr[4] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label45.Text);
                    }
                    else if (arr[5] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label46.Text);
                    }

                    User_6.Parameters.AddWithValue("@分數A", a);


                    User_6.Parameters.AddWithValue("@隊伍B", Label47.Text);

                    User_6.Parameters.AddWithValue("@分數B", b);
                    User_6.Parameters.AddWithValue("@區域幾輪", "B區第二輪");
                    User_6.Parameters.AddWithValue("@日期", str);
                    User_6.ExecuteNonQuery();

                    if (a > b)
                    {

                        Label174.Text = Label47.Text;

                        Image10.ImageUrl = "~/img/大普通LR.jpg";
                        arr[4] += 1;
                        arr[5] += 1;
                    }
                    else if (a < b)
                    {
                        if (arr[4] > arr[5])
                        {
                            Label174.Text = Label45.Text;
                        }
                        else if (arr[4] < arr[5])
                        {
                            Label174.Text = Label46.Text;
                        }
                        Image10.ImageUrl = "~/img/大普通RR.jpg";
                        arr[6] += 2;
                        arr[7] += 1;
                    }
                }
            }//////-2

            //第二輪結束
            if (TextBox28.Text != "" && TextBox29.Text != "")
            {
                a = Convert.ToInt32(TextBox28.Text);
                b = Convert.ToInt32(TextBox29.Text);
                if (a != b)
                {
                    Label35.Text += a;
                    Label36.Text += b;
                    TextBox28.Visible = false;
                    TextBox29.Visible = false;
                    TextBox28.Text = "";
                    TextBox29.Text = "";
                    Label66.Visible = true;
                    Button16.Visible = true;//B區敗部

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_7 = new SqlCommand(inscmd, con);
                    User_7.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_7.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_7.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    if (arr[0] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label41.Text);
                    }
                    else if (arr[1] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label42.Text);
                    }
                    else if (arr[2] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label43.Text);
                    }
                    else if (arr[3] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label44.Text);
                    }

                    User_7.Parameters.AddWithValue("@分數A", a);

                    if (arr[4] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label45.Text);
                    }
                    else if (arr[5] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label46.Text);
                    }
                    else if (arr[6] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label47.Text);
                    }
                    else if (arr[7] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label48.Text);
                    }

                    User_7.Parameters.AddWithValue("@分數B", b);
                    User_7.Parameters.AddWithValue("@區域幾輪", "B區第三輪");
                    User_7.Parameters.AddWithValue("@日期", str);
                    User_7.ExecuteNonQuery();

                    if (a > b)
                    {
                        if (arr[4] > arr[5] & arr[4] > arr[6] & arr[4] > arr[7])
                        {
                            Label178.Text = Label45.Text;
                        }
                        else if (arr[5] > arr[4] & arr[5] > arr[6] & arr[5] > arr[7])
                        {
                            Label178.Text = Label46.Text;
                        }
                        else if (arr[6] > arr[4] & arr[6] > arr[5] & arr[6] > arr[7])
                        {
                            Label178.Text = Label47.Text;
                        }
                        else if (arr[7] > arr[4] & arr[7] > arr[5] & arr[7] > arr[6])
                        {
                            Label178.Text = Label48.Text;
                        }
                        Image8.ImageUrl = "~/img/大大普通LR.jpg";
                        arr[0] += 1;
                        arr[1] += 1;
                        arr[2] += 1;
                        arr[3] += 1;
                    }
                    else if (a < b)
                    {
                        if (arr[0] > arr[1] & arr[0] > arr[2] & arr[0] > arr[3])
                        {
                            Label178.Text = Label41.Text;
                        }
                        else if (arr[1] > arr[0] & arr[1] > arr[2] & arr[1] > arr[3])
                        {
                            Label178.Text = Label42.Text;
                        }
                        else if (arr[2] > arr[0] & arr[2] > arr[1] & arr[2] > arr[3])
                        {
                            Label178.Text = Label43.Text;
                        }
                        else if (arr[3] > arr[0] & arr[3] > arr[2] & arr[3] > arr[0])
                        {
                            Label178.Text = Label44.Text;
                        }
                        Image8.ImageUrl = "~/img/大大普通RR.jpg";
                        arr[4] += 1;
                        arr[5] += 1;
                        arr[6] += 1;
                        arr[7] += 1;
                    }

                }
            }
            //OVER

            /* if (c == 0 & TextBox23.Visible == false & TextBox16.Visible == false & TextBox17.Visible == false & TextBox18.Visible
                 == false & TextBox19.Visible == false & TextBox20.Visible == false & TextBox21.Visible == false & TextBox22.Visible == false
                 /*& Label11.Text!="" & Label12.Text!="" & Label13.Text!="" & Label14.Text!="" & Label15.Text!="" & Label16.Text!="" & Label17.Text!="" &
                 Label18.Text!="")
             {
                 c++;
                 TextBox24.Visible = true;
                 TextBox25.Visible = true;
                 TextBox26.Visible = true;
                 TextBox27.Visible = true;
             }
             else if (d == 0 & TextBox24.Visible == false & TextBox25.Visible == false & TextBox26.Visible == false & TextBox27.Visible == false & TextBox23.Visible == false & TextBox16.Visible == false & TextBox17.Visible == false & TextBox18.Visible
                 == false & TextBox19.Visible == false & TextBox20.Visible == false & TextBox21.Visible == false & TextBox22.Visible == false)
             {
                 d++;
                 TextBox28.Visible = true;
                 TextBox29.Visible = true;
             }
             else if (f == 0 & c == 1 & d == 1 & TextBox28.Visible == false & TextBox29.Visible == false)
             {
                 c = 0;
                 d = 0;
                 f = 0;
                 Button5.Visible = false;
             }
             */
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (arr[0] > arr[1] && arr[0] > arr[2] & arr[0] > arr[3] & arr[0] > arr[4] & arr[0] > arr[5] & arr[0] > arr[6] & arr[0] > arr[7] & Label66.Visible == true)
            {
                Label66.Text = Label41.Text;
                Label247.Text = Label66.Text;
            }
            else if (arr[1] > arr[0] && arr[1] > arr[2] & arr[1] > arr[3] & arr[1] > arr[4] & arr[1] > arr[5] & arr[1] > arr[6] & arr[1] > arr[7] & Label66.Visible == true)
            {
                Label66.Text = Label42.Text;
                Label247.Text = Label66.Text;
            }
            else if (arr[2] > arr[1] && arr[2] > arr[0] & arr[2] > arr[3] & arr[2] > arr[4] & arr[2] > arr[5] & arr[2] > arr[6] & arr[2] > arr[7] & Label66.Visible == true)
            {
                Label66.Text = Label43.Text;
                Label247.Text = Label66.Text;
            }
            else if (arr[3] > arr[1] && arr[3] > arr[2] & arr[3] > arr[0] & arr[3] > arr[4] & arr[3] > arr[5] & arr[3] > arr[6] & arr[3] > arr[7] & Label66.Visible == true)
            {
                Label66.Text = Label44.Text;
                Label247.Text = Label66.Text;
            }
            else if (arr[4] > arr[1] && arr[4] > arr[2] & arr[4] > arr[3] & arr[4] > arr[0] & arr[4] > arr[5] & arr[4] > arr[6] & arr[4] > arr[7] & Label66.Visible == true)
            {
                Label66.Text = Label45.Text;
                Label247.Text = Label66.Text;
            }
            else if (arr[5] > arr[1] && arr[5] > arr[2] & arr[5] > arr[3] & arr[5] > arr[4] & arr[5] > arr[0] & arr[5] > arr[6] & arr[5] > arr[7] & Label66.Visible == true)
            {
                Label66.Text = Label46.Text;
                Label247.Text = Label66.Text;

            }
            else if (arr[6] > arr[1] && arr[6] > arr[2] & arr[6] > arr[3] & arr[6] > arr[4] & arr[6] > arr[5] & arr[6] > arr[0] & arr[6] > arr[7] & Label66.Visible == true)
            {
                Label66.Text = Label47.Text;
                Label247.Text = Label66.Text;
            }
            else if (arr[7] > arr[1] && arr[7] > arr[2] & arr[7] > arr[3] & arr[7] > arr[4] & arr[7] > arr[5] & arr[7] > arr[6] & arr[7] > arr[0] & Label66.Visible == true)
            {
                Label66.Text = Label48.Text;
                Label247.Text = Label66.Text;
            }

            if (Label66.Text == Label247.Text)
            {
                TextBox135.Visible = true;
                Button5.Visible = false;
                // Label10.Text += "" + arr[0] + "" + arr[1] + "" + arr[2] + "" + arr[3] + "" + arr[4] + "" + arr[5] + "" + arr[6] + "" + arr[7];
                arr[0] = 0;
                arr[1] = 0;
                arr[2] = 0;
                arr[3] = 0;
                arr[4] = 0;
                arr[5] = 0;
                arr[6] = 0;
                arr[7] = 0;
            }

            con.Close();

        }//B區比賽

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
            if (TextBox131.Text != "" && TextBox132.Text != "")
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
                    User_2.Parameters.AddWithValue("@賽制", "19人雙淘汰");
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
                    User_3.Parameters.AddWithValue("@賽制", "19人雙淘汰");
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
            }
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

            if (TextBox125.Text != "" && TextBox126.Text != "")
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
                    User_5.Parameters.AddWithValue("@賽制", "19人雙淘汰");

                    User_5.Parameters.AddWithValue("@隊伍A", Label241.Text);


                    User_5.Parameters.AddWithValue("@分數A", a);

                    if (arr4[2] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍B", Label243.Text);
                    }
                    else if (arr4[3] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍B", Label244.Text);
                    }

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
                        arr4[2] += 1;
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
                    User_6.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    if (arr4[4] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label245.Text);
                    }
                    else if (arr4[5] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label246.Text);
                    }

                    User_6.Parameters.AddWithValue("@分數A", a);

                    User_6.Parameters.AddWithValue("@隊伍B", Label247.Text);

                    User_6.Parameters.AddWithValue("@分數B", b);
                    User_6.Parameters.AddWithValue("@區域幾輪", "決賽區第二輪");
                    User_6.Parameters.AddWithValue("@日期", str);
                    User_6.ExecuteNonQuery();

                    if (a > b)
                    {

                        Image66.ImageUrl = "~/img/大普通LR.jpg";
                        arr4[4] += 1;
                        arr4[5] += 1;
                    }
                    else if (a < b)
                    {

                        Image66.ImageUrl = "~/img/大普通RR.jpg";
                        arr4[6] += 2;
                        arr4[7] += 1;
                    }
                }
            }////-2

            //第二輪結束
            if (TextBox123.Text != "" && TextBox124.Text != "")
            {
                a = Convert.ToInt32(TextBox123.Text);
                b = Convert.ToInt32(TextBox124.Text);
                if (a != b)
                {
                    Label235.Text += a;
                    Label236.Text += b;
                    TextBox123.Visible = false;
                    TextBox124.Visible = false;
                    TextBox123.Text = "";
                    TextBox124.Text = "";
                    Label234.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_7 = new SqlCommand(inscmd, con);
                    User_7.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_7.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_7.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    if (arr4[0] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label241.Text);
                    }
                    else if (arr4[1] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label242.Text);
                    }
                    else if (arr4[2] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label243.Text);
                    }
                    else if (arr4[3] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label244.Text);
                    }

                    User_7.Parameters.AddWithValue("@分數A", a);

                    if (arr4[4] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label245.Text);
                    }
                    else if (arr4[5] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label246.Text);
                    }
                    else if (arr4[6] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label247.Text);
                    }
                    else if (arr4[7] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label248.Text);
                    }

                    User_7.Parameters.AddWithValue("@分數B", b);
                    User_7.Parameters.AddWithValue("@區域幾輪", "決賽區總決賽");
                    User_7.Parameters.AddWithValue("@日期", str);
                    User_7.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image64.ImageUrl = "~/img/大大普通LR.jpg";
                        arr4[0] += 1;
                        arr4[1] += 1;
                        arr4[2] += 1;
                        arr4[3] += 1;
                    }
                    else if (a < b)
                    {
                        Image64.ImageUrl = "~/img/大大普通RR.jpg";
                        arr4[4] += 1;
                        arr4[5] += 1;
                        arr4[6] += 1;
                        arr4[7] += 1;
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
            else if (arr4[1] > arr4[0] && arr4[1] > arr4[2] & arr4[1] > arr4[3] & arr4[1] > arr4[4] & arr4[1] > arr4[5] & arr4[1] > arr4[6] & arr4[1] > arr4[7] & Label234.Visible == true)
            {
                Label234.Text = Label242.Text;
            }
            else if (arr4[2] > arr4[1] && arr4[2] > arr4[0] & arr4[2] > arr4[3] & arr4[2] > arr4[4] & arr4[2] > arr4[5] & arr4[2] > arr4[6] & arr4[2] > arr4[7] & Label234.Visible == true)
            {
                Label234.Text = Label243.Text;
            }
            else if (arr4[3] > arr4[1] && arr4[3] > arr4[2] & arr4[3] > arr4[0] & arr4[3] > arr4[4] & arr4[3] > arr4[5] & arr4[3] > arr4[6] & arr4[3] > arr4[7] & Label234.Visible == true)
            {
                Label234.Text = Label244.Text;
            }
            else if (arr4[4] > arr4[1] && arr4[4] > arr4[2] & arr4[4] > arr4[3] & arr4[4] > arr4[0] & arr4[4] > arr4[5] & arr4[4] > arr4[6] & arr4[4] > arr4[7] & Label234.Visible == true)
            {
                Label234.Text = Label245.Text;
            }
            else if (arr4[5] > arr4[1] && arr4[5] > arr4[2] & arr4[5] > arr4[3] & arr4[5] > arr4[4] & arr4[5] > arr4[0] & arr4[5] > arr4[6] & arr4[5] > arr4[7] & Label234.Visible == true)
            {
                Label234.Text = Label246.Text;
            }
            else if (arr4[6] > arr4[1] && arr4[6] > arr4[2] & arr4[6] > arr4[3] & arr4[6] > arr4[4] & arr4[6] > arr4[5] & arr4[6] > arr4[0] & arr4[6] > arr4[7] & Label234.Visible == true)
            {
                Label234.Text = Label247.Text;
            }
            else if (arr4[7] > arr4[1] && arr4[7] > arr4[2] & arr4[7] > arr4[3] & arr4[7] > arr4[4] & arr4[7] > arr4[5] & arr4[7] > arr4[6] & arr4[7] > arr4[0] & Label234.Visible == true)
            {
                Label234.Text = Label248.Text;
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

        protected void Button11_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            DateTime date = DateTime.Now;
            String str = date.ToString();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            string inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
            SqlCommand User = new SqlCommand(inscmd, con);

            if (TextBox39.Text != "" && TextBox40.Text != "")
            {

                a = Convert.ToInt32(TextBox39.Text);
                b = Convert.ToInt32(TextBox40.Text);
                if (a != b)
                {
                    Label88.Text += a;
                    Label89.Text += b;
                    TextBox39.Visible = false;
                    TextBox40.Visible = false;
                    TextBox39.Text = "";
                    TextBox40.Text = "";
                    TextBox35.Visible = true;

                    User.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    User.Parameters.AddWithValue("@隊伍A", Label80.Text);
                    User.Parameters.AddWithValue("@分數A", a);
                    User.Parameters.AddWithValue("@隊伍B", Label81.Text);
                    User.Parameters.AddWithValue("@分數B", b);
                    User.Parameters.AddWithValue("@區域幾輪", "C區第一輪");
                    User.Parameters.AddWithValue("@日期", str);
                    User.ExecuteNonQuery();

                    if (a > b)
                    {
                        Label195.Text = Label81.Text;
                        Image23.ImageUrl = "~/img/普通LR.jpg";
                        arr3[0] += 1;
                    }
                    else if (a < b)
                    {
                        Label195.Text = Label80.Text;
                        Image23.ImageUrl = "~/img/普通RR.jpg";
                        arr3[1] += 1;
                    }
                }
            }
            /*      if (TextBox41.Text != "" && TextBox42.Text != "")
                  {
                      a = Convert.ToInt32(TextBox41.Text);
                      b = Convert.ToInt32(TextBox42.Text);
                      if (a != b)
                      {
                          Label90.Text += a;
                          Label91.Text += b;
                          TextBox41.Visible = false;
                          TextBox42.Visible = false;
                          TextBox41.Text = "";
                          TextBox42.Text = "";
                          TextBox36.Visible = true;
                          Button17.Visible = true;

                          inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                          SqlCommand User_2 = new SqlCommand(inscmd, con);
                          User_2.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                          User_2.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                          User_2.Parameters.AddWithValue("@賽制", "20人雙淘汰");
                          User_2.Parameters.AddWithValue("@隊伍A", Label82.Text);
                          User_2.Parameters.AddWithValue("@分數A", a);
                          User_2.Parameters.AddWithValue("@隊伍B", Label83.Text);
                          User_2.Parameters.AddWithValue("@分數B", b);
                          User_2.Parameters.AddWithValue("@區域幾輪", "C區第一輪");
                          User_2.Parameters.AddWithValue("@日期", str);
                          User_2.ExecuteNonQuery();

                          if (a > b)
                          {
                              Label196.Text = Label83.Text;
                              Image24.ImageUrl = "~/img/普通LR.jpg";
                              arr3[2] += 1;
                          }
                          else if (a < b)
                          {
                              Label196.Text = Label82.Text;
                              Image24.ImageUrl = "~/img/普通RR.jpg";
                              arr3[3] += 1;
                          }
                      }
                  }*/
            if (TextBox43.Text != "" && TextBox44.Text != "")
            {
                a = Convert.ToInt32(TextBox43.Text);
                b = Convert.ToInt32(TextBox44.Text);
                if (a != b)
                {
                    Label92.Text += a;
                    Label93.Text += b;
                    TextBox43.Visible = false;
                    TextBox44.Visible = false;
                    TextBox43.Text = "";
                    TextBox44.Text = "";
                    TextBox37.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_3 = new SqlCommand(inscmd, con);
                    User_3.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_3.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_3.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    User_3.Parameters.AddWithValue("@隊伍A", Label84.Text);
                    User_3.Parameters.AddWithValue("@分數A", a);
                    User_3.Parameters.AddWithValue("@隊伍B", Label85.Text);
                    User_3.Parameters.AddWithValue("@分數B", b);
                    User_3.Parameters.AddWithValue("@區域幾輪", "C區第一輪");
                    User_3.Parameters.AddWithValue("@日期", str);
                    User_3.ExecuteNonQuery();

                    if (a > b)
                    {
                        Label196.Text = Label85.Text;
                        Image25.ImageUrl = "~/img/普通LR.jpg";
                        arr3[4] += 1;
                    }
                    else if (a < b)
                    {
                        Label196.Text = Label84.Text;
                        Image25.ImageUrl = "~/img/普通RR.jpg";
                        arr3[5] += 1;
                    }
                }
            }
            /*if (TextBox45.Text != "" && TextBox46.Text != "")
            {
                a = Convert.ToInt32(TextBox45.Text);
                b = Convert.ToInt32(TextBox46.Text);
                if (a != b)
                {
                    Label94.Text += a;
                    Label95.Text += b;
                    TextBox45.Visible = false;
                    TextBox46.Visible = false;
                    TextBox45.Text = "";
                    TextBox46.Text = "";
                    TextBox38.Visible = true;
                    Button17.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_4 = new SqlCommand(inscmd, con);
                    User_4.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_4.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_4.Parameters.AddWithValue("@賽制", "24人雙淘汰");
                    User_4.Parameters.AddWithValue("@隊伍A", Label86.Text);
                    User_4.Parameters.AddWithValue("@分數A", a);
                    User_4.Parameters.AddWithValue("@隊伍B", Label87.Text);
                    User_4.Parameters.AddWithValue("@分數B", b);
                    User_4.Parameters.AddWithValue("@區域幾輪", "C區第一輪");
                    User_4.Parameters.AddWithValue("@日期", str);
                    User_4.ExecuteNonQuery();

                    if (a > b)
                    {
                        Label198.Text = Label87.Text;
                        Image26.ImageUrl = "~/img/普通LR.jpg";
                        arr3[6] += 1;
                    }
                    else if (a < b)
                    {
                        Label198.Text = Label86.Text;
                        Image26.ImageUrl = "~/img/普通RR.jpg";
                        arr3[7] += 1;
                    }
                }
            }*/
            //第一輪結束

            if (TextBox35.Text != "" && TextBox36.Text != "")
            {
                a = Convert.ToInt32(TextBox35.Text);
                b = Convert.ToInt32(TextBox36.Text);
                if (a != b)
                {
                    Label76.Text += a;
                    Label77.Text += b;
                    TextBox35.Visible = false;
                    TextBox36.Visible = false;
                    TextBox35.Text = "";
                    TextBox36.Text = "";
                    TextBox33.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_5 = new SqlCommand(inscmd, con);
                    User_5.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_5.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_5.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    if (arr3[0] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label80.Text);
                    }
                    else if (arr3[1] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label81.Text);
                    }

                    User_5.Parameters.AddWithValue("@分數A", a);


                    User_5.Parameters.AddWithValue("@隊伍B", Label82.Text);


                    User_5.Parameters.AddWithValue("@分數B", b);
                    User_5.Parameters.AddWithValue("@區域幾輪", "C區第二輪");
                    User_5.Parameters.AddWithValue("@日期", str);
                    User_5.ExecuteNonQuery();

                    if (a > b)
                    {
                        Label199.Text = Label82.Text;

                        Image21.ImageUrl = "~/img/大普通LR.jpg";
                        arr3[0] += 1;
                        arr3[1] += 1;
                    }
                    else if (a < b)
                    {
                        if (arr3[0] > arr3[1])
                        {
                            Label199.Text = Label80.Text;
                        }
                        else if (arr3[0] < arr3[1])
                        {
                            Label199.Text = Label81.Text;
                        }
                        Image21.ImageUrl = "~/img/大普通RR.jpg";
                        arr3[2] += 2;
                        arr3[3] += 1;
                    }
                }
            }////////-1
            if (TextBox37.Text != "" && TextBox38.Text != "")
            {
                a = Convert.ToInt32(TextBox37.Text);
                b = Convert.ToInt32(TextBox38.Text);
                if (a != b)
                {
                    Label78.Text += a;
                    Label79.Text += b;
                    TextBox37.Visible = false;
                    TextBox38.Visible = false;
                    TextBox37.Text = "";
                    TextBox38.Text = "";
                    TextBox34.Visible = true;
                    Button17.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_6 = new SqlCommand(inscmd, con);
                    User_6.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_6.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_6.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    if (arr3[4] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label84.Text);
                    }
                    else if (arr3[5] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label85.Text);
                    }

                    User_6.Parameters.AddWithValue("@分數A", a);


                    User_6.Parameters.AddWithValue("@隊伍B", Label86.Text);

                    User_6.Parameters.AddWithValue("@分數B", b);
                    User_6.Parameters.AddWithValue("@區域幾輪", "C區第二輪");
                    User_6.Parameters.AddWithValue("@日期", str);
                    User_6.ExecuteNonQuery();

                    if (a > b)
                    {

                        Label197.Text = Label86.Text;

                        Image22.ImageUrl = "~/img/大普通LR.jpg";
                        arr3[4] += 1;
                        arr3[5] += 1;
                    }
                    else if (a < b)
                    {
                        if (arr3[4] > arr3[5])
                        {
                            Label197.Text = Label84.Text;
                        }
                        else if (arr3[4] < arr3[5])
                        {
                            Label197.Text = Label85.Text;
                        }
                        Image22.ImageUrl = "~/img/大普通RR.jpg";
                        arr3[6] += 2;
                        arr3[7] += 1;
                    }
                }
            }//////////-2

            //第二輪結束
            if (TextBox33.Text != "" && TextBox34.Text != "")
            {
                a = Convert.ToInt32(TextBox33.Text);
                b = Convert.ToInt32(TextBox34.Text);
                if (a != b)
                {
                    Label74.Text += a;
                    Label75.Text += b;
                    TextBox33.Visible = false;
                    TextBox34.Visible = false;
                    TextBox33.Text = "";
                    TextBox34.Text = "";
                    Label73.Visible = true;
                    Button17.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_7 = new SqlCommand(inscmd, con);
                    User_7.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_7.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_7.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    if (arr3[0] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label80.Text);
                    }
                    else if (arr3[1] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label81.Text);
                    }
                    else if (arr3[2] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label82.Text);
                    }
                    else if (arr3[3] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label83.Text);
                    }

                    User_7.Parameters.AddWithValue("@分數A", a);

                    if (arr3[4] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label84.Text);
                    }
                    else if (arr3[5] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label85.Text);
                    }
                    else if (arr3[6] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label86.Text);
                    }
                    else if (arr3[7] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label87.Text);
                    }

                    User_7.Parameters.AddWithValue("@分數B", b);
                    User_7.Parameters.AddWithValue("@區域幾輪", "C區第三輪");
                    User_7.Parameters.AddWithValue("@日期", str);
                    User_7.ExecuteNonQuery();

                    if (a > b)
                    {
                        if (arr3[4] > arr3[5] & arr3[4] > arr3[6] & arr3[4] > arr3[7])
                        {
                            Label201.Text = Label84.Text;
                        }
                        else if (arr3[5] > arr3[4] & arr3[5] > arr3[6] & arr3[5] > arr3[7])
                        {
                            Label201.Text = Label85.Text;
                        }
                        else if (arr3[6] > arr3[4] & arr3[6] > arr3[5] & arr3[6] > arr3[7])
                        {
                            Label201.Text = Label86.Text;
                        }
                        else if (arr3[7] > arr3[4] & arr3[7] > arr3[5] & arr3[7] > arr3[6])
                        {
                            Label201.Text = Label87.Text;
                        }
                        Image20.ImageUrl = "~/img/大大普通LR.jpg";
                        arr3[0] += 1;
                        arr3[1] += 1;
                        arr3[2] += 1;
                        arr3[3] += 1;
                    }
                    else if (a < b)
                    {
                        if (arr3[0] > arr3[1] & arr3[0] > arr3[2] & arr3[0] > arr3[3])
                        {
                            Label201.Text = Label80.Text;
                        }
                        else if (arr3[1] > arr3[0] & arr3[1] > arr3[2] & arr3[1] > arr3[3])
                        {
                            Label201.Text = Label81.Text;
                        }
                        else if (arr3[2] > arr3[0] & arr3[2] > arr3[1] & arr3[2] > arr3[3])
                        {
                            Label201.Text = Label82.Text;
                        }
                        else if (arr3[3] > arr3[0] & arr3[3] > arr3[2] & arr3[3] > arr3[0])
                        {
                            Label201.Text = Label83.Text;
                        }
                        Image20.ImageUrl = "~/img/大大普通RR.jpg";
                        arr3[4] += 1;
                        arr3[5] += 1;
                        arr3[6] += 1;
                        arr3[7] += 1;
                    }
                }
            }
            //OVER

            /*if (c == 0 & TextBox39.Visible == false & TextBox40.Visible == false & TextBox41.Visible == false & TextBox42.Visible
                == false & TextBox43.Visible == false & TextBox44.Visible == false & TextBox45.Visible == false & TextBox46.Visible == false
                /*& Label11.Text!="" & Label12.Text!="" & Label13.Text!="" & Label14.Text!="" & Label15.Text!="" & Label16.Text!="" & Label17.Text!="" &
                Label18.Text!="")
            {
                c++;
                TextBox35.Visible = true;
                TextBox36.Visible = true;
                TextBox37.Visible = true;
                TextBox38.Visible = true;
            }
            else if (d == 0 & c == 1 & TextBox35.Visible == false & TextBox36.Visible == false & TextBox37.Visible == false & TextBox38.Visible == false)
            {
                d++;
                TextBox33.Visible = true;
                TextBox34.Visible = true;
            }
            else if (f == 0 & c == 1 & d == 1 & TextBox33.Visible == false & TextBox34.Visible == false)
            {
                c = 0;
                d = 0;
                f = 0;
                Button11.Visible = false;
            }*/

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (arr3[0] > arr3[1] && arr3[0] > arr3[2] & arr3[0] > arr3[3] & arr3[0] > arr3[4] & arr3[0] > arr3[5] & arr3[0] > arr3[6] & arr3[0] > arr3[7] & Label73.Visible == true)
            {
                Label73.Text = Label80.Text;
                Label245.Text = Label73.Text;
            }
            else if (arr3[1] > arr3[0] && arr3[1] > arr3[2] & arr3[1] > arr3[3] & arr3[1] > arr3[4] & arr3[1] > arr3[5] & arr3[1] > arr3[6] & arr3[1] > arr3[7] & Label73.Visible == true)
            {
                Label73.Text = Label81.Text;
                Label245.Text = Label73.Text;
            }
            else if (arr3[2] > arr3[1] && arr3[2] > arr3[0] & arr3[2] > arr3[3] & arr3[2] > arr3[4] & arr3[2] > arr3[5] & arr3[2] > arr3[6] & arr3[2] > arr3[7] & Label73.Visible == true)
            {
                Label73.Text = Label82.Text;
                Label245.Text = Label73.Text;
            }
            else if (arr3[3] > arr3[1] && arr3[3] > arr3[2] & arr3[3] > arr3[0] & arr3[3] > arr3[4] & arr3[3] > arr3[5] & arr3[3] > arr3[6] & arr3[3] > arr3[7] & Label73.Visible == true)
            {
                Label73.Text = Label83.Text;
                Label245.Text = Label73.Text;
            }
            else if (arr3[4] > arr3[1] && arr3[4] > arr3[2] & arr3[4] > arr3[3] & arr3[4] > arr3[0] & arr3[4] > arr3[5] & arr3[4] > arr3[6] & arr3[4] > arr3[7] & Label73.Visible == true)
            {
                Label73.Text = Label84.Text;
                Label245.Text = Label73.Text;
            }
            else if (arr3[5] > arr3[1] && arr3[5] > arr3[2] & arr3[5] > arr3[3] & arr3[5] > arr3[4] & arr3[5] > arr3[0] & arr3[5] > arr3[6] & arr3[5] > arr3[7] & Label73.Visible == true)
            {
                Label73.Text = Label85.Text;
                Label245.Text = Label73.Text;

            }
            else if (arr3[6] > arr3[1] && arr3[6] > arr3[2] & arr3[6] > arr3[3] & arr3[6] > arr3[4] & arr3[6] > arr3[5] & arr3[6] > arr3[0] & arr3[6] > arr3[7] & Label73.Visible == true)
            {
                Label73.Text = Label86.Text;
                Label245.Text = Label73.Text;
            }
            else if (arr3[7] > arr3[1] && arr3[7] > arr3[2] & arr3[7] > arr3[3] & arr3[7] > arr3[4] & arr3[7] > arr3[5] & arr3[7] > arr3[6] & arr3[7] > arr3[0] & Label73.Visible == true)
            {
                Label73.Text = Label87.Text;
                Label245.Text = Label73.Text;
            }
            if (Label73.Text == Label245.Text)
            {
                TextBox133.Visible = true;
                Button11.Visible = false;
                arr3[0] = 0;
                arr3[1] = 0;
                arr3[2] = 0;
                arr3[3] = 0;
                arr3[4] = 0;
                arr3[5] = 0;
                arr3[6] = 0;
                arr3[7] = 0;
            }
            con.Close();
        }//C區比賽

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
                    User.Parameters.AddWithValue("@賽制", "19人雙淘汰");
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
            /*    if (TextBox75.Text != "" && TextBox76.Text != "")
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
                        User_2.Parameters.AddWithValue("@賽制", "21人雙淘汰");
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
                }*/
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
                    User_3.Parameters.AddWithValue("@賽制", "19人雙淘汰");
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
                    User_5.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    if (arr6[0] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label149.Text);
                    }
                    else if (arr6[1] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label150.Text);
                    }

                    User_5.Parameters.AddWithValue("@分數A", a);

                    User_5.Parameters.AddWithValue("@隊伍B", Label151.Text);


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
                        arr6[2] += 2;
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
                    User_6.Parameters.AddWithValue("@賽制", "19人雙淘汰");
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
                    User_7.Parameters.AddWithValue("@賽制", "19人雙淘汰");
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
                Label246.Text = Label142.Text;
            }
            else if (arr6[1] > arr6[0] && arr6[1] > arr6[2] & arr6[1] > arr6[3] & arr6[1] > arr6[4] & arr6[1] > arr6[5] & arr6[1] > arr6[6] & arr6[1] > arr6[7] & Label142.Visible == true)
            {
                Label142.Text = Label150.Text;
                Label246.Text = Label142.Text;
            }
            else if (arr6[2] > arr6[1] && arr6[2] > arr6[0] & arr6[2] > arr6[3] & arr6[2] > arr6[4] & arr6[2] > arr6[5] & arr6[2] > arr6[6] & arr6[2] > arr6[7] & Label142.Visible == true)
            {
                Label142.Text = Label151.Text;
                Label246.Text = Label142.Text;
            }
            else if (arr6[3] > arr6[1] && arr6[3] > arr6[2] & arr6[3] > arr6[0] & arr6[3] > arr6[4] & arr6[3] > arr6[5] & arr6[3] > arr6[6] & arr6[3] > arr6[7] & Label142.Visible == true)
            {
                Label142.Text = Label152.Text;
                Label246.Text = Label142.Text;
            }
            else if (arr6[4] > arr6[1] && arr6[4] > arr6[2] & arr6[4] > arr6[3] & arr6[4] > arr6[0] & arr6[4] > arr6[5] & arr6[4] > arr6[6] & arr6[4] > arr6[7] & Label142.Visible == true)
            {
                Label142.Text = Label153.Text;
                Label246.Text = Label142.Text;
            }
            else if (arr6[5] > arr6[1] && arr6[5] > arr6[2] & arr6[5] > arr6[3] & arr6[5] > arr6[4] & arr6[5] > arr6[0] & arr6[5] > arr6[6] & arr6[5] > arr6[7] & Label142.Visible == true)
            {
                Label142.Text = Label154.Text;
                Label246.Text = Label142.Text;
            }
            else if (arr6[6] > arr6[1] && arr6[6] > arr6[2] & arr6[6] > arr6[3] & arr6[6] > arr6[4] & arr6[6] > arr6[5] & arr6[6] > arr6[0] & arr6[6] > arr6[7] & Label142.Visible == true)
            {
                Label142.Text = Label155.Text;
                Label246.Text = Label142.Text;
            }
            /*   else if (arr2[7] > arr2[1] && arr2[7] > arr2[2] & arr2[7] > arr2[3] & arr2[7] > arr2[4] & arr2[7] > arr2[5] & arr2[7] > arr2[6] & arr2[7] > arr2[0] & Label67.Visible == true)
               {
                   Label67.Text = Label8.Text;
                   Label69.Text = Label67.Text;
               }*/
            //沒第八隊

            if (Label142.Text == Label246.Text)  //最後改
            {
                TextBox134.Visible = true;
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

        protected void Button16_Click(object sender, EventArgs e)//B區敗部
        {
            int a = 0;
            int b = 0;

            DateTime date = DateTime.Now;
            String str = date.ToString();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            string inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
            SqlCommand User = new SqlCommand(inscmd, con);

            if (TextBox87.Text != "" && TextBox88.Text != "")
            {

                a = Convert.ToInt32(TextBox87.Text);
                b = Convert.ToInt32(TextBox88.Text);
                if (a != b)
                {
                    Label180.Text += a;
                    Label181.Text += b;
                    TextBox87.Visible = false;
                    TextBox88.Visible = false;
                    TextBox87.Text = "";
                    TextBox88.Text = "";
                    TextBox83.Visible = true; //開啟上面

                    User.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    User.Parameters.AddWithValue("@隊伍A", Label172.Text);
                    User.Parameters.AddWithValue("@分數A", a);
                    User.Parameters.AddWithValue("@隊伍B", Label173.Text);
                    User.Parameters.AddWithValue("@分數B", b);
                    User.Parameters.AddWithValue("@區域幾輪", "B區敗部第一輪");
                    User.Parameters.AddWithValue("@日期", str);
                    User.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image46.ImageUrl = "~/img/普通LR.jpg";
                        arr7[0] += 1;
                    }
                    else if (a < b)
                    {
                        Image46.ImageUrl = "~/img/普通RR.jpg";
                        arr7[1] += 1;
                    }
                }
            }
            /*   if (TextBox89.Text != "" && TextBox90.Text != "")
               {
                   a = Convert.ToInt32(TextBox89.Text);
                   b = Convert.ToInt32(TextBox90.Text);
                   if (a != b)
                   {
                       Label182.Text += a;
                       Label183.Text += b;
                       TextBox89.Visible = false;
                       TextBox90.Visible = false;
                       TextBox89.Text = "";
                       TextBox90.Text = "";
                       TextBox84.Visible = true; //開啟上面

                       inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                       SqlCommand User_2 = new SqlCommand(inscmd, con);
                       User_2.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                       User_2.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                       User_2.Parameters.AddWithValue("@賽制", "22人雙淘汰");
                       User_2.Parameters.AddWithValue("@隊伍A", Label174.Text);
                       User_2.Parameters.AddWithValue("@分數A", a);
                       User_2.Parameters.AddWithValue("@隊伍B", Label175.Text);
                       User_2.Parameters.AddWithValue("@分數B", b);
                       User_2.Parameters.AddWithValue("@區域幾輪", "B區敗部第一輪");
                       User_2.Parameters.AddWithValue("@日期", str);
                       User_2.ExecuteNonQuery();

                       if (a > b)
                       {
                           Image47.ImageUrl = "~/img/普通LR.jpg";
                           arr7[2] += 1;
                       }
                       else if (a < b)
                       {
                           Image47.ImageUrl = "~/img/普通RR.jpg";
                           arr7[3] += 1;
                       }
                   }
               }*/
        /*    if (TextBox91.Text != "" && TextBox92.Text != "")
            {
                a = Convert.ToInt32(TextBox91.Text);
                b = Convert.ToInt32(TextBox92.Text);
                if (a != b)
                {
                    Label184.Text += a;
                    Label185.Text += b;
                    TextBox91.Visible = false;
                    TextBox92.Visible = false;
                    TextBox91.Text = "";
                    TextBox92.Text = "";
                    TextBox85.Visible = true; //開啟上面

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_3 = new SqlCommand(inscmd, con);
                    User_3.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_3.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_3.Parameters.AddWithValue("@賽制", "20人雙淘汰");
                    User_3.Parameters.AddWithValue("@隊伍A", Label176.Text);
                    User_3.Parameters.AddWithValue("@分數A", a);
                    User_3.Parameters.AddWithValue("@隊伍B", Label177.Text);
                    User_3.Parameters.AddWithValue("@分數B", b);
                    User_3.Parameters.AddWithValue("@區域幾輪", "B區敗部第一輪");
                    User_3.Parameters.AddWithValue("@日期", str);
                    User_3.ExecuteNonQuery();


                    if (a > b)
                    {
                        Image48.ImageUrl = "~/img/普通LR.jpg";
                        arr7[4] += 1;
                    }
                    else if (a < b)
                    {
                        Image48.ImageUrl = "~/img/普通RR.jpg";
                        arr7[5] += 1;
                    }
                }
            }*/

            //第一輪結束

            if (TextBox83.Text != "" && TextBox84.Text != "")
            {
                a = Convert.ToInt32(TextBox83.Text);
                b = Convert.ToInt32(TextBox84.Text);
                if (a != b)
                {
                    Label168.Text += a;
                    Label169.Text += b;
                    TextBox83.Visible = false;
                    TextBox84.Visible = false;
                    TextBox83.Text = "";
                    TextBox84.Text = "";
                    TextBox81.Visible = true; //開啟上面

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_5 = new SqlCommand(inscmd, con);
                    User_5.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_5.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_5.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    if (arr7[0] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label172.Text);
                    }
                    else if (arr7[1] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label173.Text);
                    }

                    User_5.Parameters.AddWithValue("@分數A", a);

                    User_5.Parameters.AddWithValue("@隊伍B", Label174.Text);

                    User_5.Parameters.AddWithValue("@分數B", b);
                    User_5.Parameters.AddWithValue("@區域幾輪", "B區敗部第二輪");
                    User_5.Parameters.AddWithValue("@日期", str);
                    User_5.ExecuteNonQuery();

                    if (a > b)
                    {

                        Image44.ImageUrl = "~/img/大普通LR.jpg";
                        arr7[0] += 1;
                        arr7[1] += 1;
                    }
                    else if (a < b)
                    {
                        Image44.ImageUrl = "~/img/大普通RR.jpg";
                        arr7[2] += 2;
                        arr7[3] += 1;
                    }
                }
            }
            if (TextBox85.Text != "" && TextBox86.Text != "")
            {
                a = Convert.ToInt32(TextBox85.Text);
                b = Convert.ToInt32(TextBox86.Text);
                if (a != b)
                {
                    Label170.Text += a;
                    Label171.Text += b;
                    TextBox85.Visible = false;
                    TextBox86.Visible = false;
                    TextBox85.Text = "";
                    TextBox86.Text = "";
                    TextBox82.Visible = true; //開啟上面

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_6 = new SqlCommand(inscmd, con);
                    User_6.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_6.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_6.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    
                    User_6.Parameters.AddWithValue("@隊伍A", Label176.Text);
  

                    User_6.Parameters.AddWithValue("@分數A", a);

                    User_6.Parameters.AddWithValue("@隊伍B", Label178.Text);

                    User_6.Parameters.AddWithValue("@分數B", b);
                    User_6.Parameters.AddWithValue("@區域幾輪", "B區敗部第二輪");
                    User_6.Parameters.AddWithValue("@日期", str);
                    User_6.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image45.ImageUrl = "~/img/大普通LR.jpg";
                        arr7[4] += 2;
                        arr7[5] += 1;
                    }
                    else if (a < b)
                    {

                        Image45.ImageUrl = "~/img/大普通RR.jpg";
                        arr7[6] += 2;
                        arr7[7] += 1;
                    }
                }
            }

            //第二輪結束
            if (TextBox81.Text != "" && TextBox82.Text != "")
            {
                a = Convert.ToInt32(TextBox81.Text);
                b = Convert.ToInt32(TextBox82.Text);
                if (a != b)
                {
                    Label166.Text += a;
                    Label167.Text += b;
                    TextBox81.Visible = false;
                    TextBox82.Visible = false;
                    TextBox81.Text = "";
                    TextBox82.Text = "";
                    Label165.Visible = true; //必改

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_7 = new SqlCommand(inscmd, con);
                    User_7.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_7.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_7.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    if (arr7[0] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label172.Text);
                    }
                    else if (arr7[1] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label173.Text);
                    }
                    else if (arr7[2] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label174.Text);
                    }
                    else if (arr7[3] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label175.Text);
                    }

                    User_7.Parameters.AddWithValue("@分數A", a);

                    if (arr7[4] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label176.Text);
                    }
                    else if (arr7[5] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label177.Text);
                    }
                    else if (arr7[6] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label178.Text);
                    }


                    User_7.Parameters.AddWithValue("@分數B", b);
                    User_7.Parameters.AddWithValue("@區域幾輪", "B區敗部第三輪");
                    User_7.Parameters.AddWithValue("@日期", str);
                    User_7.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image43.ImageUrl = "~/img/大大普通LR.jpg";
                        arr7[0] += 1;
                        arr7[1] += 1;
                        arr7[2] += 1;
                        arr7[3] += 1;
                    }
                    else if (a < b)
                    {

                        Image43.ImageUrl = "~/img/大大普通RR.jpg";
                        arr7[4] += 1;
                        arr7[5] += 1;
                        arr7[6] += 1;
                        arr7[7] += 1;
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


            if (arr7[0] > arr7[1] && arr7[0] > arr7[2] & arr7[0] > arr7[3] & arr7[0] > arr7[4] & arr7[0] > arr7[5] & arr7[0] > arr7[6] & arr7[0] > arr7[7] & Label165.Visible == true)
            {
                Label165.Text = Label172.Text;
                Label243.Text = Label165.Text;
            }
            else if (arr7[1] > arr7[0] && arr7[1] > arr7[2] & arr7[1] > arr7[3] & arr7[1] > arr7[4] & arr7[1] > arr7[5] & arr7[1] > arr7[6] & arr7[1] > arr7[7] & Label165.Visible == true)
            {
                Label165.Text = Label173.Text;
                Label243.Text = Label165.Text;
            }
            else if (arr7[2] > arr7[1] && arr7[2] > arr7[0] & arr7[2] > arr7[3] & arr7[2] > arr7[4] & arr7[2] > arr7[5] & arr7[2] > arr7[6] & arr7[2] > arr7[7] & Label165.Visible == true)
            {
                Label165.Text = Label174.Text;
                Label243.Text = Label165.Text;
            }
            else if (arr7[3] > arr7[1] && arr7[3] > arr7[2] & arr7[3] > arr7[0] & arr7[3] > arr7[4] & arr7[3] > arr7[5] & arr7[3] > arr7[6] & arr7[3] > arr7[7] & Label165.Visible == true)
            {
                Label165.Text = Label175.Text;
                Label243.Text = Label165.Text;
            }
            else if (arr7[4] > arr7[1] && arr7[4] > arr7[2] & arr7[4] > arr7[3] & arr7[4] > arr7[0] & arr7[4] > arr7[5] & arr7[4] > arr7[6] & arr7[4] > arr7[7] & Label165.Visible == true)
            {
                Label165.Text = Label176.Text;
                Label243.Text = Label165.Text;
            }
            else if (arr7[5] > arr7[1] && arr7[5] > arr7[2] & arr7[5] > arr7[3] & arr7[5] > arr7[4] & arr7[5] > arr7[0] & arr7[5] > arr7[6] & arr7[5] > arr7[7] & Label165.Visible == true)
            {
                Label165.Text = Label177.Text;
                Label243.Text = Label165.Text;
            }
            else if (arr7[6] > arr7[1] && arr7[6] > arr7[2] & arr7[6] > arr7[3] & arr7[6] > arr7[4] & arr7[6] > arr7[5] & arr7[6] > arr7[0] & arr7[6] > arr7[7] & Label165.Visible == true)
            {
                Label165.Text = Label178.Text;
                Label243.Text = Label165.Text;
            }
            /*   else if (arr2[7] > arr2[1] && arr2[7] > arr2[2] & arr2[7] > arr2[3] & arr2[7] > arr2[4] & arr2[7] > arr2[5] & arr2[7] > arr2[6] & arr2[7] > arr2[0] & Label67.Visible == true)
               {
                   Label67.Text = Label8.Text;
                   Label69.Text = Label67.Text;
               }*/
            //沒第八隊

            if (Label165.Text == Label243.Text)  //最後改
            {
                Button16.Visible = false;
                TextBox131.Visible = true;
                arr7[0] = 0;
                arr7[1] = 0;
                arr7[2] = 0;
                arr7[3] = 0;
                arr7[4] = 0;
                arr7[5] = 0;
                arr7[6] = 0;
                arr7[7] = 0;

            }

            con.Close();

        }

        protected void Button17_Click(object sender, EventArgs e)//C區敗部
        {

            int a = 0;
            int b = 0;

            DateTime date = DateTime.Now;
            String str = date.ToString();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            string inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
            SqlCommand User = new SqlCommand(inscmd, con);


            if (TextBox101.Text != "" && TextBox102.Text != "")
            {

                a = Convert.ToInt32(TextBox101.Text);
                b = Convert.ToInt32(TextBox102.Text);
                if (a != b)
                {
                    Label203.Text += a;
                    Label204.Text += b;
                    TextBox101.Visible = false;
                    TextBox102.Visible = false;
                    TextBox101.Text = "";
                    TextBox102.Text = "";
                    TextBox97.Visible = true; //開啟上面

                    User.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    User.Parameters.AddWithValue("@隊伍A", Label195.Text);
                    User.Parameters.AddWithValue("@分數A", a);
                    User.Parameters.AddWithValue("@隊伍B", Label196.Text);
                    User.Parameters.AddWithValue("@分數B", b);
                    User.Parameters.AddWithValue("@區域幾輪", "C區敗部第一輪");
                    User.Parameters.AddWithValue("@日期", str);
                    User.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image53.ImageUrl = "~/img/普通LR.jpg";
                        arr8[0] += 1;
                    }
                    else if (a < b)
                    {
                        Image53.ImageUrl = "~/img/普通RR.jpg";
                        arr8[1] += 1;
                    }
                }
            }
            /*      if (TextBox103.Text != "" && TextBox104.Text != "")
                  {
                      a = Convert.ToInt32(TextBox103.Text);
                      b = Convert.ToInt32(TextBox104.Text);
                      if (a != b)
                      {
                          Label205.Text += a;
                          Label206.Text += b;
                          TextBox103.Visible = false;
                          TextBox104.Visible = false;
                          TextBox103.Text = "";
                          TextBox104.Text = "";
                          TextBox98.Visible = true; //開啟上面

                          inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                          SqlCommand User_2 = new SqlCommand(inscmd, con);
                          User_2.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                          User_2.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                          User_2.Parameters.AddWithValue("@賽制", "22人雙淘汰");
                          User_2.Parameters.AddWithValue("@隊伍A", Label197.Text);
                          User_2.Parameters.AddWithValue("@分數A", a);
                          User_2.Parameters.AddWithValue("@隊伍B", Label198.Text);
                          User_2.Parameters.AddWithValue("@分數B", b);
                          User_2.Parameters.AddWithValue("@區域幾輪", "C區敗部第一輪");
                          User_2.Parameters.AddWithValue("@日期", str);
                          User_2.ExecuteNonQuery();

                          if (a > b)
                          {
                              Image54.ImageUrl = "~/img/普通LR.jpg";
                              arr8[2] += 1;
                          }
                          else if (a < b)
                          {
                              Image54.ImageUrl = "~/img/普通RR.jpg";
                              arr8[3] += 1;
                          }
                      }
                  }*/
            /*     if (TextBox105.Text != "" && TextBox106.Text != "")
                 {
                     a = Convert.ToInt32(TextBox105.Text);
                     b = Convert.ToInt32(TextBox106.Text);
                     if (a != b)
                     {
                         Label207.Text += a;
                         Label208.Text += b;
                         TextBox105.Visible = false;
                         TextBox106.Visible = false;
                         TextBox105.Text = "";
                         TextBox106.Text = "";
                         TextBox99.Visible = true; //開啟上面

                         inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                         SqlCommand User_3 = new SqlCommand(inscmd, con);
                         User_3.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                         User_3.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                         User_3.Parameters.AddWithValue("@賽制", "21人雙淘汰");
                         User_3.Parameters.AddWithValue("@隊伍A", Label199.Text);
                         User_3.Parameters.AddWithValue("@分數A", a);
                         User_3.Parameters.AddWithValue("@隊伍B", Label200.Text);
                         User_3.Parameters.AddWithValue("@分數B", b);
                         User_3.Parameters.AddWithValue("@區域幾輪", "C區敗部第一輪");
                         User_3.Parameters.AddWithValue("@日期", str);
                         User_3.ExecuteNonQuery();

                         if (a > b)
                         {
                             Image55.ImageUrl = "~/img/普通LR.jpg";
                             arr8[4] += 1;
                         }
                         else if (a < b)
                         {
                             Image55.ImageUrl = "~/img/普通RR.jpg";
                             arr8[5] += 1;
                         }
                     }
                 }*/


            //第一輪結束

            if (TextBox97.Text != "" && TextBox98.Text != "")
            {
                a = Convert.ToInt32(TextBox97.Text);
                b = Convert.ToInt32(TextBox98.Text);
                if (a != b)
                {
                    Label191.Text += a;
                    Label192.Text += b;
                    TextBox97.Visible = false;
                    TextBox98.Visible = false;
                    TextBox97.Text = "";
                    TextBox98.Text = "";
                    TextBox95.Visible = true; //開啟上面

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_5 = new SqlCommand(inscmd, con);
                    User_5.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_5.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_5.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    if (arr8[0] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label195.Text);
                    }
                    else if (arr8[1] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label196.Text);
                    }

                    User_5.Parameters.AddWithValue("@分數A", a);


                    User_5.Parameters.AddWithValue("@隊伍B", Label197.Text);


                    User_5.Parameters.AddWithValue("@分數B", b);
                    User_5.Parameters.AddWithValue("@區域幾輪", "C區敗部第二輪");
                    User_5.Parameters.AddWithValue("@日期", str);
                    User_5.ExecuteNonQuery();


                    if (a > b)
                    {

                        Image51.ImageUrl = "~/img/大普通LR.jpg";
                        arr8[0] += 1;
                        arr8[1] += 1;
                    }
                    else if (a < b)
                    {
                        Image51.ImageUrl = "~/img/大普通RR.jpg";
                        arr8[2] += 2;
                        arr8[3] += 1;
                    }
                }
            }
            if (TextBox99.Text != "" && TextBox100.Text != "")
            {
                a = Convert.ToInt32(TextBox99.Text);
                b = Convert.ToInt32(TextBox100.Text);
                if (a != b)
                {
                    Label193.Text += a;
                    Label194.Text += b;
                    TextBox99.Visible = false;
                    TextBox100.Visible = false;
                    TextBox99.Text = "";
                    TextBox100.Text = "";
                    TextBox96.Visible = true; //開啟上面

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_6 = new SqlCommand(inscmd, con);
                    User_6.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_6.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_6.Parameters.AddWithValue("@賽制", "19人雙淘汰");


                    User_6.Parameters.AddWithValue("@隊伍A", Label199.Text);

                    User_6.Parameters.AddWithValue("@分數A", a);

                    User_6.Parameters.AddWithValue("@隊伍B", Label201.Text);

                    User_6.Parameters.AddWithValue("@分數B", b);
                    User_6.Parameters.AddWithValue("@區域幾輪", "C區敗部第二輪");
                    User_6.Parameters.AddWithValue("@日期", str);
                    User_6.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image52.ImageUrl = "~/img/大普通LR.jpg";
                        arr8[4] += 2;
                        arr8[5] += 1;
                    }
                    else if (a < b)
                    {

                        Image52.ImageUrl = "~/img/大普通RR.jpg";
                        arr8[6] += 2;
                        arr8[7] += 1;
                    }
                }
            }

            //第二輪結束
            if (TextBox95.Text != "" && TextBox96.Text != "")
            {
                a = Convert.ToInt32(TextBox95.Text);
                b = Convert.ToInt32(TextBox96.Text);
                if (a != b)
                {
                    Label189.Text += a;
                    Label190.Text += b;
                    TextBox95.Visible = false;
                    TextBox96.Visible = false;
                    TextBox95.Text = "";
                    TextBox96.Text = "";
                    Label188.Visible = true; //必改

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_7 = new SqlCommand(inscmd, con);
                    User_7.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_7.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_7.Parameters.AddWithValue("@賽制", "19人雙淘汰");
                    if (arr8[0] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label195.Text);
                    }
                    else if (arr8[1] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label196.Text);
                    }
                    else if (arr8[2] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label197.Text);
                    }
                    else if (arr8[3] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label198.Text);
                    }

                    User_7.Parameters.AddWithValue("@分數A", a);

                    if (arr8[4] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label199.Text);
                    }
                    else if (arr8[5] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label200.Text);
                    }
                    else if (arr8[6] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label201.Text);
                    }


                    User_7.Parameters.AddWithValue("@分數B", b);
                    User_7.Parameters.AddWithValue("@區域幾輪", "C區敗部第三輪");
                    User_7.Parameters.AddWithValue("@日期", str);
                    User_7.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image50.ImageUrl = "~/img/大大普通LR.jpg";
                        arr8[0] += 1;
                        arr8[1] += 1;
                        arr8[2] += 1;
                        arr8[3] += 1;
                    }
                    else if (a < b)
                    {

                        Image50.ImageUrl = "~/img/大大普通RR.jpg";
                        arr8[4] += 1;
                        arr8[5] += 1;
                        arr8[6] += 1;
                        arr8[7] += 1;
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


            if (arr8[0] > arr8[1] && arr8[0] > arr8[2] & arr8[0] > arr8[3] & arr8[0] > arr8[4] & arr8[0] > arr8[5] & arr8[0] > arr8[6] & arr8[0] > arr8[7] & Label188.Visible == true)
            {
                Label188.Text = Label195.Text;
                Label244.Text = Label188.Text;
            }
            else if (arr8[1] > arr8[0] && arr8[1] > arr8[2] & arr8[1] > arr8[3] & arr8[1] > arr8[4] & arr8[1] > arr8[5] & arr8[1] > arr8[6] & arr8[1] > arr8[7] & Label188.Visible == true)
            {
                Label188.Text = Label196.Text;
                Label244.Text = Label188.Text;
            }
            else if (arr8[2] > arr8[1] && arr8[2] > arr8[0] & arr8[2] > arr8[3] & arr8[2] > arr8[4] & arr8[2] > arr8[5] & arr8[2] > arr8[6] & arr8[2] > arr8[7] & Label188.Visible == true)
            {
                Label188.Text = Label197.Text;
                Label244.Text = Label188.Text;
            }
            else if (arr8[3] > arr8[1] && arr8[3] > arr8[2] & arr8[3] > arr8[0] & arr8[3] > arr8[4] & arr8[3] > arr8[5] & arr8[3] > arr8[6] & arr8[3] > arr8[7] & Label188.Visible == true)
            {
                Label188.Text = Label198.Text;
                Label244.Text = Label188.Text;
            }
            else if (arr8[4] > arr8[1] && arr8[4] > arr8[2] & arr8[4] > arr8[3] & arr8[4] > arr8[0] & arr8[4] > arr8[5] & arr8[4] > arr8[6] & arr8[4] > arr8[7] & Label188.Visible == true)
            {
                Label188.Text = Label199.Text;
                Label244.Text = Label188.Text;
            }
            else if (arr8[5] > arr8[1] && arr8[5] > arr8[2] & arr8[5] > arr8[3] & arr8[5] > arr8[4] & arr8[5] > arr8[0] & arr8[5] > arr8[6] & arr8[5] > arr8[7] & Label188.Visible == true)
            {
                Label188.Text = Label200.Text;
                Label244.Text = Label188.Text;
            }
            else if (arr8[6] > arr8[1] && arr8[6] > arr8[2] & arr8[6] > arr8[3] & arr8[6] > arr8[4] & arr8[6] > arr8[5] & arr8[6] > arr8[0] & arr8[6] > arr8[7] & Label188.Visible == true)
            {
                Label188.Text = Label201.Text;
                Label244.Text = Label188.Text;
            }
            /*   else if (arr2[7] > arr2[1] && arr2[7] > arr2[2] & arr2[7] > arr2[3] & arr2[7] > arr2[4] & arr2[7] > arr2[5] & arr2[7] > arr2[6] & arr2[7] > arr2[0] & Label67.Visible == true)
               {
                   Label67.Text = Label8.Text;
                   Label69.Text = Label67.Text;
               }*/
            //沒第八隊

            if (Label188.Text == Label244.Text)  //最後改
            {
                TextBox132.Visible = true;
                Button17.Visible = false;
                arr8[0] = 0;
                arr8[1] = 0;
                arr8[2] = 0;
                arr8[3] = 0;
                arr8[4] = 0;
                arr8[5] = 0;
                arr8[6] = 0;
                arr8[7] = 0;

            }

            con.Close();
        }
    }
}