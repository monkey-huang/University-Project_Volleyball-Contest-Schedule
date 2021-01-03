﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sixteen.aspx.cs" Inherits="專題.arransingle.WebForm1" %>

<!DOCTYPE html>
<html lang="en">

<head>
 <style type='text/css'>
.eight {

        width:50%;  
        margin-left:auto; 
        margin-right:auto;
    }
     .four {
        width:50%;  
        margin-left:auto; 
        margin-right:auto;
     }
</style>

        <style type='text/css'>
.lab {

        height:25px;   
        line-height:25px;   
        overflow:hidden;   

    }
</style>
    <style type='text/css'>
.con {

    text-align:center;
    }
</style>
     <style>
        #myCarousel {
            width:600px;
        }
         .auto-style2 {
             width: 73px;
         }
         .auto-style3 {
             width: 73px;
         }
         .auto-style4 {
             width: 73px;
         }
         .auto-style5 {
             width: 70px;
         }
         .auto-style6 {
             width: 74px;
         }
         .auto-style7 {
             width: 73px;
         }
         .auto-style8 {
             width: 73px;
         }
         .auto-style9 {
             width: 73px;
         }
         .auto-style10 {
             height: auto;
         }
         .auto-style11 {
             height: auto;
             
         }
         .auto-style12 {
             height: auto;
             font-size: x-large;
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
    <link href="../web/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="../web/css/landing-page.css" rel="stylesheet">

    <!-- Custom Fonts -->
    <link href="../web/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <link href="../web/css.css" rel="stylesheet" type="text/css">

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
                <a class="navbar-brand topnav" href="../index.aspx"><h4>首頁</h4></a>
            </div>
            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav navbar-right">
                    <li>
                        <h4> <asp:Button ID="Button4" runat="server" Text="登出" Visible="False" OnClick="Button4_Click" Width=70/> </h4>
                    </li>
                    <li>
                        <a href=http://www1.pu.edu.tw/~s1025410/end2/game.html ><h4>小遊戲</h4></a>
                    </li>
                    <li>
                        <a href="../movie.aspx"><h4>教學影片</h4></a>
                    </li>
                    <li>
                        <a href="../Sign up.aspx"><h4>線上報名</h4></a>
                    </li>
                    <li>
                        <a href="../Scoring.aspx"><h4>排球規則</h4></a>
                    </li>
                    <li>
                        <a href="../Arrangement.aspx"><h4>賽程表</h4></a>
                    </li>
                     <li>
                        <a href="../Team Information.aspx"><h4>歷史隊伍資料查詢</h4></a>
                    </li>
                     <li>
                        <a href="../Sign in.aspx"><h4>會員登入</h4></a>
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
                        <h2>16單淘汰</h2>
                        <h5> <asp:Label ID="Label34" runat="server" Text="" Visible="False"></asp:Label> </h5>
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

            
             <asp:Label ID="Label73" runat="server" Text="" style="font-size: x-large; color: #FF0000"></asp:Label>
             <br />
             <br />

            
             <br />

            
             <table class="eight" border="0">
                                <tr>
                     <td colspan="8" class="auto-style12">
    
                                             A區</td>
                 </tr>
                                <tr>
                     <td colspan="8" class="auto-style10">
    
                                             <asp:Label ID="Label67" runat="server" Visible="False"></asp:Label>
                                             <br />
    
                                             <asp:Image ID="Image7" runat="server" ImageUrl="~/img/大大普通.jpg" /></td>
                 </tr>
               <tr>
                     <td colspan="4" class="auto-style10">
                   
  
             <asp:Label ID="Label23" runat="server" Text=""></asp:Label>
                   
  
                         <br />
                   
  
             <asp:TextBox ID="TextBox13" runat="server" Height="27px" Width="23px" Visible="False"></asp:TextBox>
                   
  
                     </td>
                     <td colspan="4" class="auto-style10">

             <asp:Label ID="Label24" runat="server" Text=""></asp:Label>
             
                         <br />

             <asp:TextBox ID="TextBox14" runat="server" Height="27px" Width="23px" Visible="False"></asp:TextBox>
             
                    </td>
                 </tr>
                 <tr>
                     <td colspan="4" class="auto-style10">
                   
                <asp:Image ID="Image5" runat="server" ImageUrl="~/img/大普通.jpg" />
                     </td>
                     <td colspan="4" class="auto-style10"><asp:Image ID="Image6" runat="server" ImageUrl="~/img/大普通.jpg" />
                    </td>
                 </tr>
                 <tr>
                     <td colspan="2" class="auto-style10"><asp:Label ID="Label19" runat="server" Text=""></asp:Label>
                         <br />
             <asp:TextBox ID="TextBox9" runat="server" Height="27px" Width="23px" Visible="False"></asp:TextBox> </td>
                     <td colspan="2" class="auto-style10"><asp:Label ID="Label20" runat="server" Text=""></asp:Label>
                         <br />
                         <asp:TextBox ID="TextBox10" runat="server" Height="27px" Width="23px" Visible="False"></asp:TextBox> </td>
                     <td colspan="2" class="auto-style10">
         <asp:Label ID="Label21" runat="server" Text=""></asp:Label>
                         <br />
                         <asp:TextBox ID="TextBox11" Height="27px" Width="23px" Visible="False" runat="server"></asp:TextBox>
                     </td>
                     <td colspan="2" class="auto-style10">
             <asp:Label ID="Label22" runat="server" Text=""></asp:Label>
                         <br />
             
                
                   
                <asp:TextBox ID="TextBox12" runat="server" Height="27px" Width="23px" Visible="False"></asp:TextBox> 
             
                
                   
                     </td>
                 </tr>
                 <tr>
                     <td colspan="2">
                   
                <asp:Image ID="Image1" runat="server"  ImageUrl="~/img/普通.jpg"/>
                     </td>
                     <td colspan="2">

                <asp:Image ID="Image2" runat="server" ImageUrl="~/img/普通.jpg" />
                     </td>
                     <td colspan="2">
                <asp:Image ID="Image3" runat="server" ImageUrl="~/img/普通.jpg" />
                     </td>
                     <td colspan="2">
                <asp:Image ID="Image4" runat="server" ImageUrl="~/img/普通.jpg" />
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style2">
               
                  
                <asp:Label ID="Label1" runat="server" Text="" width=45px Height="16px"></asp:Label>
               
                  
                     </td>
                     <td class="auto-style3"><asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style4"><asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style5"><asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style6">
                  
                <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style7"> <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style8"> <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style9">
                <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style2"><asp:Label ID="Label11" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style3"><asp:Label ID="Label12" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style4"><asp:Label ID="Label13" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style5"><asp:Label ID="Label14" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style6"><asp:Label ID="Label15" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style7"><asp:Label ID="Label16" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style8"><asp:Label ID="Label17" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style9"><asp:Label ID="Label18" runat="server" Text=""></asp:Label>
                  
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style2"> <asp:TextBox ID="TextBox1" runat="server" Height="27px" Width="23px"></asp:TextBox>
                     </td>
                     <td class="auto-style3">
                <asp:TextBox ID="TextBox2" runat="server" Height="27px" Width="23px"></asp:TextBox>
                     </td>
                     <td class="auto-style4">
                <asp:TextBox ID="TextBox3" runat="server" Height="27px" Width="23px"></asp:TextBox>
                     </td>
                     <td class="auto-style5">
                <asp:TextBox ID="TextBox4" runat="server" Height="27px" Width="23px"></asp:TextBox>
                     </td>
                     <td class="auto-style6"><asp:TextBox ID="TextBox5" runat="server" Height="27px" Width="23px"></asp:TextBox>
                     </td>
                     <td class="auto-style7"><asp:TextBox ID="TextBox6" runat="server" Height="27px" Width="23px"></asp:TextBox>
                     </td>
                     <td class="auto-style8">
                <asp:TextBox ID="TextBox7" runat="server" Height="27px" Width="23px"></asp:TextBox>
                     </td>
                     <td class="auto-style9"><asp:TextBox ID="TextBox8" runat="server" Height="27px" Width="23px"></asp:TextBox>
                     </td>
                 </tr>
             </table>
             <br />
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="比賽A" Visible="False" Width=100/>
             <br />
             <br />

             <br />

            
             <table class="eight" border="0">
                                <tr>
                     <td colspan="8" class="auto-style12">
    
                                             B區</td>
                 </tr>
                                <tr>
                     <td colspan="8" class="auto-style10">
    
                                             <asp:Label ID="Label66" runat="server" Visible="False"></asp:Label>
                                             <br />
    
                                             <asp:Image ID="Image8" runat="server" ImageUrl="~/img/大大普通.jpg" /></td>
                 </tr>
               <tr>
                     <td colspan="4" class="auto-style10">
                   
  
             <asp:Label ID="Label35" runat="server" Text=""></asp:Label>

                         <br />

                <asp:TextBox ID="TextBox28" runat="server" Height="27px" Width="23px" Visible="False"></asp:TextBox>
                   
  
                     </td>
                     <td colspan="4" class="auto-style10">

             <asp:Label ID="Label36" runat="server" Text=""></asp:Label>
             
                         <br />

                         <asp:TextBox ID="TextBox29" runat="server" Height="27px" Width="23px" Visible="False"></asp:TextBox>
             
                    </td>
                 </tr>
                 <tr>
                     <td colspan="4" class="auto-style10">
                   
                <asp:Image ID="Image9" runat="server" ImageUrl="~/img/大普通.jpg" />
                     </td>
                     <td colspan="4" class="auto-style10"><asp:Image ID="Image10" runat="server" ImageUrl="~/img/大普通.jpg" />
                    </td>
                 </tr>
                 <tr>
                     <td colspan="2" class="auto-style10"><asp:Label ID="Label37" runat="server" Text=""></asp:Label>

                         <br />

                <asp:TextBox ID="TextBox24" runat="server" Height="27px" Width="23px" Visible="False"></asp:TextBox>
                 
                     </td>

                     <td colspan="2" class="auto-style10"><asp:Label ID="Label38" runat="server" Text=""></asp:Label>
                         <br />
                <asp:TextBox ID="TextBox25" runat="server" Height="27px" Width="23px" Visible="False"></asp:TextBox>
                     </td>

                     <td colspan="2" class="auto-style10">
         <asp:Label ID="Label39" runat="server" Text=""></asp:Label>
                         <br />
                         <asp:TextBox ID="TextBox26" runat="server" Height="27px" Width="23px" Visible="False"></asp:TextBox>
 
                     </td>
                     <td colspan="2" class="auto-style10">
             <asp:Label ID="Label40" runat="server" Text=""></asp:Label>
                         <br />
                         <asp:TextBox ID="TextBox27" runat="server" Height="27px" Width="23px" Visible="False"></asp:TextBox>     
                   
                     </td>
                 </tr>
                 <tr>
                     <td colspan="2">
                   
                         <asp:Image ID="Image15" runat="server" ImageUrl="~/img/普通.jpg" />
                     </td>
                     <td colspan="2">

                         <asp:Image ID="Image16" runat="server" ImageUrl="~/img/普通.jpg" />
                     </td>
                     <td colspan="2">
                         <asp:Image ID="Image17" runat="server" ImageUrl="~/img/普通.jpg" />
                     </td>
                     <td colspan="2">
                         <asp:Image ID="Image18" runat="server" ImageUrl="~/img/普通.jpg" />
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style2">
               
                  
                <asp:Label ID="Label41" runat="server" Text=""></asp:Label>
               
                  
                     </td>
                     <td class="auto-style3"><asp:Label ID="Label42" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style4"><asp:Label ID="Label43" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style5"><asp:Label ID="Label44" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style6">
                  
                <asp:Label ID="Label45" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style7"> <asp:Label ID="Label46" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style8"> <asp:Label ID="Label47" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style9">
                <asp:Label ID="Label48" runat="server" Text=""></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style2"><asp:Label ID="Label49" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style3"><asp:Label ID="Label50" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style4"><asp:Label ID="Label51" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style5"><asp:Label ID="Label52" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style6"><asp:Label ID="Label53" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style7"><asp:Label ID="Label54" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style8"><asp:Label ID="Label55" runat="server" Text=""></asp:Label>
                     </td>
                     <td class="auto-style9"><asp:Label ID="Label56" runat="server" Text=""></asp:Label>
                  
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style2"> 
                   
  
             <asp:TextBox ID="TextBox16" runat="server" Height="27px" Width="23px" Visible="true"></asp:TextBox>
                     </td>
                     <td class="auto-style3">

             <asp:TextBox ID="TextBox17" runat="server" Height="27px" Width="23px" Visible="true"></asp:TextBox>
             
                     </td>
                     <td class="auto-style4">
             <asp:TextBox ID="TextBox18" runat="server" Height="27px" Width="23px" Visible="true"></asp:TextBox> 
                     </td>
                     <td class="auto-style5">
                         <asp:TextBox ID="TextBox19" runat="server" Height="27px" Width="23px" Visible="true"></asp:TextBox> 
                     </td>
                     <td class="auto-style6">
                         <asp:TextBox ID="TextBox20" Height="27px" Width="23px" Visible="true" runat="server"></asp:TextBox>
                     </td>
                     <td class="auto-style7">
             
                
                   
                <asp:TextBox ID="TextBox21" runat="server" Height="27px" Width="23px" Visible="true"></asp:TextBox> 
             
                
                   
                     </td>
                     <td class="auto-style8">
                         <asp:TextBox ID="TextBox22" runat="server" Height="27px" Width="23px"></asp:TextBox>
                     </td>
                     <td class="auto-style9">
                <asp:TextBox ID="TextBox23" runat="server" Height="27px" Width="23px"></asp:TextBox>
                     </td>
                 </tr>
             </table>
             <br />
             <asp:Button ID="Button5" runat="server" Text="比賽B" OnClick="Button5_Click" Visible="False" Width=100/>
             <br />
             <br />
             <br />

            
             <table class="four" border="0">
                                <tr>
                     <td colspan="2" class="auto-style12">
    
                                             決賽</td>
                 </tr>
                                <tr>
                     <td colspan="2" class="auto-style11">
    
                                             <asp:Label ID="Label68" runat="server" Visible="False"></asp:Label>
                                             <br />
    
                                             <asp:Image ID="Image19" runat="server" ImageUrl="~/img/大大普通.jpg" /></td>
                 </tr>
               <tr>
                     <td class="auto-style10">
                   
  
             <asp:Label ID="Label69" runat="server" Text="A區比賽"></asp:Label>
                   
  
                         <br />
                         <asp:Label ID="Label71" runat="server" Text=""></asp:Label>
                   
  
                         <br />
                   
  
                <asp:TextBox ID="TextBox31" runat="server" Height="27px" Width="23px" Visible="False"></asp:TextBox>
                   
  
                     </td>
                     <td class="auto-style10">

             <asp:Label ID="Label70" runat="server" Text="B區比賽"></asp:Label>
             
                         <br />
             
                         <asp:Label ID="Label72" runat="server" Text=""></asp:Label>
             
                         <br />

                         <asp:TextBox ID="TextBox32" runat="server" Height="27px" Width="23px" Visible="False"></asp:TextBox>
             
                    </td>
                 </tr>
                 </table>
             <asp:Button ID="Button8" runat="server" Text="比賽決賽" OnClick="Button8_Click" Width=100 Visible="False"/>
             <br />
             <br />
             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" Visible="False">
                 <Columns>
                     <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                     <asp:BoundField DataField="比賽項目" HeaderText="比賽項目" SortExpression="比賽項目" />
                     <asp:BoundField DataField="系別" HeaderText="系別" SortExpression="系別" />
                     <asp:BoundField DataField="主要聯絡電話" HeaderText="主要聯絡電話" SortExpression="主要聯絡電話" />
                     <asp:BoundField DataField="參賽組別" HeaderText="參賽組別" SortExpression="參賽組別" />
                 </Columns>
             </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Id], [比賽項目], [系別], [主要聯絡電話], [參賽組別] FROM [報名資料]"></asp:SqlDataSource>
             <br />
            
        </div>
               
     
        </div>
        <!-- /.container -->

   
    <!-- /.content-section-a -->

	</div>
        <hr />



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
                            <a href="https://www.facebook.com/kenwang31?fref=ts" class="btn btn-default btn-lg"><i class="fa fa-linkedin fa-fw"></i> <span class="network-name">Ken</span></a>
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
    <script src="../web/js/jquery.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="../web/js/bootstrap.min.js"></script>

    </form>

</body>

</html>