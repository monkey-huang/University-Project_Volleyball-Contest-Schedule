<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sign up.aspx.cs" Inherits="專題.Sign_up" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <style type='text/css'>
.con {

    text-align:center;
    }
        .tab {
            height:auto;
            text-align:center;
            margin-left:auto;
            margin-right:auto;
            width:40%;
        }
</style>
     <style>
        #myCarousel {
            width:600px;
        }
         .auto-style1 {
             background-color: #999;
         }
         .auto-style2 {
             height: 26px;
         }
         .auto-style3 {
             background-color: #999;
             height: 23px;
         }
         .auto-style4 {
             height: 23px;
         }
         </style>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Landing Page - Start Bootstrap Theme</title>

    <!-- Bootstrap Core CSS -->
    <link href="web/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="web/css/landing-page.css" rel="stylesheet">

    <!-- Custom Fonts -->
    <link href="web/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <link href="web/css.css" rel="stylesheet" type="text/css">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

</head>

<body>

    <form id="form1" runat="server">

    <!-- Navigation -->
    <nav class="navbar navbar-default navbar-fixed-top topnav" role="navigation">
        <div class="container topnav">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand topnav" href="index.aspx"><h4>首頁</h4></a>
            </div>
            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav navbar-right">
                    <li><h4>
                             <asp:Button ID="Button1" runat="server" Text="登出" Visible="False" OnClick="Button1_Click" Width="70" />
                    </h4>
                         </li>
                    <li>
                        <a href=http://www1.pu.edu.tw/~s1025410/end2/game.html ><h4>小遊戲</h4></a>
                    </li>
                    <li>
                        <a href="movie.aspx"><h4>教學影片</h4></a>
                    </li>
                     <li>
                        <a href="Sign up.aspx"><h4>線上報名</h4></a>
                    </li>
                    <li>
                        <a href="Scoring.aspx"><h4>排球規則</h4></a>
                    </li>
                    <li>
                        <a href="Arrangement.aspx"><h4>賽程表</h4></a>
                    </li>
                     <li>
                        <a href="Team Information.aspx"><h4>歷史隊伍資料查詢</h4></a>
                    </li>
                     <li>
                        <a href="Sign in.aspx"><h4>會員登入</h4></a>
                    </li>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav>


    <!-- Header -->
    
    <div class="intro-header">
        <div class="container">

            <div class="row">
                <div class="col-lg-12">
                    <div class="intro-message">
                        <h1>靜宜排球網</h1>
                        <h2>線上報名</h2>
                        <h5> <asp:Label ID="Label1" runat="server" ></asp:Label></h5>
                          
                       
                    
                        <hr class="intro-divider">
                        <ul class="list-inline intro-social-buttons">
                          
                        </ul>
                    </div>
                </div>
            </div>

        </div>
        <!-- /.container -->

    </div>
    <!-- /.intro-header -->

    <!-- Page Content -->


    
       <div class="row">

                    <br />
                    <table class="tab" border="1">
                        <tr>
                            <td class="auto-style3">比賽項目</td>
                            <td colspan="7" class="auto-style4">
                                <asp:DropDownList ID="DropDownList2" runat="server">
                                    <asp:ListItem>靜宜大學105學年度全校新生盃排球錦標賽</asp:ListItem>
                                    <asp:ListItem>靜宜大學105學年度全校教職員工排球錦標賽</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">系別:</td>
                            <td colspan="3">
                                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                            </td >
                            <td class="auto-style1">主要聯絡電話:</td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">領隊:</td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" Width="66px"></asp:TextBox>
                            </td>
                            <td  class="auto-style1" colspan="2">教練:</td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server" Width="77px"></asp:TextBox>
                            </td>
                            <td  class="auto-style1" colspan="2">管理:</td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server" Width="77px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">參賽組別:</td>
                            <td colspan="7">
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem>男子組</asp:ListItem>
                                    <asp:ListItem>女子組</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">球員資料</td>
                            <td colspan="2">
                                班級</td>
                            <td colspan="3">
                                學號</td>
                            <td colspan="2">
                                姓名</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">隊長1</td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">隊員2</td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">隊員3</td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">隊員4</td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">隊員5</td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">隊員6</td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">隊員7</td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">隊員8</td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox28" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox29" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">隊員9</td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox30" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox31" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox32" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">隊員10</td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox33" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox34" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox35" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">隊員11</td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox36" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox37" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox38" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">隊員12</td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox39" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="TextBox40" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TextBox41" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="8" class="auto-style2">
                                <asp:Button ID="Button2" runat="server" Text="送出" OnClick="Button2_Click" />
                                <br />
                                <asp:Label ID="Label3" runat="server" Text="最少填6位選手" style="font-size: x-large"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="8" class="auto-style2">
                                &nbsp;</td>
                        </tr>
                    </table>
                    <br />
                    <br />
                    
              <br />  
                    <br />
           <br />

                   

                </div>
        <!-- /.container -->


    <!-- /.content-section-a -->

	




    <div class="banner">

        <div class="container">

            <div class="row">
                <div class="col-lg-6">
                    <h2>製作團隊</h2>
                </div>
                <div class="col-lg-6">
                    <ul class="list-inline banner-social-buttons">
                        <li>
                            <a href="https://www.facebook.com/profile.php?id=100000661112917" class="btn btn-default btn-lg"><i class="fa fa-linkedin fa-fw"></i> <span class="network-name">星豪</span></a>
                        </li>
                        <li>
                            <a href="https://www.facebook.com/niiyangchen?fref=ts" class="btn btn-default btn-lg"><i class="fa fa-linkedin fa-fw"></i> <span class="network-name">洋琛</span></a>
                        </li>
                        <li>
                            <a href="https://www.facebook.com/profile.php?id=100000402351864&fref=ts" class="btn btn-default btn-lg"><i class="fa fa-linkedin fa-fw"></i> <span class="network-name">威仰</span></a>
                        </li>
                        <li>
                            <a href="https://www.facebook.com/kenwang31?fref=ts" class="btn btn-default btn-lg"><i class="fa fa-linkedin fa-fw"></i> <span class="network-name">昱程</span></a>
                        </li>
                    </ul>
                </div>
            </div>

        </div>
        <!-- /.container -->

    </div>
    <!-- /.banner -->

    <!-- Footer -->


    <!-- jQuery -->
    <script src="web/js/jquery.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="web/js/bootstrap.min.js"></script>

    </form>

</body>

</html>