<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Set-new.aspx.cs" Inherits="UI.Set_new" %>

<!DOCTYPE html>

<html>
	<head>
		<meta charset="UTF-8">
		<title></title>
		<link rel="stylesheet" type="text/css" href="css/nav.css"/>
		<link rel="stylesheet" type="text/css" href="css/Set-New.css"/>
		<script src="js/jquery-3.4.1.min.js" type="text/javascript" charset="utf-8"></script>
		<script type="text/javascript">
		    $(function () {
		        $(".head--ul_1>li").hover(function () {
		            $(this).toggleClass("bgcolor");
		            $(this).children("a").css("color", "black");
		        }, function () {
		            $(this).toggleClass("bgcolor");
		            $(this).children("a").css("color", "grey");
		        });
		        $(".head_login").hide();
		        var vali = new Validators();
		        $("#btn").bind("click", vali.subByJs);
		    });
		</script>
	</head>
	<body>
			<!--头部-->
		<div class="head">
			<div class="header">
				<div class="logo">
					<!--logo区域-->
				</div>
				<ul class="head--ul_1">
					<li>
						<a href="shouye.html">首页</a>
					</li>
					<li>
						<a href="#">新闻</a>
					</li>
					<li>
						<a href="#">发现</a>
					</li>
				</ul>
				<div class="grid-cell-1">
					<div class="head_cten">
						<input type="text" class="head--txt_1" placeholder="搜索"/>
					    <a href="#"><img src="img/search.png" class="head--img_2"/></a>
					</div>
				</div>
				<div class="nav_user">
					<span class="head_login">
						<a href="#">登录</a>
					</span>
					<div class="head_user">
						<span class="span_ion ion-ios-compose"></span>
						<span class="span_ion ion-ios-bell"></span>
						<div class="div_userimg">
							<!--用户头像-->
							<img src="img/game_pic1.jpg" width="100%" height="100%"/>
						</div>
					</div>
				</div>
			</div>
		</div>
	<div class="set">
		<div class="forms">
				<h2>设置新密码</h2>
				<span>新密码应不少于8位，且不可与之前设置过的密码重复。</span>
					<form id="Form1" method="post" runat="server">
						<ul>
							<li><input type="password" name="Password" id="Password" placeholder="新密码" required=" " runat="server"/></li>
							<li><input type="password" name="newPassword" id="newPassword" placeholder="再输入一次新密码" required=" " runat="server"/></li>
							<li><input type="submit" value="重置密码" id="setsign" runat="server" onserverclick="setsign_ServerClick"/></li>
						</ul>
					</form>
				</div>
	</div>
	</body>
</html>
