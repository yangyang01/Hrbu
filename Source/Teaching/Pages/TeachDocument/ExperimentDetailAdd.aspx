<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExperimentDetailAdd.aspx.cs" Inherits="Teaching.Pages.TeachDocument.ExperimentDetailAdd" %>

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
                        <legend>实验大纲详情添加</legend>
                        <div class="info">
                            <div>
                                <span class="left">课程编码：</span> <span class="right">
                                    <asp:TextBox ID="txtStuNo" runat="server" CssClass="txt" Style="margin-left: -10px;"></asp:TextBox></span>
                                <span class="left a">实验编号：</span><span class="right"><asp:TextBox ID="txtStuName" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">实验内容：</span><span class="right"><asp:TextBox ID="txtSex" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">实验学时：</span><span class="right"><asp:TextBox ID="txtTel" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                             <div>
                                <span class="left">实验类型：</span><span class="right"><asp:TextBox ID="TextBox1" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>

                            <div style="margin-top: 8px">
                                <span style="margin-left: 30px;">实验教学目的：<textarea rows="5" cols="80"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 30px;">实验教学要求：<textarea rows="5" cols="80"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 66px;">实验原理：<textarea rows="5" cols="80"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 66px;">实验步骤：<textarea rows="5" cols="80"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 12px;">实验仪器和器材：<textarea rows="5" cols="80"></textarea></span>
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
