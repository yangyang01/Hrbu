<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MailBox.aspx.cs" Inherits="Teaching.Pages.MailBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="../Content/js/libs/jquery-1.8.3.min.js"></script>
    <script src="../Content/js/mailbox.js"></script>
    <link href="../Content/css/mailbox.css" rel="stylesheet" />
    <link href="../Content/css/index.css" rel="stylesheet" />
</head>
<body style="background-color: rgb(241, 232, 235)">
    <form id="form1" runat="server">
        <div style="width: 1100px; height: 200px;margin: -17px 0px 0px 110px">
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
        <div style="width: 1090px; height: 760px; background-color: white; margin: 27px 0px 0px 116px">
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
 转<input  tyep="TEXT" name="page" size="2" maxlength="5" value="">页
                                        <input type="submit" value="GO">
                                    </td>
                                </tr>
                            </form>
                        </table>

                    </div>
                    <div class="line"></div>
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
