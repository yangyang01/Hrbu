<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeachingSyllabusAdd.aspx.cs" Inherits="Teaching.Pages.TeachDocument.TeachingSyllabusAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../../Content/css/basicInfo.css" rel="stylesheet" />
    <link href="../../Content/css/global.css" rel="stylesheet" />
    <script src="../../Content/js/libs/jquery-1.8.3.min.js"></script>

    <title></title>
    <style>
        .i {
            font-size: 13px;
        }
    </style>
</head>
<body>
    <script type="text/javascript">
        $(function () {
            $('#btnSubmit').click(function () {
                var flag = $('#txtCourseCode').val() && $('#txtTextbook').val;
                if (!flag) {
                    if (!flag) {
                        $('#rfvCourseCode').css('display', $('#txtCourseCode').val() ? "none" : "");
                        $('#rfvTextbook').css('display', $('#txtTextbook').val() ? "none" : "");
                    }
                    return !!flag;
                }
            })
        });
    </script>
    <form id="form1" runat="server">
        <div>
            <ul style="display: inline-block; list-style-type: none; margin-left: 100px">
                <li class="title">
                    <fieldset>
                        <legend>教学大纲添加</legend>
                        <div class="info">
                            <div>
                                <span class="left">课程编码：</span> <span class="right">
                                    <asp:TextBox ID="txtCourseCode" runat="server" CssClass="txt" Style="margin-left: -10px;"></asp:TextBox></span>
                                <span class="left a">先修课程：</span><span class="right"><asp:TextBox ID="txtPrerequisiteCourse" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">教材：</span><span class="right"><asp:TextBox ID="txtTextbook" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">参考书：</span><span class="right"><asp:TextBox ID="txtReferenceBook" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div style="margin-top: 8px">
                                <span style="margin-left: 65px;">教学内容：<textarea id="txtaTeachContent" rows="5" cols="80" runat="server"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 65px;">教学原则：<textarea id="txtaTeachPrinciple" rows="5" cols="80" runat="server"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 65px;">教学方法：<textarea id="txtaTeachMethod" rows="5" cols="80" runat="server"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 65px;">教学目的：<textarea id="txtaTeachAim" rows="5" cols="80" runat="server"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 65px;">教学任务：<textarea id="txtaTeachTask" rows="5" cols="80" runat="server"></textarea></span>
                            </div>
                        </div>
                    </fieldset>
                    <div style="padding-left: 590px; margin-top: 20px">
                        <asp:Button runat="server" ID="btnSubmit" Text="确认提交" CssClass="button" OnClick="ClickbtnSubmit" />&nbsp;
                         <asp:Button runat="server" Text="清除重置" CssClass="button" />&nbsp;
                        <asp:Button runat="server" Text="返回" CssClass="button" OnClientClick="window.close();return false;" />

                    </div>
                    <div style="margin-left: -100px;">
                        <span id="rfvCourseCode" class="errorTip i" style="display: none; color: red;">请输入课程编码！</span><br />
                        <span id="rfvTextbook" class="errorTip i" style="display: none; color: red;">请输入教材！</span><br />
                    </div>
                </li>
            </ul>
        </div>
    </form>
</body>
</html>
