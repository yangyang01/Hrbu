<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssessmentSyllabusAdd.aspx.cs" Inherits="Teaching.Pages.TeachDocument.AssessmentSyllabusAdd" %>

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
                        <legend>考核大纲添加</legend>
                        <div class="info">
                            <div>
                                <span class="left">课程编码：</span> <span class="right">
                                    <asp:TextBox ID="txtStuNo" runat="server" CssClass="txt" Style="margin-left: -10px;"></asp:TextBox></span>
                                <span class="left a">考核方式：</span><span class="right"><asp:TextBox ID="txtStuName" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">考核形式：</span><span class="right"><asp:TextBox ID="txtSex" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">主客观题比例：</span><span class="right"><asp:TextBox ID="txtTel" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">题型比例：</span><span class="right"><asp:TextBox ID="txtMajor" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">难度等级：</span><span class="right"><asp:TextBox ID="txtClass" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                           				
                            <div style="margin-top:8px">
                                <span style="margin-left: 65px;">考核目的：<textarea rows="5" cols="80"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 12px;">课程学习的基础：<textarea rows="5" cols="80"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 12px;">考核的内容范围：<textarea rows="5" cols="80"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 12px;">考核试题的要求：<textarea rows="5" cols="80"></textarea></span>
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
