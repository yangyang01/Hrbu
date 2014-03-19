<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssessmentDetailAdd.aspx.cs" Inherits="Teaching.Pages.TeachDocument.AssessmentDetailAdd" %>

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
                        <legend>考核大纲详情添加</legend>
                        <div class="info">
                            <div>
                                <span class="left">课程编码：</span> <span class="right">
                                    <asp:TextBox ID="txtStuNo" runat="server" CssClass="txt" Style="margin-left: -10px;"></asp:TextBox></span>
                                <span class="left a">章节：</span><span class="right"><asp:TextBox ID="txtStuName" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div style="margin-top: 8px">
                                <span style="margin-left: 86px;">样题：&nbsp;&nbsp;<asp:FileUpload runat="server"></asp:FileUpload></span>
                            </div>
                            <div style="margin-top: 8px">
                                <span style="margin-left: 82px;">知识点：<textarea rows="5" cols="80"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 100px;">识记：<textarea rows="5" cols="80"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 100px;">理解：<textarea rows="5" cols="80"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 100px;">运用：<textarea rows="5" cols="80"></textarea></span>
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
