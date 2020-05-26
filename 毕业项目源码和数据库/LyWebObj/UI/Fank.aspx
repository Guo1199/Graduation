<%@ Page Title="" Language="C#" MasterPageFile="~/Main/MainHome.Master" AutoEventWireup="true" CodeBehind="Fank.aspx.cs" Inherits="UI.Fank" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--样式表--%>
    <link href="css/Fank.css" rel="stylesheet" type="text/css" />
    <script>
        $(function () {
            $(".head--ul_1>li").hover(function () {
                $(this).toggleClass("bgcolor");
                $(this).children("a").css("color", "black");
            }, function () {
                $(this).toggleClass("bgcolor");
                $(this).children("a").css("color", "grey");
            });
            $(".head_login").hide();
            //我要反馈界面显示
            $(".fk").show();
            $(".top_div:eq(0)").toggleClass("style2");
            $(".top_div:eq(0)").click(function () {
                if ($(".fk").is(":hidden")) {
                    $(this).toggleClass("style2").siblings("div").toggleClass("style2");
                    $(".fk").show();
                    $(".myfk").hide();
                }
            });
            $(".top_div:eq(1)").click(function () {
                if ($(".myfk").is(":hidden")) {
                    $(this).toggleClass("style2").siblings("div").toggleClass("style2");
                    $(".myfk").show();
                    $(".fk").hide();
                }
            });
            //获取光标时
            $(".fk_txt").click(function () {
                if ($(this).text() == "请输入您的意见（80字以内）") {
                    $(this).text("");
                }
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <from id="form" runat="server">
        <div class="big">
			<div class="top">
				<div class="top_div">我要反馈</div>
				<div class="top_div">我的反馈</div>
			    
			</div>
			<!--我要反馈-->
			<div class="fk">
                <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" CssClass="fk_txt" ></asp:TextBox>
				<input type="submit" value="提交" class="fk_but" runat="server" onserverclick="addfank"/>
			</div>
			<div class="myfk">
                <asp:Label ID="Label1" runat="server" CssClass="label"></asp:Label>
                <asp:Repeater ID="RepeaterFank" runat="server">
                    <ItemTemplate>
                        <div class="fk_con">
                            <div class="con_top">
                                反馈时间：<span><%# Eval("feedbackTime") %></span>&nbsp;&nbsp;&nbsp;&nbsp;受理状态:<span><%# Eval("acceptancestatus") %></span><asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" CssClass="LinkButton1" CommandName="delete" CommandArgument=<%# Eval("id") %> >删除</asp:LinkButton>
                            </div>
                            <div class="con_bot"><%# Eval("content") %></div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
			</div>
		</div>
    </from>
</asp:Content>
