<%@ Page Title="" Language="C#" MasterPageFile="~/Main/MainHome.Master" AutoEventWireup="true" CodeBehind="Detailed.aspx.cs" Inherits="UI.Detailed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Detailed.css" rel="stylesheet" type="text/css" />
    <script src="js/jquery-3.4.1.min.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <from runat="server" id="from1">
        <div class="big">
        <div class="top">
			<div class="top_user">
				<div class="userimg"><img src="" runat="server" id="userimg"/></div>
				<div class="username" runat="server" id="username"><%--我的用户名--%></div>
                <asp:Button ID="Button3" runat="server" Text="+关注" CssClass="usergz" OnClick="Button3_Click"></asp:Button>
			</div>
			<div class="top_dt">
				<div class="dt_nr" runat="server" id="usercon">
					<%--动态内容--%>
				</div>
				<div class="dt_img" runat="server" id="stateimg">
				</div>
				<div class="dt_xz">
					<div class="dt_dc"><span runat="server" id="dc"></span></div>
					<div class="dt_dz"><span runat="server" id="dz"></span></div>
				</div>
			</div>
		</div>
		<div class="bot">
            <textarea class="bot_txt" placeholder="我也来说几句！(40字以内)" runat="server" id="bot_txt" maxlength="40"></textarea>
            <asp:Button ID="Button1" runat="server" Text="确定" CssClass="bot_but" OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" Text="清空" CssClass="bot_but" OnClick="Button2_Click"/>
		</div>

        <asp:Repeater ID="RepeaterPl" runat="server">
            <ItemTemplate>
        <div class="statepl">
            <div class="pl_user">
				<div class="userimg"><img src="Images/<%# Eval("userimg") %>"/></div>
				<div class="username"><%# Eval("username") %></div>
                <div class="time"><%# Eval("pltime") %></div>
                <div class="pl_xz">
					<div class="dt_dc"><span><%# Eval("plbadnums") %></span></div>
					<div class="dt_dz"><span><%# Eval("plgoodnums") %></span></div>
				</div>
			</div>
            <div class="pl_nr" runat="server" id="plnr">
					<%--评论内容--%>
                    <%# Eval("commentarycontent") %>
				</div>
        </div>
            </ItemTemplate>
        </asp:Repeater>
            </div>
    </from>
</asp:Content>
