<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forget.aspx.cs" Inherits="UI.forget" %>

<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8">
		<title></title>
		<link rel="stylesheet" type="text/css" href="css/nav.css"/>
		<link rel="stylesheet" type="text/css" href="css/forget.css"/>
		
		<script src="js/jquery-3.4.1.min.js" type="text/javascript" charset="utf-8"></script>
		<script type="text/javascript" src="js/jquery.min.js"></script>
        <script type="text/javascript" src="js/jquery.poshytip.js"></script>
        <script type='text/javascript' src='js/jq.validate.js'></script>
        <script src="js/jquery-1.12.3.min.js"></script>
        <script type="text/javascript" src="js/code.js"></script>  
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
		<!--<script type="text/javascript">
			$(function(){
				$("#msg").html(validateCode(4));
					
				$("#msg").click(function(){
					$("#msg").html(validateCode(4));
				})
				function validateCode(n){
    var s="abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    var ret=""; 
    for(var i=0;i<n;i++) {
        var index = Math.floor(Math.random() * 62); 
        ret += s.charAt(index);
    }
    return ret; 
    }		
    $("#subsign").click(function(){
					var yzm=$("#Code").val();
					var yz=$("#msg").val();
					if(yzm==yz)
					{
						alert("登录成功");
					}
					else
					{
						alert("验证码错误");
						var yz1=yz;
					}
					if(yz1==yz)
				{
					alert("请刷新验证码");
				}
				})
			});
		</script>-->
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
	    <div class="forgets">
	   	<div class="forms">
				<h2>忘记密码</h2>
					<form action="#" method="post">
						<ul>
							<li><input type="text" name="useraccount" id="Phone" placeholder="请输入您的用户账号" required=" " valType="MOBILE" msg="<font color=red>*</font>格式不正确" runat="server"/></li>
							<li><input type="email" name="Email" id="Email" placeholder="请输入您的Email" required=" " valType="MAIL" msg="<font color=red>*</font>电子邮箱格式不正确" runat="server"/></li>
							<li>
							<span id="code" class="nocode">验证码</span> 
                                <input type="text" class="input" id="cked" runat="server"/> 
                                       <div style="text-align:center;"></div>
							</li>
							<li><input type="submit" value="下一步" id="check" runat="server" onserverclick="check_ServerClick"/></li>
						</ul>
					</form>
				</div>
	   </div>
	</body>
</html>
