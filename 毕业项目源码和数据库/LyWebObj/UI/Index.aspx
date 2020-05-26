<%@ Page Title="首页" Language="C#" MasterPageFile="~/Main/MainHome.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UI.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--样式表--%>
    <link href="css/Index.css" rel="stylesheet" type="text/css"/>
    <%--js--%>
    <script src="../js/jquery-3.4.1.min.js" type="text/javascript" charset="utf-8"></script>
    <script>
        $(function () {
            var timer;
            var lunboindex = 0;
            function Moveshow() {
                var len = $(".right--top_ul>li").length;
                timer = setInterval(function () {
                    lunboindex++;
                    if (lunboindex >= len) {
                        lunboindex = 0;
                    }
                    $(".right_top a img").eq(lunboindex).show().parent().siblings("a").children("img").hide();
                    $(".right--top_ul>li").eq(lunboindex).addClass("licss").siblings("li").removeClass("licss");
                }, 4000);
            }
            //调用轮播方法
            Moveshow();
            //轮播li点击事件
            $(".right--top_ul li").click(function () {
                lunboindex = $(this).val();
                $(".right_top a img").eq(lunboindex).show().parent().siblings("a").children("img").hide();
                $(".right--top_ul>li").eq(lunboindex).addClass("licss").siblings("li").removeClass("licss");
            });
            //上一张点击事件
            $(".lunbo_left").click(function () {
                lunboindex--;
                if (lunboindex < 0) {
                    lunboindex = 4;
                }
                $(".right_top a img").eq(lunboindex).show().parent().siblings("a").children("img").hide();
                $(".right--top_ul>li").eq(lunboindex).addClass("licss").siblings("li").removeClass("licss");
            });
            //下一张点击事件
            $(".lunbo_right").click(function () {
                lunboindex++;
                if (lunboindex >= 5) {
                    lunboindex = 0;
                }
                $(".right_top a img").eq(lunboindex).show().parent().siblings("a").children("img").hide();
                $(".right--top_ul>li").eq(lunboindex).addClass("licss").siblings("li").removeClass("licss");
            });
            //鼠标浮动到图片时事件
            $(".right_top").hover(function () {
                $(".right_top img").css("transform", "scale(1.1,1.1)");
                $(".lunbo_left").css("display", "block");
                $(".lunbo_right").css("display", "block");
            }, function () {
                $(".right_top img").css("transform", "scale(1,1)");
                $(".lunbo_left").css("display", "none");
                $(".lunbo_right").css("display", "none");
            });
            //加载时前后一张图片按钮隐藏
            $(".lunbo_left").css("display", "none");
            $(".lunbo_right").css("display", "none");
            //隐藏关注动态界面
            $(".div1_bot2").hide();
            //加载时热门动态蓝色下边框
            $(".div1--top_span1").addClass("style1");
            $(".div1--top_span2>a").css("color", "#C7C7C7");
            //关注动态点击事件
            $(".div1--top_span2>a").click(function () {
                if ($(".div1_bot2").is(":hidden")) {
                    $(".div1--top_span1").toggleClass("style1");
                    $(".div1--top_span1>a").css("color", "#C7C7C7");
                    $(this).css("color", "black");
                    $(".div1--top_span2").toggleClass("style1");
                    //显示关注动态界面
                    $(".div1_bot2").show();
                    //隐藏热门动态界面
                    $(".div1_bot1").hide();
                    $(".div1--bot1_div6").hide();
                }
            });
            //热门动态点击事件
            $(".div1--top_span1>a").click(function () {
                if ($(".div1_bot1").is(":hidden")) {
                    $(".div1--top_span2").toggleClass("style1");
                    $(".div1--top_span2>a").css("color", "#C7C7C7");
                    $(this).css("color", "black");
                    $(".div1--top_span1").toggleClass("style1");
                    //隐藏关注动态界面
                    $(".div1_bot2").hide();
                    //显示热门动态界面
                    $(".div1_bot1").show();
                    $(".div1--bot1_div6").show();
                }
            });

            //左下侧鼠标浮动事件
            $(".left_bot>ul>li").hover(function () {
                $(this).css("border-bottom", "1px solid black");
                $(this).css("cursor", "pointer");
                $(this).children("a").css("color", "black");
            }, function () {
                $(this).css("border-bottom", "1px solid gainsboro");
                $(this).children("a").css("color", "gray");
            });
            //左上侧鼠标浮动事件
            $(".left--top_div2>ul>li>a").hover(function () {
                $(this).css({ color: "red" });
                $(this).parent("li").css("transform", "scale(1.1,1.1)");
            }, function () {
                $(this).css({ color: "black" });
                $(this).parent("li").css("transform", "scale(1,1)");
            });
            //轮播按钮浮动事件
            $(".right_top>div").hover(function () {
                $(this).css("opacity", "0.8");
            }, function () {
                $(this).css("opacity", "0.5");
            });
            //如果含有图片则不隐藏
            $(".dtimg").parent("div").hide();
            $(".dtimg:has(img)").parent("div").show();
            //新闻点击事件
            $(".right--bot_div2").hide();
            $(".left_bot>ul>li:eq(1)").click(function () {
                $(".right--bot_div1").hide().siblings("div").show();
            });


            //滑动自动加载
            //var timer;
            //$(window).bind('scroll',function(){
            //    clearTimeout(timer);
            //    timer = setTimeout(function(){
            //        if($(window).scrollTop()+$(window).height()==$(document).height()){ 
            //            //最底部
            //        }
            //    },300)
            //}); 

        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
			<div class="content_left">
				<div class="left_top">
                    <img src="Images/photo_1.jpg" width="300px" height="150px"/>
					<div class="left--top_div1">
						<div class="left--top_userimg">
							<img src="" id="contentimg" runat="server"/>
						</div>
					    <span class="left--top_span_1" id="username" runat="server"></span>
					</div>
					<div class="left--top_div2">
						<ul>
							<li><a href="#">发布动态</a></li>
							<li><a href="Fank.aspx">反馈中心</a></li>
							<li><a href="#">我的消息</a></li>
						</ul>
					</div>
					<div class="left--top_div3">
						<a href="User.aspx">个人中心&nbsp;&gt;</a>
					</div>
				</div>
				<div class="left_bot">
					<ul>
						<li><a href="Index.aspx?index=0">首页</a></li>
						<li><a href="#">新闻</a></li>
						<li><a href="Index.aspx?index=1">搞笑闲趣</a></li>
						<li><a href="Index.aspx?index=2">影视娱乐</a></li>
						<li><a href="Index.aspx?index=3">游戏</a></li>
						<li><a href="Index.aspx?index=4">体育健身</a></li>
						<li><a href="Index.aspx?index=5">生活情感</a></li>
					</ul>
				</div>
			</div>
			<div class="content_right">
				<div class="right_top">
					<a href="#"><img src="Images/ad-1.jpg" width="100%" height="100%" class="show"/></a>
					<a href="#"><img src="Images/ad-2.jpg" width="100%" height="100%"/></a>
					<a href="#"><img src="Images/ad-3.jpg" width="100%" height="100%"/></a>
					<a href="#"><img src="Images/ad-4.jpg" width="100%" height="100%"/></a>
					<a href="#"><img src="Images/ad-5.jpg" width="100%" height="100%"/></a>
					<ul class="right--top_ul"> 
						<li class="licss" value="0"></li>
						<li value="1"></li>
						<li value="2"></li>
						<li value="3"></li>
						<li value="4"></li>
					</ul>
					<div class="lunbo_left"><a href="#">&lt;</a></div>
			        <div class="lunbo_right"><a href="#">&gt;</a></div>
				</div>
				<div class="right_bot">
					<!--首页div-->
					<div class="right--bot_div1">
						<div class="div1_top">
							<span class="div1--top_span1"><a href="#">热门话题</a></span>
							<span class="div1--top_span2"><a href="#">关注动态</a></span>
						</div>
						<div class="div1_bot1" runat="server" id="div1_bot1">
                            <span runat="server" id="span" class="span"></span>
                            <asp:Repeater ID="RepeaterState" runat="server">
                                <ItemTemplate>
                                    <a href="Detailed.aspx?stateid=<%# Eval("stateid") %>" class="statelink">
							<div class="div1--bot1_div1">
								<div class="userdt_1">
									<div class="dtfl"><%# Eval("statetype") %></div>
									<div class="dtfont"><%# Eval("statecontent") %></div>
								</div>
                                <div class="userdt_2">
								    <div class="dtimg"><img src="<%# Eval("statephoto") %>" /></div>
							    </div>
								<div class="userdt_3">
									<div class="dtpl"><span><%# Eval("plnum") %></span></div>
									<div class="dtdc"><span><%# Eval("statebadnums") %></span></div>
									<div class="dtdz"><span><%# Eval("stategoodnums") %></span></div>
								</div>
							</div>
                                    </a>
                                 </ItemTemplate>
                            </asp:Repeater>
						</div>
                        <div class="div1--bot1_div6">
                                <asp:Button ID="Button1" runat="server" Text="更多" OnClick="Button1_Click" CssClass="button1"/>
						</div>
						<!--关注动态div-->
						<div class="div1_bot2">
                            <span runat="server" id="span1" class="span1"></span>
                            <asp:Repeater ID="RepeaterGzDt" runat="server">
                                <ItemTemplate>
                                    <a href="Detailed.aspx?stateid=<%# Eval("stateid") %>" class="statelink">
							<div class="div1--bot1_div1">
								<div class="userdt_1">
									<div class="dtfl"><%# Eval("statetype") %></div>
									<div class="dtfont"><%# Eval("statecontent") %></div>
								</div>
                                <div class="userdt_2">
								    <div class="dtimg"><img src="<%# Eval("statephoto") %>" /></div>
							    </div>
								<div class="userdt_3">
									<div class="dtpl"><span><%# Eval("plnum") %></span></div>
									<div class="dtdc"><span><%# Eval("statebadnums") %></span></div>
									<div class="dtdz"><span><%# Eval("stategoodnums") %></span></div>
								</div>
							</div>
                                    </a>
                                 </ItemTemplate>
                            </asp:Repeater>
						</div>
					</div>
					<!--新闻div-->
					<div class="right--bot_div2">
						<iframe src="New.aspx" id="userdt" name="userdt" width="100%" height="900px" frameborder="0"></iframe>
					</div>
				</div>
			</div>
		</div>
</asp:Content>
