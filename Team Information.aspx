<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Team Information.aspx.cs" Inherits="專題.Team_Information" %>


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
             width: 50%;
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
                        <h4><asp:Button ID="Button2" runat="server" Visible="False" Text="登出" OnClick="Button2_Click" Width="70"/></h4>
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
                        <h2>隊伍歷史資料查詢</h2>
                        <h5> <asp:Label ID="Label2" runat="server" Text="" Visible="False"></asp:Label> </h5>
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

            <div class="row">
                  <div class ="con">

   

                <asp:Label ID="Label1" runat="server" style="font-size: large" Text="請輸入欲查詢隊伍:"></asp:Label>

                           <asp:DropDownList ID="DropDownList1" runat="server">
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
                  <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查詢" Width="53px" />
                      <br />
                      <br />
                      <br />
                      <br />
                      <table>
                          <tr>
                              <td class="auto-style1">
                  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="3" DataSourceID="SqlDataSource1" GridLines="Vertical" HorizontalAlign="Center" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" DataKeyNames="Id">
                      <AlternatingRowStyle BackColor="#DCDCDC" />
                      <Columns>
                          <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" InsertVisible="False" ReadOnly="True" />
                          <asp:BoundField DataField="比賽項目" HeaderText="比賽項目" SortExpression="比賽項目" />
                                                    <asp:BoundField DataField="參賽組別" HeaderText="參賽組別" SortExpression="參賽組別" />
                          <asp:BoundField DataField="賽制" HeaderText="賽制" SortExpression="賽制" />
                          <asp:BoundField DataField="隊伍A" HeaderText="隊伍A" SortExpression="隊伍A" />
                          <asp:BoundField DataField="分數A" HeaderText="分數A" SortExpression="分數A" />
                          <asp:BoundField DataField="隊伍B" HeaderText="隊伍B" SortExpression="隊伍B" />
                          <asp:BoundField DataField="分數B" HeaderText="分數B" SortExpression="分數B" />
                          <asp:BoundField DataField="區域幾輪" HeaderText="區域幾輪" SortExpression="區域幾輪" />
                          <asp:BoundField DataField="日期" HeaderText="日期" SortExpression="日期" />
                      </Columns>
                      <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                      <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                      <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                      <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                      <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                      <SortedAscendingCellStyle BackColor="#F1F1F1" />
                      <SortedAscendingHeaderStyle BackColor="#0000A9" />
                      <SortedDescendingCellStyle BackColor="#CAC9C9" />
                      <SortedDescendingHeaderStyle BackColor="#000065" />
                  </asp:GridView>
                              </td>
                          </tr>
                      </table>
                  <br />
                  <br />
                <br />
                <br />
                  <br />
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [比賽資料] where 隊伍A=@A OR 隊伍B=@A">
                      <SelectParameters>
                          <asp:ControlParameter ControlID="DropDownList1" Name="A" PropertyName="SelectedValue" />
                      </SelectParameters>
                  </asp:SqlDataSource>
              
                           <br />

              
                           </div>
                </div>
               
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