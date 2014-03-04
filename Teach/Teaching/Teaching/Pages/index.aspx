<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Teaching.Pages.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Content/css/index.css" rel="stylesheet" />
    <script src="../Content/js/global.js"></script>
    <title></title>
    <script type="text/javascript">

        function change(ss) {
            if (ss == top1) {
                document.getElementById('left2').style.display = block;
                document.getElementById('right2').style.display = none;
                document.getElementById('left1').style.color = black;
            }
            else {
                document.getElementById('left2').style.display = none;
                document.getElementById('right2').style.display = block;
                document.getElementById('right').style.color = black;
            }
        }
    </script>
</head>
<body style="background-color: rgb(241, 232, 235)">
    <form id="Form2" runat="server" target="_middem">
        <div style="width: 1100px; height: 2900px; height: 2700px !important; background-color: white; margin: -17px 0px 0px 110px">
            <div style="width: 1100px; height: 50px; margin-left: 5px;">
                <table style="margin: 16px 0 0  -2px;">
                    <tr>
                        <td>
                            <div class="b" style="margin: -2px 0px; height: 36px; border-color: rgb(253, 88, 24); border-width: 0em;">
                                <div class="c" style="background-color: rgb(247, 195, 183); border-bottom: 2px solid #FFE2E2; height: 5px;">
                                    &nbsp;
                                </div>
                                <div class="d" style="padding: 15px 8px 0px 10px; width: 575px; font-size: 24px; text-align: center;">
                                    头条新闻<span class="more" style="margin-left: 14px;"></span>
                                </div>
                            </div>
                        </td>
                        <td>
                            <div style="width: 469px; height: 25px; padding: 7px 0 0 20px; margin-left: 3px; border: 1px solid #FCC1C1;">
                                <span style="width: 197px; height: 22px; background: url(/Content/Images/search_box.jpg) no-repeat; display: block; float: left;">
                                    <input name="keyword" type="text" value="请输入您要检索的关键词" style="width: 170px; color: #444444; height: 19px; *height: 20px; padding-top: 1px; *padding-top: 0; border: 0; background: none; margin-left: 26px; line-height: 20px;" />
                                </span>
                                <input type="hidden" name="Field" value="Title" />
                                <input name="" type="image" src="/Content/Images/search_button.jpg" style="margin-left: 30px;" />
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
            <%-- part one --%>
            <div style="width: 1100px; height: 350px; margin: -8px 0px -8px -1px;">
                <div class="self" style="margin-left: 5px">
                    <div id="picplayer" style="position: relative; overflow: hidden; width: 300px; height: 295px; clear: none; border: solid 1px #ccc;">
                        there is a pic-player 
                    </div>
                    <div style="width: 300px; height: 20px; background-color: rgb(201, 197, 197)">
                        <center><span class="newstitle">2013年10月份信息报送工作考核情况的通报</span></center>
                    </div>
                </div>

                <div class="a" style="margin: 5px 2px 5px -13px;">
                    <div class="b">
                        <div class="c">&nbsp;</div>
                        <div class="d" style="padding: 0 8px 0px 10px; width: 265px;">要&nbsp;闻 <span class="more" style="margin-left: 175px"><a href="ListDetail.aspx">更多>></a></span></div>
                    </div>
                    <div id="inform" class="inform cont" style="height: 303px">
                        <ul id="top" style="width: 50px; margin-left: -32px">
                            <a href="NewsDetial.aspx">
                                <li>县委政法委召开“整顿作风，提升效能，优化环境”主题教育实</li>
                            </a>
                            <li>关于11月份县综治委成员单位社会管理综合治理重点工作月考评结果的通报</li>
                            <li>2013年11月份新闻宣传类信息考核情况的通报</li>
                            <li>关于1-9月份县综治委成员单位社会管理综合治理重点工作月考评结果的通报</li>
                            <li>2013年10月份信息报送工作考核情况的通报</li>
                            <li>县委政法委召开“整顿作风，提升效能，优化环境”主题教育实</li>
                            <li>关于11月份县综治委成员单位社会管理综合治理重点工作月考评结果的通报</li>
                            <li>2013年11月份新闻宣传类信息考核情况的通报</li>
                        </ul>
                        <%--<div id="bottom"></div>--%>
                    </div>
                </div>
                <div class="a" style="width: 490px;">
                    <div class="b">
                        <div class="c">&nbsp;</div>
                        <div class="d" style="padding: 0 10px 0px 10px;">高层动态<span class="more" style="margin-left: 363px; margin-left: 368px !important"> 更多>></span></div>
                    </div>
                    <div class="cont"></div>
                </div>

                <%-- part two --%>
                <div style="width: 1100px; height: 350px;">
                    <div class="a" style="width: 303px;">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0px 10px 0px 11px;">通知公告<span class="more" style="margin-left: 175px; margin-left: 180px !important"> 更多>></span></div>
                        </div>

                        <div class="cont">
                            <div style="height: 248px">
                            </div>
                            <span>
                                <a href="MailBox.aspx">
                                    <img src="/Content/Images/box.jpg" alt="政法书记信箱" border="0" style="height: 70px; width: 300px;" /></a></span>
                        </div>
                    </div>
                    <div class="a" style="width: 283px">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 3px;"><span id="left1" onmouseover="change('top1')">乡镇动态</span>|<span id="right1" onmouseover="change('top2')">他山之石</span><span class="more" style="margin-left: 95px; margin-left: 108px !important"> 更多>></span></div>
                        </div>
                        <div id="left2" class="cont">乡镇动态</div>
                        <div id="right2" class="cont" style="display: none;">他山之石</div>
                    </div>

                    <div class="a" style="width: 490px">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 13px 0px 7px; padding-left: 15px !important">重要活动<span class="more" style="margin-left: 363px; margin-left: 360px !important"> 更多>></span></div>
                        </div>
                        <div class="cont"></div>
                    </div>
                </div>
                <%--cxdt picture --%>
                <div class="cxdt cxdt1">
                </div>
                <%--part four --%>
                <div style="width: 1100px; height: 350px;">
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">维护稳定<span class="more" style="margin-left: 233px; margin-left: 239px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 300px;"></div>
                    </div>
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">综治治理<span class="more" style="margin-left: 233px; margin-left: 239px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 300px;"></div>
                    </div>
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">见义勇为<span class="more" style="margin-left: 233px; margin-left: 239px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 300px;"></div>
                    </div>
                </div>
                <%--cxdt picture --%>
                <div class="cxdt cxdt2">
                </div>
                <%--part five --%>
                <div style="width: 1100px; height: 350px;">
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">执法司法<span class="more" style="margin-left: 233px; margin-left: 239px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 300px;"></div>
                    </div>
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">依法行政<span class="more" style="margin-left: 598px; margin-left: 605px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 723px;"></div>
                    </div>
                </div>
                <%--cxdt picture --%>
                <div class="cxdt cxdt3">
                </div>
                <%--part six --%>
                <div style="width: 1100px; height: 350px;">
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">教育培训<span class="more" style="margin-left: 233px; margin-left: 239px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 300px;"></div>
                    </div>
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">人事任免<span class="more" style="margin-left: 233px; margin-left: 239px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 300px;"></div>
                    </div>
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">党建园地<span class="more" style="margin-left: 233px; margin-left: 239px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 300px;"></div>
                    </div>
                </div>
                <%--cxdt picture --%>
                <div class="cxdt cxdt4">
                </div>
                <%-- part seven --%>
                <div style="width: 1100px; height: 350px;">
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">法院<span class="more" style="margin-left: 170px; margin-left: 174px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 250px;"></div>
                    </div>
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">检察院<span class="more" style="margin-left: 160px; margin-left: 164px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 250px;"></div>
                    </div>
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">公安<span class="more" style="margin-left: 170px; margin-left: 174px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 250px;"></div>
                    </div>
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">司法行政<span class="more" style="margin-left: 143px; margin-left: 147px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 240px;"></div>
                    </div>
                </div>
                <%--cxdt picture --%>
                <div class="cxdt cxdt5">
                </div>
                <%-- part eight --%>
                <div style="width: 1100px; height: 350px;">
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">理论文章<span class="more" style="margin-left: 139px; margin-left: 143px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 240px;"></div>
                    </div>
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">书画天地<span class="more" style="margin-left: 146px; margin-left: 150px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 240px;"></div>
                    </div>
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">摄影长廊<span class="more" style="margin-left: 142px; margin-left: 146px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 240px;"></div>
                    </div>
                    <div class="a">
                        <div class="b">
                            <div class="c">&nbsp;</div>
                            <div class="d" style="padding: 0 10px 0px 8px;">心灵驿站<span class="more" style="margin-left: 141px; margin-left: 147px !important"> 更多>></span></div>
                        </div>
                        <div class="cont" style="width: 240px;"></div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
