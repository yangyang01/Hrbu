<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListDetail.aspx.cs" Inherits="Teaching.Pages.ListDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="../Content/js/libs/jquery-1.8.3.min.js"></script>
    <script src="../Content/js/lrtk.js"></script>
    <link href="../Content/css/lrtk.css" rel="stylesheet" />
    <link href="../Content/css/picnews.css" rel="stylesheet" />
    <script src="../Content/js/picnews.js"></script>
    <link href="../Content/css/index.css" rel="stylesheet" />
    <style type="text/css">
        .hint {
            margin: 5px;
        }

        .date {
            font-size: 16px;
            font-weight: bold;
            text-align: center;
            margin: 30px 150px;
        }

        .content_title {
            font-family: '微软雅黑';
            margin: 19px 0px 20px 1px;
            height: 40px;
            line-height: 40px;
            border-bottom: solid 1px #C5C5C5;
            background: url('/Content/Images/buttom_title.png') 0 0 repeat-x;
        }

            .content_title span {
                font-size: 20px;
                margin-left: -923px;
            }

        .inform li {
            width: 840px;
            height: 25px;
            line-height: 25px;
            padding: 7px 0 5px 25px;
            background: url(/Content/Images/li.gif) no-repeat 8px center;
            white-space: nowrap;
            /*overflow: hidden;*/
            text-overflow: ellipsis;
            font-family: inherit;
            font-size: 14px;
            list-style: none;
        }

        .cont {
            height: 590px;
        }

        .publishTitle {
            display: block;
            float: left;
            width: 750px;
        }

        publishDate {
            width: 50px;
        }
    </style>
</head>
<body style="background-color: rgb(241, 232, 235)">

    <form id="form1" runat="server" target="_middem">
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
        <div style="width: 1094px; height: 920px; background-color: white; margin: 30px 0px 0px 113px;">
            <div class="cont">
                <div class="content_title"><span>要 闻</span></div>
                <div id="inform" class="inform" style="border-bottom:1px dashed gray">
                    <ul id="top" style="width: 50px; margin-left: 12px;">
                        <li><a href="NewsDetial.aspx"><span class="publishTitle">县委政法委召开“整顿作风，提升效能，优化环境”主题教育实</span></a><span class="publishDate"> 2014-02-14</span></li>
                        <li><span class="publishTitle">关于11月份县综治委成员单位社会管理综合治理重点工作月考评结果的通报</span><span class="publishDate"> 2014-02-14</span></li>
                        <li><span class="publishTitle">2013年11月份新闻宣传类信息考核情况的通报</span><span class="publishDate"> 2014-02-14</span></li>
                        <li><span class="publishTitle">关于1-9月份县综治委成员单位社会管理综合治理重点工作月考评结果的通报</span><span class="publishDate"> 2014-02-14</span></li>
                        <li><span class="publishTitle">2013年10月份信息报送工作考核情况的通报</span><span class="publishDate"> 2014-02-14</span></li>
                        <li><span class="publishTitle">县委政法委召开“整顿作风，提升效能，优化环境”主题教育实</span><span class="publishDate"> 2014-02-14</span></li>
                        <li><span class="publishTitle">关于11月份县综治委成员单位社会管理综合治理重点工作月考评结果的通报</span><span class="publishDate"> 2014-02-14</span></li>
                        <li><span class="publishTitle">2013年11月份新闻宣传类信息考核情况的通报</span><span class="publishDate"> 2014-02-14</span></li>
                        <li><span class="publishTitle">关于11月份县综治委成员单位社会管理综合治理重点工作月考评结果的通报</span><span class="publishDate"> 2014-02-14</span></li>
                        <li><span class="publishTitle">2013年11月份新闻宣传类信息考核情况的通报</span><span class="publishDate"> 2014-02-14</span></li>
                        <li><span class="publishTitle">关于1-9月份县综治委成员单位社会管理综合治理重点工作月考评结果的通报</span><span class="publishDate"> 2014-02-14</span></li>
                        <li><span class="publishTitle">2013年10月份信息报送工作考核情况的通报</span><span class="publishDate"> 2014-02-14</span></li>
                        <li><span class="publishTitle">县委政法委召开“整顿作风，提升效能，优化环境”主题教育实</span><span class="publishDate"> 2014-02-14</span></li>
                    </ul>
                    <%--<div id="bottom"></div>--%>
                </div>
                <div style="font-size:13px;border-bottom:1px solid red">
                    <p align="right" style="margin: 8px 10px 0 0;">
                        首页 上一页 下一页 尾页 页次：/页 共条记录 转<input tyep="TEXT" name="page" size="2" maxlength="5" value="">页
                                        <input type="submit" value="GO">
                </div>
            </div>

            <div style="width: 1091px; height: 250px;">
                <div class="a">
                    <div class="b">
                        <div class="c">&nbsp;</div>
                        <div class="d" style="padding: 0 10px 0px 5px;">图片新闻<span class="more" style="margin-left: 971px"> 更多>></span></div>
                    </div>
                    <div class="box" style="width: 1088px; height: 200px">
                        <div class="">
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
