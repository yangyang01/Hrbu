<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsDetial.aspx.cs" Inherits="Teaching.Pages.NewsDetial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="../Content/js/libs/jquery-1.8.3.min.js"></script>
    <script src="../Content/js/lrtk.js"></script>
    <link href="../Content/css/lrtk.css" rel="stylesheet" />
    <style type="text/css">
        .navi li {
            list-style: none;
            display: inline-block;
            float: left;
            width: 120px;
            color: white;
            font-weight: bold;
            font-size: 15px;
            height: 20px;
            padding: 10px 0;
            text-align: center;
        }

            .navi li:hover {
                background: rgb(255, 111, 111) no-repeat right 0;
                color: #333;
                /*width: 80px;*/
                height: 12px;
                margin-top: 3px;
            }

        .navi {
            width: 1090px;
            height: 40px;
            background-color: rgb(199, 10, 10);
            margin: -17px 5px;
        }

        .footer {
            width: 1080px;
            background: #fff url(/Content/Images/footer.gif) repeat-x;
            padding: 35px 0 0 0;
            text-align: center;
            margin: 0 auto;
        }

        .hint {
            margin: 5px;
        }

        .cont {
            border: 1px solid #EE8888;
            width: 1090px;
            height: 900px;
            margin: 25px 0px 10px 5px;
        }

        .title {
            font-size: 30px;
            font-weight: bold;
            text-align: center;
            margin: 30px 150px;
        }

        .a {
            float: left;
            border-width: 0 1px 1px 1px;
            border-color: #EE8888;
            border-style: solid;
            margin: 5px 3px;
        }

        .b {
            height: 30px;
            border-width: 1px;
            border-color: #EE8888;
            border-style: solid;
            margin: 0 -1px;
            background: #FCC1C1;
            position: relative;
            float: left;
        }

        .c {
            line-height: 10px;
            color: #f9f9f9;
            background: #FDF8F8;
            border-bottom: 6px solid #FFE2E2;
        }

        .d {
            padding: 0 210px 0px 8px;
            line-height: 22px;
            font-size: 14px;
            color: red;
            clear: both;
            margin-top: -12px;
            cursor: pointer;
            font-weight: bold;
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
        <div style="width: 1100px; height: 1470px; background-color: white; margin: -17px 0px 0px 110px">
            <%--head picture --%>
            <div style="background-color: rgb(255, 111, 111); width: 1090px; height: 200px; margin-left: 5px"></div>
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
            <div class="cont">
                <div class="title">关于11月份县综治委成员单位社会管理综合治理重点工作月考评结果的通报</div>
                <div class="date">【来源：县委政法委】 【录入时间：14-01-09 09:06:17】 【浏览次数：42】 </div>
                <div style="border-bottom: 2px solid rgb(221, 211, 211); rgb(199, 196, 196); margin: 0px 20px;">
                </div>
            </div>

            <div style="width: 1100px; height: 250px;">
                <div class="a">
                    <div class="b">
                        <div class="c">&nbsp;</div>
                        <div class="d" style="padding: 0 10px 0px 5px;">图片新闻<span class="more" style="margin-left: 971px"> 更多>></span></div>
                    </div>
                    <div class="box" style="width: 1090px; height: 200px">
                        <div class="">
                            <style>
                                * {
                                    margin: 0;
                                    padding: 0;
                                }

                                /*.other {
                                        width: 100%;
                                        height: 50px;
                                        background: #F00;
                                    }*/

                                .main {
                                    width: 1100px;
                                    height: 130px;
                                    margin: 0 auto;
                                    /*border: 1px solid #000;*/
                                    overflow: hidden;
                                    position: relative;
                                }

                                .banner a {
                                    display: block;
                                    float: left;
                                    margin: 15px 0 0 15px;
                                }

                                .banner {
                                    position: absolute;
                                    width: 800%;
                                }

                                #wrap1,
                                #wrap2 {
                                    float: left;
                                }

                                .text {
                                    text-align: center;
                                }

                                #wrap1 a,
                                #wrap2 a {
                                    text-decoration: none;
                                }

                                #wrap1 span,
                                #wrap2 span {
                                    display: block;
                                    width: 100px;
                                    height: 130px;
                                    /*border: 1px solid #000;*/
                                    font-size: 36px;
                                    text-align: center;
                                    background: white;
                                    padding: 0px 10px;
                                }
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

                            <script type="text/javascript">
                                window.onload = function () {
                                    speed = -1;
                                    move = getId('banner');
                                    getId('wrap2').innerHTML = getId('wrap1').innerHTML;
                                    var time = setInterval(automove, 400);
                                    getId('main').onmouseover = function () {
                                        clearInterval(time);
                                    }
                                    getId('main').onmouseout = function () {
                                        time = setInterval(automove, 10);
                                    }
                                    getId('left').onclick = function () {
                                        speed = -1;
                                    }
                                    getId('right').onclick = function () {
                                        speed = 1;
                                    }
                                }
                                function getId(id) {
                                    return document.getElementById(id);
                                }
                                function automove() {
                                    if (parseInt(move.style.left) <= -getId('wrap1').offsetWidth) {
                                        move.style.left = 0 + 'px';
                                    }
                                    if (move.offsetLeft > 0) {
                                        move.style.left = -getId('wrap1').offsetWidth + 'px';
                                    }
                                    move.style.left = move.offsetLeft + speed + 'px';
                                }
                            </script>
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
            <div class="footer" style="margin: 10px;">
            </div>
            <div style="font-size: 15px; text-align: center; color: gray;">
                友情链接：<a class="hint">aaaaaa</a> |<a class="hint">bbbbbb</a>| <a class="hint">cccccc</a>| <a class="hint">dddddd</a><br />
                <div style="height: 20px; margin-top: 30px; font-size: 12px">
                    铜陵平安网 版权所有
                </div>
                <div style="font-size: 12px">建议使用 1024 X 768 分辨率，IE9.0 或以上版本浏览本网站</div>
            </div>
    </form>
</body>
</html>
