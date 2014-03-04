<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Hrbu.Teaching.WebUI.Error" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>华住集团人力资源信息平台</title>
    <meta http-equiv="X-UA-Compatible" content="IE=8" />
    <link href="~/Content/css/global.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/css/libs/WdatePicker.css" rel="stylesheet" type="text/css" />
    <script src='<%=ResolveUrl("~/Content/js/libs/jquery-1.8.3.min.js") %>' type="text/javascript"></script>
    <script src='<%=ResolveUrl("~/Content/js/libs/WdatePicker.js") %>' type="text/javascript"></script>
    <script src='<%=ResolveUrl("~/Content/js/libs/colResizable-1.3.source.js") %>' type="text/javascript"></script>
    <script src="<%=ResolveUrl("~/Content/js/utility.js") %>" type="text/javascript"></script>
</head>
<body style="margin: 0px auto;">
    <form id="form1" runat="server">
        <div class="header-wrapper">
            <div class="header margin_1140_center">
                <div class="logo logo_left">
                    <img src="<%=ResolveUrl("~/content/images/logo_hr.png") %>" class="fl">
                </div>
            </div>
        </div>
        <div class="margin_1140_center mainContent">
            <div>
                系统提示：
       
            </div>
            <div style="margin-top: 20px">
                您当前的账户没有访问权限，如需要请联系系统管理员！ 
       
            </div>
            <div style="margin: 10px 328px; display: none;">
                <asp:Label ID="lblErrorMsg" runat="server"></asp:Label>
            </div>
        </div>
        <div class="footer">
            <div class="footerAddress">
                <a href="http://www.huazhu.com/xiyue" title="禧玥酒店" target="_blank">禧玥酒店</a>
                <a href="#" title="漫心酒店" target="_blank">漫心酒店</a>
                <a href="http://www.huazhu.com/quanji" title="全季酒店" target="_blank">全季酒店</a>
                <a href="http://www.huazhu.com/event/xingcheng.aspx" title="星程酒店" target="_blank">星程酒店</a>
                <a href="http://www.huazhu.com/kuaijie" title="汉庭酒店" target="_blank">汉庭酒店</a>
                <a href="http://www.hiinns.com/" title="海友酒店" target="_blank">海友酒店</a>
            </div>
            <div class="footerImg">
                <img src='<%=ResolveUrl("Content/images/group_logo.png") %>' />
            </div>
            Copyright 2013 华住集团版权所有
        </div>
    </form>
</body>
</html>
