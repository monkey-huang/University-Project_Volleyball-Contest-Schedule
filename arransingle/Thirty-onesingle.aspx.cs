using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace 專題.arransingle
{
    public partial class Thirty_onesingle : System.Web.UI.Page
    {

        static int[] arr = new int[8]; //B區專用
        static int[] arr2 = new int[8];//A區專用
        static int[] arr3 = new int[8];//C區專用
        static int[] arr4 = new int[4];///決賽用
        static int[] arr5 = new int[8]; //D區專用                                      //
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
                        Button12.Visible = true;

                        Label34.Text = "歡迎" + "管理員" + "登入";

                        Random r = new Random();
                        String[] s = new String[31];
                        int j = 0;
                        for (int i = 0; i < s.Length; i++)
                        {
                            s[i] = "";
                        }


                        if (Session["Seed team"] != null)/////有種子時
                        {
                            s[30] = Session["Seed team"].ToString();

                            for (int i = 0; i < GridView1.Rows.Count; i++)
                            {
                                if (GridView1.Rows[i].Cells[1].Text == Session["Registration name"].ToString() & GridView1.Rows[i].Cells[4].Text == Session["Entries"].ToString() & GridView1.Rows[i].Cells[2].Text.ToString() != Session["Seed team"].ToString())
                                {
                                    while (true)
                                    {
                                        j = r.Next(0, 30);
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
                            ///////////////////////
                            Label41.Text = s[8];
                            Label42.Text = s[9];
                            Label43.Text = s[10];
                            Label44.Text = s[11];
                            Label45.Text = s[12];
                            Label46.Text = s[13];
                            Label47.Text = s[14];
                            Label48.Text = s[15];
                            ///////////////////////
                            Label80.Text = s[16];
                            Label81.Text = s[17];
                            Label82.Text = s[18];
                            Label83.Text = s[19];
                            Label84.Text = s[20];
                            Label85.Text = s[21];
                            Label87.Text = s[22];
                            Label86.Text = s[23];
                            /////////////////////////////////
                            Label115.Text = s[24];
                            Label116.Text = s[25];
                            Label117.Text = s[26];
                            Label118.Text = s[27];
                            Label119.Text = s[28];
                            Label120.Text = s[29];
                            Label121.Text = s[30];/////種子

                        }
                        else  ///沒種子時
                        {
                            for (int i = 0; i < GridView1.Rows.Count; i++)
                            {
                                if (GridView1.Rows[i].Cells[1].Text == Session["Registration name"].ToString() & GridView1.Rows[i].Cells[4].Text == Session["Entries"].ToString())
                                {
                                    while (true)
                                    {
                                        j = r.Next(0, 31);
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
                            ///////////////////////
                            Label41.Text = s[8];
                            Label42.Text = s[9];
                            Label43.Text = s[10];
                            Label44.Text = s[11];
                            Label45.Text = s[12];
                            Label46.Text = s[13];
                            Label47.Text = s[14];
                            Label48.Text = s[15];
                            ////////////////////////
                            Label80.Text = s[16];
                            Label81.Text = s[17];
                            Label82.Text = s[18];
                            Label83.Text = s[19];
                            Label84.Text = s[20];
                            Label85.Text = s[21];
                            Label87.Text = s[22];
                            Label86.Text = s[23];
                            /////////////////////////
                            Label115.Text = s[24];
                            Label116.Text = s[25];
                            Label117.Text = s[26];
                            Label118.Text = s[27];
                            Label119.Text = s[28];
                            Label120.Text = s[29];
                            Label121.Text = s[30];

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
                            Label37.Text = er.Message;
                        }

                        con.Close();
                    }

                    ///////////////////////////////////////////////////////////乾好亂喔////////////////////////////////////
                    Button4.Visible = true;//登出的按鈕
                    Label34.Visible = true;//登入時的文字
                    Label142.Text = Session["Registration name"] + "「" + Session["Entries"] + "」";   ////設置大標題是甚麼
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
                    User.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User.Parameters.AddWithValue("@隊伍A", Label1.Text);
                    User.Parameters.AddWithValue("@分數A", a);
                    User.Parameters.AddWithValue("@隊伍B", Label2.Text);
                    User.Parameters.AddWithValue("@分數B", b);
                    User.Parameters.AddWithValue("@區域幾輪", "A區第一輪");
                    User.Parameters.AddWithValue("@日期", str);
                    User.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image1.ImageUrl = "~/img/普通LR.jpg";
                        arr2[0] += 1;
                    }
                    else if (a < b)
                    {
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

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_2 = new SqlCommand(inscmd, con);
                    User_2.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_2.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_2.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User_2.Parameters.AddWithValue("@隊伍A", Label3.Text);
                    User_2.Parameters.AddWithValue("@分數A", a);
                    User_2.Parameters.AddWithValue("@隊伍B", Label4.Text);
                    User_2.Parameters.AddWithValue("@分數B", b);
                    User_2.Parameters.AddWithValue("@區域幾輪", "A區第一輪");
                    User_2.Parameters.AddWithValue("@日期", str);
                    User_2.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image2.ImageUrl = "~/img/普通LR.jpg";
                        arr2[2] += 1;
                    }
                    else if (a < b)
                    {
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
                    User_3.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User_3.Parameters.AddWithValue("@隊伍A", Label5.Text);
                    User_3.Parameters.AddWithValue("@分數A", a);
                    User_3.Parameters.AddWithValue("@隊伍B", Label6.Text);
                    User_3.Parameters.AddWithValue("@分數B", b);
                    User_3.Parameters.AddWithValue("@區域幾輪", "A區第一輪");
                    User_3.Parameters.AddWithValue("@日期", str);
                    User_3.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image3.ImageUrl = "~/img/普通LR.jpg";
                        arr2[4] += 1;
                    }
                    else if (a < b)
                    {
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

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_4 = new SqlCommand(inscmd, con);
                    User_4.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_4.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_4.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User_4.Parameters.AddWithValue("@隊伍A", Label7.Text);
                    User_4.Parameters.AddWithValue("@分數A", a);
                    User_4.Parameters.AddWithValue("@隊伍B", Label8.Text);
                    User_4.Parameters.AddWithValue("@分數B", b);
                    User_4.Parameters.AddWithValue("@區域幾輪", "A區第一輪");
                    User_4.Parameters.AddWithValue("@日期", str);
                    User_4.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image4.ImageUrl = "~/img/普通LR.jpg";
                        arr2[6] += 1;
                    }
                    else if (a < b)
                    {
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
                    User_5.Parameters.AddWithValue("@賽制", "31人單淘汰");
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
                        Image5.ImageUrl = "~/img/大普通LR.jpg";
                        arr2[0] += 1;
                        arr2[1] += 1;
                    }
                    else if (a < b)
                    {
                        Image5.ImageUrl = "~/img/大普通RR.jpg";
                        arr2[2] += 1;
                        arr2[3] += 1;
                    }
                }
            }
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
                    User_6.Parameters.AddWithValue("@賽制", "31人單淘汰");
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
                        Image6.ImageUrl = "~/img/大普通LR.jpg";
                        arr2[4] += 1;
                        arr2[5] += 1;
                    }
                    else if (a < b)
                    {
                        Image6.ImageUrl = "~/img/大普通RR.jpg";
                        arr2[6] += 1;
                        arr2[7] += 1;
                    }
                }
            }

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
                    User_7.Parameters.AddWithValue("@賽制", "31人單淘汰");
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
                        Image7.ImageUrl = "~/img/大大普通LR.jpg";
                        arr2[0] += 1;
                        arr2[1] += 1;
                        arr2[2] += 1;
                        arr2[3] += 1;
                    }
                    else if (a < b)
                    {
                        Image7.ImageUrl = "~/img/大大普通RR.jpg";
                        arr2[4] += 1;
                        arr2[5] += 1;
                        arr2[6] += 1;
                        arr2[7] += 1;
                    }
                }
            }

            //OVER

            /*if (c == 0 & TextBox1.Visible == false & TextBox2.Visible == false & TextBox3.Visible == false & TextBox4.Visible
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
                Label69.Text = Label67.Text;
            }
            else if (arr2[1] > arr2[0] && arr2[1] > arr2[2] & arr2[1] > arr2[3] & arr2[1] > arr2[4] & arr2[1] > arr2[5] & arr2[1] > arr2[6] & arr2[1] > arr2[7] & Label67.Visible == true)
            {
                Label67.Text = Label2.Text;
                Label69.Text = Label67.Text;
            }
            else if (arr2[2] > arr2[1] && arr2[2] > arr2[0] & arr2[2] > arr2[3] & arr2[2] > arr2[4] & arr2[2] > arr2[5] & arr2[2] > arr2[6] & arr2[2] > arr2[7] & Label67.Visible == true)
            {
                Label67.Text = Label3.Text;
                Label69.Text = Label67.Text;
            }
            else if (arr2[3] > arr2[1] && arr2[3] > arr2[2] & arr2[3] > arr2[0] & arr2[3] > arr2[4] & arr2[3] > arr2[5] & arr2[3] > arr2[6] & arr2[3] > arr2[7] & Label67.Visible == true)
            {
                Label67.Text = Label4.Text;
                Label69.Text = Label67.Text;
            }
            else if (arr2[4] > arr2[1] && arr2[4] > arr2[2] & arr2[4] > arr2[3] & arr2[4] > arr2[0] & arr2[4] > arr2[5] & arr2[4] > arr2[6] & arr2[4] > arr2[7] & Label67.Visible == true)
            {
                Label67.Text = Label5.Text;
                Label69.Text = Label67.Text;
            }
            else if (arr2[5] > arr2[1] && arr2[5] > arr2[2] & arr2[5] > arr2[3] & arr2[5] > arr2[4] & arr2[5] > arr2[0] & arr2[5] > arr2[6] & arr2[5] > arr2[7] & Label67.Visible == true)
            {
                Label67.Text = Label6.Text;
                Label69.Text = Label67.Text;
            }
            else if (arr2[6] > arr2[1] && arr2[6] > arr2[2] & arr2[6] > arr2[3] & arr2[6] > arr2[4] & arr2[6] > arr2[5] & arr2[6] > arr2[0] & arr2[6] > arr2[7] & Label67.Visible == true)
            {
                Label67.Text = Label7.Text;
                Label69.Text = Label67.Text;
            }
            else if (arr2[7] > arr2[1] && arr2[7] > arr2[2] & arr2[7] > arr2[3] & arr2[7] > arr2[4] & arr2[7] > arr2[5] & arr2[7] > arr2[6] & arr2[7] > arr2[0] & Label67.Visible == true)
            {
                Label67.Text = Label8.Text;
                Label69.Text = Label67.Text;
            }

            if (Label67.Text == Label69.Text)
            {
                Button1.Visible = false;
                TextBox31.Visible = true;
                arr2[0] = 0;
                arr2[1] = 0;
                arr2[2] = 0;
                arr2[3] = 0;
                arr2[4] = 0;
                arr2[5] = 0;
                arr2[6] = 0;
                arr2[7] = 0;

            }
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
                    User.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User.Parameters.AddWithValue("@隊伍A", Label41.Text);
                    User.Parameters.AddWithValue("@分數A", a);
                    User.Parameters.AddWithValue("@隊伍B", Label42.Text);
                    User.Parameters.AddWithValue("@分數B", b);
                    User.Parameters.AddWithValue("@區域幾輪", "B區第一輪");
                    User.Parameters.AddWithValue("@日期", str);
                    User.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image15.ImageUrl = "~/img/普通LR.jpg";
                        arr[0] += 1;
                    }
                    else if (a < b)
                    {
                        Image15.ImageUrl = "~/img/普通RR.jpg";
                        arr[1] += 1;
                    }
                }
            }
            if (TextBox18.Text != "" && TextBox19.Text != "")
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

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_2 = new SqlCommand(inscmd, con);
                    User_2.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_2.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_2.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User_2.Parameters.AddWithValue("@隊伍A", Label43.Text);
                    User_2.Parameters.AddWithValue("@分數A", a);
                    User_2.Parameters.AddWithValue("@隊伍B", Label44.Text);
                    User_2.Parameters.AddWithValue("@分數B", b);
                    User_2.Parameters.AddWithValue("@區域幾輪", "B區第一輪");
                    User_2.Parameters.AddWithValue("@日期", str);
                    User_2.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image16.ImageUrl = "~/img/普通LR.jpg";
                        arr[2] += 1;
                    }
                    else if (a < b)
                    {
                        Image16.ImageUrl = "~/img/普通RR.jpg";
                        arr[3] += 1;
                    }
                }
            }
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
                    User_3.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User_3.Parameters.AddWithValue("@隊伍A", Label45.Text);
                    User_3.Parameters.AddWithValue("@分數A", a);
                    User_3.Parameters.AddWithValue("@隊伍B", Label46.Text);
                    User_3.Parameters.AddWithValue("@分數B", b);
                    User_3.Parameters.AddWithValue("@區域幾輪", "B區第一輪");
                    User_3.Parameters.AddWithValue("@日期", str);
                    User_3.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image17.ImageUrl = "~/img/普通LR.jpg";
                        arr[4] += 1;
                    }
                    else if (a < b)
                    {
                        Image17.ImageUrl = "~/img/普通RR.jpg";
                        arr[5] += 1;
                    }
                }
            }
            if (TextBox22.Text != "" && TextBox23.Text != "")
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

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_4 = new SqlCommand(inscmd, con);
                    User_4.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_4.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_4.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User_4.Parameters.AddWithValue("@隊伍A", Label47.Text);
                    User_4.Parameters.AddWithValue("@分數A", a);
                    User_4.Parameters.AddWithValue("@隊伍B", Label48.Text);
                    User_4.Parameters.AddWithValue("@分數B", b);
                    User_4.Parameters.AddWithValue("@區域幾輪", "B區第一輪");
                    User_4.Parameters.AddWithValue("@日期", str);
                    User_4.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image18.ImageUrl = "~/img/普通LR.jpg";
                        arr[6] += 1;
                    }
                    else if (a < b)
                    {
                        Image18.ImageUrl = "~/img/普通RR.jpg";
                        arr[7] += 1;
                    }
                }
            }
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
                    User_5.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    if (arr[0] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label41.Text);
                    }
                    else if (arr[1] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label42.Text);
                    }

                    User_5.Parameters.AddWithValue("@分數A", a);

                    if (arr[2] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍B", Label43.Text);
                    }
                    else if (arr[3] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍B", Label44.Text);
                    }

                    User_5.Parameters.AddWithValue("@分數B", b);
                    User_5.Parameters.AddWithValue("@區域幾輪", "B區第二輪");
                    User_5.Parameters.AddWithValue("@日期", str);
                    User_5.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image9.ImageUrl = "~/img/大普通LR.jpg";
                        arr[0] += 1;
                        arr[1] += 1;
                    }
                    else if (a < b)
                    {
                        Image9.ImageUrl = "~/img/大普通RR.jpg";
                        arr[2] += 1;
                        arr[3] += 1;
                    }
                }
            }
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

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_6 = new SqlCommand(inscmd, con);
                    User_6.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_6.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_6.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    if (arr[4] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label45.Text);
                    }
                    else if (arr[5] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label46.Text);
                    }

                    User_6.Parameters.AddWithValue("@分數A", a);

                    if (arr[6] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍B", Label47.Text);
                    }
                    else if (arr[7] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍B", Label48.Text);
                    }
                    User_6.Parameters.AddWithValue("@分數B", b);
                    User_6.Parameters.AddWithValue("@區域幾輪", "B區第二輪");
                    User_6.Parameters.AddWithValue("@日期", str);
                    User_6.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image10.ImageUrl = "~/img/大普通LR.jpg";
                        arr[4] += 1;
                        arr[5] += 1;
                    }
                    else if (a < b)
                    {
                        Image10.ImageUrl = "~/img/大普通RR.jpg";
                        arr[6] += 1;
                        arr[7] += 1;
                    }
                }
            }

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

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_7 = new SqlCommand(inscmd, con);
                    User_7.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_7.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_7.Parameters.AddWithValue("@賽制", "31人單淘汰");
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
                        Image8.ImageUrl = "~/img/大大普通LR.jpg";
                        arr[0] += 1;
                        arr[1] += 1;
                        arr[2] += 1;
                        arr[3] += 1;
                    }
                    else if (a < b)
                    {
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
             }*/

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (arr[0] > arr[1] && arr[0] > arr[2] & arr[0] > arr[3] & arr[0] > arr[4] & arr[0] > arr[5] & arr[0] > arr[6] & arr[0] > arr[7] & Label66.Visible == true)
            {
                Label66.Text = Label41.Text;
                Label70.Text = Label66.Text;
            }
            else if (arr[1] > arr[0] && arr[1] > arr[2] & arr[1] > arr[3] & arr[1] > arr[4] & arr[1] > arr[5] & arr[1] > arr[6] & arr[1] > arr[7] & Label66.Visible == true)
            {
                Label66.Text = Label42.Text;
                Label70.Text = Label66.Text;
            }
            else if (arr[2] > arr[1] && arr[2] > arr[0] & arr[2] > arr[3] & arr[2] > arr[4] & arr[2] > arr[5] & arr[2] > arr[6] & arr[2] > arr[7] & Label66.Visible == true)
            {
                Label66.Text = Label43.Text;
                Label70.Text = Label66.Text;
            }
            else if (arr[3] > arr[1] && arr[3] > arr[2] & arr[3] > arr[0] & arr[3] > arr[4] & arr[3] > arr[5] & arr[3] > arr[6] & arr[3] > arr[7] & Label66.Visible == true)
            {
                Label66.Text = Label44.Text;
                Label70.Text = Label66.Text;
            }
            else if (arr[4] > arr[1] && arr[4] > arr[2] & arr[4] > arr[3] & arr[4] > arr[0] & arr[4] > arr[5] & arr[4] > arr[6] & arr[4] > arr[7] & Label66.Visible == true)
            {
                Label66.Text = Label45.Text;
                Label70.Text = Label66.Text;
            }
            else if (arr[5] > arr[1] && arr[5] > arr[2] & arr[5] > arr[3] & arr[5] > arr[4] & arr[5] > arr[0] & arr[5] > arr[6] & arr[5] > arr[7] & Label66.Visible == true)
            {
                Label66.Text = Label46.Text;
                Label70.Text = Label66.Text;

            }
            else if (arr[6] > arr[1] && arr[6] > arr[2] & arr[6] > arr[3] & arr[6] > arr[4] & arr[6] > arr[5] & arr[6] > arr[0] & arr[6] > arr[7] & Label66.Visible == true)
            {
                Label66.Text = Label47.Text;
                Label70.Text = Label66.Text;
            }
            else if (arr[7] > arr[1] && arr[7] > arr[2] & arr[7] > arr[3] & arr[7] > arr[4] & arr[7] > arr[5] & arr[7] > arr[6] & arr[7] > arr[0] & Label66.Visible == true)
            {
                Label66.Text = Label48.Text;
                Label70.Text = Label66.Text;
            }

            if (Label66.Text == Label70.Text)
            {
                Button5.Visible = false;
                TextBox32.Visible = true;
                arr[0] = 0;
                arr[1] = 0;
                arr[2] = 0;
                arr[3] = 0;
                arr[4] = 0;
                arr[5] = 0;
                arr[6] = 0;
                arr[7] = 0;
            }


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

            if (TextBox31.Text != "" && TextBox32.Text != "")
            {

                a = Convert.ToInt32(TextBox31.Text);
                b = Convert.ToInt32(TextBox32.Text);
                if (a != b)
                {
                    Label71.Text += a;
                    Label72.Text += b;
                    TextBox31.Visible = false;
                    TextBox32.Visible = false;
                    TextBox31.Text = "";
                    TextBox32.Text = "";
                    TextBox49.Visible = true;

                    User.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User.Parameters.AddWithValue("@隊伍A", Label69.Text);
                    User.Parameters.AddWithValue("@分數A", a);
                    User.Parameters.AddWithValue("@隊伍B", Label70.Text);
                    User.Parameters.AddWithValue("@分數B", b);
                    User.Parameters.AddWithValue("@區域幾輪", "決賽區第一輪");
                    User.Parameters.AddWithValue("@日期", str);
                    User.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image19.ImageUrl = "~/img/大普通LR.jpg";
                        arr4[0] += 1;

                    }
                    else if (a < b)
                    {
                        Image19.ImageUrl = "~/img/大普通RR.jpg";
                        arr4[1] += 1;
                    }
                }

            }
            if (TextBox65.Text != "" && TextBox66.Text != "")
            {

                a = Convert.ToInt32(TextBox65.Text);
                b = Convert.ToInt32(TextBox66.Text);
                if (a != b)
                {
                    Label140.Text += a;
                    Label141.Text += b;
                    TextBox65.Visible = false;
                    TextBox66.Visible = false;
                    TextBox65.Text = "";
                    TextBox66.Text = "";
                    TextBox50.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_2 = new SqlCommand(inscmd, con);
                    User_2.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_2.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_2.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User_2.Parameters.AddWithValue("@隊伍A", Label104.Text);
                    User_2.Parameters.AddWithValue("@分數A", a);
                    User_2.Parameters.AddWithValue("@隊伍B", Label139.Text);
                    User_2.Parameters.AddWithValue("@分數B", b);
                    User_2.Parameters.AddWithValue("@區域幾輪", "決賽區第一輪");
                    User_2.Parameters.AddWithValue("@日期", str);
                    User_2.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image27.ImageUrl = "~/img/大普通LR.jpg";
                        arr4[2] += 1;

                    }
                    else if (a < b)
                    {
                        Image27.ImageUrl = "~/img/大普通RR.jpg";
                        arr4[3] += 1;
                    }
                }
            }
            ///////////////第一輪////////////
            if (TextBox49.Text != "" && TextBox50.Text != "")
            {

                a = Convert.ToInt32(TextBox49.Text);
                b = Convert.ToInt32(TextBox50.Text);
                if (a != b)
                {
                    Label106.Text += a;
                    Label107.Text += b;
                    TextBox49.Visible = false;
                    TextBox50.Visible = false;
                    TextBox49.Text = "";
                    TextBox50.Text = "";
                    Button8.Visible = false;
                    Label68.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_5 = new SqlCommand(inscmd, con);
                    User_5.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_5.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_5.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    if (arr4[0] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label69.Text);
                    }
                    else if (arr4[1] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label70.Text);
                    }

                    User_5.Parameters.AddWithValue("@分數A", a);

                    if (arr4[2] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍B", Label104.Text);
                    }
                    else if (arr4[3] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍B", Label139.Text);
                    }
                    User_5.Parameters.AddWithValue("@分數B", b);
                    User_5.Parameters.AddWithValue("@區域幾輪", "決賽區總決賽");
                    User_5.Parameters.AddWithValue("@日期", str);
                    User_5.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image28.ImageUrl = "~/img/大大大普通LR.jpg";
                        arr4[0] += 1;
                        arr4[1] += 1;

                    }
                    else if (a < b)
                    {
                        Image28.ImageUrl = "~/img/大大大普通RR.jpg";
                        arr4[2] += 1;
                        arr4[3] += 1;
                    }
                }
            }
            /* if (c == 0 & TextBox31.Visible == false & TextBox32.Visible == false & TextBox65.Visible == false & TextBox66.Visible == false
                 /*& Label11.Text!="" & Label12.Text!="" & Label13.Text!="" & Label14.Text!="" & Label15.Text!="" & Label16.Text!="" & Label17.Text!="" &
                 Label18.Text!="")
             {
                 c++;
                 TextBox49.Visible = true;
                 TextBox50.Visible = true;
             }
             else if (d == 0 & c == 1 & TextBox49.Visible == false & TextBox50.Visible == false)
             {
                 c = 0;
                 Button8.Visible = false;

             }*/


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (arr4[0] > arr4[1] && arr4[0] > arr4[2] & arr4[0] > arr4[3] & Label68.Visible == true)
            {
                Label68.Text = Label69.Text;
                arr4[0] = 0;
                arr4[1] = 0;
                arr4[2] = 0;
                arr4[3] = 0;
            }
            else if (arr4[1] > arr4[0] && arr4[1] > arr4[2] & arr4[1] > arr4[3] & Label68.Visible == true)
            {
                Label68.Text = Label70.Text;
                arr4[0] = 0;
                arr4[1] = 0;
                arr4[2] = 0;
                arr4[3] = 0;
            }
            else if (arr4[2] > arr4[1] && arr4[2] > arr4[0] & arr4[2] > arr4[3] & Label68.Visible == true)
            {
                Label68.Text = Label104.Text;
                arr4[0] = 0;
                arr4[1] = 0;
                arr4[2] = 0;
                arr4[3] = 0;
            }
            else if (arr4[3] > arr4[1] && arr4[3] > arr4[0] & arr4[3] > arr4[0] & Label68.Visible == true)
            {
                Label68.Text = Label139.Text;
                arr4[0] = 0;
                arr4[1] = 0;
                arr4[2] = 0;
                arr4[3] = 0;
            }


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
                    User.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User.Parameters.AddWithValue("@隊伍A", Label80.Text);
                    User.Parameters.AddWithValue("@分數A", a);
                    User.Parameters.AddWithValue("@隊伍B", Label81.Text);
                    User.Parameters.AddWithValue("@分數B", b);
                    User.Parameters.AddWithValue("@區域幾輪", "C區第一輪");
                    User.Parameters.AddWithValue("@日期", str);
                    User.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image23.ImageUrl = "~/img/普通LR.jpg";
                        arr3[0] += 1;
                    }
                    else if (a < b)
                    {
                        Image23.ImageUrl = "~/img/普通RR.jpg";
                        arr3[1] += 1;
                    }
                }
            }
            if (TextBox41.Text != "" && TextBox42.Text != "")
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

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_2 = new SqlCommand(inscmd, con);
                    User_2.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_2.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_2.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User_2.Parameters.AddWithValue("@隊伍A", Label82.Text);
                    User_2.Parameters.AddWithValue("@分數A", a);
                    User_2.Parameters.AddWithValue("@隊伍B", Label83.Text);
                    User_2.Parameters.AddWithValue("@分數B", b);
                    User_2.Parameters.AddWithValue("@區域幾輪", "C區第一輪");
                    User_2.Parameters.AddWithValue("@日期", str);
                    User_2.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image24.ImageUrl = "~/img/普通LR.jpg";
                        arr3[2] += 1;
                    }
                    else if (a < b)
                    {
                        Image24.ImageUrl = "~/img/普通RR.jpg";
                        arr3[3] += 1;
                    }
                }
            }
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
                    User_3.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User_3.Parameters.AddWithValue("@隊伍A", Label84.Text);
                    User_3.Parameters.AddWithValue("@分數A", a);
                    User_3.Parameters.AddWithValue("@隊伍B", Label85.Text);
                    User_3.Parameters.AddWithValue("@分數B", b);
                    User_3.Parameters.AddWithValue("@區域幾輪", "C區第一輪");
                    User_3.Parameters.AddWithValue("@日期", str);
                    User_3.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image25.ImageUrl = "~/img/普通LR.jpg";
                        arr3[4] += 1;
                    }
                    else if (a < b)
                    {
                        Image25.ImageUrl = "~/img/普通RR.jpg";
                        arr3[5] += 1;
                    }
                }
            }
            if (TextBox45.Text != "" && TextBox46.Text != "")
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

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_4 = new SqlCommand(inscmd, con);
                    User_4.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_4.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_4.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User_4.Parameters.AddWithValue("@隊伍A", Label86.Text);
                    User_4.Parameters.AddWithValue("@分數A", a);
                    User_4.Parameters.AddWithValue("@隊伍B", Label87.Text);
                    User_4.Parameters.AddWithValue("@分數B", b);
                    User_4.Parameters.AddWithValue("@區域幾輪", "C區第一輪");
                    User_4.Parameters.AddWithValue("@日期", str);
                    User_4.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image26.ImageUrl = "~/img/普通LR.jpg";
                        arr3[6] += 1;
                    }
                    else if (a < b)
                    {
                        Image26.ImageUrl = "~/img/普通RR.jpg";
                        arr3[7] += 1;
                    }
                }
            }
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
                    User_5.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    if (arr3[0] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label80.Text);
                    }
                    else if (arr3[1] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label81.Text);
                    }

                    User_5.Parameters.AddWithValue("@分數A", a);

                    if (arr3[2] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍B", Label82.Text);
                    }
                    else if (arr3[3] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍B", Label83.Text);
                    }

                    User_5.Parameters.AddWithValue("@分數B", b);
                    User_5.Parameters.AddWithValue("@區域幾輪", "C區第二輪");
                    User_5.Parameters.AddWithValue("@日期", str);
                    User_5.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image21.ImageUrl = "~/img/大普通LR.jpg";
                        arr3[0] += 1;
                        arr3[1] += 1;
                    }
                    else if (a < b)
                    {
                        Image21.ImageUrl = "~/img/大普通RR.jpg";
                        arr3[2] += 1;
                        arr3[3] += 1;
                    }
                }
            }
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

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_6 = new SqlCommand(inscmd, con);
                    User_6.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_6.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_6.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    if (arr3[4] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label84.Text);
                    }
                    else if (arr3[5] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label85.Text);
                    }

                    User_6.Parameters.AddWithValue("@分數A", a);

                    if (arr3[6] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍B", Label86.Text);
                    }
                    else if (arr3[7] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍B", Label87.Text);
                    }
                    User_6.Parameters.AddWithValue("@分數B", b);
                    User_6.Parameters.AddWithValue("@區域幾輪", "C區第二輪");
                    User_6.Parameters.AddWithValue("@日期", str);
                    User_6.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image22.ImageUrl = "~/img/大普通LR.jpg";
                        arr3[4] += 1;
                        arr3[5] += 1;
                    }
                    else if (a < b)
                    {
                        Image22.ImageUrl = "~/img/大普通RR.jpg";
                        arr3[6] += 1;
                        arr3[7] += 1;
                    }
                }
            }

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

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_7 = new SqlCommand(inscmd, con);
                    User_7.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_7.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_7.Parameters.AddWithValue("@賽制", "31人單淘汰");
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
                        Image20.ImageUrl = "~/img/大大普通LR.jpg";
                        arr3[0] += 1;
                        arr3[1] += 1;
                        arr3[2] += 1;
                        arr3[3] += 1;
                    }
                    else if (a < b)
                    {
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
                Label104.Text = Label73.Text;
            }
            else if (arr3[1] > arr3[0] && arr3[1] > arr3[2] & arr3[1] > arr3[3] & arr3[1] > arr3[4] & arr3[1] > arr3[5] & arr3[1] > arr3[6] & arr3[1] > arr3[7] & Label73.Visible == true)
            {
                Label73.Text = Label81.Text;
                Label104.Text = Label73.Text;
            }
            else if (arr3[2] > arr3[1] && arr3[2] > arr3[0] & arr3[2] > arr3[3] & arr3[2] > arr3[4] & arr3[2] > arr3[5] & arr3[2] > arr3[6] & arr3[2] > arr3[7] & Label73.Visible == true)
            {
                Label73.Text = Label82.Text;
                Label104.Text = Label73.Text;
            }
            else if (arr3[3] > arr3[1] && arr3[3] > arr3[2] & arr3[3] > arr3[0] & arr3[3] > arr3[4] & arr3[3] > arr3[5] & arr3[3] > arr3[6] & arr3[3] > arr3[7] & Label73.Visible == true)
            {
                Label73.Text = Label83.Text;
                Label104.Text = Label73.Text;
            }
            else if (arr3[4] > arr3[1] && arr3[4] > arr3[2] & arr3[4] > arr3[3] & arr3[4] > arr3[0] & arr3[4] > arr3[5] & arr3[4] > arr3[6] & arr3[4] > arr3[7] & Label73.Visible == true)
            {
                Label73.Text = Label84.Text;
                Label104.Text = Label73.Text;
            }
            else if (arr3[5] > arr3[1] && arr3[5] > arr3[2] & arr3[5] > arr3[3] & arr3[5] > arr3[4] & arr3[5] > arr3[0] & arr3[5] > arr3[6] & arr3[5] > arr3[7] & Label73.Visible == true)
            {
                Label73.Text = Label85.Text;
                Label104.Text = Label73.Text;

            }
            else if (arr3[6] > arr3[1] && arr3[6] > arr3[2] & arr3[6] > arr3[3] & arr3[6] > arr3[4] & arr3[6] > arr3[5] & arr3[6] > arr3[0] & arr3[6] > arr3[7] & Label73.Visible == true)
            {
                Label73.Text = Label86.Text;
                Label104.Text = Label73.Text;
            }
            else if (arr3[7] > arr3[1] && arr3[7] > arr3[2] & arr3[7] > arr3[3] & arr3[7] > arr3[4] & arr3[7] > arr3[5] & arr3[7] > arr3[6] & arr3[7] > arr3[0] & Label73.Visible == true)
            {
                Label73.Text = Label87.Text;
                Label104.Text = Label73.Text;
            }
            if (Label73.Text == Label104.Text)
            {
                Button11.Visible = false;
                TextBox65.Visible = true;
                arr3[0] = 0;
                arr3[1] = 0;
                arr3[2] = 0;
                arr3[3] = 0;
                arr3[4] = 0;
                arr3[5] = 0;
                arr3[6] = 0;
                arr3[7] = 0;
            }

        }//C區比賽

        protected void Button12_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            DateTime date = DateTime.Now;
            String str = date.ToString();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            string inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
            SqlCommand User = new SqlCommand(inscmd, con);

            if (TextBox57.Text != "" && TextBox58.Text != "")
            {

                a = Convert.ToInt32(TextBox57.Text);
                b = Convert.ToInt32(TextBox58.Text);
                if (a != b)
                {
                    Label123.Text += a;
                    Label124.Text += b;
                    TextBox57.Visible = false;
                    TextBox58.Visible = false;
                    TextBox57.Text = "";
                    TextBox58.Text = "";
                    TextBox53.Visible = true;

                    User.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User.Parameters.AddWithValue("@隊伍A", Label115.Text);
                    User.Parameters.AddWithValue("@分數A", a);
                    User.Parameters.AddWithValue("@隊伍B", Label116.Text);
                    User.Parameters.AddWithValue("@分數B", b);
                    User.Parameters.AddWithValue("@區域幾輪", "D區第一輪");
                    User.Parameters.AddWithValue("@日期", str);
                    User.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image32.ImageUrl = "~/img/普通LR.jpg";
                        arr5[0] += 1;
                    }
                    else if (a < b)
                    {
                        Image32.ImageUrl = "~/img/普通RR.jpg";
                        arr5[1] += 1;
                    }
                }
            }
            if (TextBox59.Text != "" && TextBox60.Text != "")
            {
                a = Convert.ToInt32(TextBox59.Text);
                b = Convert.ToInt32(TextBox60.Text);
                if (a != b)
                {
                    Label125.Text += a;
                    Label126.Text += b;
                    TextBox59.Visible = false;
                    TextBox60.Visible = false;
                    TextBox59.Text = "";
                    TextBox60.Text = "";
                    TextBox54.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_2 = new SqlCommand(inscmd, con);
                    User_2.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_2.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_2.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User_2.Parameters.AddWithValue("@隊伍A", Label117.Text);
                    User_2.Parameters.AddWithValue("@分數A", a);
                    User_2.Parameters.AddWithValue("@隊伍B", Label118.Text);
                    User_2.Parameters.AddWithValue("@分數B", b);
                    User_2.Parameters.AddWithValue("@區域幾輪", "D區第一輪");
                    User_2.Parameters.AddWithValue("@日期", str);
                    User_2.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image33.ImageUrl = "~/img/普通LR.jpg";
                        arr5[2] += 1;
                    }
                    else if (a < b)
                    {
                        Image33.ImageUrl = "~/img/普通RR.jpg";
                        arr5[3] += 1;
                    }
                }
            }
            if (TextBox61.Text != "" && TextBox62.Text != "")
            {
                a = Convert.ToInt32(TextBox61.Text);
                b = Convert.ToInt32(TextBox62.Text);
                if (a != b)
                {
                    Label127.Text += a;
                    Label128.Text += b;
                    TextBox61.Visible = false;
                    TextBox62.Visible = false;
                    TextBox61.Text = "";
                    TextBox62.Text = "";
                    TextBox55.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_3 = new SqlCommand(inscmd, con);
                    User_3.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_3.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_3.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User_3.Parameters.AddWithValue("@隊伍A", Label119.Text);
                    User_3.Parameters.AddWithValue("@分數A", a);
                    User_3.Parameters.AddWithValue("@隊伍B", Label120.Text);
                    User_3.Parameters.AddWithValue("@分數B", b);
                    User_3.Parameters.AddWithValue("@區域幾輪", "D區第一輪");
                    User_3.Parameters.AddWithValue("@日期", str);
                    User_3.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image34.ImageUrl = "~/img/普通LR.jpg";
                        arr5[4] += 1;
                    }
                    else if (a < b)
                    {
                        Image34.ImageUrl = "~/img/普通RR.jpg";
                        arr5[5] += 1;
                    }
                }
            }
            if (TextBox63.Text != "" && TextBox64.Text != "")
            {
                a = Convert.ToInt32(TextBox63.Text);
                b = Convert.ToInt32(TextBox64.Text);
                if (a != b)
                {
                    Label129.Text += a;
                    Label130.Text += b;
                    TextBox63.Visible = false;
                    TextBox64.Visible = false;
                    TextBox63.Text = "";
                    TextBox64.Text = "";
                    TextBox56.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_4 = new SqlCommand(inscmd, con);
                    User_4.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_4.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_4.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    User_4.Parameters.AddWithValue("@隊伍A", Label121.Text);
                    User_4.Parameters.AddWithValue("@分數A", a);
                    User_4.Parameters.AddWithValue("@隊伍B", Label122.Text);
                    User_4.Parameters.AddWithValue("@分數B", b);
                    User_4.Parameters.AddWithValue("@區域幾輪", "D區第一輪");
                    User_4.Parameters.AddWithValue("@日期", str);
                    User_4.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image35.ImageUrl = "~/img/普通LR.jpg";
                        arr5[6] += 1;
                    }
                    else if (a < b)
                    {
                        Image35.ImageUrl = "~/img/普通RR.jpg";
                        arr5[7] += 1;
                    }
                }
            }
            //第一輪結束

            if (TextBox53.Text != "" && TextBox54.Text != "")
            {
                a = Convert.ToInt32(TextBox53.Text);
                b = Convert.ToInt32(TextBox54.Text);
                if (a != b)
                {
                    Label111.Text += a;
                    Label112.Text += b;
                    TextBox53.Visible = false;
                    TextBox54.Visible = false;
                    TextBox53.Text = "";
                    TextBox54.Text = "";
                    TextBox51.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_5 = new SqlCommand(inscmd, con);
                    User_5.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_5.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_5.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    if (arr5[0] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label115.Text);
                    }
                    else if (arr5[1] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍A", Label116.Text);
                    }

                    User_5.Parameters.AddWithValue("@分數A", a);

                    if (arr5[2] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍B", Label117.Text);
                    }
                    else if (arr5[3] == 1)
                    {
                        User_5.Parameters.AddWithValue("@隊伍B", Label118.Text);
                    }

                    User_5.Parameters.AddWithValue("@分數B", b);
                    User_5.Parameters.AddWithValue("@區域幾輪", "D區第二輪");
                    User_5.Parameters.AddWithValue("@日期", str);
                    User_5.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image30.ImageUrl = "~/img/大普通LR.jpg";
                        arr5[0] += 1;
                        arr5[1] += 1;
                    }
                    else if (a < b)
                    {
                        Image30.ImageUrl = "~/img/大普通RR.jpg";
                        arr5[2] += 1;
                        arr5[3] += 1;
                    }
                }
            }
            if (TextBox55.Text != "" && TextBox56.Text != "")
            {
                a = Convert.ToInt32(TextBox55.Text);
                b = Convert.ToInt32(TextBox56.Text);
                if (a != b)
                {
                    Label113.Text += a;
                    Label114.Text += b;
                    TextBox55.Visible = false;
                    TextBox56.Visible = false;
                    TextBox55.Text = "";
                    TextBox56.Text = "";
                    TextBox52.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_6 = new SqlCommand(inscmd, con);
                    User_6.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_6.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_6.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    if (arr5[4] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label119.Text);
                    }
                    else if (arr5[5] == 1)
                    {
                        User_6.Parameters.AddWithValue("@隊伍A", Label120.Text);
                    }

                    User_6.Parameters.AddWithValue("@分數A", a);

                    User_6.Parameters.AddWithValue("@隊伍B", Label121.Text);/////永遠是這隊伍

                    User_6.Parameters.AddWithValue("@分數B", b);
                    User_6.Parameters.AddWithValue("@區域幾輪", "D區第二輪");
                    User_6.Parameters.AddWithValue("@日期", str);
                    User_6.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image31.ImageUrl = "~/img/大普通LR.jpg";
                        arr5[4] += 1;
                        arr5[5] += 1;
                    }
                    else if (a < b)
                    {
                        Image31.ImageUrl = "~/img/大普通RR.jpg";
                        arr5[6] += 2;
                        arr5[7] += 1;
                    }



                }
            }

            //第二輪結束
            if (TextBox51.Text != "" && TextBox52.Text != "")
            {
                a = Convert.ToInt32(TextBox51.Text);
                b = Convert.ToInt32(TextBox52.Text);
                if (a != b)
                {
                    Label109.Text += a;
                    Label110.Text += b;
                    TextBox51.Visible = false;
                    TextBox52.Visible = false;
                    TextBox51.Text = "";
                    TextBox52.Text = "";
                    Label108.Visible = true;
                    Button8.Visible = true;

                    inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                    SqlCommand User_7 = new SqlCommand(inscmd, con);
                    User_7.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User_7.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User_7.Parameters.AddWithValue("@賽制", "31人單淘汰");
                    if (arr5[0] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label115.Text);
                    }
                    else if (arr5[1] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label116.Text);
                    }
                    else if (arr5[2] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label117.Text);
                    }
                    else if (arr5[3] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍A", Label118.Text);
                    }

                    User_7.Parameters.AddWithValue("@分數A", a);

                    if (arr5[4] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label119.Text);
                    }
                    else if (arr5[5] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label120.Text);
                    }
                    else if (arr5[6] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label121.Text);
                    }
                    else if (arr5[7] == 2)
                    {
                        User_7.Parameters.AddWithValue("@隊伍B", Label122.Text);
                    }

                    User_7.Parameters.AddWithValue("@分數B", b);
                    User_7.Parameters.AddWithValue("@區域幾輪", "D區第三輪");
                    User_7.Parameters.AddWithValue("@日期", str);
                    User_7.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image29.ImageUrl = "~/img/大大普通LR.jpg";
                        arr5[0] += 1;
                        arr5[1] += 1;
                        arr5[2] += 1;
                        arr5[3] += 1;
                    }
                    else if (a < b)
                    {
                        Image29.ImageUrl = "~/img/大大普通RR.jpg";
                        arr5[4] += 1;
                        arr5[5] += 1;
                        arr5[6] += 1;
                        arr5[7] += 1;
                    }
                }

            }
            //OVER

            /*if (c == 0 & TextBox57.Visible == false & TextBox58.Visible == false & TextBox59.Visible == false & TextBox60.Visible
                == false & TextBox61.Visible == false & TextBox62.Visible == false & TextBox63.Visible == false & TextBox64.Visible == false
                /*& Label11.Text!="" & Label12.Text!="" & Label13.Text!="" & Label14.Text!="" & Label15.Text!="" & Label16.Text!="" & Label17.Text!="" &
                Label18.Text!="")
            {
                c++;
                TextBox53.Visible = true;
                TextBox54.Visible = true;
                TextBox55.Visible = true;
                TextBox56.Visible = true;
            }
            else if (d == 0 & c == 1 & TextBox53.Visible == false & TextBox54.Visible == false & TextBox55.Visible == false & TextBox56.Visible == false)
            {
                d++;
                TextBox51.Visible = true;
                TextBox52.Visible = true;
            }
            else if (f == 0 & c == 1 & d == 1 & TextBox51.Visible == false & TextBox52.Visible == false)
            {
                c = 0;
                d = 0;
                f = 0;
                Button12.Visible = false;
            }*/

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (arr5[0] > arr5[1] && arr5[0] > arr5[2] & arr5[0] > arr5[3] & arr5[0] > arr5[4] & arr5[0] > arr5[5] & arr5[0] > arr5[6] & arr5[0] > arr5[7] & Label108.Visible == true)
            {
                Label108.Text = Label115.Text;
                Label139.Text = Label108.Text;
            }
            else if (arr5[1] > arr5[0] && arr5[1] > arr5[2] & arr5[1] > arr5[3] & arr5[1] > arr5[4] & arr5[1] > arr5[5] & arr5[1] > arr5[6] & arr5[1] > arr5[7] & Label108.Visible == true)
            {
                Label108.Text = Label116.Text;
                Label139.Text = Label108.Text;
            }
            else if (arr5[2] > arr5[1] && arr5[2] > arr5[0] & arr5[2] > arr5[3] & arr5[2] > arr5[4] & arr5[2] > arr5[5] & arr5[2] > arr5[6] & arr5[2] > arr5[7] & Label108.Visible == true)
            {
                Label108.Text = Label117.Text;
                Label139.Text = Label108.Text;
            }
            else if (arr5[3] > arr5[1] && arr5[3] > arr5[2] & arr5[3] > arr5[0] & arr5[3] > arr5[4] & arr5[3] > arr5[5] & arr5[3] > arr5[6] & arr5[3] > arr5[7] & Label108.Visible == true)
            {
                Label108.Text = Label118.Text;
                Label139.Text = Label108.Text;
            }
            else if (arr5[4] > arr5[1] && arr5[4] > arr5[2] & arr5[4] > arr5[3] & arr5[4] > arr5[0] & arr5[4] > arr5[5] & arr5[4] > arr5[6] & arr5[4] > arr5[7] & Label108.Visible == true)
            {
                Label108.Text = Label119.Text;
                Label139.Text = Label108.Text;
            }
            else if (arr5[5] > arr5[1] && arr5[5] > arr5[2] & arr5[5] > arr5[3] & arr5[5] > arr5[4] & arr5[5] > arr5[0] & arr5[5] > arr5[6] & arr5[5] > arr5[7] & Label108.Visible == true)
            {
                Label108.Text = Label120.Text;
                Label139.Text = Label108.Text;

            }
            else if (arr5[6] > arr5[1] && arr5[6] > arr5[2] & arr5[6] > arr5[3] & arr5[6] > arr5[4] & arr5[6] > arr5[5] & arr5[6] > arr5[0] & arr5[6] > arr5[7] & Label108.Visible == true)
            {
                Label108.Text = Label121.Text;
                Label139.Text = Label108.Text;
            }
            else if (arr5[7] > arr5[1] && arr5[7] > arr5[2] & arr5[7] > arr5[3] & arr5[7] > arr5[4] & arr5[7] > arr5[5] & arr5[7] > arr5[6] & arr5[7] > arr5[0] & Label108.Visible == true)
            {
                Label108.Text = Label122.Text;
                Label139.Text = Label108.Text;
            }
            if (Label108.Text == Label139.Text)
            {
                Button12.Visible = false;
                TextBox66.Visible = true;
                arr5[0] = 0;
                arr5[1] = 0;
                arr5[2] = 0;
                arr5[3] = 0;
                arr5[4] = 0;
                arr5[5] = 0;
                arr5[6] = 0;
                arr5[7] = 0;
            }
        }//D區比賽



    }
}