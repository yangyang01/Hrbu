<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SyllabusDetailAdd.aspx.cs" Inherits="Teaching.Pages.TeachDocument.SyllabusDetailAdd" %>

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
         .r {
            border-radius: 5px;
        }
    </style>
</head>
<body>
    <script type="text/javascript">
        $(function () {
            $('#btnSubmit').click(function () {
                var flag = $('#txtSerialNo').val() && $('#txtTitle').val() && $('#txtaSynopsis').val();
                if (!flag) {
                    if (!flag) {
                        $('#rfvSerialNo').css('display', $('#txtSerialNo').val() ? "none" : "");
                        $('#rfvtxtTitle').css('display', $('#txtTitle').val() ? "none" : "");
                        $('#rfvSynopsis').css('display', $('#txtaSynopsis').val() ? "none" : "");
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
                        <legend>教学大纲详情添加</legend>
                        <div class="info">
                            <div>
                                <span class="left">课程编码：</span> <span class="right">
                                    <asp:TextBox ID="txtCourseCode" runat="server" CssClass="txt" Style="margin-left: -10px;"></asp:TextBox></span>
                                <span class="left a">序号：</span><span class="right"><asp:TextBox ID="txtSerialNo" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">标题：</span><span class="right"><asp:TextBox ID="txtTitle" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">理论课时：</span><span class="right"><asp:TextBox ID="txtTheoreticalLessons" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">实验课时：</span><span class="right"><asp:TextBox ID="txtExperimentLessons" runat="server" CssClass="txt"></asp:TextBox></span>
                                <span class="left a">上机课时：</span><span class="right"><asp:TextBox ID="txtComputerLessons" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div>
                                <span class="left">习题课时：</span><span class="right"><asp:TextBox ID="txtExerciseLessons" runat="server" CssClass="txt"></asp:TextBox></span>
                            </div>
                            <div style="margin-top: 8px">
                                <span style="margin-left: 65px;">教学目的：<textarea id="txtaTeachingAims" rows="5" cols="80" runat="server"  class="r"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 65px;">教学要求：<textarea id="txtaTeachRequirement" rows="5" cols="80" runat="server"  class="r"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 65px;">内容提要：<textarea id="txtaSynopsis" rows="5" cols="80" runat="server"  class="r"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 11px;">教学重点与难点：<textarea id="txtaTeachKeyPoint" rows="5" cols="80" runat="server"  class="r"></textarea></span>
                            </div>
                            <div>
                                <span style="margin-left: 48px;">复习思考题：<textarea id="txtaLessonReview" rows="5" cols="80" runat="server"  class="r"></textarea></span>
                            </div>
                        </div>
                    </fieldset>
                    <div style="padding-left: 590px; margin-top: 20px">
                        <asp:Button runat="server" Text="确认提交" CssClass="button" ID="btnSubmit" OnClick="ClickbtnSubmit" />&nbsp;
                         <asp:Button runat="server" Text="清除重置" CssClass="button" />&nbsp;
                        <asp:Button runat="server" Text="返回" CssClass="button" OnClientClick="window.close();return false;" />

                    </div>
                    <div style="margin-left: -100px;">
                        <span id="rfvSerialNo" class="errorTip i" style="display: none; color: red;">请输入序号！</span><br />
                        <span id="rfvtxtTitle" class="errorTip i" style="display: none; color: red;">请输入标题！</span><br />
                        <span id="rfvSynopsis" class="errorTip i" style="display: none; color: red;">请输入内容提要！</span>
                    </div>
                </li>
            </ul>
        </div>
    </form>
</body>
</html>
