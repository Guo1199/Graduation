<%@ Page Title="" Language="C#" MasterPageFile="~/Main/MainHome.Master" AutoEventWireup="true" CodeBehind="Release.aspx.cs" Inherits="UI.Release" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="content">
			<div class="left">
				<div>
					<textarea placeholder="你有什么新鲜事想告诉大家？" runat="server" id="text1"></textarea>
				</div>
				<div class="Photo">
					<span>照片：</span>
					<asp:FileUpload ID="FileUpload1" runat="server" />
					 <asp:DropDownList ID="DropDownList1" runat="server" Class="login_input" OnSelectedIndexChanged="Page_Load"></asp:DropDownList>
				</div>
				<input type="submit" id="Submit1" name="" value="发布" class="sub"  onserverclick="Submit1_ServerClick"/>
               
			</div>`
			<div class="right">
				<ul class="Notice">
					<li>投稿须知</li>
					<li>1、只要你发布的事，不含政治、色情、诽谤、歧视等内容。</li>
					<li>2、文章经过审核后发表</li>
					<li>3、转载请注明出处</li>
					<li>4、投稿内容著作权、版权归乐语网所有</li>
				</ul>
			</div>
		</div>
</asp:Content>
