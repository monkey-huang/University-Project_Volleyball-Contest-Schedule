<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Scoring.aspx.cs" Inherits="專題.Scoring" %>

<html lang="en">

<head>
     <style>
        #myCarousel {
            width:600px;
        }
         .auto-style1 {
             color: #FF0000;
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
                    <li>
                        <h4><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登出" Visible="False" Width=70/></h4>
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
                        <h2>排球規則</h2>
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
            <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
              
            
                        <h1 class="text-center">
                            排球規則簡介
                        </h1>
                        <h2 class="text-center">
                           <span class="auto-style1"><em>場地：</em></span><br />
                            </h2>
                        <h3 class="text-left">
　排球比賽是由兩個隊各六名球員，在長18公尺，寬9公尺的球場上比賽。球場由中線分隔為兩部分，中線上方懸掛一定高度的球網。球員以適當的傳接方法將球由網上擊過，以落入對方場內為目標。
球員人數：每隊12名隊員，其中一人登記為自由防守球員。每次下場比賽6人。<br />
                        </h3>
                        <h2 class="text-center">
<span class="auto-style1"><em>比賽方式：</em></span><br />
                        </h2>
                        <h3 class="text-left">
計分：接發球隊犯規或失誤，則發球隊得一分且繼續發球。<br />
發球隊犯規，對隊得一分且得到發球權。<br />
第一局至第四局先獲25分者，勝一局，若24：24則須領先2分才勝。決勝局第五局，先獲15分並領先2分為勝。<br />
每場比賽採五局三勝制，2：2局時，第五局為決勝局。<br />
基本動作之規則：<br />
                        </h3>
                        <h2 class="text-center">
<span class="auto-style1"><em>發球：</em></span><br />
                         </h2>
                        <h3 class="text-left">
排球比賽有關發球的規則如下：<br />
一、六人制排球比賽中，輪到發球時，每人每次只能有一次發球機會，如發球隊得分時，同一發球員得繼續發球。<br />
二、發球者必須按比賽前排定的順序，每次換邊發球，須按順時針方向輪轉。<br />
三、發球者必須在發球區空間內發球。(發球區指球場端線後延邊線兩端之延伸)<br />
四、球在向上拋起後，必須以單手或單臂擊球，不得踢或擲球。<br />
五、球被擊離手前，發球者不得踩線或越入球場內。<br />
六、球須越過兩標誌竿內的網上，並落入對方場內才算好球。<br />
七、發球失誤時，換對方發球，且對方得一分。<br />
八、發球時，兩隊球員的前後排與左右球員的關係位置不得有誤。<br />
九、須經裁判鳴笛才可發球，8秒鐘內完成。<br />
十、不可試圖發球。<br />
                        </h3>
                        <h2 class="text-center">
<span class="auto-style1"><em>接發球：</em></span><br />
                        </h2>
                        <h3 class="text-left">
一、身體任何部位擊球皆合法。<br />
二、不能持球、連擊，一個人不能連續打2次。<br />
三、擊球最多三次，第三次要過網。<br />
                        </h3>
                        <h2 class="text-center">
<span class="auto-style1"><em>攻擊(扣球)：</em></span><br />
                        </h2>
                        <h3 class="text-left">
一、後排球員不得在前排作攻擊，可在3公尺線後，起跳時，不得觸及線上或越過攻擊線。<br />
二、對方發球，不得攻擊。<br />
三、不可過網攻擊，不可觸網。<br />
                        </h3>
                        <h2 class="text-center">
<span class="auto-style1"><em>攔網：</em></span><br />
                        </h2>
                        <h3 class="text-left">
一、攔網球員觸及球時，便算完成攔網，只有前排球員可以攔網。<br />
二、攔網的觸球不計入球隊的擊球次數，攔網觸球後，該隊仍有三次擊球，將球擊入對方場區。<br />
三、攔網後的第一次擊球，可由任何一人觸球，其中包括在攔網時觸球的球員。<br />
四、在不妨礙對方球員活動的情況下，球員可在攔網球，將手及手臂伸越球網，但不能在對方球員完成攻擊前越過球網觸球。<br />
五、對方的發球不可攔網。<br />
                        </h3>
                        <h2 class="text-center">
<span class="auto-style1"><em>自由防守球員：</em></span><br />
                        </h2>
                        <h3 class="text-left">
一、自由防守球員必須穿著與其他球員明顯不同顏色或不同樣式的比賽服。<br />
二、自由防守球員可以替補任何一位後排球員。<br />
三、自由防守球員只能扮演後排球員的角色，並且不能將高於網上端的球擊向對區(含場內及無障礙區)。<br />
四、自由防守球員不得發球、攔網或試圖攔網。<br />
五、自由防守球員於前區及延長區域內，使用高手手指傳球時，則隊友不得將高於網上端的球擊向對區。如果自由防守球員於後區以高手手指傳球時，則隊友可以任意擊球。<br />
六、自由防守球員的替補不計為合法正常替補次數；其替補次數、對象不限，但其退場必須與原球員相互替補，再替補時必須經過一次死球。<br />
                        </h3>
                        <h2 class="text-center">
<span class="auto-style1"><em>換人：</em></span><br />
                        </h2>
                        <h3 class="text-left">
每隊每局最多可6人次替補，指定替補。<br />
每局開始上場球員，僅可在該局中退場一次，再進場一次，替補球員每局僅可上場一次。<br />
                        </h3>
                        <h2 class="text-center">
<span class="auto-style1"><em>暫停：</em></span><br />
                        </h2>
                        <h3 class="text-left">
第一局至第四局，每局各有二次技術暫停，時間60秒，任何一隊先獲8分或16分時自動暫停，另有二次要求暫停，時間各30秒。<br />
決勝局(第五局)沒有技術暫停，每隊有2次暫停，時間30秒。</h3>
                        <p class="text-left">
                            &nbsp;</p>
                        <h3 class="text-left">
                            
                            <span class="auto-style1">https://zh.wikipedia.org/wiki/%E6%8E%92%E7%90%83以上資料取自於此網維基百科</span><br />
                        </h3>
                        <a>

                    </a>
                    
                </div>
          
        </div>

    <hr />
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