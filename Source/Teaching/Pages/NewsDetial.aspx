<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsDetial.aspx.cs" Inherits="Teaching.Pages.NewsDetial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="../Content/js/libs/jquery-1.8.3.min.js"></script>
    <script src="../Content/js/lrtk.js"></script>
    <link href="../Content/css/lrtk.css" rel="stylesheet" />
    <link href="../Content/css/index.css" rel="stylesheet" />
    <link href="../Content/css/picnews.css" rel="stylesheet" />
    <script src="../Content/js/picnews.js"></script>
    <style type="text/css">
        .hint {
            margin: 5px;
        }

        .cont {
            border: 1px solid #EE8888;
            width: 1085px;
            height: 900px;
            margin: 25px 0px 10px 4px;
        }

        .newtitle {
            font-size: 30px;
            font-weight: bold;
            text-align: center;
            margin: 30px 150px;
        }

        .date {
            font-size: 16px;
            font-weight: bold;
            text-align: center;
            margin: 30px 150px;
        }
    </style>
</head>
<body style="background-color: rgb(241, 232, 235)">
    <form id="form1" runat="server">
        <div style="width: 1100px; height: 200px; margin: -17px 0px 0px 110px">
            <%--head picture --%>
            <div class="head">
                <img src=" /Content/Images/head.jpg" style="width: 1091px; height: 189px; margin-left: 4px;" />
            </div>
            <%-- navigater --%>
            <div class="navi">
                <ul>
                    <a href="main.aspx">
                        <li>首  页</li>
                    </a>
                    <li style="margin-left: -17px;">要 闻</li>
                    <li>平安建设</li>
                    <li>法制建设</li>
                    <li>队伍建设</li>
                    <li>部门动态</li>
                    <li>政法文化</li>
                    <li>安徽长安网</li>
                </ul>
            </div>
        </div>
        <div style="width: 1094px; height: 1236px; background-color: white; margin: 27px 0px 0px 113px">
            <div class="cont">
                <div class="newtitle">关于11月份县综治委成员单位社会管理综合治理重点工作月考评结果的通报</div>
                <div class="date">【来源：县委政法委】 【录入时间：14-01-09 09:06:17】 【浏览次数：42】 </div>
                <div style="border-bottom: 2px solid rgb(221, 211, 211); rgb(199, 196, 196); margin: 0px 20px;">
                </div>
            </div>

            <div style="width: 1094px; height: 250px;">
                <div class="a">
                    <div class="b">
                        <div class="c">&nbsp;</div>
                        <div class="d" style="padding: 0 10px 0px 3px;">图片新闻<span class="more" style="margin-left: 971px"> 更多>></span></div>
                    </div>
                    <div class="box" style="width: 1086px; height: 200px">
                        <div class="">
                            <style>
   
                            </style>
                            <div class="main" id="main">
                                <div class="banner" id="banner">
                                    <div id="wrap1">
                                        <a href="#"><span>
                                            <img src="/Content/Images/1.jpg" /></span></a><a href="#"><span><img src="/Content/Images/2.jpg" /></span></a><a href="#"><span><img src="/Content/Images/3.jpg" /></span></a><a href="#"><span><img src="/Content/Images/4.jpg" /></span></a><a href="#"><span><img src="/Content/Images/5.jpg" /></span></a>
                                        <a href="#"><span>
                                            <img src="/Content/Images/6.jpg" /></span></a><a href="#"><span><img src="/Content/Images/7.jpg" /></span></a><a href="#"><span><img src="/Content/Images/8.jpg" /></span></a><a href="#"><span><img src="/Content/Images/9.jpg" /></span></a><a href="#"><span><img src="/Content/Images/10.jpg" /></span></a>
                                    </div>
                                    <div id="wrap2">
                                    </div>
                                </div>
                            </div>
                            <div class="other">
                            </div>
                            <a href="javascript:void(0)" id="left">
                                <div class="og_prev"></div>
                            </a>
                            <a href="javascript:void(0)" id="right">
                                <div class="og_next"></div>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div style="width: 1100px; height: 100px; margin: -60px 0px 0px 110px">
            <div class="footer">
            </div>
            <div style="font-size: 15px; text-align: center; color: gray;">
                友情链接：<a class="hint">aaaaaa</a> |<a class="hint">bbbbbb</a>| <a class="hint">cccccc</a>| <a class="hint">dddddd</a><br />
                <div style="height: 20px; margin-top: 30px; font-size: 12px">
                    铜陵平安网 版权所有
                </div>
                <div style="font-size: 12px">建议使用 1024 X 768 分辨率，IE9.0 或以上版本浏览本网站</div>
            </div>
        </div>
    </form>
</body>
</html>
