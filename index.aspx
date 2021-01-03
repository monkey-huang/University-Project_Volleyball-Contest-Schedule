<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="專題.index" %>

<html lang="en">

<head>
    <style type='text/css'>
.con {

    text-align:center;
    }
        .tab {
            margin-left:auto;
            margin-right:auto;
        }
</style>
     <style>
        #myCarousel {
            width:600px;
        }
         .auto-style1 {
             width: 50%;
             margin-left:auto;
             margin-right:auto;
             text-align:center;
             margin-top: 0px;
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
                             <asp:Button ID="Button1" runat="server" Text="登出" Visible="False" OnClick="Button1_Click" Width=70 />
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
                        <h2>首頁</h2>
                        <h5> <asp:Label ID="Label1" runat="server" Visible="False" ></asp:Label></h5>
                          
                       
                    
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

                    <div class="col-sm-4 col-lg-4 col-md-4">
                        <div class="thumbnail">
                            <img src="/img/透明1-1.png"alt="">
                            <div class="caption">
                                <h4><a href="#">發佈日期:<asp:Label ID="Label2" runat="server" Text="2016/10/20"></asp:Label></a>
                                </h4>
                                <p>
                                    <asp:Label ID="Label4" runat="server" Text="靜宜大學105學年度全校新生盃排球錦標賽--10/17至10/19將舉辦排球比賽"></asp:Label>
                                </p>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-4 col-lg-4 col-md-4">
                        <div class="thumbnail">
                            <img src="/img/透明1-1.png" alt="">
                            <div class="caption">
                                <h4><a href="#">發佈日期:<asp:Label ID="Label5" runat="server" Text="2016/10/14"></asp:Label></a>
                                </h4>
                                <p>
                                    <asp:Label ID="Label6" runat="server" Text="靜宜大學105學年度全校新生盃排球錦標賽--10/17至10/19將舉辦排球比賽"></asp:Label></p>
                            </div>
                        </div>
                    </div>

                    <div class="col-sm-4 col-lg-4 col-md-4">
                        <div class="thumbnail">
                            <img src="/img/透明1-1.png" alt="">
                            <div class="caption">
                                <h4><a href="#">發佈日期:<asp:Label ID="Label7" runat="server" Text="2016/10/8"></asp:Label></a>
                                </h4>
                                <p><asp:Label ID="Label3" runat="server" Text="	靜宜大學105學年度全校新生盃排球錦標賽--10/11至10/12將舉辦排球比賽"></asp:Label></p>
                            </div>
                        </div>
                    </div>
                   
                    <div class="col-sm-4 col-lg-4 col-md-4">
                        <div class="thumbnail">
                            <img src="/img/透明1-1.png" alt="">
                            <div class="caption">
                                <h4><a href="#">發佈日期:<asp:Label ID="Label8" runat="server" Text="2016/10/1"></asp:Label></a>
                                </h4>
                                <p><asp:Label ID="Label9" runat="server" Text="靜宜大學105學年度全校新生盃排球錦標賽--將在10/3~10/5舉辦排球比賽"></asp:Label></p>
                            </div>
                           
                        </div>
                    </div>
              
          
                    <div class="col-sm-4 col-lg-4 col-md-4">
                        <div class="thumbnail">
                            <img src="/img/透明1-1.png" alt="">
                            <div class="caption">
                                <h4><a href="#">發佈日期:<asp:Label ID="Label10" runat="server" Text="2016/9/19"></asp:Label></a>
                                </h4>
                                <p><asp:Label ID="Label11" runat="server" Text="靜宜大學105學年度全校新生盃排球錦標賽--競賽規程及報名表(9/23報名截止)"></asp:Label></p>
                            </div>       
                        </div>
                    </div>
 

                    <table class="auto-style1">
                        <tr>
                            <td>
      
                                <asp:Button ID="Button2" runat="server" Text="1" Width="26px" />
      
                                <asp:Button ID="Button3" runat="server" Text="2" Width="26px"/>
      
                                <asp:Button ID="Button4" runat="server" Text="下一頁" Width=70 />
      
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" Visible="False">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                            <asp:BoundField DataField="公布日期" HeaderText="公布日期" SortExpression="公布日期" />
                            <asp:BoundField DataField="公告內容" HeaderText="公告內容" SortExpression="公告內容" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [公告事項]"></asp:SqlDataSource>
                                <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                    </table>
                    
              <br />  <br />
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

