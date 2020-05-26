<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="UI.Register" %>

<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8">
		<title></title>
		<link rel="stylesheet" type="text/css" href="css/nav.css"/>
		<link rel="stylesheet" type="text/css" href="css/register.css"/>
		<script src="js/jquery-3.4.1.min.js" type="text/javascript" charset="utf-8"></script>
		<script type="text/javascript" src="js/jquery.min.js"></script>
        <script type="text/javascript" src="js/jquery.poshytip.js"></script>
        <script type='text/javascript' src='js/jq.validate.js'></script>
		<script type="text/javascript">
		    $(function () {
		        var vali = new Validators();
		        $("#btn").bind("click", vali.subByJs);
		    });
		</script>
	</head>
	<body>
   	<div id="regist">
			<div class="Title">
				<img src="Images/标题-2.png" class="imge"/>
			</div>
	   <div class="register">
	   	<div class="form">
				<h2>注册账号</h2>
					<form method="post" runat="server">
						<ul>
							<li><input type="text" name="Username" id="Username" placeholder="用户名" required=" " valType="CHINESE" msg="<font color=red>*</font>中文格式不正确" runat="server"/></li>
							<li><input type="password" name="Password" id="Password" placeholder="密码" required=" " runat="server"/></li>
							<li><input type="email" name="Email" id="Email" placeholder="Email" required=" " valType="MAIL" msg="<font color=red>*</font>电子邮箱格式不正确" runat="server"/></li>
							<li><input type="text" name="Phone" id="Phone" placeholder="电话" required=" " valType="MOBILE" msg="<font color=red>*</font>手机格式不正确" runat="server"/></li>
                            <li><input type="text" name="IDcard" id="IDcard" placeholder="身份证号码" required=" " valType="IDENTITY" msg="<font color=red>*</font>身份证号格式不正确" runat="server"/></li>
							<li><input type="submit" value="注册" id="subsign" runat="server" onserverclick="subsign_ServerClick"/></li>
						</ul>
					</form>
				</div>
	   </div>
		</div>
		
	</body>
</html>
