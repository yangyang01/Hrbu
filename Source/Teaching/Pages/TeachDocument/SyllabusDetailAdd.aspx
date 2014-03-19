<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SyllabusDetailAdd.aspx.cs" Inherits="Teaching.Pages.TeachDocument.SyllabusDetailAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../../Content/css/basicInfo.css" rel="stylesheet" />
    <link href="../../Content/css/global.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul style="display: inline-block; list-style-type: none; margin-left: 100px">
                <li class="title">
                    <fieldset>
                        <legend>教学大纲详情添加</legend>
                        <div class="info">
                            <div>
                                <span class="left">课程编码：</span> <span class="right">
                                    <asp:TextBox ID="txtStuNo" runat="server" CssClass="txt" Style="margin-left: -10px;"></asp:TextBox></span>
                                <span class="left a">序号：</span><span class="right"><asp:TextBox ID="txtStuName" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">标题：</span><span class="right"><asp:TextBox ID="txtSex" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">理论课时：</span><span class="right"><asp:TextBox ID="txtTel" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">实验课时：</span><span class="right"><asp:TextBox ID="txtMajor" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">上机课时：</span><span class="right"><asp:TextBox ID="txtClass" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">习题课时：</span><span class="right"><asp:TextBox ID="txtZipCode" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div style="margin-top: 8px">
                                <span style="margin-left: 65px;">教学目的：<textarea rows="5" cols="80"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 65px;">教学要求：<textarea rows="5" cols="80"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 65px;">内容提要：<textarea rows="5" cols="80"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 11px;">教学重点与难点：<textarea rows="5" cols="80"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 48px;">复习思考题：<textarea rows="5" cols="80"></textarea></span>
                            </div>
                        </div>
                    </fieldset>
                    <div style="padding-left: 590px; margin-top: 20px">
                        <asp:Button runat="server" Text="确认提交" CssClass="button" />&nbsp;
                         <asp:Button runat="server" Text="清除重置" CssClass="button" />&nbsp;
                        <asp:Button runat="server" Text="返回" CssClass="button" OnClientClick="window.close();return false;" />

                    </div>
                </li>
            </ul>
        </div>
    </form>
</body>
</html>
