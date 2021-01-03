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
    public partial class WebForm1 : System.Web.UI.Page
    {

        static int[] arr = new int[8];
        static int[] arr2 = new int[8];

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
                        Label34.Text = "歡迎" + "管理員" + "登入";

                        Random r = new Random();
                        String[] s = new String[16];
                        int j = 0;
                        for (int i = 0; i < s.Length; i++)
                        {
                            s[i] = "";
                        }


                        if (Session["Seed team"] != null)/////有種子時
                        {
                            s[15] = Session["Seed team"].ToString();

                            for (int i = 0; i < GridView1.Rows.Count; i++)
                            {
                                if (GridView1.Rows[i].Cells[1].Text == Session["Registration name"].ToString() & GridView1.Rows[i].Cells[4].Text == Session["Entries"].ToString() & GridView1.Rows[i].Cells[2].Text.ToString() != Session["Seed team"].ToString())
                                {
                                    while (true)
                                    {
                                        j = r.Next(0, 15);
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
                            Label48.Text = s[14];
                            Label47.Text = s[15];////////放種子

                        }
                        else  ///沒種子時
                        {
                            for (int i = 0; i < GridView1.Rows.Count; i++)
                            {
                                if (GridView1.Rows[i].Cells[1].Text == Session["Registration name"].ToString() & GridView1.Rows[i].Cells[4].Text == Session["Entries"].ToString())
                                {
                                    while (true)
                                    {
                                        j = r.Next(0, 16);
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
                    Label73.Text = Session["Registration name"] + "「" + Session["Entries"] + "」";   ////設置大標題是甚麼
                }
                else
                {
                    Label34.Visible = true;
                    Label34.Text = "您尚未登入 無法使用此功能喔";
                    Button1.Visible = false;
                    Button5.Visible = false;
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
                    User.Parameters.AddWithValue("@賽制", "16人單淘汰");
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
                    User_2.Parameters.AddWithValue("@賽制", "16人單淘汰");
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
                    User_3.Parameters.AddWithValue("@賽制", "16人單淘汰");
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
                    User_4.Parameters.AddWithValue("@賽制", "16人單淘汰");
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
                    User_5.Parameters.AddWithValue("@賽制", "16人單淘汰");
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
                    User_6.Parameters.AddWithValue("@賽制", "16人單淘汰");
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
                    User_7.Parameters.AddWithValue("@賽制", "16人單淘汰");
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

           /* if (c == 0 & TextBox1.Visible == false & TextBox2.Visible == false & TextBox3.Visible == false & TextBox4.Visible
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
            else if (c==1 & d==1 & f == 0 & TextBox13.Visible == false & TextBox14.Visible == false)
            {
                c = 0;
                d = 0;
                f = 0;
                Button1.Visible = false;
            }
            */

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

            con.Close();
        }//A區比賽

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["New"] = null;
            Button4.Visible = false;
            Label34.Visible = false;
            Response.Redirect("../index.aspx");
        }

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
                    User.Parameters.AddWithValue("@賽制", "16人單淘汰");
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
                    User_2.Parameters.AddWithValue("@賽制", "16人單淘汰");
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
                    User_3.Parameters.AddWithValue("@賽制", "16人單淘汰");
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
                    User_4.Parameters.AddWithValue("@賽制", "16人單淘汰");
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
                    User_5.Parameters.AddWithValue("@賽制", "16人單淘汰");
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
                    User_6.Parameters.AddWithValue("@賽制", "16人單淘汰");
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
                    User_7.Parameters.AddWithValue("@賽制", "16人單淘汰");
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
            else if (f == 0 & c==1 & d==1 & TextBox28.Visible == false & TextBox29.Visible == false)
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
                Button8.Visible = true;
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
            

            if (TextBox31.Text != "" && TextBox32.Text != "")
            {

                a = Convert.ToInt32(TextBox31.Text);
                b = Convert.ToInt32(TextBox32.Text);

                DateTime date = DateTime.Now;
                String str = date.ToString();

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                con.Open();
                string inscmd = "INSERT INTO 比賽資料 (比賽項目,參賽組別,賽制,隊伍A,分數A,隊伍B,分數B,區域幾輪,日期) values (@比賽項目,@參賽組別,@賽制,@隊伍A,@分數A,@隊伍B,@分數B,@區域幾輪,@日期)";
                SqlCommand User = new SqlCommand(inscmd, con);

                if (a != b)
                {
                    Label71.Text += a;
                    Label72.Text += b;
                    TextBox31.Visible = false;
                    TextBox32.Visible = false;
                    TextBox31.Text = "";
                    TextBox32.Text = "";
                    Label68.Visible = true;

                    User.Parameters.AddWithValue("@比賽項目", Session["Registration name"].ToString());
                    User.Parameters.AddWithValue("@參賽組別", Session["Entries"].ToString());
                    User.Parameters.AddWithValue("@賽制", "16人單淘汰");
                    User.Parameters.AddWithValue("@隊伍A", Label69.Text);
                    User.Parameters.AddWithValue("@分數A", a);
                    User.Parameters.AddWithValue("@隊伍B", Label70.Text);
                    User.Parameters.AddWithValue("@分數B", b);
                    User.Parameters.AddWithValue("@區域幾輪", "決賽最後一輪");
                    User.Parameters.AddWithValue("@日期", str);
                    User.ExecuteNonQuery();

                    if (a > b)
                    {
                        Image19.ImageUrl = "~/img/大大普通LR.jpg";
                        Label68.Text = Label69.Text;
                    }
                    else if (a < b)
                    {
                        Image19.ImageUrl = "~/img/大大普通RR.jpg";
                        Label68.Text = Label70.Text;
                    }

                }
            }
  
        }//決賽
    }
}