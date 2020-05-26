<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="New.aspx.cs" Inherits="UI.New" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <%--样式--%>
    <link href="css/New.css" rel="stylesheet" type="text/css"/>
    <%--js--%>
    <script src="js/jquery-3.4.1.min.js" type="text/javascript"></script>
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
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="big">
			<a href="https://www.hao123.com/mid?from=shoubai&key=9358359955464114496&type=rec">
				<div class="big_div">
					<div class="big_left">
						<img style="opacity: 1;" src="https://dgss1.baidu.com/6ONXsjip0QIZ8tyhnq/it/u=1242028783,1672913158&amp;fm=173&amp;app=49&amp;f=JPEG?w=312&amp;h=208&amp;s=EA18AA4446737B9058B4E3770300D06D">
					</div>
					<div class="big_right">
						<div class="big_title">习近平领航中国经济巨轮破浪前行</div>
						<div class="big_nr">2019年，新中国迎来70岁生日，决胜全面建成小康社会进入关键之年。这一年，国内外风险挑战明显上升。以习近平同志为核心的党中央带领全党全国人民，坚持稳中求...</div>
					</div>
				</div>
			</a>

			<a href="https://www.hao123.com/mid?from=shoubai&key=9834499664811966148&type=rec">
				<div class="big_div">
					<div class="big_left">
						<img style="opacity: 1;" src="https://dgss1.baidu.com/6ONXsjip0QIZ8tyhnq/it/u=3270792091,3321355098&amp;fm=173&amp;app=49&amp;f=JPEG?w=312&amp;h=208&amp;s=D32DB044B2400F5F70983CD50300C088">
					</div>
					<div class="big_right">
						<div class="big_title">浙江很受期待的一座跨海大桥，全长27.9公里</div>
						<div class="big_nr">跨海大桥是我国很浩大的工程，任何一个城市在打造跨海大桥的过程中，都会引起很多人的瞩目鱼重视，而除了是被人逐步接受之外，也仍然是有不少的大桥工程都能起...</div>
					</div>
				</div>
			</a>

			<a href="http://hlj.sina.com.cn/news/b/2019-12-12/detail-iihnzhfz5284658.shtml">
				<div class="big_div">
					<div class="big_left">
						<img src="http://n.sinaimg.cn/hlj/transform/266/w640h426/20191212/5ba8-ikrsesr8287135.jpg">
					</div>
					<div class="big_right">
						<div class="big_title">哈尔滨新区企业登记智能审批系统上线</div>
						<div class="big_nr">哈尔滨新区企业登记智能审批系统上线 11日，在哈尔滨新区行政服务中心，来自哈尔滨市沿楠科技有限公司的王晗东通过登录企业登记4.0版智能审批系统，仅用了10分钟完成了企业信息登记，几秒后系统自动审批，便拿到了企业的营业执照...
						</div>
					</div>
				</div>
			</a>

			<a href="http://jiangsu.sina.com.cn/news/general/2017-03-15/detail-ifycnpit1950133.shtml">
				<div class="big_div">
					<div class="big_left">
						<img src="http://n.sinaimg.cn/jiangsu/transform/20170315/aAPk-fychtth0494662.jpg" />
					</div>
					<div class="big_right">
						<div class="big_title">重磅！南京主城区暂停向拥有2套及以上住房本市居民出售住房</div>
						<div class="big_nr">为贯彻落实国家因城施策、分类调控的要求，坚持“房子是用来住的，不是用来炒的”，强化住房居住属性，促进南京市房地产市场平稳健康发展，3月15日，南京市政府办公厅出台《关于进一步调整我市住房限购政策的通知》</div>
					</div>
				</div>
			</a>

			<a href="https://www.hao123.com/mid?from=shoubai&key=9675413200079608282&type=rec">
				<div class="big_div">
					<div class="big_left">
						<img style="opacity: 1;" src="https://dgss1.baidu.com/6ONXsjip0QIZ8tyhnq/it/u=3646414063,734173185&amp;fm=173&amp;app=49&amp;f=JPEG?w=312&amp;h=208&amp;s=B2E4F0044C10B1CE06B710990300D089">
					</div>
					<div class="big_right">
						<div class="big_title">时隔一年之久，仍有射手无脑走下路，官方只需一技便可永除后患</div>
						<div class="big_nr">时隔一年之久，仍有射手无脑走下路，官方只需一技便可永除后患/时隔一年之久，仍有射手无脑走下路，玩家提出一技完美解决该问题。本期研究话题：建议设置开局路...</div>
					</div>
				</div>
			</a>
		</div>
    </form>
</body>
</html>
