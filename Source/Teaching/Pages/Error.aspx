<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Hrbu.Teaching.WebUI.Error" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    </form>
</body>
</html>
