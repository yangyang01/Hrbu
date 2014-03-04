<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="Teaching.Pages.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="../Content/js/libs/jquery-1.8.3.min.js"></script>
    <script src="../Content/js/lrtk.js"></script>
    <link href="../Content/css/lrtk.css" rel="stylesheet" />
    <script type="text/javascript">
       
        function change(ss){
            if(ss==top1){
                document.getElementById('left2').style.display=block;
                document.getElementById('right2').style.display = none;
                document.getElementById('left1').style.color = black;
            }
            else{
                document.getElementById('left2').style.display=none;
                document.getElementById('right2').style.display = block;
                document.getElementById('right').style.color = black;
            }
        }
    </script>
    <style type="text/css">
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

        .title {
            background-color: red;
            font-size: 15px;
            color: yellow;
        }

        .cont {
            height: 320px;
        }

        .self {
            float: left;
            border-width: 1px;
            border-color: #EE8888;
            border-style: solid;
            height: 317px;
            width: 300px;
            margin: 5px 20px;
        }

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

        .cxdt {
            width: 1000px;
            height: 40px;
            margin: -10px 0px 10px 5px;
            clear: both;
        }

        .cxdt1 {
            background: url(/Content/Images/cxdt1.gif) no-repeat;
        }

        .cxdt2 {
            background: url(/Content/Images/cxdt2.gif) no-repeat;
        }

        .cxdt3 {
            background: url(/Content/Images/cxdt3.gif) no-repeat;
        }

        .cxdt4 {
            background: url(/Content/Images/cxdt4.gif) no-repeat;
        }

        .cxdt5 {
            background: url(/Content/Images/cxdt5.gif) no-repeat;
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

        .navi li:hover {
            background: rgb(255, 111, 111) no-repeat right 0;
            color: #333;
            /*width: 130px;*/
            height: 12px;
            margin-top: 3px;
        }

        .navi {
            width: 1090px;
            height: 40px;
            background-color: rgb(199, 10, 10);
            margin: -2px 5px;
        }

        .more {
            font-size: 13px;
            font-weight: initial;
        }

        .inform li {
            width: 245px;
            height: 25px;
            line-height: 25px;
            padding: 5px 0 5px 20px;
            background: url(/Content/Images/li.gif) no-repeat 8px center;
            white-space: nowrap;
            overflow: hidden;
            text-overflow: ellipsis;
            font-family: inherit;
            font-size: 14px;
        }

        .newstitle {
            white-space: nowrap;
            overflow: hidden;
            text-overflow: ellipsis;
            font-size: 0.9em;
            margin-top: -5px;
        }
    </style>
</head>
<body style="background-color: rgb(241, 232, 235)">
    <form id="form1" runat="server">
        <div style="width: 1100px; height: 2900px; height: 2960px !important; background-color: white; margin: -17px 0px 0px 110px">
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
            <br />
            <div style="width: 1100px; height: 40px; margin-left: 5px;">
                <table style="margin-left: -2px;">
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
                    <script>
                        var p = $('#picplayer');
                        var pics1 = [{ url: '/Content/Images/1.jpg', link: '', time: 5000 }, { url: '/Content/Images/2.jpg', link: '', time: 5000 }, { url: '/Content/Images/3.jpg', link: '', time: 5000 }, { url: '/Content/Images/4.jpg', link: '', time: 5000 }, { url: '/Content/Images/5.jpg', link: '', time: 5000 }];
                        initPicPlayer(pics1, p.css('width').split('px')[0], p.css('height').split('px')[0]);
                        // 
                        function initPicPlayer(pics, w, h) {
                            //选中的图片 
                            var selectedItem;
                            //选中的按钮 
                            var selectedBtn;
                            //自动播放的id 
                            var playID;
                            //选中图片的索引 
                            var selectedIndex;
                            //容器 
                            var p = $('#picplayer');
                            p.text('');
                            p.append('<div id="piccontent"></div>');
                            var c = $('#piccontent');
                            for (var i = 0; i < pics.length; i++) {
                                //添加图片到容器中 
                                c.append('<a href="' + pics[i].link + '" target="_blank"><img id="picitem' + i + '" style="display: none;height: 329px;width:298.5px;z-index:' + i + '" src="' + pics[i].url + '" /></a>');
                            }
                            //按钮容器，绝对定位在右下角 
                            p.append('<div id="picbtnHolder" style="position:absolute;top:' + (h - 25) + 'px;width:' + w + 'px;height:20px;z-index:10000;"></div>');
                            // 
                            var btnHolder = $('#picbtnHolder');
                            btnHolder.append('<div id="picbtns" style="float:right; padding-right:1px;"></div>');
                            var btns = $('#picbtns');
                            // 
                            for (var i = 0; i < pics.length; i++) {
                                //增加图片对应的按钮 
                                btns.append('<span id="picbtn' + i + '" style="cursor:pointer;background-color:#eee; display:inline-block;"> ' + (i + 1) + ' </span> ');
                                $('#picbtn' + i).data('index', i);
                                $('#picbtn' + i).click(
                                    function (event) {
                                        if (selectedItem.attr('src') == $('#picitem' + $(this).data('index')).attr('src')) {
                                            return;
                                        }
                                        setSelectedItem($(this).data('index'));
                                    }
                                );
                            }
                            btns.append(' ');
                            /// 
                            setSelectedItem(0);
                            //显示指定的图片index 
                            function setSelectedItem(index) {
                                selectedIndex = index;
                                clearInterval(playID);
                                //alert(index); 
                                if (selectedItem) selectedItem.fadeOut('fast');
                                selectedItem = $('#picitem' + index);
                                selectedItem.fadeIn('slow');
                                // 
                                if (selectedBtn) {
                                    selectedBtn.css('backgroundColor', '#eee');
                                    selectedBtn.css('color', '#000');
                                }
                                selectedBtn = $('#picbtn' + index);
                                selectedBtn.css('backgroundColor', '#000');
                                selectedBtn.css('color', '#fff');
                                //自动播放 
                                playID = setInterval(function () {
                                    var index = selectedIndex + 1;
                                    if (index > pics.length - 1) index = 0;
                                    setSelectedItem(index);
                                }, pics[index].time);
                            }
                        }
                    </script>
                </div>

                <div class="a" style="margin: 5px 2px 5px -13px;">
                    <div class="b">
                        <div class="c">&nbsp;</div>
                        <div class="d" style="padding: 0 8px 0px 10px; width: 265px;">要&nbsp;闻 <span class="more" style="margin-left: 175px"><a href="ListDetail.aspx">更多>></a></span></div>
                    </div>
                    <div id="inform" class="inform cont">
                        <ul id="top" style="width: 50px">
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
                        <div id="right2" class="cont">他山之石</div>
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
                <%-- footer --%>
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
