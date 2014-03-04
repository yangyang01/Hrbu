<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MailBox.aspx.cs" Inherits="Teaching.Pages.MailBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="../Content/js/libs/jquery-1.8.3.min.js"></script>
    <style type="text/css">
        <!--
        .style1 {
            color: #FF0000;
        }

        img {
            border: none;
        }
        -->
        * {
            margin: 0px;
            padding: 0px;
        }

        img {
            vertical-align: bottom;
        }

        body {
            margin: 0px auto;
            font-family: Verdana, Arial, Helvetica, sans-serif,"新宋体";
            font-size: 12px;
            color: #333;
            font-variant: normal;
            background-attachment: fixed;
            margin-top: 10px;
        }

        a:link {
            color: #990000;
        }

        .clear {
            clear: both;
        }

        #contain {
            width: 904px;
            background-color: #FFFFFF;
            margin: 0px auto;
        }

        #header {
            width: 900px;
            margin: 0px 2px 5px 2px;
        }

        .header_pic {
            width: 100%;
            height: 170px;
            margin: 5px auto;
        }

        .header_menu {
            width: 898px;
            height: 30px;
            margin: 0px auto;
            border: 1px solid #D2D2D2;
            background: url(../images/mb.jpg) no-repeat;
        }

            .header_menu ul li {
                line-height: 30px;
                padding-left: 20px;
                list-style-type: none;
                float: left;
            }

                .header_menu ul li a:link {
                    color: #FFFFFF;
                }

                .header_menu ul li a:hover {
                    color: #00FF33;
                }

                .header_menu ul li a:visited {
                    color: #FFFFFF;
                }

        #box {
            width: 898px;
            margin: 0px auto;
            border: 1px solid #D2D2D2;
        }

        .box_list {
            width: 890px;
            margin: 5px 4px;
        }

            .box_list p {
                line-height: 20px;
            }

            .box_list .list_time {
                line-height: 20px;
                color: #C1C1C1;
            }

            .box_list .list_t {
                line-height: 22px;
            }

            .box_list .list_dc {
                line-height: 22px;
                text-indent: 2em;
                color: #6C6C6C;
            }

            .box_list .list_d {
                line-height: 22px;
                text-indent: 2em;
                color: #993300;
                letter-spacing: 1px;
                background-color: #FBEAE3;
            }

                .box_list .list_d span {
                    color: #FF3300;
                    font-weight: bold;
                }

        .line {
            border-bottom: 1px #CCCCCC dotted;
            width: 100%;
            height: 1px;
            margin: 5px auto;
            line-height: 1px;
            overflow: hidden;
        }

        #xycopy {
            width: 898px;
            margin: 5px 2px;
            border: 1px solid #D2D2D2;
            overflow: hidden;
        }

        .xycopy_list {
            width: 890px;
            margin: 5px 4px;
        }

            .xycopy_list .footnav {
                width: 100%;
                line-height: 20px;
                color: #616161;
            }

            .xycopy_list .footdc {
                width: 100%;
                line-height: 24px;
            }

        .box_box {
            width: 768px;
            margin: 30px 64px;
            border: 1px solid #D2D2D2;
            background-color: #F6F6F6;
        }

        .box_book {
            width: 728px;
            margin: 15px 20px;
        }

            .box_book p {
                line-height: 22px;
                text-align: center;
                font-size: 13px;
                font-weight: bold;
            }

            .box_book .book_w {
                width: 100%;
            }

                .box_book .book_w ul li {
                    padding-left: 10px;
                    line-height: 22px;
                }

        .about {
            margin: 20px;
            text-indent: 2em;
            width: 858px;
            line-height: 22px;
            font-size: 13px;
        }

        .b_p {
            width: 250px;
            height: 20px;
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

        .sjxxbg {
            text-align: left;
            margin: 20px;
        }

            .sjxxbg p {
                text-indent: 2em;
            }
    </style>
    <script language="javascript" type="text/javascript">
        function cheackbook() {
            var form = document.form_book;
            if (form.book_title.value.replace(/ /g, "") == "") {
                alert("留言标题内容不能为空，请认真填写");
                form.book_title.focus();
                return false;
            }

            if (form.book_name.value.replace(/ /g, "") == "") {
                alert("留言者姓名不能为空，请重新填写");
                form.book_name.focus();
                return false;
            }
            else if (form.book_name.value.replace(/ /g, "").length < 2) {
                alert("姓名字数太短了，请填写真实姓名");
                form.book_name.focus();
                return false;
            }
            else if (form.book_name.value.replace(/ /g, "").length > 10) {
                alert("姓名字数太长了，请填写真实姓名");
                form.book_name.focus();
                return false;
            }
            if (form.book_email.value.replace(/ /g, "") == "") {
                alert("电子邮件地址不能为空");
                form.book_email.focus();
                return false;
            }
            if (form.book_email.value.replace(/ /g, "") != "") {
                if ((!/^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/.test(form.book_email.value.replace(/ /g, "")))) {
                    alert("电子邮件格式不符合标准");
                    form.book_email.focus();
                    return false;
                }
            }
            if (form.book_qq.value.replace(/ /g, "") == "") {
                alert("联系QQ不能为空");
                form.book_qq.focus();
                return false;
            }
            if (isNaN(form.book_qq.value)) {
                alert("QQ号码必须为数字");
                form.book_qq.focus();
                return false;
            }
            if (form.book_qq.value.replace(/ /g, "").length != "" & form.book_qq.value.replace(/ /g, "").length < 5) {
                alert("QQ号码不符合标准");
                form.book_qq.focus();
                return false;
            }
            if (form.book_qq.value.replace(/ /g, "").length > 12) {
                alert("这么长的QQ号码不符合标准");
                form.book_qq.focus();
                return false;
            }
            if (form.book_body.value.replace(/ /g, "") == "") {
                alert("留言内容不能为空");
                form.book_body.focus();
                return false;
            }
            else if (form.book_body.value.replace(/ /g, "").length < 8) {
                alert("留言内容太少了，有刷屏的嫌疑!\n\n呵呵，请重新输入你的留言。");
                form.book_body.focus();
                return false;
            }

        }
    </script>
</head>
<body style="background-color: rgb(241, 232, 235)">
    <form id="form1" runat="server">
        <div style="width: 1100px; height: 980px; background-color: white; margin: -17px 0px 0px 110px">
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
            <div style="width: 1100px;">
                <div class="sjxxbg">
                    <p>真诚欢迎广大网民朋友为铜陵的政法综治工作建言献策，提出意见和建议。为便于及时回复和解决来信人的问题，请来信人在来信前阅读以下几点：</p>
                    <p>1、来信要填写真实姓名、准确地址、有效的电子信箱和联系电话等确切的信息。</p>
                    <p>2、为尊重和保护来信人隐私权利，我们对来信内容严格保密，来信回复不予公开，来信人凭信件编号和查询密码进行查询。</p>
                    <p>3、来信人反映的问题要尽量客观具体、尊重事实，以便问题的调查和解决。</p>
                </div>
            </div>
            <div id="contain">
                <div id="header"></div>
                <div id="box">
                    <div class="box_box">
                        <div class="box_book">
                            <p>发表留言</p>
                            <form action="add_book_passed.asp" method="post" name="form_book" onsubmit="return cheackbook();">
                                <table cellpadding="0" cellspacing="8" border="0" width="580" align="center">
                                    <tr>
                                        <td width="65">
                                            <div align="right">留言标题：</div>
                                        </td>
                                        <td width="491">
                                            <input name="book_title" type="text" class="b_p" />
                                            <input name="gbook_sh" value="1" type="hidden" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div align="right">姓名：</div>
                                        </td>
                                        <td>
                                            <input name="book_name" type="text" class="b_p" />
                                            *</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div align="right">E_mail：</div>
                                        </td>
                                        <td>
                                            <input name="book_email" type="text" class="b_p" />
                                            * 是否隐藏
              <input type="checkbox" name="yc_email" id="yc_email" value="1" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div align="right">联系电话：</div>
                                        </td>
                                        <td>
                                            <input name="book_tel" type="text" class="b_p" />
                                            [<span class="style1">为用户保密，其他用户看不到该信息</span>]</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div align="right">联系QQ：</div>
                                        </td>
                                        <td>
                                            <input name="book_qq" type="text" class="b_p" />
                                            * 是否隐藏
                                        <input type="checkbox" name="yc_qq" id="yc_qq" value="1" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div align="right">联系地址：</div>
                                        </td>
                                        <td>
                                            <input name="book_address" type="text" class="b_p" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div align="right">留言内容：</div>
                                        </td>
                                        <td>
                                            <textarea name="book_body" cols="60" rows="7"></textarea>
                                            *</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div align="right">验证码：</div>
                                        </td>
                                        <td>
                                            <input name="VerifyCode" type="text" size="7" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <input type="submit" name="Submit" value="提交" />
                                            <input type="reset" name="Submit2" value="重置" /></td>
                                    </tr>
                                </table>
                            </form>
                            <div class="line"></div>
                            <h5>&nbsp;</h5>
                        </div>
                    </div>
                    <div id="header"></div>
                    <div id="box">

                        <div class="box_list">
                            <p>暂无留言信息记录！</p>
                        </div>
                        <div class="line"></div>
                        <table width="100%" border="0" cellpadding="0" cellspacing="0">
                            <form method="get" onsubmit="document.location = 'http://www.panl.gov.cn/guess/add_book.asp?Page='+ this.page.value;return false;">
                                <tr>
                                    <td align="left" class="hui">
                                        <p align="right">
                                            首页 
上一页 
下一页 
尾页 
页次：/页
 共条记录
 转<input class="wenbenkuang" tyep="TEXT" name="page" size="2" maxlength="5" value="">页
                                        <input class="go-wenbenkuang" type="submit" value="GO">
                                    </td>
                                </tr>
                            </form>
                        </table>

                    </div>
                    <div class="line"></div>
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
