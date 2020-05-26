<%@ Page Title="" Language="C#" MasterPageFile="~/Main/MainHome.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="UI.User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--样式表--%>
    <link href="css/User.css" rel="stylesheet" type="text/css" />
    <%--js--%>
    <script src="js/jquery-3.4.1.min.js" type="text/javascript" charset="utf-8"></script>
    <script>
        $(function () {
            //添加类
            $(".bot1_top_div1").addClass("style2");
            //我的评论点击事件
            $(".bot1_top_div2").click(function () {
                if ($(".bot1_bot2").is(":hidden")) {
                    $(this).toggleClass("style2").siblings("div").toggleClass("style2");
                    $(".bot1_bot2").show();
                    $(".bot1_bot1").hide();
                }
            });
            //我的动态点击事件
            $(".bot1_top_div1").click(function () {
                if ($(".bot1_bot1").is(":hidden")) {
                    $(this).toggleClass("style2").siblings("div").toggleClass("style2");
                    $(".bot1_bot1").show();
                    $(".bot1_bot2").hide();
                }
            });
            //查看详细资料点击事件
            $(".span_2").click(function () {
                if ($(".user_bot2").is(":hidden")) {
                    $(".user_bot2").show();
                    $(".user_bot1").hide();
                    $(".user_bot3").hide();
                    $(this).html("返回");
                    $(".user_xz").hide();
                } else {
                    $(".user_bot2").hide();
                    $(".user_bot1").show();
                    $(".user_bot3").hide();
                    $(this).html("查看详细资料&nbsp;&nbsp;&gt;");
                    $(".user_xz").show();
                }
            });
            //编辑个人资料点击事件
            $(".user_xz").click(function () {
                if ($(".user_bot3").is(":hidden")) {
                    $(".user_bot2").hide();
                    $(".user_bot1").hide();
                    $(".user_bot3").show();
                    $(this).html("返回");
                    $(".span_2").hide();
                } else {
                    $(".user_bot2").hide();
                    $(".user_bot1").show();
                    $(".user_bot3").hide();
                    $(this).html("编辑个人资料");
                    $(".span_2").show();
                }
            });
            //浮动到头像提醒点击更改头像
            $(".user_img").hover(function () {
                $(this).children("div").show();
            }, function () {
                $(this).children("div").hide();
            });

            //获得用户生日
            function birshow() {
                var bir = $(".txtsfz").val();
                var year = bir.substr(6, 4);//截取年
                var month = bir.substr(10, 2);//截取月
                var day = bir.substr(12, 2);//截取日
                var userbit = year + "-" + month + "-" + day;
                $(".txtbir").val(userbit);
                $(".birthdays").text(userbit);
                var time = new Date();
                var nowyear = time.getFullYear();
                $(".txtage").val(nowyear - year);
                $(".age").text(nowyear - year);
            }
            birshow();

            //更换头像
            $(".user_img>div").click(function () {
                $(".file").show();
            });
            $(".but2").click(function () {
                $(".file").hide();
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <from id="from1" runst="sever">
    <div class="big">
            <div class="file">
             <asp:FileUpload ID="FileUpload1" runat="server" Font-Size="X-Large" BackColor="White" CssClass="fileupload"></asp:FileUpload>
             <asp:Button ID="Button1" runat="server" Text="确认" CssClass="file_but" OnClick="Button1_Click"></asp:Button>
                <asp:Button ID="Button2" runat="server" Text="取消" CssClass="file_but but2"></asp:Button>
            </div>
			<div class="user_top">
                <img src="Images/photo_2.jpg" width="500px" height="300px" />
				<div class="user--top_div1">
					<!--用户头像div-->
					<div class="user_img">
						<div>
                        点击更换头像
						</div>
						<img src="Images/game_pic1.jpg" id="uimg" runat="server"/>
					</div>
					<div class="user_name">
						<span class="span_1" id="uname" runat="server">我的用户名</span>
						<span class="span_2">查看详细资料&nbsp;&nbsp;&gt;</span>
					</div>
					<div class="user_xz">编辑个人资料</div>
				</div>
			</div>
			<div class="user_bot1">
				<div class="bot1_top">
					<div class="bot1_top_div1">我的动态</div>
					<div class="bot1_top_div2">我的评论</div>
				</div>
				<!--我的动态div-->
                <asp:Repeater ID="RepeaterMyState" runat="server">
                    <ItemTemplate>
                        <div class="bot1_bot1">
					<div class="dt_nr">
						<%# Eval("statecontent") %>
					</div>
					<div class="dt_img">
						<img src="<%# Eval("statephoto") %>" />
					</div>
					<div class="dt_sel">
						<div class="dt_pl"><span class="pl_span"><%# Eval("plnum") %></span></div>
					    <div class="dt_dc"><span class="dc_span"><%# Eval("stategoodnums") %></span></div>
					    <div class="dt_dz"><span class="dz_span"><%# Eval("statebadnums") %></span></div>
					</div>
				    </div>
                    </ItemTemplate>
                </asp:Repeater>
				<div class="bot1_bot2">
                    <asp:Repeater ID="RepeaterMyPl" runat="server">
                        <ItemTemplate>
                            <a href="Detailed.aspx?stateid=<%# Eval("stateid") %>" class="mypl_link">
                                <div class="my_pl">
                                    <div class="mypl_top">
                                        <span>评论时间：<%# Eval("pltime") %></span>
                                        <div class="pl_sel">
					                        <div class="dt_dc"><span class="dc_span"><%# Eval("plbadnums") %></span></div>
					                        <div class="dt_dz"><span class="dz_span"><%# Eval("plgoodnums") %></span></div>
					                    </div>
                                    </div>
                                    <div class="mypl_bot">
                                        <%# Eval("commentarycontent") %>
                                    </div>
                                </div>
                            </a>
                            </ItemTemplate>
                    </asp:Repeater>
				</div>
			</div>
			<!--这里是查看个人详细资料-->
			<div class="user_bot2">
                <asp:Repeater ID="RepeaterUserInfo" runat="server">
                    <ItemTemplate>
                        <ul>
				    	<li>用户名:&nbsp;&nbsp;<span class="username"><%# Eval("username") %></span></li>
				    	<li>身份证号:&nbsp;&nbsp;<span class="sfz"><%# Eval("usercard") %></span></li>
				    	<li>年龄:&nbsp;&nbsp;<span class="age"></span></li>
				    	<li>性别:&nbsp;&nbsp;<span class="sex"><%# Eval("usersex") %></span></li>
				    	<li>生日:&nbsp;&nbsp;<span class="birthdays"></span></li>
				    	<li>邮箱:&nbsp;&nbsp;<span class="city"><%# Eval("useremile") %></span></li>
				    </ul>
                    </ItemTemplate>
                </asp:Repeater>
				    
				    <div class="user--bot2_right">
				    	<div class="right_div">
				    		<div class="mygz"><span class="span_3">关注了</span><br/><span runat="server" id="mygz"></span></div>
				    	    <div class="gzmy"><span class="span_3">关注者</span><br/><span runat="server" id="gzmy"></span></div>
				    	</div>
				    	<div class="mydt"><span class="span_3">我的动态</span>&nbsp;&nbsp;&nbsp;&nbsp;<span runat="server" id="mydt"></span></div>
				    	<div class="mypl"><span class="span_3">我的评论</span>&nbsp;&nbsp;&nbsp;&nbsp;<span runat="server" id="mypl"></span></div>
				    </div>
			</div>
			<!--这里是修改个人资料-->
			<div class="user_bot3">
                <table class="tab">
					<tr>
						<td>用户名：<input type="text" class="txt txtname"  runat="server" id="txtname"/></td>
						<td>身份证号：<input type="text" class="txt txtsfz" value="" runat="server" id="txtsfz"/></td>
					</tr>
					<tr>
						<td>年&nbsp;&nbsp;&nbsp;&nbsp;龄：<input type="text" class="txt txtage" value="" disabled="disabled"/></td>
						<td>性&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;别：
                            <select class="txt txtsex" runat="server" id="txtsex">
                                <option value="男"></option>
                                <option value="女"></option>
                            </select>
						</td>
					</tr>
					<tr>
						<td>生&nbsp;&nbsp;&nbsp;&nbsp;日：<input type="text" class="txt txtbir" value="" disabled="disabled"/></td>
						<td>邮&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;箱：<input type="text" class="txt txtem" value="" runat="server" id="txtem"/></td>
					</tr>
					<tr>
						<td colspan="2" class="tab_td"><input type="submit" value="提交" class="btn" runat="server" onserverclick="updateclick"/></td>
					</tr>
				</table>
			</div>
		</div>
        </from>
</asp:Content>
