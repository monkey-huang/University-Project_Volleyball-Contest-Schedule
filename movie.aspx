<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="movie.aspx.cs" Inherits="專題.movie" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <style type='text/css'>
.con {

    text-align:center;
    }
        .tab {
            margin-left:auto;
            margin-right:auto;
        }
        .wr {
            text-align:center;
        }
                .eight {
            width:80%;
            margin-left:auto;
            margin-right:auto;
       
}
</style>
     <style>
        #myCarousel {
            width:600px;
        }
         .auto-style2 {
             font-size: x-large;
             text-align:center;
         }
         .auto-style3 {
             font-size: x-large;
             text-align: center;
             height: 34px;
         }
         .auto-style4 {
             font-size: large;
             width: 545px;
             text-align: center;
         }
         .auto-style5 {
             width: 545px;
         }
         .auto-style6 {
             color: #CC0000;
             font-size: xx-large;
             text-align: center;
         }
         .auto-style7 {
             font-size: x-large;
             width: 545px;
             text-align: center;
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
                        <h2>教學影片</h2>
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

       
    
    <div class="container">
    <div class="con">
    <div class="row">
        
        <table class="eight">
            <tr>
                <td class="auto-style6" colspan="2">基本動作</td>
            </tr>
            <tr>
                <td class="auto-style7"><strong>1.低手發球</strong></td>
                <td class="auto-style7"><strong>2.低手</strong></td>
            </tr>
            <tr>
                <td class="auto-style5"><div class="embed-responsive embed-responsive-4by3">
  <iframe width="854" height="480" src="https://www.youtube.com/embed/_m75j1lSID4" frameborder="0" allowfullscreen></iframe>
</div></td>
                <td><div class="embed-responsive embed-responsive-4by3">
  <iframe width="854" height="480" src="https://www.youtube.com/embed/pVRXGrHFBYE" frameborder="0" allowfullscreen></iframe>
</div></td>
            </tr>
            <tr>
                <td class="auto-style7"><strong>3.高手</strong></td>
                <td class="auto-style2"><strong>4.攻擊</strong></td>
            </tr>
            <tr>
                <td class="auto-style5"><div class="embed-responsive embed-responsive-4by3">
  <iframe width="854" height="480" src="https://www.youtube.com/embed/-AQYyc0SUKc" frameborder="0" allowfullscreen></iframe>
</div></td>
                <td><div class="embed-responsive embed-responsive-4by3">
<iframe width="854" height="480" src="https://www.youtube.com/embed/ZWUy1N5xd3M" frameborder="0" allowfullscreen></iframe>
</div></td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <strong>5.欄網</strong></td>
                <td class="auto-style7"> <strong>6.上手發球</strong></td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <div class="embed-responsive embed-responsive-4by3">
                        <iframe id="I6" allowfullscreen="" frameborder="0" height="480" name="I6" src="https://www.youtube.com/embed/tlxQCYU4iaY" width="854"></iframe>
                    </div>
                </td>
                <td> <div class="embed-responsive embed-responsive-4by3">
                    <iframe width="854" height="480" src="https://www.youtube.com/embed/m_Rlot9INrI" frameborder="0" allowfullscreen></iframe>
                    </div>
                    </td>
            </tr>
            </table>
        
        <br />
        
        <br />
        
        <table class="eight">
            <tr>
                <td class="auto-style6" colspan="2">進階動作</td>
            </tr>
            <tr>
                <td class="auto-style7"><strong>7.跳躍發球</strong></td>
                <td class="auto-style7"><strong>8.側滾翻</strong></td>
            </tr>
            <tr>
                <td><div class="embed-responsive embed-responsive-4by3">
                    <iframe width="854" height="480" src="https://www.youtube.com/embed/cvf-7qRuOuY" frameborder="0" allowfullscreen></iframe>
                    </div>
                    </td>
                <td><div class="embed-responsive embed-responsive-4by3">
                    <iframe width="854" height="480" src="https://www.youtube.com/embed/skduyOA0LXU" frameborder="0" allowfullscreen></iframe>
                    </div>
                    </td>
            </tr>
            <tr>
                <td colspan="2" class="auto-style3"><strong>9.魚躍接球</strong></td>
            </tr>
            <tr>
                <td colspan="2"><div class="embed-responsive embed-responsive-4by3">
                    <iframe id="I7" allowfullscreen="" frameborder="0" height="480" name="I7" src="https://www.youtube.com/embed/N2IWcRatRdo" width="854"></iframe>
                    </div>
                </td>
            </tr>
            </table>
        
        <br />
        
        <br />
        
        </div>
        </div>
              <!-- /.container -->
        </div>

    <!-- /.content-section-a -->

	




   
        <!-- /.container -->
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

