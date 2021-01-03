<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Arrangement.aspx.cs" Inherits="專題.Arrangement" %>


<html lang="en">

<head>
      <style type='text/css'>
.con {

    text-align:center;
    }
</style>
     <style>
        #myCarousel {
            width:600px;
        }
         .auto-style1 {
             width: 80%;
             margin-left:auto;
             margin-right:auto;
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
                        <h4><asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="登出" Visible="False" Width=70 /></h4>
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
                        <h2>賽程表排程</h2>
                        <h5>
                            <asp:Label ID="Label3" runat="server" Text="" Visible="False"></asp:Label></h5>
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


    

        <div class="con">
    <div class="content-section-a">
          <div class="row">
             
                <h4>
              <asp:Label ID="Label1" runat="server" Text="報名名稱" style="font-size: large" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList2" runat="server" Visible="False">
                        <asp:ListItem>靜宜大學105學年度全校新生盃排球錦標賽</asp:ListItem>
                        <asp:ListItem>靜宜大學105學年度全校教職員工排球錦標賽</asp:ListItem>
                    </asp:DropDownList>
                    </h4>
                <p>
                    &nbsp;</p>
                <h4>
                <asp:Label ID="Label5" runat="server" Text="參賽組別" style="font-size: large" Visible="False"></asp:Label>
                <asp:DropDownList ID="DropDownList3" runat="server" Visible="False">
                    <asp:ListItem>男子組</asp:ListItem>
                    <asp:ListItem>女子組</asp:ListItem>
                    <asp:ListItem>混合組</asp:ListItem>
                </asp:DropDownList>
                    </h4>
               <p>
                    &nbsp;</p>
                <h4>
              <asp:Label ID="Label2" runat="server" Text="選擇賽制" style="font-size: large" Visible="False"></asp:Label>
                   <asp:DropDownList ID="DropDownList1" runat="server" Visible="False">
                  <asp:ListItem>單淘汰</asp:ListItem>
                  <asp:ListItem>雙淘汰</asp:ListItem>
              </asp:DropDownList>
                  </h4>
                <p>
                    &nbsp;</p>
                <p>
                    <asp:Label ID="Label6" runat="server" style="font-size: large" Text="種子隊" Visible="False"></asp:Label>
                    <asp:DropDownList ID="DropDownList4" runat="server" Visible="False">
                        <asp:ListItem>無</asp:ListItem>
                        <asp:ListItem>英文系</asp:ListItem>
                        <asp:ListItem>西文系</asp:ListItem>
                        <asp:ListItem>日文系</asp:ListItem>
                        <asp:ListItem>中文系</asp:ListItem>
                        <asp:ListItem>社工系</asp:ListItem>
                        <asp:ListItem>台文系</asp:ListItem>
                        <asp:ListItem>法律系</asp:ListItem>
                        <asp:ListItem>生態系</asp:ListItem>
                        <asp:ListItem>大傳系</asp:ListItem>
                        <asp:ListItem>財數系</asp:ListItem>
                        <asp:ListItem>應化系</asp:ListItem>
                        <asp:ListItem>食營系</asp:ListItem>
                        <asp:ListItem>化科系</asp:ListItem>
                        <asp:ListItem>統資系</asp:ListItem>
                        <asp:ListItem>企管系</asp:ListItem>
                        <asp:ListItem>國企系</asp:ListItem>
                        <asp:ListItem>會計系</asp:ListItem>
                        <asp:ListItem>觀光系</asp:ListItem>
                        <asp:ListItem>財金系</asp:ListItem>
                        <asp:ListItem>資管系</asp:ListItem>
                        <asp:ListItem>資工系</asp:ListItem>
                        <asp:ListItem>資傳系</asp:ListItem>
                        <asp:ListItem>寰管系</asp:ListItem>
                        <asp:ListItem>寰外系</asp:ListItem>
                    </asp:DropDownList>
                </p>
             
               <h4>
              <asp:Button ID="Button1" runat="server" Text="排賽程" OnClick="Button1_Click" width="80" Visible="False"/>
                
                   </h4>
                <p>
                    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                    <asp:Label ID="Label7" runat="server"></asp:Label>
                </p>
                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" Visible="False">
                                <Columns>
                                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                                    <asp:BoundField DataField="比賽項目" HeaderText="比賽項目" SortExpression="比賽項目" />
                                    <asp:BoundField DataField="系別" HeaderText="系別" SortExpression="系別" />
                                    <asp:BoundField DataField="主要聯絡電話" HeaderText="主要聯絡電話" SortExpression="主要聯絡電話" />
                                    <asp:BoundField DataField="領隊" HeaderText="領隊" SortExpression="領隊" />
                                    <asp:BoundField DataField="教練" HeaderText="教練" SortExpression="教練" />
                                    <asp:BoundField DataField="管理" HeaderText="管理" SortExpression="管理" />
                                    <asp:BoundField DataField="參賽組別" HeaderText="參賽組別" SortExpression="參賽組別" />
                                    <asp:BoundField DataField="隊長1" HeaderText="隊長1" SortExpression="隊長1" />
                                </Columns>
                                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                                <RowStyle BackColor="White" ForeColor="#003399" />
                                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                                <SortedDescendingHeaderStyle BackColor="#002876" />
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Id], [比賽項目], [系別], [主要聯絡電話], [領隊], [教練], [管理], [參賽組別], [隊長1] FROM [報名資料]" DeleteCommand="DELETE FROM [報名資料] WHERE [Id] = @Id" InsertCommand="INSERT INTO [報名資料] ([比賽項目], [系別], [主要聯絡電話], [領隊], [教練], [管理], [參賽組別], [隊長1]) VALUES (@比賽項目, @系別, @主要聯絡電話, @領隊, @教練, @管理, @參賽組別, @隊長1)" UpdateCommand="UPDATE [報名資料] SET [比賽項目] = @比賽項目, [系別] = @系別, [主要聯絡電話] = @主要聯絡電話, [領隊] = @領隊, [教練] = @教練, [管理] = @管理, [參賽組別] = @參賽組別, [隊長1] = @隊長1 WHERE [Id] = @Id">
                                <DeleteParameters>
                                    <asp:Parameter Name="Id" Type="Int32" />
                                </DeleteParameters>
                                <InsertParameters>
                                    <asp:Parameter Name="比賽項目" Type="String" />
                                    <asp:Parameter Name="系別" Type="String" />
                                    <asp:Parameter Name="主要聯絡電話" Type="String" />
                                    <asp:Parameter Name="領隊" Type="String" />
                                    <asp:Parameter Name="教練" Type="String" />
                                    <asp:Parameter Name="管理" Type="String" />
                                    <asp:Parameter Name="參賽組別" Type="String" />
                                    <asp:Parameter Name="隊長1" Type="String" />
                                </InsertParameters>
                                <UpdateParameters>
                                    <asp:Parameter Name="比賽項目" Type="String" />
                                    <asp:Parameter Name="系別" Type="String" />
                                    <asp:Parameter Name="主要聯絡電話" Type="String" />
                                    <asp:Parameter Name="領隊" Type="String" />
                                    <asp:Parameter Name="教練" Type="String" />
                                    <asp:Parameter Name="管理" Type="String" />
                                    <asp:Parameter Name="參賽組別" Type="String" />
                                    <asp:Parameter Name="隊長1" Type="String" />
                                    <asp:Parameter Name="Id" Type="Int32" />
                                </UpdateParameters>
                            </asp:SqlDataSource>
                        </td>
                    </tr>
                </table>
            
            
      </div>
    </div>
  </div>
    <!-- /.content-section-a -->
        <br />
        <br />
        <br />
        <br />
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