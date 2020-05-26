<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Login" %>

<!DOCTYPE html>

<html>
	<head>
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width,initial-scale=1,minimum-scale=1,maximum-scale=1,user-scalable=no" />
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8">

		<script type="application/x-javascript"> 
			addEventListener("load", function() 
			{ setTimeout(hideURLbar, 0); }, false); 
			function hideURLbar(){ window.scrollTo(0,1); } 
		</script>
		<title></title>
		<link rel="stylesheet" type="text/css" href="css/Login.css"/>
	</head>
	<body>
         <form  method="post" runat="server" >
             <div id="login">
				
			<div class="Title">
				<img src="Images/标题-2.png" class="imge"/>
			</div>
			<div class="Dbox">
				<div class="AP-login">
					<span class="Pwd-login">用户登录</span>
					<a href="Register.aspx" class="register">注册</a>
					<hr>
				</div>
				<div class="A-login">
					<ul>
					<li><input type="text" id="txtUser" name="txtUser" style="BORDER-TOP-STYLE: none;BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; BORDER-BOTTOM-STYLE:solid ; " placeholder="账号" runat="server"/></li>
					<li><input type="password" id="txtPwd" name="txtPwd" style="BORDER-TOP-STYLE: none;BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; BORDER-BOTTOM-STYLE:solid;" placeholder="密码" runat="server"/></li>
					<li class="Forget">
						<a href="forget.aspx">forget.aspx</a>" class="Forgett">忘记密码？</a></li>
					<li><input type="submit" id="Sign" value="登录" runat="server" onserverclick="Sign_ServerClick"/></li>
					</ul>

				</div>
				<div class="SC-login">
			    <div class="social-icons w3layouts agileits">
				<span>- 其他方式登录 -</span>
				<ul>
					<li class="qq"><a href="#">
					<span class="icons w3layouts agileits"></span>
					<span class="text w3layouts agileits">QQ</span></a></li>
					<li class="weixin w3ls"><a href="#">
					<span class="icons w3layouts"></span>
					<span class="text w3layouts agileits">微信</span></a></li>
					<li class="weibo aits"><a href="#">
					<span class="icons agileits"></span>
					<span class="text w3layouts agileits">微博</span></a></li>
					
				</ul><div class="clear"> </div>
			</div>
				</div>
				<!--<div class="PH-login">
					
				</div>-->
				<div class="Notes">
					@2019 乐语.&nbsp;&nbsp;<a href="#">使用乐语网前必读</a>.&nbsp;&nbsp;<a href="#">乐语网协议</a>.&nbsp;&nbsp;<a href="#">联系我们</a>.&nbsp;&nbsp;<a >联系我们  注册机构</a>. 
					&nbsp;&nbsp;<a href="#">隐私政策</a>.&nbsp;&nbsp;<a href="#">投诉反馈</a>信息网络传播视听节目许可证  291112222
					&nbsp;&nbsp;<img src="img/警徽.png" />出版物经营许可证 <a href="#">侵权举报</a>.&nbsp;&nbsp;<a href="#">网上有害信息举报专区</a>.&nbsp;&nbsp;<a href="#">儿童色情信息举报专区</a>
					.&nbsp;&nbsp;违法和不良信息举报：010-82716601
				</div>
				</div>
				
		</div>
			</form>
	</body>
</html>

